using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp42
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            int[,] mas = new int[10, 10];
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    mas[i, j] += random.Next(0, 10);
                    Console.Write(mas[i, j] + " ");
                }
                Console.WriteLine();
            }
            int n = 0;
            long sum = mas[0, 0];
            for (int i = 0; i < 10; i++)
            {
                if (sum < mas[i, n])
                {
                    sum = mas[i, n];
                }
                n++;
            }

            //2
            int y = 0;
            for (int i = 0; i < 10; i++)
            {
                if (mas[i, y] == sum)
                {
                    Console.WriteLine(mas[i, y]);
                    Console.WriteLine("Максимальный элемент главной диагонали + координаты: " + i + y);
                    break;
                }
                y++;
            }
            int yy = 0;
            long summ = mas[0, 9];
            for (int i = 9; i > 0; i--)
            {
                if (summ < mas[yy, i])
                {
                    summ = mas[yy, i];
                }
                yy++;
            }
            int x = 0;

            for (int i = 9; i > 0; i--)
            {
                if (mas[x, i] == summ)
                {
                    Console.WriteLine(summ);
                    Console.WriteLine("Максимальный элемент побочной диагонали + координаты: " + x + i);
                    break;
                }
                x++;
            }
            int nm = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    nm += mas[j, i];
                }
                Console.WriteLine("Сумма элементов каждого столбца = " + nm);
                nm = 0;
            }
          
        }
    }
}

        
    













