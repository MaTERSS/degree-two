/*
 Найдите минимальную степень двойки, превосходящую заданное число. 
К примеру, для числа 4 будет 2 в степени 3, то есть 8. 4<8.
Для числа 29 будет 2 в степени 5, то есть 32. 29<32.
В консоль вывести число (лучше получить от Random), степень и само число 2 в найденной степени.
Math.Pow не используйте, реализовать надо с помощью простых математических операций.
 */
using System;
using System.Text;

namespace CSharplight
{
    internal class Programm
    {
        static void Main(string[] args)
        {
            int numberForDegree = 2;
            int numberToDegree = 2;
            int degree = 1;
            int startOfRange = 0;
            int endOfRange = 30;
            Random random = new Random();
            int number = random.Next(startOfRange, endOfRange);
            
            while (numberToDegree <= number)
            {                
                numberToDegree *= numberForDegree;  
                degree++;                
            }           
         
                Console.WriteLine($"для числа {number} будет {numberForDegree} в степени {degree}, то есть {numberToDegree}");
        }
    }
}
