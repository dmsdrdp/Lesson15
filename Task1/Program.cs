using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArithProgressin arith = new ArithProgressin();       // Арифметическая прогрессия
            GeomProgression geom = new GeomProgression();        // Геометрическая прогрессия

            Console.WriteLine("Введите начальное значение арифметической прогрессии");
            arith.SetStart(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Введите шаг арифметической прогрессии");
            arith.setStep(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Арифметическая прогрессия");  // Проверка арифметической прогрессия
            Console.WriteLine(arith.GetNext()); 
            Console.WriteLine(arith.GetNext());
            Console.WriteLine(arith.GetNext());
            Console.WriteLine(arith.GetNext());
            Console.WriteLine(arith.GetNext());
            Console.WriteLine("Сброс");                      
            arith.Reset();                                   // Сброс
            Console.WriteLine(arith.GetNext());
            Console.WriteLine(arith.GetNext());

            Console.WriteLine("Введите начальное значение геометрической прогрессии"); // Проверка геометрической прогрессия
            geom.SetStart(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Введите шаг геометрической прогрессии");
            geom.setStep(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine(geom.GetNext());
            Console.WriteLine(geom.GetNext());
            Console.WriteLine(geom.GetNext());
            Console.WriteLine(geom.GetNext());
            Console.WriteLine(geom.GetNext()); 
            Console.WriteLine("Сброс");                       
            arith.Reset();                                          // Сброс
            Console.WriteLine(geom.GetNext());
            Console.WriteLine(geom.GetNext()); 

            Console.ReadKey();

        }
    }
}
