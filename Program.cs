using System;

namespace Temperatura_za_sedmicata
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedete broi redove");
            int redove = int.Parse(Console.ReadLine());
            Console.WriteLine("vuvedete broi koloni");
            int koloni = int.Parse(Console.ReadLine());
            int[,] temp = new int[2, 7];
            for (int i = 0; i < redove; i++)
            {
                for (int j = 0; j < koloni; j++)
                {
                    Console.WriteLine("Vuvedi temperaturata weeeee");
                    temp[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("P  V  S  C  P  S  N");
            for (int i = 0; i < redove; i++)
            {
                for (int j = 0; j < koloni; j++)
                {
                    Console.Write(temp[i, j] + "  ");
                }
                Console.WriteLine();
            }
            int suma = 0;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 5; j < 7; j++)
                {
                    suma = suma + temp[i, j];
                }
            }
            Console.WriteLine("sumata za wekenda e " + suma);
            
           double suma1 = (double)suma / 4;
            Console.WriteLine("srednata temperatura za ponedelnik e {0:f2}", suma1);
            double suma2 = 0;
            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j <= 0; j++)
                    suma2 = temp[i, j];
                Console.WriteLine("temperaturata za ponedelnik e {0:f2}", suma2);
            }
            int max = -10000;
            int maxi=0;
            int maxi1=0;
            for (int i = 0; i < redove; i++)
            {
                for (int j = 0; j < koloni; j++)
                {
                    if (max < temp[i, j]) 
                    {
                        max = temp[i, j];
                         maxi = i;
                         maxi1 = j;
                    }
                }
            }
            Console.WriteLine("maximalna temperatura e" + max);
            Console.WriteLine("indeksa na maksimalnata e" + maxi + maxi1);



        }
    }
}
