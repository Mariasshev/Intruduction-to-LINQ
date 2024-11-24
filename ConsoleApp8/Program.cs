using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{


    class Program
    {
        static void Main(string[] args)
        {
            //1 task
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Получение всего массива: ");
            foreach (var el in arr) Console.WriteLine(el);

            Console.WriteLine("Получение четных: ");
            var Arr2 = from el in arr
                       where el % 2 == 0
                       select el;

            foreach (var el in Arr2) Console.WriteLine(el);

            Console.WriteLine("Получение нечетных: ");
            var Arr3 = from el in arr
                       where el % 2 != 0
                       select el;

            foreach (var el in Arr3) Console.WriteLine(el);

            Console.WriteLine("Получение значения больше заданного: ");
            Console.Write("Введите число: ");
            int userNum = int.Parse(Console.ReadLine());

            var Arr4 = from el in arr
                       where el > userNum
                       select el;

            foreach (var el in Arr4) Console.WriteLine(el);


            Console.WriteLine("Получение чисел в заданном диапазоне: ");
            Console.Write("Введите 1 число: ");
            int start = int.Parse(Console.ReadLine());

            Console.Write("Введите 2 число: ");
            int end = int.Parse(Console.ReadLine());

            var Arr5 = from el in arr
                       where el >= start && el <= end
                       select el;
            foreach (var el in Arr5) Console.WriteLine(el);


            Console.WriteLine("Получение чисел кратные семи. Результат отсортировать по возрастанию: ");
            var Arr6 = from el in arr
                       where el % 7 == 0
                       orderby el
                       select el;

            foreach (var el in Arr6) Console.WriteLine(el);

            Console.WriteLine("Получение чисел кратные восьми. Результат отсортировать по возрастанию: ");
            var Arr7 = from el in arr
                       where el % 8 == 0
                       orderby el
                       select el;

            foreach (var el in Arr7) Console.WriteLine(el);
        }
    }
}
