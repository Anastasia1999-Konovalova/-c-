using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Введите массив, размера от 0 до 20:");
                int n = int.Parse(Console.ReadLine());

                bool stop = false;
                while (true)
                {
                    if (n >= 0 && n <= 20)
                    {
                        stop = true;
                        break; //выход из внутреннего цикла
                    }
                }
                Console.Write("Введите диапазон чисел, например до 10:");
                int m = int.Parse(Console.ReadLine());

                int[] a = new int[n];
                Random random = new Random();
                Console.Write("Массив: ");
                for (int i = 0; i < a.Length; i++)
                {
                    a[i] = random.Next(m);
                    Console.Write("{0} ", a[i]);
                }

                // Сортировка

                int temp;
                for (int i = 0; i < a.Length - 1; i++)
                {
                    for (int j = i + 1; j < a.Length; j++)
                    {
                        if (a[i] > a[j])
                        {
                            temp = a[i];
                            a[i] = a[j];
                            a[j] = temp;
                        }
                    }
                }

                // Вывод

                Console.WriteLine("Вывод отсортированного массива:");
                for (int i = 0; i < a.Length; i++)
                {
                    Console.WriteLine(a[i]);
                }

                Console.ReadLine();

                // Сортировка 2

                int kemp;
                for (int i = 0; i < a.Length - 1; i++)
                {
                    for (int j = i + 1; j < a.Length; j++)
                    {
                        if (a[i] < a[j])
                        {
                            kemp = a[i];
                            a[i] = a[j];
                            a[j] = kemp;
                        }
                    }
                }

                // Вывод 2

                Console.WriteLine("Вывод отсортированного массива:");
                for (int i = 0; i < a.Length; i++)
                {
                    Console.WriteLine(a[i]);
                }

                Console.ReadLine();

                if (stop)
                {
                    break; // выход из внешнего цикла
                }

            }

        }
    }
}
