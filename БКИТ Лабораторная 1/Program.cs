using System;

namespace БКИТ_Лабораторная_1

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Герасименко Анастасия ИУ5-35Б";
            double a, b, c;
            if (args.Length == 3)
            {
                Console.WriteLine("Аргументы из строки.");
                try
                {
                    a = Double.Parse(args[0]);
                    b = Double.Parse(args[1]);
                    c = Double.Parse(args[2]);
                }
                catch
                {
                    Console.WriteLine("Аргументы строки некорректны.");
                    a = ReadDouble("Введите коэффициент А: ");
                    b = ReadDouble("Введите коэффициент B: ");
                    c = ReadDouble("Введите коэффициент C: ");
                }
            }
            else
            {
                Console.WriteLine("Введите аргументы для уравнения вида: А*x^4 + B*x^2 + C = 0");
                a = ReadDouble("Введите коэффициент А: ");
                b = ReadDouble("Введите коэффициент B: ");
                c = ReadDouble("Введите коэффициент C: ");
            }
            if (a == 0 && b != 0)
            {
                double root = (-1 * c) / b;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Корни " + Math.Sqrt(root) + " и -" + Math.Sqrt(root));
            }
            else if (a != 0)
            {
                double d = b * b - 4 * a * c;
                Console.WriteLine("Дискриминант: " + d);
                if (d > 0)
                {
                    double root_1 = (-1 * b + Math.Sqrt(d)) / (2 * a);
                    double root_2 = (-1 * b - Math.Sqrt(d)) / (2 * a);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Корни уравнения: ");
                    Console.WriteLine("x1: " + Math.Sqrt(root_1));
                    Console.WriteLine("x2: " + -1 * Math.Sqrt(root_1));
                    Console.WriteLine("x3: " + Math.Sqrt(root_2));
                    Console.WriteLine("x4: " + -1 * Math.Sqrt(root_2));
                }
                else if (d < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Корней нет :-( ");
                }
                else
                {
                    double root = (b + Math.Sqrt(d)) / (2 * a);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Корни уравнения: " + Math.Sqrt(root) + " и " + -1 * Math.Sqrt(root));
                }
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Оба коэффициента при х равны нулю.");
            }
            Console.ReadLine();
        }
        static double ReadDouble(string consoleMessage)
        {
            string resultString;
            double resultDouble;
            bool f;
            do
            {
                Console.Write(consoleMessage);
                resultString = Console.ReadLine();
                if (!(f = double.TryParse(resultString, out resultDouble)))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Некорректный ввод, попробуйте снова :-) ");
                    Console.ResetColor();
                }
            }
            while (!f);
            return resultDouble;
        }
    }
}

