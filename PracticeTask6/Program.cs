using System;
namespace PracticeTask6
{
    class Program
    {
        static void Main(string[] args)
        {
            double valReal = 23.456f;
            int valInteger = 160;
            Console.WriteLine("Преобразуем int в другие целые типы");
            Console.WriteLine("\nТипы {0,14} {1,10} {2,10} {3,10} {4,10} {5,10}", "Int", "Int16", "Int32", "Int64", "Byte", "sbyte");
            Console.WriteLine("Значения {0,10} {1,10} {2,10} {3,10} {4,10} {5,10}", valInteger, (Int16)(valInteger), valInteger, (Int64)(valInteger), (Byte)(valInteger), (SByte)(valInteger));
            Console.WriteLine("Байты {0,13} {1,10} {2,10} {3,10} {4,10} {5,10}", sizeof(int), sizeof(Int16), sizeof(Int32), sizeof(Int64), sizeof(byte), sizeof(sbyte));
            Console.WriteLine("\nНажмите Enter");
            Console.ReadKey();
            Console.WriteLine("Преобразуем int в типы с плавающей точкой");
            Console.WriteLine("\nТипы {0,14} {1,10} {2,10}", "Int", "double", "Single");
            Console.WriteLine("Значения {0,10} {1,10} {2,10}", valInteger, (double)(valInteger), (Single)(valInteger));
            Console.WriteLine("Байты {0,13} {1,10} {2,10}", sizeof(int), sizeof(double), sizeof(Single));
            Console.WriteLine("\nНажмите Enter");
            Console.ReadKey();
            Console.WriteLine("Преобразуем double в Single и int");
            Console.WriteLine("\nТипы {0,14} {1,10} {2,10}", "Int", "double", "Single");
            Console.WriteLine("Значения {0,10} {1,10:F} {2,10:F}", (int)(valReal), valReal, (Single)(valReal));
            Console.WriteLine("Байты {0,13} {1,10} {2,10}", sizeof(int), sizeof(double), sizeof(Single));
            Console.WriteLine("\nНажмите Enter");
            Console.ReadKey();
        }
    }
}
