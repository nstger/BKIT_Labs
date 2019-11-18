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
                double r = (-1 * c) / b;
                Console.ForegroundColor = ConsoleColor.Green;
                if (c <=0 )
                Console.WriteLine("Корни " + Math.Sqrt(r) + " и -" + Math.Sqrt(r));
                else if (c==0)  Console.WriteLine("Корень: " + Math.Sqrt(r));
                else Console.WriteLine("Корни не являются действительными числами");
            }
            else if (a != 0)
            {
                double d = b * b - 4 * a * c;
                Console.WriteLine("Дискриминант: " + d);
                if (d > 0)
                {
                    double r_1 = (-1 * b + Math.Sqrt(d)) / (2 * a);
                    double r_2 = (-1 * b - Math.Sqrt(d)) / (2 * a);
                    if (r_1 > 0 && r_2 >= 0)
                    {
                        if (r_2 != 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Корни уравнения: ");
                            Console.WriteLine("x1: " + Math.Sqrt(r_1));
                            Console.WriteLine("x2: " + -1 * Math.Sqrt(r_1));
                            Console.WriteLine("x3: " + Math.Sqrt(r_2));
                            Console.WriteLine("x4: " + -1 * Math.Sqrt(r_2));
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Корни уравнения: ");
                            Console.WriteLine("x1: " + Math.Sqrt(r_1));
                            Console.WriteLine("x2: " + -1 * Math.Sqrt(r_1));
                            Console.WriteLine("x3: " + Math.Sqrt(r_2));
                        }
                    }
                    else if (r_1 > 0 && r_2 < 0)
                    {
                        Console.WriteLine("Корни уравнения: ");
                        Console.WriteLine("x1: " + Math.Sqrt(r_1));
                        Console.WriteLine("x2: " + -1 * Math.Sqrt(r_1));
                        Console.WriteLine("x3 и x4 не являются действительными числами");
                    }
                    else if (r_1 < 0 && r_2 > 0)
                    {
                        Console.WriteLine("x1: " + Math.Sqrt(r_2));
                        Console.WriteLine("x2: " + -1 * Math.Sqrt(r_2));
                        Console.WriteLine("x3 и x4 не являются действительными числами");
                    }
                    else if (r_1 == 0)
                    {
                        Console.WriteLine("x: " + Math.Sqrt(r_1));
                    }
                }

                else if (d < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Действительных корней нет :-( ");
                }
                else
                {
                    double r = (b + Math.Sqrt(d)) / (2 * a);
                    Console.ForegroundColor = ConsoleColor.Green;
                    if (r != 0)
                        Console.WriteLine("Корни уравнения: " + Math.Sqrt(r) + " и " + -1 * Math.Sqrt(r));
                    else Console.WriteLine("Корень: " + Math.Sqrt(r));
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

