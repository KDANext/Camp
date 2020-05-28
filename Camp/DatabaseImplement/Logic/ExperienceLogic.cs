using BusinessLogic.Models;
using BusinessLogic.ViewModels;
using DatabaseImplement.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DatabaseImplement.Logic
{
    public class ExperienceLogic
    {
        public void CreateOrUpdate(ExperienceBindingModel model)
        {
            using (var context = new CampDatabase())
            {
                Experience experience;
                if (model.Id.HasValue)
                {
                    experience = context.Experience.FirstOrDefault(rec => rec.Id ==
                   model.Id);
                    if (experience == null)
                    {
                        throw new Exception("Элемент не найден");
                    }
                }
                else
                {
                    experience = new Experience();
                    context.Experience.Add(experience);
                }
                experience.AgeFrom = model.AgeFrom;
                experience.AgeTo = model.AgeTo;
                experience.Years = model.Years;
                context.SaveChanges();
            }
        }
        public void Delete(ExperienceBindingModel model)
        {
            using (var context = new CampDatabase())
            {
                Experience experience = context.Experience.FirstOrDefault(rec => rec.Id ==
               model.Id);
                if (experience != null)
                {
                    context.Experience.Remove(experience);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Элемент не найден");
                }
            }
        }
        public List<ExperienceViewModel> Read(ExperienceBindingModel model)
        {
            using (var context = new CampDatabase())
            {
                return context.Experience
                .Where(rec => model == null || rec.Id == model.Id)
                .Select(rec => new ExperienceViewModel
                {
                    Id = rec.Id,
                    AgeFrom = rec.AgeFrom,
                    AgeTo = rec.AgeTo,
                    Years = rec.Years
                })
                .ToList();
            }
        }
    }
}
