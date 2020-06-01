using BusinessLogic.Models;
using BusinessLogic.ViewModels;
using DatabaseImplement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseImplement.Logic
{
    public class GroupLogic
    {        
        public void CreateOrUpdate(GroupBindingModel model)
        {
            using (var context = new CampDatabase())
            {
                using (var transaction = context.Database.BeginTransaction())
                {                
                    Group group;

                    if (model.Id.HasValue)
                    {
                        group = context.Groups.FirstOrDefault(rec => rec.Id ==
                       model.Id);
                        if (group == null)
                        {
                            throw new Exception("Элемент не найден");
                        }
                    }
                    else
                    {
                        group = new Group();
                        context.Groups.Add(group);
                    }
                    //group.CounsellorId = model.CounsellorId == 0 ? group.CounsellorId : model.CounsellorId;
                    group.Name = model.Name;
                    group.Profile = model.Profile;
                    context.SaveChanges();
                    if (model.Id.HasValue)
                    {
                        // нашли детей, входящих в эту группу
                        var Children = context.Children.Where(rec
                       => rec.GroupId == model.Id.Value).ToList();
                        // у каждого ребёнка изменили значение группы
                        foreach (var child in Children)
                        {                            
                            child.GroupId = model.Id;
                        }
                    }
                    // добавили новые
                    foreach (var child in context.Children)
                    {
                        if (model.Children.ContainsKey(child.Id))
                        {
                            child.GroupId = group.Id;
                        }
                    }
                    if (model.CounselorId != 0 && model.CounselorId == null)
                    {
                        var Counselor = context.Counsellors.Where(x => x.Id == model.CounselorId).ToList()[0];
                        Counselor.GroupId = group.Id;
                    }
                    context.SaveChanges();
                    
                    transaction.Commit();
                }
            }
        }


        public void Delete(GroupBindingModel model)
        {
            using (var context = new CampDatabase())
            {
                Group group = context.Groups.FirstOrDefault(rec => rec.Id == model.Id);
                if (group != null)
                {
                    // нашли детей, входящих в эту группу
                    var Children = context.Children.Where(rec
                   => rec.GroupId == model.Id.Value).ToList();
                    // у каждого ребёнка обнулили значение группы
                    foreach (var child in Children)
                    {
                        child.GroupId = 0;
                    }
                    context.Groups.Remove(group);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Элемент не найден");
                }
            }
        }
        public List<GroupViewModel> Read(GroupBindingModel model)
        {
            using (var context = new CampDatabase())
            {              
                return context.Groups
                .Where(rec => model == null ||
                        (rec.Id == model.Id && model.Id.HasValue))
                .Select(rec => new GroupViewModel
                {
                    Id = rec.Id,
                    CounsellorId = context.Counsellors.Where(x => x.GroupId == rec.Id).First().Id,
                    CounsellorName = context.Counsellors.Where(x => x.GroupId == rec.Id).First().FIO,
                    Name = rec.Name,
                    Profile = rec.Profile,
                })
                .ToList();
            }
        }
    }
}
