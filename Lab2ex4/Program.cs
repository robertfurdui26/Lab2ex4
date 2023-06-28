using System;

namespace Lab2ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            /* • Ex 4: Scrieti un program care va determina daca un numar este sau nu
             palindrom.*/

            //Am folosit netul,nu m-am descurcat singur,ca sa fiu sincer

            Console.WriteLine("Introduceți un număr: ");
            int numar = int.Parse(Console.ReadLine());

            int numarInitial = numar;
            int invers = 0;

            while (numar > 0)
            {
                int cifra = numar % 10;
                invers = invers * 10 + cifra;
                numar /= 10;
            }

            if (numarInitial == invers)
            {
                Console.WriteLine("Numărul {0} este palindrom.", numarInitial);
            }
            else
            {
                Console.WriteLine("Numărul {0} nu este palindrom.", numarInitial);
            }
        }
    }
}