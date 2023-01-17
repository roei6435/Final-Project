using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_Club
{
    public class ClassesList
    {
        List<Classes> listC;
        public static string highKey = "high";
        public static string lowKey = "low";


        public ClassesList(List<Classes> listC)
        {
            this.listC = listC;
        }
        public bool checkIfKeyIsProper(string key)
        {
            if (key == highKey || key == lowKey) return true;
            return false;
        }
        public Classes findClassById(string classId)
        {
            foreach (Classes c in listC)
            {
                if (c.ClassId == classId)
                    return c;
            }
            return null;
        }

        public Classes findClassByName(string name)
        {
            foreach (Classes c in listC)
            {
                if (c.NameClass == name)
                    return c;
            }
            return null;
        }

        public int getCountActiveClasses()
        {
            int counter = 0;
            foreach(Classes classs in listC)
            {
                if(classs.Activity)
                    counter++;
            }
            return counter;
        }
        public Classes theMostPopulerOrNotPopulerClass(string key)
        {
            if (!checkIfKeyIsProper(key))return null;
            int maxFriends=0, minFriends = int.MaxValue;
            Classes populerClass=null, noPopulerClass=null;
            if (listC[0].ArrayRegisteredUsersThisClass != null)
            {
                minFriends = maxFriends = listC[0].ArrayRegisteredUsersThisClass.Length;
                noPopulerClass= populerClass= listC[0];
            }
            for(int i = 1; i < listC.Count; i++)
            {
                if (listC[i].ArrayRegisteredUsersThisClass != null)
                {
                    if (listC[i].ArrayRegisteredUsersThisClass.Length > maxFriends)
                    {
                        populerClass = listC[i];
                        maxFriends = listC[i].ArrayRegisteredUsersThisClass.Length;
                    }
                    else if (listC[i].ArrayRegisteredUsersThisClass.Length < minFriends)
                    {
                        noPopulerClass=listC[i];
                        minFriends = listC[i].ArrayRegisteredUsersThisClass.Length;
                    }
                }
               

            }
            switch (key)
            {
                case "high":
                    return populerClass;
                case "low":
                    return noPopulerClass;
                default:return null;


            }


        }
        
        public Classes theLowestAndHighstAvgGrade(string key)
        {
            float maxRating=0,minRating=6;
            Classes maxC=listC[0],minC=maxC;
            foreach (Classes c in listC)
            {
                if (c.ArrayReviews != null)
                {
                    int sumRating = 0;float avgNow;
                    for (int i = 0; i < c.ArrayReviews.Length; i++)
                    {
                        sumRating+=int.Parse(c.ArrayReviews[i].Rating);
                    }
                    avgNow= sumRating / (float)c.ArrayReviews.Length;
                    if(avgNow > maxRating)
                    {
                        maxRating = avgNow;
                        maxC= c;

                    }
                    else if(avgNow < minRating)
                    {
                        minRating = avgNow;
                        minC= c;    
                    }
                }            
            }
            switch (key)
            {
                case "high":
                    maxC.Pic.Tag = maxRating.ToString("0.#");
                    return maxC;
                case "low":
                    minC.Pic.Tag = minRating.ToString("0.#");
                    return minC;
                default: return null;
            }
        }

        public Classes getLowestAndHighstReviews(string key)
        {
            if (!checkIfKeyIsProper(key)) return null;
            int maxReviews=0, minReviews=int.MaxValue;
            Classes cMax, cMin; cMax = cMin = listC[0];
            for(int i = 0; i < listC.Count; i++)
            {
                if (key == lowKey && listC[i].ArrayReviews is null)  //if have class not reviews
                {
                    return listC[i];
                }
                else if (listC[i].ArrayReviews != null && listC[i].ArrayReviews.Length > maxReviews)
                {
                    maxReviews = listC[i].ArrayReviews.Length;
                    cMax = listC[i];
                }
                else if (listC[i].ArrayReviews != null && listC[i].ArrayReviews.Length < minReviews)
                {
                    minReviews = listC[i].ArrayReviews.Length;
                    cMin = listC[i];
                }
            }
            switch (key)
            {
                case "high":
                    return cMax;
                case "low":
                    return cMin;
                default: return null;
            }



              
        }

        public int getActiveClassesPercent()
        {
            float active = 0;
            foreach (Classes c in listC)
            {
                if (c.Activity)
                    active = active + 1.0f;
            }
            return (int)(active / listC.Count() * 100);
        }

        public string getAvgRaitingAllClasses()
        {
            float sumAllAvgRaitings = 0;
            foreach (Classes c in listC)
            {
                if (c.ArrayReviews != null)
                {
                    int sumRating = 0;
                    for (int i = 0; i < c.ArrayReviews.Length; i++)
                    {
                        sumRating += int.Parse(c.ArrayReviews[i].Rating);
                    }
                    sumAllAvgRaitings += sumRating / (float)c.ArrayReviews.Length;
                }

            }
           return (sumAllAvgRaitings/(float)listC.Count()).ToString("#.0");
        }

        public Classes getMostOrLeastFriendsClass(string key)
        {
            int maxFriends = 0,minFriends=int.MaxValue;Classes cMax=null,cMin=null;
            for(int i = 0; i < listC.Count; i++)
            {
                if (listC[i].ArrayRegisteredUsersThisClass != null)
                {
                    if(listC[i].ArrayRegisteredUsersThisClass.Length > maxFriends)
                    {
                        maxFriends = listC[i].ArrayRegisteredUsersThisClass.Length;
                        cMax = listC[i];
                    }
                    else if(listC[i].ArrayRegisteredUsersThisClass.Length < minFriends)
                    {
                        minFriends = listC[i].ArrayRegisteredUsersThisClass.Length;
                        cMin = listC[i];
                    }
                }
                else
                {
                    if(key==lowKey)
                        return listC[i];
                }
            }
            switch (key)
            {
                case "high":
                    return cMax;
                case "low":
                    return cMin;
                default: return null;


            }

        }



    }
}
