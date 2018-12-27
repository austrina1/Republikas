using System;
using System.Collections.Generic;
using System.IO;
namespace ZiemassvētkuMājasdarbs
{
    public class FailuLasisanaUnRakstisana
    {
     

        public void LasitUnApmainīt()
        {
            //ielasam rindas no faila masiva (ta ka piemera)
            //tas bus string tipa masivs, konvertejam uz int

            string[] lines = File.ReadAllLines(@"dzejolis.txt");

            // Display the file contents by using a foreach loop.


            System.Console.WriteLine("Dzejolītis:");
            foreach (string line in lines)
            {
                // Use a tab to indent each line of the file.
                Console.WriteLine("\t" + line);
            }

            Console.ReadLine();

        }

    }
}
