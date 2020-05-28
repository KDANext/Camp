using BusinessLogic.Models;
using BusinessLogic.ViewModels;
using DatabaseImplement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DatabaseImplement.Logic
{
    public class ChildLogic
    {
        public void CreateOrUpdate(ChildBindingModel model)
        {
            using (var context = new CampDatabase())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        Child child = context.Children.FirstOrDefault(rec =>
                       rec.FIO == model.FIO && rec.Id != model.Id);
                        if (child != null)
                        {
                            throw new Exception("Уже есть ребёнок с таким именем");
                        }
                        if (model.Id.HasValue)
                        {
                            child = context.Children.FirstOrDefault(rec => rec.Id ==
                           model.Id);
                            if (child == null)
                            {
                                throw new Exception("Ребёнок не найден");
                            }
                        }
                        else
                        {
                            child = new Child();
                            context.Children.Add(child);
                        }
                        child.FIO = model.FIO;
                        child.Age = model.Age;
                        context.SaveChanges();
                        if (model.Id.HasValue)
                        {
                            var ChildInterests = context.ChildInterests.Where(rec
                           => rec.ChildId == model.Id.Value).ToList();
                            // удалили те, которых нет в модели
                            context.ChildInterests.RemoveRange(ChildInterests.Where(rec =>
                            !model.ChildInterests.ContainsKey(rec.InterestId)).ToList());
                            context.SaveChanges();
                            // обновили количество у существующих записей
                            foreach (var updateInterest in ChildInterests)
                            {    
                                model.ChildInterests.Remove(updateInterest.InterestId);
                            }
                            context.SaveChanges();
                        }
                        // добавили новые
                        foreach (var interest in model.ChildInterests)
                        {
                            context.ChildInterests.Add(new ChildInterests
                            {
                                ChildId = child.Id,
                                InterestId = interest.Key,                               
                            });
                            context.SaveChanges();
                        }
                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }
        public void Delete(ChildBindingModel model)
        {
            using (var context = new CampDatabase())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        // удаяем записи по компонентам при удалении компьютера
                        context.ChildInterests.RemoveRange(context.ChildInterests.Where(rec =>
                        rec.ChildId == model.Id));
                        Child child = context.Children.FirstOrDefault(rec => rec.Id
                        == model.Id);
                        if (child != null)
                        {
                            context.Children.Remove(child);
                            context.SaveChanges();
                        }
                        else
                        {
                            throw new Exception("Элемент не найден");
                        }
                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }
        public List<ChildViewModel> Read(ChildBindingModel model)
        {
            using (var context = new CampDatabase())
            {
                return context.Children
                .Where(rec => model == null || rec.Id == model.Id)
                .ToList()
               .Select(rec => new ChildViewModel
               {
                   Id = rec.Id,
                   FIO = rec.FIO,
                   Age = rec.Age,
                   ChildInterests = context.ChildInterests
                .Include(recPC => recPC.interest)
               .Where(recPC => recPC.ChildId == rec.Id)
               .ToDictionary(recPC => recPC.ChildId, recPC =>
                recPC.interest.interest)
               })
               .ToList();
            }
        }
    }
}
