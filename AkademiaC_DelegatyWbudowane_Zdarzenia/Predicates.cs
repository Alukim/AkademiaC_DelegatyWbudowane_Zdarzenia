using System;
using System.Collections.Generic;

namespace AkademiaC_DelegatyWbudowane_Zdarzenia
{
    public class Predicates : IIntroducer
    {
        public void Introduce()
        {
            FindAll();
            Collection();
        }

        private void FindAll()
        {
            var list = new List<int> { 11, 2, 13, 9, 22 };

            Predicate<int> gratherThanTenPredicate = GreatherThanTen;
            Predicate<int> lowerThanTwentyPredicate = LowerThanTwenty;

            var newList = list.FindAll(gratherThanTenPredicate);

            Methods.ShowList(newList);

            newList = list.FindAll(lowerThanTwentyPredicate);

            Methods.ShowList(newList);
        }

        public static bool GreatherThanTen(int arg)
        {
            return arg > 10;
        }

        public static bool LowerThanTwenty(int arg)
        {
            return arg < 20;
        }

        private void Collection()
        {
            Predicate<Person> predicateMethod = MoreThan22;
            Person[] lstPeople =
            {
                new Person(){ Name = "Tomek", Age = 23},
                new Person(){ Name = "Franko", Age = 21},
                new Person(){ Name = "Doman", Age = 18},
                new Person(){ Name = "Alicja", Age = 19},
            };

            var tempPerson = Array.Find(lstPeople, predicateMethod);
            Console.WriteLine("Person older than 22 is :" + tempPerson.Name);
            Console.ReadKey();
        }

        public static bool MoreThan22(Person employee)
        {
            return employee.Age > 22;
        }
    }
}
