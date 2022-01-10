using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleLab5_6
{
    class Lab5_6
    {
        static void Main(string[] args)
        {
            Console.Write("Введите размерность двухмерного массива N=");
            int N = Math.Abs(Convert.ToInt32(Console.ReadLine()));
            int[,] t = new int[N, N];
            int p1 = 1;
            int p2 = 1;
            int sum_stroka = 0;
            int[] t_stroka = new int[N];
            int sum_stolb = 0;
            int[] t_stolb = new int[N];
            int sum_diag_right = 0;
            int sum_diag_left = 0;
            bool f = false;
            Console.WriteLine("Заполните массив NxN:");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write("Введите {0}-й элемент {1}-й строки массива - ", p2++, p1);
                    t[i,j] = Convert.ToInt32(Console.ReadLine());
                }
                p1++;
                p2 = 1;
            }
            Console.WriteLine();
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write("{0} ", t[i, j]);
                }
                Console.WriteLine();
            }
            // Массив сумм строк
            Console.WriteLine();
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    int w = Math.Abs(j - (N - 1));
                    sum_stroka += t[i, j];
                    // Правая и левая диагонали
                    if (i == j)
                    {
                        sum_diag_right += t[i, j];
                    }
                    if ( i==w )
                    {
                        sum_diag_left += t[i, j];
                    }
                }
                t_stroka[i] = sum_stroka;
                sum_stroka = 0;
                Console.WriteLine("{0} ", t_stroka[i]);
            }
            // Массив сумм столбов
            Console.WriteLine();
            for (int j = 0; j < N; j++)
            {
                for (int i = 0; i < N; i++)
                {
                    sum_stolb += t[i, j];
                }
                t_stolb[j] = sum_stolb;
                sum_stolb = 0;
                Console.Write("{0} ", t_stolb[j]);
            }
            Console.WriteLine();
            Console.WriteLine();
            //=====================================================================
            if (sum_diag_right==sum_diag_left)
            {
                for (int i = 0; i < N; i++)
                {
                    if (t_stroka[i]==t_stolb[i])
                    {
                        f = true;
                    }
                    else
                    {
                        f = false;
                    }
                }
                
            }
            else
            {
                f = false;
            }
            if (f == true)
            {
                Console.Write("Это магический квадрат");
            }
            else
            {
                Console.Write("Это НЕ магический квадрат");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(sum_diag_right);
            Console.WriteLine(sum_diag_left);
            Console.WriteLine();
            Console.Write("Для завершения нажмите любую клавишу");
            Console.ReadKey();
        }
    }
}
