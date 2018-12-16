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

            int result = SaskaititVaiAtnemt(skaitlis1, skaitlis2);
            Console.WriteLine(result);
            Console.ReadLine();


        }


        static int SaskaititVaiAtnemt(int a, int b)
        {
            Console.WriteLine("Saskaitit, atnemt vai kāpināt?");
            String izvele = Console.ReadLine();

            if (izvele == "+")
            {
                return a + b;
            }
            else if (izvele == "-")
            {
                return a - b;
            }
            else if (izvele == "^")
            {
                return Kāpināt();
            }
            else 
            {
                return -9999;
                }
        }

        static int IevaditSkaitli(String izvadamaZina)

        {
            Console.WriteLine(izvadamaZina);
            String ievade = Console.ReadLine();

            return Convert.ToInt16(ievade);
        }

        public int Kāpināt(int bāze, int pakāpe)

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
