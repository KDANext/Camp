using DatabaseImplement.Models;
using System;
using System.Linq;
using System.Runtime.Remoting.Contexts;

namespace DatabaseImplement.Logic
{
    public class MatchingLogic
    {
        //средний возраст детей в группе
        public int FindAvarageChildrenAge(int groupId)
        {
            using (var context = new CampDatabase())
            {
                int age = 0;
                int count = 0;
                                
                foreach (Child child in context.Children)
                {
                    if(child.GroupId == groupId)
                    {
                        age = age + child.Age;
                        count++;
                    }
                    
                }
                return age / count;

            }
        }  

        // ищем разницу между средним возрастом детей и возрастом, с которым у вожатого есть опыт работы
        public int FindDiff(int AgeFrom, int AgeTo, int age)
        {
            if (age > AgeFrom && age < AgeTo)
            {
                return 0;
            }
            else return Math.Min(Math.Abs(age - AgeFrom), Math.Abs(age - AgeTo));
        }

        //проверяем, свободен ли вожатый
        public bool CounsellorIsFree(int Id)
        {
            using (var context = new CampDatabase())
            {
                foreach (Counsellor counsellor in context.Counsellors)
                {
                    if(counsellor.Id == Id && counsellor.GroupId != 0)
                    {
                        return true;
                    }                   
                }
                return false;
            }                
        }

        //количество общих интересов группы и вожатого
        public int FindSameInterestsCount(int counsellorId, int groupId)
        {
            using (var context = new CampDatabase())
            {
                int count = 0;
                foreach (var interest in context.CounsellorInterests)
                {
                    if(interest.CounsellorId == counsellorId)
                    count += FindChildrenWithThisInterestCount(interest.InterestId, groupId);
                }
                return count;
            }
                
        }

        // ищем количество детей с определённым интересом в группе
        public int FindChildrenWithThisInterestCount(int interestId, int groupId)
        {
            using (var context = new CampDatabase())
            {
                int count = 0;
                foreach(var child in context.Children)
                {
                    foreach (var interest in context.ChildInterests)
                    {
                        if (child.GroupId == groupId && child.Id == interest.ChildId && interest.InterestId == interestId)
                        {
                            count++;
                        }
                    }
                }    
                return count;
            }
        }      

        //ищем наиболее подходящего свободного вожатого для группы
        public int FindCounsellor(int groupId)
        {
            using (var context = new CampDatabase())
            {                                 
                int id = -1;
                // индекс, который определяет, насколько подходит опыт работы к среднему возрасту детей = опыт работы*кол-во общих интересов / (разница возрастов + 1)
                int maxIndex = 0;                   
                foreach (Experience experience in context.Experience)
                {   
                    if(CounsellorIsFree(experience.CounsellorId))
                    {
                        int index = experience.Years*FindSameInterestsCount(experience.CounsellorId, groupId) / (FindDiff(experience.AgeFrom, experience.AgeTo, FindAvarageChildrenAge(groupId)) + 1);
                        if(index > maxIndex)
                        {
                            maxIndex = index;
                            id = experience.CounsellorId;
                        }
                    }                    
                }
                return id;                
            }
        }
    }
}
