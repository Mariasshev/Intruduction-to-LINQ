using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string University { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {
            //1 task
            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //Console.WriteLine("Получение всего массива: ");
            //foreach (var el in arr) Console.WriteLine(el);

            //Console.WriteLine("Получение четных: ");
            //var Arr2 = from el in arr
            //           where el % 2 == 0
            //           select el;

            //foreach (var el in Arr2) Console.WriteLine(el);

            //Console.WriteLine("Получение нечетных: ");
            //var Arr3 = from el in arr
            //           where el % 2 != 0
            //           select el;

            //foreach (var el in Arr3) Console.WriteLine(el);

            //Console.WriteLine("Получение значения больше заданного: ");
            //Console.Write("Введите число: ");
            //int userNum = int.Parse(Console.ReadLine());

            //var Arr4 = from el in arr
            //           where el > userNum
            //           select el;

            //foreach (var el in Arr4) Console.WriteLine(el);


            //Console.WriteLine("Получение чисел в заданном диапазоне: ");
            //Console.Write("Введите 1 число: ");
            //int start = int.Parse(Console.ReadLine());

            //Console.Write("Введите 2 число: ");
            //int end = int.Parse(Console.ReadLine());

            //var Arr5 = from el in arr
            //           where el >= start && el <= end
            //           select el;
            //foreach (var el in Arr5) Console.WriteLine(el);


            //Console.WriteLine("Получение чисел кратные семи. Результат отсортировать по возрастанию: ");
            //var Arr6 = from el in arr
            //           where el % 7 == 0
            //           orderby el
            //           select el;

            //foreach (var el in Arr6) Console.WriteLine(el);

            //Console.WriteLine("Получение чисел кратные восьми. Результат отсортировать по возрастанию: ");
            //var Arr7 = from el in arr
            //           where el % 8 == 0
            //           orderby el
            //           select el;

            //foreach (var el in Arr7) Console.WriteLine(el);


            //task 2
            //string[] cities = { "Италия", "Киев", "Мадрид", "Анталья", "Барселона", "Днепр", "Непал" };
            //Console.WriteLine("Получение всего массива городов: ");
            //foreach (var el in cities) Console.WriteLine(el);

            //Console.WriteLine("Получение города с длиной названия равной заданному: ");
            //Console.Write("Введите город: ");
            //string userCity = Console.ReadLine();

            //var city1 = from el in cities
            //            where el.Length == userCity.Length
            //            select el;

            //foreach (var el in city1) Console.WriteLine(el);


            //Console.WriteLine("Получение города названия, которых начинается с буквы A: ");
            //var city2 = from el in cities
            //            where el.ToUpper().StartsWith("А")
            //            select el;

            //foreach (var el in city2) Console.WriteLine(el);


            //Console.WriteLine("Получение города названия, которых заканчивается на букву M: ");
            //var city3 = from el in cities
            //            where el.ToUpper().EndsWith("М")
            //            select el;

            //foreach (var el in city3) Console.WriteLine(el);

            //Console.WriteLine("Получение города названия, которых начинаются на N и заканчиваются на букву K: ");
            //var city4 = from el in cities
            //            where el.ToUpper().StartsWith("Н") && el.ToUpper().EndsWith("К")
            //            select el;

            //foreach (var el in city4) Console.WriteLine(el);

            //Console.WriteLine("Получение города названия, которых начинаются на Ne. Результат отсортировать по убыванию: ");
            //var city5 = from el in cities
            //            where el.StartsWith("Не")
            //            orderby el
            //            select el;

            //foreach (var el in city5) Console.WriteLine(el);


            //task 3

            List<User> users = new List<User>
            {
                new User { Name = "Alice", Surname = "Johnson", Age = 23, University = "IT Step" },
                new User { Name = "Boris", Surname = "Smith", Age = 18, University = "IT Step" },
                new User { Name = "Carol", Surname = "Davis", Age = 22, University = "Oxford" },
                new User { Name = "David", Surname = "Wilson", Age = 24, University = "MIT" },
                new User { Name = "Brody", Surname = "Taylor", Age = 23, University = "IT Step" }

            };

            Console.WriteLine("Получить весь массив студентов: ");
            foreach (var el in users) Console.WriteLine(el);

            Console.WriteLine("Получить студентов с именем Boris: ");
            var user1 = from el in users
                        where el.Name == "Boris"
                        select el;
            foreach (var el in user1) Console.WriteLine(el);

            Console.WriteLine("Получить студентов с фамилией, которая начинается с Bro: ");
            var user2 = from el in users
                        where el.Surname.StartsWith("Bro")
                        select el;
            foreach (var el in user2) Console.WriteLine(el);

            Console.WriteLine("Получить студентов, которые старше 19 лет: ");
            var user3 = from el in users
                        where el.Age > 19
                        select el;
            foreach (var el in user3) Console.WriteLine(el);

            Console.WriteLine("Получить студентов, которые старше 20 лет и младше 23 лет: ");
            var user4 = from el in users
                        where el.Age > 20 && el.Age < 23
                        select el;
            foreach (var el in user4) Console.WriteLine(el);

            Console.WriteLine("Получить студентов, которые учатся в MIT: ");
            var user5 = from el in users
                        where el.University == "MIT"
                        select el;
            foreach (var el in user5) Console.WriteLine(el);

            Console.WriteLine("Получить студентов, которые учатся в Oxford и их возраст старше 18 лет. Результат отсортировать по возрасту по убыванию: ");
            var user6 = from el in users
                        where el.University == "Oxford" && el.Age > 18
                        orderby el
                        select el;
            foreach (var el in user6) Console.WriteLine(el);





        }
    }
}
