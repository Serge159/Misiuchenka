using System;

namespace ТЗ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число");
            int a = Convert.ToInt32(Console.ReadLine());
            
            if (a > 7)
                Console.WriteLine("Привет");
            else
                Console.WriteLine("Введите другое число");
        }
    }
}
