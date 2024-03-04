using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace calculatorconsoleapp
{
    class program
    {
        static void Main(string[] args)
        {
        }

        static int Penambahan(int a, int b)
        {
            return a + b;
        }

        static int Pengurangan(int a, int b)
        {
            return a - b;
        }

    }
}

class program
{
    static void main(string[]args)
    {
        Console.Title = "aplikasi calculator";

        int a = 10;
        int b = 6;

        Console.WriteLine("Hasil Penambahan " + a + " + b + " = " + Penambahan(a, b));
        Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, Pengurangan(a, b));
        Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", a, b, Perkalian (a,b));
        Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, Pembagian (a,b));

        Console.WriteLine("\")







    }


}
    


    