using Max;
using MaxSum;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace MaxSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = null;
            Calculation result = new Calculation();
            if (args.Length != 0)
            {
                for (int i = 0; i < args.Length; i++)
                {
                    path = args[i].Trim('"');
                    if (File.Exists(path))
                    {
                        result.calc(path);
                    }
                    else
                    {
                        Console.WriteLine("Некоректный путь к файлу");
                    }
                }
            }
            else if (args.Length == 0)
            {
                Console.Write("Укажите путь к файлу - ");
                path = Console.ReadLine().Trim('"');
            }
            
        }
    }
}
