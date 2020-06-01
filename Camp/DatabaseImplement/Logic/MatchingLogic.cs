using DatabaseImplement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DatabaseImplement.Logic
{
    public class MatchingLogic
    {

        public void Match()
        {
            using (var context = new CampDatabase())
            {     
                foreach (var group in context.Groups)
                {
                    if (FindCounsellor(group.Id) == -1)
                    {
                        throw new Exception("Недостаточно вожатых для всех групп");
                    }                    
                    //ищем вожатого с данным id и устанавливаем ему id группы
                    foreach(var counsellor in context.Counsellors)
                    {
                        if(counsellor.Id == FindCounsellor(group.Id))
                        {
                            counsellor.GroupId = group.Id;
                        }
                    }                    
                }
                MessageBox.Show("Все вожатые распределены по группам");
                context.SaveChanges();
            }
        }

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

        public void Calculate()
        {
            using (var context = new CampDatabase())
            {
                var Counselors = context.Counsellors.ToList();
                var Groups = context.Groups.ToList();
                foreach(var councelor in Counselors)
                {
                    if(councelor.GroupId != null)
                    {
                        Groups.RemoveAll(x => x.Id == councelor.GroupId);
                    }
                }
                Counselors.RemoveAll(x => x.GroupId != null);
                if(Groups.Count > Counselors.Count)
                {
                    throw new Exception("Недостаточно вожатых для всех групп");
                }
                //<идВожатого,идГрупа,насколькоПодходитВожатый>
                List<Tuple<int, int, int>> table = new List<Tuple<int, int, int>>();
                foreach(var c in Counselors)
                {
                    foreach(var g in Groups)
                    {
                        table.Add(CreateScore(c.Id, g.Id));
                    }
                }
                DistributeСounselors(table);

            }
        }

        private void DistributeСounselors(List<Tuple<int, int, int>> table)
        {
            int GroupId, CounselorId;
            {
                var temp = table.First(x => x.Item3 == table.Max(y => y.Item3));
                GroupId = temp.Item2;
                CounselorId = temp.Item1;
            }
            using (var context = new CampDatabase())
            {
                var counselor = context.Counsellors.First(x => x.Id == CounselorId);
                counselor.GroupId = GroupId;
                context.SaveChanges();
            }
            table.RemoveAll(x => x.Item1 == CounselorId || x.Item2 == GroupId);
            if (table.Count == 0)
            {
                return;
            } else
            {
                DistributeСounselors(table);
            }
        }

        private Tuple<int, int, int> CreateScore(int counselorId, int groupId)
        {
            int score = 0;
            using (var context = new CampDatabase())
            {
                var interesCounselor = context.CounsellorInterests.Where(x => x.CounsellorId == counselorId).ToList();
                var childerenInGroup = context.Children.Where(x => x.GroupId == groupId).ToList();
                var expCounselor = context.Experience.Where(x => x.CounsellorId == counselorId).ToList();
                foreach(var child in childerenInGroup)
                {
                    var interestChild = context.ChildInterests.Where(x => x.ChildId == child.Id).ToList();
                    score += CreateScoreChildCounselorInterest(interesCounselor, interestChild);
                    score += CreateScoreChildCounselorAgeAndExp(expCounselor, child.Age);
                }
                return Tuple.Create(counselorId,groupId,score);
            }
        }

        private int CreateScoreChildCounselorAgeAndExp(List<Experience> expCounselor, int age)
        {
            var listValExp = expCounselor.Where(y => y.AgeFrom <= age && y.AgeTo >= age);
            if(listValExp.Count() == 0)
            {
                return 0;
            } else
            {
                int temp = listValExp.Max(x => x.Years);
                return temp;
            }
        }

        private int CreateScoreChildCounselorInterest(List<CounsellorInterests> interesCounselor, List<ChildInterests> childInterests)
        {
            int score = 0;
            int Count;
            int CountUnlike;
            if (interesCounselor.Count() >= childInterests.Count())
            {
                Count = interesCounselor.Count();
                CountUnlike = interesCounselor.RemoveAll(x => childInterests.Select(y => y.InterestId).Contains(x.InterestId));
            } else
            {
                Count = childInterests.Count();
                CountUnlike = childInterests.RemoveAll(x => interesCounselor.Select(y => y.InterestId).Contains(x.InterestId));
            }
            score = Count - CountUnlike;
            return score;
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
                    if(counsellor.Id == Id && counsellor.GroupId == null)
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
