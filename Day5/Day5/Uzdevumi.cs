using System;
namespace Day5
{
    public class Uzdevumi
    {
        public Uzdevumi()
        {

        }

        public void PirmaisMājasdarbs()
        {
            // atrast masīva lielāko skaitli

            int[] skaitluMasivs = { 1, 2, 3, 4, 5, 9, 11 };

            int lielākaisSkaitlis = skaitluMasivs[0];

            for (int i = 1; i < skaitluMasivs.Length; i++)
            {
                if (skaitluMasivs[i] > lielākaisSkaitlis)
                {
                    lielākaisSkaitlis = skaitluMasivs[i];
                }
            }

            Console.WriteLine("Lielākais skaitlis ir " + lielākaisSkaitlis);
        }

        public void otraisMājasdarbs()
        {
            int[] skaitluMasivs = { 1, 2, 3, 4, 5, 6, 99, 23 };
            int[] masivsSkaitlu = new int[skaitluMasivs.Length];

            for(int i = 0; i < skaitluMasivs.Length; i++)
            {
                masivsSkaitlu[i] = skaitluMasivs[skaitluMasivs.Length - i - 1];
                Console.Write(masivsSkaitlu[i] + " ");
            }
        }





    }
}
