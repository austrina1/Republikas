using System;

namespace Day1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //PirmaisUzdevums();
            /* Console.WriteLine(Piemers());
             int a = Piemers();

             Console.WriteLine(Piemers2(3, a));
             Console.ReadLine();
             */
            


         

            int skaitlis1 = IevadītSkaitli("Ievadīt pirmo skaitli");

           

            int skaitlis2 = IevadītSkaitli("Ievadīt otro skaitli");


            int result = SaskaitītVaiAtņemt(skaitlis1, skaitlis2);
            Console.WriteLine(result);
            Console.ReadLine();



        }

        static void PirmaisUzdevums()
        {
            Console.WriteLine("Ka jus sauc?");

            String vards = Console.ReadLine();

            Console.WriteLine("Sveiki, " + vards);
        }

        static int Piemers()
        {
            return 4 + 3;
        }

        static int Piemers2(int a, int b)
        {
            return a + b;
        }

        static void Piemers3()
        {
            Console.WriteLine("Ievadiet simbolus!");
            String ievade = Console.ReadLine();
            int a = 5;
            if (ievade == "vii" && a > 5)
            {
                Console.WriteLine("1");
            }
            else if (ievade == "vii" && a == 5)
            {
                Console.WriteLine("2");
            }
            else
            {

            }
            // <
            // >
            // <=
            // >=
            // ==
            // !=

            // &&
            // ||
        }
        static int SaskaitītVaiAtņemt(int a, int b)
        {
            Console.WriteLine("Saskaitīt vai atņemt");
            String izvēle = Console.ReadLine();
            if (izvēle == "+")
            {
                return a + b;
            }
            else if (izvēle == "-") 
            {
                return a - b;
            } 
            else 
            {
                return -99999;
            }

        }  
        static int IevadītSkaitli(String izvadāmaZiņa) 
        {
            Console.WriteLine(izvadāmaZiņa);
            String ievade = Console.ReadLine();

            return Convert.ToInt16(ievade);

        }






        //funkcija, kas lauj cilvekam izveleties vai saskaita vai atnem
        //return, gan parametriem


    }
}
