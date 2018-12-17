using System;
namespace Day2
{
    public class Piemērs
    {
        public Piemērs()
        {
        }
           
        public void TestaIzvade()
        {
            Console.WriteLine("vii");

        }
        public static void TestaIzvade2()
        {
            Console.WriteLine("vii");
        }
        public void Cikli()
        {
            // while, do...while, for, for(zinam precīzi cik reizes ir jāizvada

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("vii");
            }

            String izvēle = "iziet";

            while (izvēle != "iziet")
            {
                Console.WriteLine("Vai gribat iziet?");
                izvēle = Console.ReadLine();
            }

            do
            {
                Console.WriteLine("Vai gribat iziet?");
                izvēle = Console.ReadLine();
            } while (izvēle != "iziet");

            // izvada zvaigznītes

        }

    }
}
