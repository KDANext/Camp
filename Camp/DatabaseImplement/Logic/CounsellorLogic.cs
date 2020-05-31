using BusinessLogic.Models;
using DatabaseImplement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;


namespace DatabaseImplement.Logic
{
    public class CounsellorLogic
    {
        public void CreateOrUpdate(CounsellorBindingModel model)
        {
            using (var context = new CampDatabase())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        Counsellor counsellor = context.Counsellors.FirstOrDefault(rec =>
                       rec.FIO == model.FIO && rec.Id != model.Id);
                        if (counsellor != null)
                        {
                            throw new Exception("Уже есть вожатый с таким именем");
                        }
                        if (model.Id.HasValue)
                        {
                            counsellor = context.Counsellors.FirstOrDefault(rec => rec.Id ==
                           model.Id);
                            if (counsellor == null)
                            {
                                throw new Exception("Вожатый не найден");
                            }
                        }
                        else
                        {
                            counsellor = new Counsellor();
                            context.Counsellors.Add(counsellor);
                        }
                        counsellor.FIO = model.FIO;
                        counsellor.GroupId = model.GroupId;
                        context.SaveChanges();
                        if (model.Id.HasValue)
                        {
                            var CounsellorExperience = context.CounsellorExperience.Where(rec
                           => rec.ExperienceId == model.Id.Value).ToList();
                            // удалили те, которых нет в модели
                            context.CounsellorExperience.RemoveRange(CounsellorExperience.Where(rec =>
                            !model.CounsellorExperience.ContainsKey(rec.ExperienceId)).ToList());
                            context.SaveChanges();
                            // обновили количество у существующих записей
                            foreach (var updateExperience in CounsellorExperience)
                            {
                                model.CounsellorExperience.Remove(updateExperience.ExperienceId);
                            }

                            var CounsellorInterests = context.CounsellorInterests.Where(rec
                           => rec.CounsellorId == model.Id.Value).ToList();
                            // удалили те, которых нет в модели
                            context.CounsellorInterests.RemoveRange(CounsellorInterests.Where(rec =>
                            !model.CounsellorInterests.ContainsKey(rec.InterestId)).ToList());
                            context.SaveChanges();
                            // обновили количество у существующих записей
                            foreach (var updateInterest in CounsellorInterests)
                            {
                                model.CounsellorInterests.Remove(updateInterest.InterestId);
                            }
                            context.SaveChanges();
                        }
                        // добавили новые
                        foreach (var interest in model.CounsellorInterests)
                        {
                            context.CounsellorInterests.Add(new CounsellorInterests
                            {
                                CounsellorId = counsellor.Id,
                                InterestId = interest.Key,
                            });
                            context.SaveChanges();
                        }
                        foreach (var experience in model.CounsellorExperience)
                        {
                            context.CounsellorExperience.Add(new CounsellorExperience
                            {
                                CounsellorId = counsellor.Id,
                                ExperienceId = experience.Key,
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
        public void Delete(CounsellorBindingModel model)
        {
            using (var context = new CampDatabase())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        // удаяем записи по опыту и интересвм при удалении вожатого
                        context.CounsellorInterests.RemoveRange(context.CounsellorInterests.Where(rec =>
                        rec.CounsellorId == model.Id));
                        context.CounsellorExperience.RemoveRange(context.CounsellorExperience.Where(rec =>
                        rec.CounsellorId == model.Id));
                        Counsellor counsellor = context.Counsellors.FirstOrDefault(rec => rec.Id
                        == model.Id);
                        if (counsellor != null)
                        {
                            context.Counsellors.Remove(counsellor);
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
        public List<CounsellorViewModel> Read(CounsellorBindingModel model)
        {
            using (var context = new CampDatabase())
            {
                return context.Counsellors
                .Where(rec => model == null || rec.Id == model.Id)
                .ToList()
               .Select(rec => new CounsellorViewModel
               {
                   Id = rec.Id,
                   FIO = rec.FIO,
                   GroupId = rec.GroupId,
                   CounsellorInterests = context.CounsellorInterests
                .Include(recPC => recPC.counsellorInterests)
               .Where(recPC => recPC.CounsellorId == rec.Id)
               .ToDictionary(recPC => recPC.CounsellorId, recPC =>
                recPC.counsellorInterests.interest),
               CounsellorExperience = context.CounsellorExperience
                .Include(recPC => recPC.counsellorExperience)
               .Where(recPC => recPC.CounsellorId == rec.Id)
               .ToDictionary(recPC => recPC.CounsellorId, recPC =>
                (recPC.counsellorExperience.AgeFrom, recPC.counsellorExperience.AgeTo, recPC.counsellorExperience.Years))
               })
               .ToList();
            }
        }
    }
}
