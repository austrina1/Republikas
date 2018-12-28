using System;
using System.Collections.Generic;
using System.IO;
namespace Day9And10
{
    public class Uzdevumi
    {
        public Uzdevumi()
        {
        }
        //1. izvadīt visus 
        // 2. izvadam to, ko gribam(  cilvēks ievada nr. mes izvadam rindinas joku.)
        // 3. Pievienot .. streamwriter pārraksta
        // bonuss - izvadam random joku.
        // 0.iziet  


        List<String> joki = new List<String>();


        public void Menu()
        {


            String choice = "";
            while (choice != "0")
            {

                Console.WriteLine("1. - Izvadīt visus jokus!");
                Console.WriteLine("2. - Izvadīt konkrētu joku!");
                Console.WriteLine("3. - Pievienot sarakstam!");
                Console.WriteLine("4. - Random joks");
                Console.WriteLine("0. - Iziet!");

                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":

                        IzvaditVisus();
                        break;
                    case "2":
                        IzvaditKonkretu();
                        break;
                    case "3":
                        PievienotJoku();
                        break;
                    case "4":
                        RandomJoks();
                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine("Nepareize izvēle!");
                        break;
                }
            }
        }

        private void IzvaditVisus()
        {
            RefreshJoki();
            foreach(String joks in joki)
            {
                Console.WriteLine(joks);
            }

            //Console.WriteLine();
        }

        private void IzvaditKonkretu()
        {
            RefreshJoki();
            Console.WriteLine("Ievadiet indeksu!");
            int jokaNr = Convert.ToInt32(Console.ReadLine());

            if (jokaNr > 0 && jokaNr <= joki.Count)
            {
                Console.WriteLine(joki[jokaNr - 1]);
            }
            else 
            {
                Console.WriteLine("Nepareiza ievade!");
            }

        }

        private void RefreshJoki()
        {
            joki.Clear();
            string[] lines = File.ReadAllLines(@"joki.txt");

            for(int i = 0; i < lines.Length; i++)
            {
                joki.Add(lines[i]);
            }
        }

        private void PievienotJoku()
        {
            RefreshJoki();
            Console.WriteLine("Ierakstiet savu joku!");

            string jocins = Convert.ToString(Console.ReadLine());

            joki.Add(jocins);

            string path = @"joki.txt";

            if (!File.Exists(path))
            {

                string[] createText = { "..." };
                File.WriteAllLines(path, createText);
            }



            using (System.IO.StreamWriter file =
               new System.IO.StreamWriter(@"joki.txt"))
            {
                foreach (string line in joki)
                {
                    file.WriteLine(line);
                }
            }

        }

        private void RandomJoks()
        {
            RefreshJoki();



            Random rnd = new Random();
           

            int r = rnd.Next(joki.Count);



            Console.WriteLine((string)joki[r]);
        }


    }
}
