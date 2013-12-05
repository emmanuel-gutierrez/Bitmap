using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitmap
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            Byte[] theBytes= new Byte[10];
            r.NextBytes(theBytes);

            Console.WriteLine("Los valores a buscar son :");
            foreach(Byte b in theBytes)
            {
                Console.Write(b + " ");
            }
            Console.WriteLine("Que valor deseas buscar?");
            Byte read = Byte.Parse(Console.ReadLine());
            int temp = 1;
            foreach(var b in theBytes)
            {
                if (b == read)
                    Console.WriteLine("Se encontro en el espacio {0}", temp);
                temp++;
            }
            Console.ReadLine();
        }
    }
}
