using System;

namespace DZ_2._1
{
    class Program
    {
        static void Main(string[] args)
            
        {
            Console.WriteLine($"Для определения средней температуры за сутки требуется ввести необходимые данные." +
                $"Введите min температуру за сутки :") ; 
                int min = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите максимальную температуру за сутки :");
                int max = int.Parse(Console.ReadLine());
                int temp = ((min + max) / 2);
            Console.WriteLine($"Средняя температура за сутки : {temp}");
         


        }
        
    }
}
