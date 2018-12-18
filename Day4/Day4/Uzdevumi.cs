using System;
namespace Day4
{
    public class Uzdevumi
    {
        public Uzdevumi()
        {
            
        }

        public void PirmaisUzd() 
        {
            Console.WriteLine("Ievadiet masīva garumu");
            int garums = Convert.ToInt16(Console.ReadLine());


            int[] skaitluMasivs = new int[garums];

            for( int i = 0; i < skaitluMasivs.Length; i++)
            {
                skaitluMasivs[i] = i + 2;
                Console.Write(skaitluMasivs[i] + " ");
            }
        }

        public void OtraisUzd() 
        {
            Console.WriteLine("Ievadiet masīva garumu");
            int garums = Convert.ToInt16(Console.ReadLine());


            int[] skaitluMasivs = new int[garums];

            for (int i = 0; i < skaitluMasivs.Length; i++) 
            { 
                skaitluMasivs[i] = 
            }

        }
    }
}
