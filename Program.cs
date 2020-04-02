using System;

namespace torre_di_Hanoi
{
    class Program
    {
        static void spostamento(int n, int da, int mezzo, int a)
        {
            if (n == 1)
            {
                Console.WriteLine("Sposta il disco da {0} a {1}", da, a);
            }
            else
            {
                spostamento(n - 1, da, a, mezzo);
                spostamento(1, da, mezzo, a);
                spostamento(n - 1, mezzo, da, a);
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Programma che simula la risoluzione della Torre di Hanoi");
            Console.WriteLine("Inserire il numero dei dischi");
            int n = Convert.ToInt32(Console.ReadLine());

            spostamento(n,1,2,3);
        }
    }
}
