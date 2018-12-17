using System;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Zvaigznītes piem = new Zvaigznītes();
              piem.ZvaigznītesIzvade();

             // Piemērs.TestaIzvade2(); 
            Zvaigznītes uzd = new Zvaigznītes();
            Console.WriteLine(uzd.Kāpināt(5,3));

            Console.ReadLine();*/

            int skaitlis1 = IevaditSkaitli("Ievadit pirmo skaitli");
            int skaitlis2 = IevaditSkaitli("Ievadit otro skaitli");


        }


        public static int Saskaitit(int a, int b)
        {
            return a + b;
        }
        public static int Atņemt(int a, int b)
        {
            return a - b;
        }

        static int IevaditSkaitli(String izvadamaZina)

        {
            Console.WriteLine(izvadamaZina);
            String ievade = Console.ReadLine();

            return Convert.ToInt16(ievade);
        }
        public static int Kāpināt(int bāze, int pakāpe)

        {
            int result = 1;
            for (int i = 0; i < pakāpe; i++)
            {
                result = result * bāze;
            }
            return result;
        }


    }
   
}
