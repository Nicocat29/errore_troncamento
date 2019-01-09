using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace errore_troncamento
{
    class Program
    {
        static void Main(string[] args)
        {
        double troncamento = 0.000000095;
        double ore = 100;
        double spazio = 0;
        double metri = 1676;
        double errore = 0;

        errore = troncamento * 100 * 60 * 60 * 10;
        spazio = metri * ore;

        errore = troncamento * 100 * 60 * 60 * 10;
        Console.WriteLine($"{errore} è il tempo errato");
        Console.WriteLine(" ");

        Console.WriteLine("calcolo dello spazio:");
        Console.WriteLine(" ");
        spazio = metri * ore;
        Console.WriteLine($"{spazio} è lo spazio");




            Console.ReadLine();




        }
    }
}
