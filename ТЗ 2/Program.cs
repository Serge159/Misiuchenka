using System;

namespace ТЗ_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите мужское имя");
            String a = Console.ReadLine();
            
            if (a == "Вячеслав")
                Console.WriteLine("Привет Вячеслав");
            else
                Console.WriteLine("Нет такого имени");
        }
    }
}
