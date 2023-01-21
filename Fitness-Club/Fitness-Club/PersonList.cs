using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_Club
{
    internal class PersonList
    {

        List<Person> listP;
        public string adminKey = "admins";
        public string userKey = "users";
       
        public PersonList(List<Person> listP)
        {
            this.listP = listP;
        }

        public Person findPersonById(string userId)
        {
            foreach (Person p in listP)
            {
                if (p.UserId == userId)
                    return p;
            }
            return null;
        }
        public bool checkIfKeyIsProper(string key)
        {
            if(key == adminKey || key== userKey) return true;
            return false;
        }

        //A FUNCTION THAT RECEIVES A LIST OF PERSONS AND SPLITTED INTO TWO LISTS OF ADMINS AND USERS
        public List<Person> getOnlyUsersOrAdminsFromListPerson(string key)
        {
            if (!checkIfKeyIsProper(key)) return null;
            List<Person>newList=new List<Person>();
            if (key == adminKey)
            {
                foreach(Person person in listP)
                {
                    if(person.IsAdmin)
                        newList.Add(person);
                }
                return newList;
            }
            foreach (Person person in listP)
            {
                if (!person.IsAdmin)
                    newList.Add(person);
            }
            return newList;
        }

        //RETURN COUNT ADMINS ADN USERS IN SYSTEM BY KEY
        public int CountAdminsANDUsersInSystem(string key)
        {
            if (!checkIfKeyIsProper(key)) return 0;
            List<Person> newList = getOnlyUsersOrAdminsFromListPerson(key);   
            return newList.Count();
        }

        public int PercentageGenderForUserORAdmins(string key)
        {
            if (!checkIfKeyIsProper(key)) return 0;
            List<Person>newList=getOnlyUsersOrAdminsFromListPerson(key);
            float male = 0;
            foreach (Person person in newList)
            {
                if (person.Gender)
                    male = male + 1.0f;
            }
            return (int)(male / newList.Count() * 100);
        }

        //A FUNCTION THAT RETURNS THE PERCENTAGE OF BLOCKED USERS IN THE SYSTEM.
        public int PercentageIsBlockedForUser()
        {
            float isBlocked = 0;
            foreach (Person person in listP)
            {
                if (!person.IsAdmin && person.IsBlocked)
                    isBlocked = isBlocked + 1.0f;
            }
            return (int)(isBlocked / CountAdminsANDUsersInSystem(userKey) * 100);
        }


        //A FUNCTION THAT RECEIVES A LIST OF EMAILS AND RETURNS IN A STRING WHAT IS THE PREFERRED
        //EMAIL AND IN WHAT PERCENTAGE OF THE TOTAL LIST.
        public string CheckFavoriteMailANDPercentForOneList(List<string> emails)
        {
            List<string> tmp = emails;
            int max = 0; string favEmail = "";
            for (int i = 0; i < tmp.Count - 1; i++)
            {

                int counter = 1;
                for (int j = i + 1; j < tmp.Count; j++)
                {
                    if (tmp[j] == tmp[i])
                    {
                        counter++;
                    }

                }
                if (counter > max)
                {
                    favEmail = tmp[i];
                }

            }
            float percent = emails.Count(s => s == favEmail);  //5
            percent=percent / emails.Count() * 100;       // 5/8*100
            return favEmail + " " + percent.ToString("0");
        }


        //A FUNCTION THAT RECEIVES A LIST OF PERSONALITIES AND BUILDS TWO EMAIL LISTS
        //FOR ADMINISTRATORS AND USERS IN ORDER TO PERFORM ACTIONS.
        public string GetFavoriteEmailAndHowMatchPercent(string key)
        {

            if (key != adminKey && key != userKey)return null;
            List<Person>newList= getOnlyUsersOrAdminsFromListPerson(key);
            List<string> emailsList = new List<string>();
           foreach(Person person in newList)
           {
                string email = person.Email;  //Roei6435@gmail.com
                try
                {
                    email = email.Split('@')[1];     //gmail.com
                    email = email.Split('.')[0];    //gmail
                    emailsList.Add(email);
                }
                catch
                {

                }

           }
           return CheckFavoriteMailANDPercentForOneList(emailsList);
        }

        //A FUNCTION THAT GET A DATE AND RETURNS AN AGE.
        public static float GetAge(string dateOfBirth)
        {
            DateTime dateOfBirth1 = Convert.ToDateTime(dateOfBirth);
            var today = DateTime.Today;

            var a = (today.Year * 100 + today.Month) * 100 + today.Day;
            var b = (dateOfBirth1.Year * 100 + dateOfBirth1.Month) * 100 + dateOfBirth1.Day;

            return (float)(a - b) / 10000;
        }

        //A FUNCTION THAT RETURNS AVG OF AGES.
        public float getAvgForListOfAdminsOrUsers(string key)
        {
            if (!checkIfKeyIsProper(key)) return 0;
            List<Person> newList = getOnlyUsersOrAdminsFromListPerson(key);
            float sum = 0f;
            foreach(Person person in newList)
            {
                sum += GetAge(person.DateBorn);
            }
            return   sum/ newList.Count();
        }



        //A FUNCTION THAT RETURNS THE MOST EXPERIENCED USER OR ADMINS AND ALSO THE LEAST EXPERIENCED.
        public List<Person> theMostAndLeastExperiencedUserOrAdmins(string key)
        {
            if (!checkIfKeyIsProper(key)) return null;
            List<Person> newList = getOnlyUsersOrAdminsFromListPerson(key);
            Person personMostExprince=newList[0], personLeastExperienced= newList[0];
            float max =GetAge(newList[0].DateRegistion), min = max;
            foreach (Person person in newList)
            {
                if (GetAge(person.DateRegistion) > max)
                {
                    max = GetAge(person.DateRegistion);
                   personMostExprince = person;
                }
                if (GetAge(person.DateRegistion) < min)
                {
                    min = GetAge(person.DateRegistion);
                    personLeastExperienced = person;
                }
            }
            newList.Clear();    
            newList.Add(personMostExprince);
            newList.Add(personLeastExperienced);
            return newList;

        }

        //A FUNCTION THAT RETURN THE MOST OLDER USER OR ADMIN AND ALSO THE MOST YOUNGER.
        public List<Person> theMostOlderAndMostYoungerUserOrAdmin(string key)
        {
            if (!checkIfKeyIsProper(key)) return null;
            List<Person> newList = getOnlyUsersOrAdminsFromListPerson(key);
            Person personMostOlder = newList[0], personMostYounger = newList[0];
            float max = GetAge(newList[0].DateBorn), min = max;
            foreach (Person person in newList)
            {
                if (GetAge(person.DateBorn) > max)
                {
                    max = GetAge(person.DateBorn);
                    personMostOlder = person;
                }
                if (GetAge(person.DateBorn) < min)
                {
                    min = GetAge(person.DateBorn);
                    personMostYounger = person;
                }
            }
            newList.Clear();
            newList.Add(personMostOlder);
            newList.Add(personMostYounger);
            return newList;
        }

        public Person theLeastOrMustActiveUser(string key)
        {

            int maxClassesRegisted = 0, minClassesRegisted = int.MaxValue;
            Person pMax, pMin; pMax = pMin = listP[0];
            for (int i = 0; i < listP.Count; i++)
            {
                if (key == "low" && listP[i].ClassesArray is null)  //if have class not reviews
                {
                    return listP[i];
                }
                else if (listP[i].ClassesArray != null && listP[i].ClassesArray.Length > maxClassesRegisted)
                {
                    maxClassesRegisted = listP[i].ClassesArray.Length;
                    pMax = listP[i];
                }
                else if (listP[i].ClassesArray != null && listP[i].ClassesArray.Length < minClassesRegisted)
                {
                    minClassesRegisted = listP[i].ClassesArray.Length;
                    pMin = listP[i];
                }
            }
            switch (key)
            {
                case "low":
                    return pMin;
                case "high":
                    return pMax;
                default: return null;
            }
        }




        //--------------------------------------------------------------------------
        public float getAvgForList()
        {
            float sum = 0f;
            foreach (Person person in listP)
            {
                sum += GetAge(person.DateBorn);
            }
            return sum / listP.Count();
        }
        public int getCountConnectInLastWeek()
        {
            int counter = 0;
            foreach (Person person in listP)
            {
                var prevDate = Convert.ToDateTime(person.LastConnect);
                var today = DateTime.Now;

                var connectBefore = today - prevDate;
                if (connectBefore.Days<8)
                {
                    counter++;  
                }
            }
            return counter;

        }

        public int getPercentageGender()
        {
            float male = 0;
            foreach (Person person in listP)
            {
                if (person.Gender)
                    male = male + 1.0f;
            }
            return (int)(male / listP.Count() * 100);
        }
        public int getPercentageIsBlocked()
        {
            float isBlocked = 0;
            foreach (Person person in listP)
            {
                if (person.IsBlocked)
                    isBlocked = isBlocked + 1.0f;
            }
            return (int)(isBlocked / listP.Count() * 100);
        }



        public Person getMostActiveAdminByTweets()
        {
            try
            {
                string response = ConnectWithServer.callToServer(AdminsStaticts.controller, "getUserIdOfMostActiveAdminByTweest#", "");
                if (response == string.Empty)
                {
                    return null;
                }
                Person p = findPersonById(response.Split('#')[0]);
                p.Email = response.Split('#')[1];     //(SET IN EMAIL FEILD THE COUNT OF TWEET)
                return p;
            }
            catch
            {
                return null;
            }

        }
        public Person getMostOlderOrMostYounger(string key)
        {
            Person older=listP[0], younger=listP[0];
            float max = GetAge(listP[0].DateBorn), min = max;
            for(int i = 1;i < listP.Count; i++)
            {
                float ageNow=GetAge(listP[i].DateBorn);
                if (ageNow> max)
                {
                    max = ageNow;
                    older = listP[i];
                }
                if (ageNow < min)
                {
                    min = ageNow;
                    younger = listP[i];
                }
            }
            if (key == "low")
            {
                return younger;
            }
            else if (key == "high")
            {
                return older;
            }
            return null;
        }

        public Person getMostAndLeastExperiencedAdmins(string key)
        {
            Person senior = listP[0], younger = listP[0];
            float max = LoginANDRegister.diffFromDatesInWeek(listP[0].DateRegistion), min = max;
            for (int i = 1; i < listP.Count; i++)
            {
                float diffNow = LoginANDRegister.diffFromDatesInWeek(listP[i].DateRegistion);
                if (diffNow > max)
                {
                    max = diffNow;
                    senior = listP[i];
                }
                if (diffNow < min)
                {
                    min = diffNow;
                    younger = listP[i];
                }
            }
            if (key == "low")
            {
                return younger;
            }
            else if (key == "high")
            {
                return senior;
            }
            return null;
        }

        public Person getMostActiveClientByClasses()
        {

            int i = 0;
            while (listP[i].ClassesArray is null)
            {
                i++;
            }
            Person active = listP[i]; int max = listP[i].ClassesArray.Length;
            while (i < listP.Count)
            {
                if (listP[i].ClassesArray != null && listP[i].ClassesArray.Length > max)
                {
                    max = listP[i].ClassesArray.Length;
                    active = listP[i];
                }
                i++;
            }
            return active;

        }

        public Person getTheUserPaidMax()
        {
            int i = 0;
            while (listP[i].ClassesArray is null)
            {
                i++;
            }
            Person paidMax = listP[i]; int max = listP[i].getSumOfPaidInTheLastMonth(), paidThisMonth;
            while (i < listP.Count)
            {
                 paidThisMonth = listP[i].getSumOfPaidInTheLastMonth();
                if (paidThisMonth != 0 && paidThisMonth > max)
                {
                    max = paidThisMonth;
                    paidMax = listP[i];
                }
                i++;
            }
            paidMax.Email = max.ToString();
            return paidMax;

        }


        private List<Payments> getTheListOfPaymentsLastMonth()
        {
            List<Payments> paymentsFromLastMonth = new List<Payments>();
            foreach(Person person in listP)
            {
                if (person.PaymentsArray != null)
                {
                    for(int j = 0; j < person.PaymentsArray.Length; j++)
                    {
                        if (person.PaymentsArray[j].Date.Month == DateTime.Now.Month)
                        {
                            paymentsFromLastMonth.Add(person.PaymentsArray[j]);
                        }
                    }
                }
                
            }
            return paymentsFromLastMonth;
        }
        public Classes getTheMostIncomeClassInLastMonth()
        {
            List<Payments>list=getTheListOfPaymentsLastMonth();
            int max = 0;
            Classes cMax = null;
            for (int i = 0; i < list.Count; i++)
            {
                int counter = 0;
                for (int j = 0; j < list.Count; j++)
                {
                    if (list[i].ClassP.ClassId == list[j].ClassP.ClassId)
                    {
                        counter++;
                    }
                }
                if (counter > max)
                {
                    max = counter;
                    cMax = list[i].ClassP;
                }

            }
            max = 0;
            foreach (Payments pay in list)
            {
                if (pay.ClassP == cMax)
                    max += int.Parse(pay.Sum);
            }
            cMax.About = max + "";
            return cMax;

        }








    }
}
