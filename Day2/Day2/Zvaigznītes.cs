using System;
namespace Day2
{
    public class Zvaigznītes
    {
        public Zvaigznītes()
        {
        }
        public void ZvaigznītesIzvade()
        {

            for (int x = 1; x < 5; x++)
            {
                for (int y = 0; y < x; y++)
                {
                    Console.Write("*");
                }


                Console.WriteLine();
                /*String zv = "";

               for (int  i= 0; i<4; i++) {
               zv += "*"; // zv + "*";
               Console.WriteLine(zv); 
               */
            }
        }
    }
}

