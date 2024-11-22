// //using System;
//
// using System;
// using static System.Math;
// using static System.Convert;
// namespace project5
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int a = int.Parse(Console.ReadLine());
//             int b = int.Parse(Console.ReadLine());
//             // int c = int.Parse(Console.ReadLine());
//             //bool result = a >=0 || b <-2;
//             //Console.WriteLine(result);
//             //1 3 5 7 9 11 - нечетные числа
//             //2 4 6 8 10 12 - четные числа
//             bool s = a % 2 == 0 && b % 2 == 0;
//             Console.WriteLine(s);
//             // % и / и // a % 2 = 0 5 % 2 = 1  5 / 2 = 2
//         }
//     }
//
//     }



using System;
using static System.Math;
using static System.Convert;

namespace project5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Вводим три числа
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            
            // Проверяем, что B находится между A и C
            bool isBetween = (b > Math.Min(a, c) && b < Math.Max(a, c));
            
            // Выводим результат
            Console.WriteLine(isBetween);
        }
    }
}
