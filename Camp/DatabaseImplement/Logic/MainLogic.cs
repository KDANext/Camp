using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BusinessLogic.Models;
using BusinessLogic.ViewModels;
using DatabaseImplement.Models;

namespace DatabaseImplement.Logic
{
    public class MainLogic
    {
        MatchingLogic logic;
        public void AddGroup(GroupBindingModel model)
        {            
            using (var context = new CampDatabase())
            {
                // проверяем, есть ли такая группа в базе данных
                Group group = context.Groups.FirstOrDefault(rec =>
               rec.Name == model.Name && rec.Id != model.Id);
                if (group != null)
                {
                    throw new Exception("Уже есть группа с таким названием");
                }
                else
                {
                    group = new Group();
                    context.Groups.Add(group);
                }
                group.Name = model.Name;
                group.CounsellorId = model.CounsellorId == 0 ? group.CounsellorId : model.CounsellorId;                
                context.SaveChanges();
            }
        }

        public void EditGroup(GroupBindingModel model)
        {            
            using (var context = new CampDatabase())
            {
                Group group = context.Groups.FirstOrDefault(rec => rec.Id == model.Id);               
                    
                if (group == null)
                {
                    throw new Exception("Элемент не найден");
                }               
                else
                {
                    group = new Group();
                    context.Groups.Add(group);
                }
                group.Name = model.Name;
                group.CounsellorId = model.CounsellorId == 0 ? group.CounsellorId : model.CounsellorId;
                context.SaveChanges();
            }
        }

        public void Match()
        {            
            using (var context = new CampDatabase())
            {
                foreach (var group in context.Groups)
                {
                    if(logic.FindCounsellor(group.Id) == -1)
                    {
                        throw new Exception("Недостаточно вожатых для всех групп");
                    }
                    group.CounsellorId = logic.FindCounsellor(group.Id);
                    MessageBox.Show("Все вожатые распределены по группам");
                }
                    context.SaveChanges();
            }
        }       


        public List<GroupViewModel> GetGroupsList()
        {
            var list = new List<GroupViewModel>();
            using (var context = new CampDatabase())
            {
                foreach (var group in context.Groups)
                {
                    list.Add(new GroupViewModel
                    {
                        Id = group.Id,                        
                        Name = group.Name,
                        Profile = group.Profile                       
                    });
                    
                }
            }
            return list;
        }
    }
}
