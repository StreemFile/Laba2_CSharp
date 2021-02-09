using System;

namespace Laba2
{
    class Program
    {
        static void Main(string[] args)
        {
            ExerciseOne();
            ExerciseTwo();
            ExerciseThree();
            ExerciseFour();
            ExerciseFive();
        }

        private static void ExerciseOne()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("Завдання 3.1");
            double sum = 0;
            Console.WriteLine("Введіть число а: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введіть число n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            double bottom = a;
            sum +=  2 / (bottom);
            for (int i = 2; i <= n; i++)
            {
                bottom = bottom * (a + i - 1);
                sum += (i * 2) / (bottom);
            }
            Console.WriteLine("Сума: " + sum);

        }

        private static void ExerciseTwo()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("Завдання 3.2");
            Console.WriteLine("Введіть точність: ");
            double precision  = Convert.ToDouble(Console.ReadLine());
            int x = 1;
            int k = 0;
            long fk = 1L;
            double result = 0;
            double neededPrecision = 1;
            while (x <= 5)
            {
                while (Math.Abs(neededPrecision) > precision)
                {
                    if (fk * k < 922337203685477807)
                    {
                        k++;
                        fk *=  k;
                        double top = (Math.Pow(-1, k + 1) * Math.Pow(x, 2 * k - 1));
                        double bottom = ((2 * k + 1) * fk);
                        neededPrecision = top / bottom;
                         if(x == 3 && k == 3) Console.WriteLine("FASFAS: " + neededPrecision);
                        result += neededPrecision;
                    }
                    else
                    {
                        break;
                    }
                }

                k = 0;
                fk = 1;
                neededPrecision = 1;
                x++;
            }
            Console.WriteLine("Результат: " + result);
        }
        
        private static void ExerciseThree()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("Завдання 3.3");
            Console.WriteLine("Введіть радіус мішені");
            int radius = Convert.ToInt32(Console.ReadLine());
            if (radius <= 0)
            {
                Console.WriteLine("Невірно заданий радіус!");
            }

            String table = "_____________________________________" + "\n" +
                           "|              Шапка                |" + "\n" +
                           "-------------------------------------" + "\n";

            for (int i = 8; i < 10; i++)
            {
                Console.WriteLine("Постріл №" + (i + 1));
                Console.WriteLine("Введіть координату х");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введіть координату у");
                int y = Convert.ToInt32(Console.ReadLine());
                if (IsInZone(x,y,radius))
                {
                    if (i == 9)
                    {
                        table += "|    " + (i+1) + "    | x: " + x + ", y: " + y + " |" 
                                 + "  Влучив   |\n"; 
                        break;
                    }
                    table += "|     " + (i+1) + "    | x: " + x + ", y: " + y + " |" 
                             + "  Влучив   |\n";
                } else
                {
                    if (i == 9)
                    {
                        table += "|    " + (i+1) + "    | x: " + x + ", y: " + y + " |" 
                                 + " Не влучив |\n";
                        break;
                    }
                    table += "|     " + (i+1) + "    | x: " + x + ", y: " + y + " |" 
                             + " Не влучив |\n";
                }
            }

            table += "-------------------------------------";
            Console.WriteLine(table);
        }
        static bool IsInZone(int x, int y,int radius)
        {
            if ((y >= 0 && x >= 0) || (y <= 0 && x <= 0))
            {
                if ((y <= 0) && (y <= x) && ((-1*y) < radius))
                {
                    return true;
                }
                if ((y >= 0) && (y >= x) && (y < radius))
                {
                    return true;
                }
            }

            return false;
        }
        
        private static void ExerciseFour()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("Завдання 3.4");
            for (int i = 10; i >= 0; i--)
            {
                if (i > 0)
                {
                    Console.WriteLine(i + " green bottles hanging on the wall," +
                                      "\n" + i + " green bottles hanging on the wall," +
                                      "\nAnd if one green bottle should accidentally fall," +
                                      "\nThere'll be " + (i - 1) + " green bottles hanging on the wall. \n");
                }
                else
                {
                    Console.WriteLine(i + " green bottles hanging on the wall," +
                                      "\n" + i + " green bottles hanging on the wall.\n");
                }
            } 
        }
        private static void ExerciseFive()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("Завдання 3.5");
            Console.WriteLine("Введіть вагу зернини: ");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(weight);
            ulong sum = 1L;
            ulong gotForThis = sum;
            Console.WriteLine("За 1-e зерно отримав " + sum);
            for (int i = 2; i <= 64; i++)
            {
                gotForThis = gotForThis * 2;
                Console.WriteLine("За " + i + "-e зерно отримав " +  gotForThis);
                sum += gotForThis;
            }

            double weightOfAll = sum * weight;
            Console.WriteLine("Всього зерен: " + sum + ".\nВага всіх зерен: " + weightOfAll);
        }

        
    }
}