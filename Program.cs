// // Задача 10: Напишите программу, которая принимает 
// // на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// // 456 -> 5
// // 782 -> 8
// // 918 -> 1

// int FindMiddleDigit(int num)
// {
//     if (num > 99 && num < 1000)
//      {
//         return (num / 10) % 10;
//      }
//      else
//      {
//         return -1;
//      }
// }
// System.Console.Write("Input your number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine(FindMiddleDigit(num));


// Задача 13: Напишите программу, которая выводит третью цифру
//  заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// int FindThirdDigit(int num)
// {
// if (num < 100)
// { 
//     System.Console.WriteLine("третьей цифры нет");
// }
// while (num > 999)
// {
//     num = num / 10;
// }

// return num % 10;
// }

// System.Console.Write("Input your number: ");
// int num = Convert.ToInt32(System.Console.ReadLine());

// System.Console.WriteLine(FindThirdDigit(num));


// Задача 15: Напишите программу, которая принимает на вход цифру,
//  обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// void WeeKendOrNot(int num)
// {
//     if (num < 1 | num > 7)
//     {
//         System.Console.WriteLine("это не день недели");
//     }
//     if (num < 6 && num > 0)
//     {
//         System.Console.WriteLine("не выходной день");
//     }
//    if (num > 5 && num < 8)
   
//    {
//        System.Console.WriteLine("выходной день");
//    }
// }

// System.Console.Write("Input your Day's number: ");

// int dayNum = Convert.ToInt32(System.Console.ReadLine());

// WeeKendOrNot(dayNum);
