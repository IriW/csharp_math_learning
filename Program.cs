using System;
using System.Collections.Generic;

namespace MathLearningProject
{
    class Program
    {
        static void HomeTaskDoubleRadius()
        {
            double a = Math.Pow(2.50, 2);
            double b = a * Math.PI;
            Console.WriteLine("Wyliczenie pola koła, pierwsza wersja:");
            Console.WriteLine($"Pole koła równa się {Math.Pow(2.50, 2) * Math.PI}");
            Console.WriteLine("Druga wersja:");
            Console.WriteLine($"Pole koła równa się {b}");
        }
        static void IfElseTraining()
        {
            int one = 45;
            int two = 66;
            int three = 11;

            if (one + three > two)
            {
                Console.WriteLine($"{one} + {three} większe niż {two}, ponieważ suma tych liczb wynosi {one + three}");
            }
            else
            {
                Console.WriteLine($"Suma {one} + {three} jest większa, niż {two}, ponieważ ich suma wynosi {one + three}");
            }
        }
        static void LearnIf()
        {
            int a = 6;
            int b = 8;
            int c = 4;
            if ((a + b + c > 10) && (a == b))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("And the first number is equal to the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("Or the first number is not equal to the second");
            }
        }

        static void WhileLoop()
        {
            int age = 32;
            while(age < 40)
            {
                Console.WriteLine($"It's still OK to be {age} ");
                age++;
            }

            Console.WriteLine("Alternative working the same way (the result should be the same):");

            int NewAge = 32;
            do
            {
            Console.WriteLine($"It's still OK to be {NewAge} ");
            NewAge++;
            } while (NewAge < 40);
            
        }
            static void ForLoop()
            {
                for (int index = 0; index < 10; index++)
                {
                Console.WriteLine($"Hello World! The index is {index}");
                }

                for (int loggerending = 10001; loggerending < 10011; loggerending++)
                {
                Console.WriteLine($"Logger_5433_0982340{loggerending}");
                };
            }

        static int SumOfDivisibles()
        {
     //Task: in numbers ranging from 0 to 70 find all the numbers divisible by 7 and sum them up

        int sum = 0;
        for (int nr =1; nr < 71; nr++)
            {
                if (nr % 7 == 0)
                {
                sum = sum + nr;
                }
            }
        Console.WriteLine($"My result is: {sum}");
        }
        static void Lists()
            //another home task
        {
            Console.WriteLine();
var buy = new List<string> {"dress", "shirt", "pants"};
foreach(var item in buy)
    {
    Console.WriteLine($"My list includes: {item}");
    }
var shopItemIndex = buy.IndexOf("pantss");
if (shopItemIndex != -1)
    {
        Console.WriteLine($"The name {buy[shopItemIndex]} has index {shopItemIndex}");
    }
else
    {
        var notFound = buy.IndexOf("notFound");
        {
            Console.WriteLine("You failed. Review your code and try again.");
        }
    }

        }
                static void Main()
        {
            Console.WriteLine("The sum of divisibles in the given range is "+SumOfDivisibles()+".");
            //Lists();
        }
    }
}
