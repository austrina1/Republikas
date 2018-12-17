using System;
namespace Day2
{
    public class EmptyClass
    {
        public EmptyClass()
        {
            String darbība = "";

        while (true)
            {

                Console.WriteLine(" Izvēlies darbību- + vai  - vai ^ ");

                darbība = Console.ReadLine();

                if (darbība == "iziet")
                {
                    break;
                }

                int skaitlis1 = Ievade("Ievadiet pirmo skaitli");
                int skaitlis2 = Ievade("Ievadiet otro skaitli");


                switch (darbība)
            {
                case "+":
                    Console.WriteLine("Rezultāts ir" + Program.Saskaitit(skaitlis1, skaitlis2));
                    break;
                case "-":
                    Console.WriteLine("Rezultāts ir" + Program.Atņemt(skaitlis1, skaitlis2));
                    break;
                case "^":
                    Console.WriteLine("Rezultāts ir" + Program.Kāpināt(skaitlis1, skaitlis2));
                        break;

                default:
                    Console.WriteLine("Nepareiza izvēle");
                    break;

            } 

            }

        }
        
        static int Ievade(String input)
        {
            Console.WriteLine(input);
            int x = Convert.ToInt32(Console.ReadLine());
            return x;
        }

    }
}
