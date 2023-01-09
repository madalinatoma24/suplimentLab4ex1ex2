using System;

namespace suplimentLab4
{
    class Program
    {
        static void Main(string[] args)
        {

            /* 1.
             Se citesc doua numere de la tastatura. Scrieti un program care va calcula
             cel mai mare divizor comun al numerelor
             */
            Console.WriteLine("Introduceri primul numar: ");
            int firstNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceri al doilea numar: ");
            int secondNum = int.Parse(Console.ReadLine());
            Console.WriteLine($"Cel mai mare divizor comun este: {MaxDivisor(firstNum, secondNum)}");


            /* 2.
            Scrie un program care afiseaza numerele de la 1 la N. Daca numarul este
            multiplu de 3, sa se afiseze Fizz, daca este multiplu de 3 sa se afiseze Buzz,
            daca e multiplu si de 3 si de 5 (ex: 15) sa se afiseze FizzBuzz, in restul
            cazurilor sa se afiseze numarul
            */
            Console.WriteLine("Introduceti numarul: ");
            int num = int.Parse(Console.ReadLine());
            CheckMultiples(num);
        }

        static int MaxDivisor(int firstNum, int secondNum)
        {
            var temp = 0;
            while (firstNum != 0 && secondNum != 0)
            {
                if (firstNum > secondNum)
                {
                    firstNum %= secondNum;
                }
                else
                {
                    secondNum %= firstNum;
                }
            }
            if (firstNum == 0)
            {
                temp = secondNum;
            }
            else
            {
                temp = firstNum;
            }
            return temp;
        }


        static void CheckMultiples(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 != 0)
                {
                    Console.WriteLine($@"Fizz, Buzz");

                }
                else if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else
                {
                    Console.WriteLine($"{i}");
                }
            }

        }
    }
}
