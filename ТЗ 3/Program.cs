using System;

namespace ТЗ_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов массива:\t");
            int elementsCount = int.Parse(Console.ReadLine());
            int[] mass = new int[elementsCount];

            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write($"Введите элемент массива под индексом {i}:\t");
                mass[i] = int.Parse(Console.ReadLine());
            }

            int a;
           
            for ( a = 0; a < mass.Length; a++)
            {
                if (mass[a] % 3 == 0)
                    Console.WriteLine($"Число кратное трем: { mass[a]}");
            }
        }
    }
}
