using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace es_thread
{
    class Program
    {

        static void Main(string[] args)
        {

            Thread th = new Thread(WriteY);

            th.Start();

            Console.WriteLine("Timer iniziato");

            System.Threading.Thread.Sleep(11000);

            Console.WriteLine("SVEGLIAAAA !"); 

            Console.ReadKey();

        }

        private static void WriteY()
        {

            for (int i = 10; i > 0; i--)
            {

                System.Threading.Thread.Sleep(1000);

                Console.Write(i + " ");

            }

        }
    }
}  