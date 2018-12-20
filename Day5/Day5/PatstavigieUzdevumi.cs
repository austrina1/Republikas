using System;
namespace Day5
{
    public class PatstavigieUzdevumi
    {
        public PatstavigieUzdevumi()
        {
        }

        public void piešķirtVērtību()
        {
            Console.WriteLine("Cik garš masīvs?");
            int garums = Convert.ToInt16(Console.ReadLine());
            int[] masivs = new int[garums];


            for (int i = 0; i < masivs.Length; i++)
            {
                if (masivs[i] >= 0)
                {
                    masivs[i] = 1;
                }

                if (masivs[i] <= 0)
                {
                    masivs[i] = 2;
                }

                Console.Write(masivs[i] + " ");
            }
        }

        public void noskaidrotVērtību()
        {
            Console.WriteLine("Cik garš masīvs?");
            int garums = Convert.ToInt16(Console.ReadLine());

            int[] masivs = new int[garums];


            for (int i = 0; i < masivs.Length; i++)
            {
                Console.WriteLine("Ievadiet vērtību");
                masivs[i] = Convert.ToInt16(Console.ReadLine());
            }


            int skaitlis = 0;

            for (int i = 0; i < masivs.Length; i++)
            {
                if ((masivs[i]) > 0 && (masivs[i] < 10))
                {
                    skaitlis++;
                }

            }

            Console.WriteLine("Atbilst " + skaitlis + " vērtības");

        }

        public void ekrānaPaziņojums()
        {
            Console.WriteLine("Ievadiet masīva garumu!");
            int garums = Convert.ToInt16(Console.ReadLine());

            int[] masivs = new int[garums];


            for (int i = 0; i < masivs.Length; i++)
            {
                Console.WriteLine("Ievadiet masīva vērtības!");
                masivs[i] = Convert.ToInt16(Console.ReadLine());
            }

            bool secība = false;

            for (int i = 0; i < masivs.Length; i++)
            {

                if (masivs[i] > masivs[i + 1])
                {
                    secība = true;
                }

                if (secība)
                {
                    Console.WriteLine("Nav augošā secībā");
                }
                else
                {
                    Console.WriteLine("Ir augošā secībā");
                }



            }


        }
    }
}
    
