using System;

namespace Dz3arrays
{
    class Program
    {
        static int TryParseInput()
        {
            int proverka;

            while (!int.TryParse(Console.ReadLine(), out proverka))
            {
                Console.WriteLine("!Значение не является целым числом!");
            }
            return proverka;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите более двух элементов массива:");

            int ArrLen = TryParseInput();

            while (ArrLen < 2)

            {
                Console.WriteLine("!Введите больше двух элементов!");

                ArrLen = TryParseInput();
            }

            Console.WriteLine($"Длина массива: {ArrLen}");

            int[] Array = new int[ArrLen];

            Console.WriteLine("Ручной ввод значений");

            for (int i = 0; i < ArrLen; i++)
            {
                Console.WriteLine($"Введите элемент массива № {i + 1}");

                Array[i] = TryParseInput();
            }

            Console.WriteLine("Вывод массива:");

            foreach (int Val in Array)
            {
                Console.Write($"{Val} ");
            }
            Console.WriteLine();

            int largestVal = 0;

            int secondLargestVal = 0;

            foreach (var Val in Array) if (Val > largestVal) largestVal = Val;

            Console.WriteLine($"Самое наибольшое значение: {largestVal}");

            foreach (var Val in Array)
            {
                if (Val > secondLargestVal && Val < largestVal) secondLargestVal = Val;
            }
            Console.WriteLine($"Второе наибольшее значение: {secondLargestVal}");
        }
    }
}