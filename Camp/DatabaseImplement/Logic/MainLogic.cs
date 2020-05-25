using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.Models;
using BusinessLogic.ViewModels;
using DatabaseImplement.Models;

namespace DatabaseImplement.Logic
{
    public class MainLogic
    {
        public void AddGroup(GroupBindingModel model)
        {
            //метод из интефейса, переделать отдельно на добавить, отдельно редактировать
            using (var context = new CampDatabase())
            {
                // ищем в базе данных группу, где имена грудды совпадают, но id разные
                Group group = context.Groups.FirstOrDefault(rec =>
               rec.Name == model.Name && rec.id != model.id);
                if (group != null)
                {
                    throw new Exception("Уже есть группа с таким названием");
                }
                //если ищем уже существующую модели
                if (model.id.HasValue)
                {
                    group = context.Groups.FirstOrDefault(rec => rec.Id ==
                   model.id);                    
                    if (group == null)
                    {
                        throw new Exception("Элемент не найден");
                    }
                }
                //
                else
                {
                    group = new Group();
                    context.Groups.Add(group);
                }
                group.Name = model.Name;
                group.Counsellorid = model.Counsellorid;
                group.children = model.children;
                context.SaveChanges();
            }
        }

        public List<GroupViewModel> GetGroupsList()
        {
            var list = new List<GroupViewModel>;
            using (var context = new CampDatabase())
            {
                foreach (var group in context.Groups)
                {
                    list.Add(new GroupViewModel
                    {
                        Id = group.id,
                        //как найти имя, если есть только id?
                        //CounsellorName  = group.
                        Name = group.Name,
                        Profile = group.Profile
                        //ChildrenCount
                    });
                    
                }
            }
            return list;
        }
    }
}
