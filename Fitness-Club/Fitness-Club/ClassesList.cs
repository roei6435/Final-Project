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
        
        public string theLowestAndHighstAvgGrade(string key)
        {
            if (!checkIfKeyIsProper(key)) return null;
            float max = 0f, min = 6f;
            string nameClassLower=null, nameClassUpper=null;   
            for(int i = 0;i < listC.Count; i++)
            {
                float sum = 0;
                if(listC[i].ArrayReviews!= null)
                {
                    for(int j = 0; j < listC[i].ArrayReviews.Length; j++)
                    {
                        int rating = int.Parse(listC[i].ArrayReviews[j].Rating);
                        sum+=rating;
                    }
                    if (sum / listC[i].ArrayReviews.Length < min)
                    {
                        min = sum / (float)listC[i].ArrayReviews.Length;
                        nameClassLower=listC[i].NameClass;    
                    }
                    else if(sum / listC[i].ArrayReviews.Length > max)
                    {
                        max = sum / (float)listC[i].ArrayReviews.Length;
                        nameClassUpper = listC[i].NameClass;
                    }
                }
            }
            switch (key)
            {
                case "low":
                    return nameClassLower + "#" + min.ToString("0.#");
                case "high":
                    return nameClassUpper + "#" + max.ToString("0.#");
                default:return null;
            }

        }

        public string theLowestAndHighstReviews(string key)
        {
            if (!checkIfKeyIsProper(key)) return null;
            int maxReviews=0, minReviews=int.MaxValue;
            Classes cMax, cMin; cMax = cMin = listC[0];
            for(int i = 0; i < listC.Count; i++)
            {
                if (key == lowKey && listC[i].ArrayReviews is null)  //if have class not reviews
                {
                    return listC[i].NameClass + "#" + 0;
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
                    return cMax.NameClass + "#" + maxReviews;
                case "low":
                    return cMin.NameClass + "#" + minReviews;
                default: return null;
            }



              
        }

    }
}
