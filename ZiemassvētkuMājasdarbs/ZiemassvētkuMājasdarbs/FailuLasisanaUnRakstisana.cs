using System;
using System.Collections.Generic;
using System.IO;
namespace ZiemassvētkuMājasdarbs
{
    public class FailuLasisanaUnRakstisana
    {


        public void LasitUnApmainīt()
        {

            string[] lines = File.ReadAllLines(@"dzejolis.txt");

            foreach (string line in lines)
            {
                Console.WriteLine("\t" + line);

            }

            Console.ReadLine();

            String[] reverseLines = new string[lines.Length];
            for (int i = 0; i < lines.Length; i++)
            {
                reverseLines[i] = lines[lines.Length - 1 - i];
                Console.WriteLine(reverseLines[i]);
            }



            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(@"dzejolis1.txt"))
            {
                foreach (string line in reverseLines)
                {
                    file.WriteLine(line);
                }
            }
        }

    }
}

