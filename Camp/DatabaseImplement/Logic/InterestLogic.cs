using BusinessLogic.BindingModels;
using BusinessLogic.ViewModels;
using DatabaseImplement.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DatabaseImplement.Logic
{
    public class InterestLogic
    {
        public void CreateOrUpdate(InterestBindingModel model)
        {
            using (var context = new CampDatabase())
            {
                Interest interest = context.Interests.FirstOrDefault(rec =>
               rec.interest == model.Interest && rec.Id != model.Id);
                if (interest != null)
                {
                    throw new Exception("Уже есть такой интерес");
                }
                if (model.Id.HasValue)
                {
                    interest = context.Interests.FirstOrDefault(rec => rec.Id ==
                   model.Id);
                    if (interest == null)
                    {
                        throw new Exception("Элемент не найден");
                    }
                }
                else
                {
                    interest = new Interest();
                    context.Interests.Add(interest);
                }
                interest.interest = model.Interest;
                context.SaveChanges();
            }
        }
        public void Delete(InterestBindingModel model)
        {
            using (var context = new CampDatabase())
            {
                Interest interest = context.Interests.FirstOrDefault(rec => rec.Id ==
               model.Id);
                if (interest != null)
                {
                    context.Interests.Remove(interest);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Элемент не найден");
                }
            }
        }
        public List<InterestViewModel> Read(InterestBindingModel model)
        {
            using (var context = new CampDatabase())
            {
                return context.Interests
                .Where(rec => model == null || rec.Id == model.Id)
                .Select(rec => new InterestViewModel
                {
                    Id = rec.Id,
                    Interest = rec.interest
                })
                .ToList();
            }
        }
    }
}
