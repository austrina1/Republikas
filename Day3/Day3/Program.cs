using System;

namespace Day3
{
    class Program
    {
        static void Main(String[] args)
        {


            Console.WriteLine("Ievadiet skaitli");

            String ievade =Console.ReadLine();

            String[] masīvs = new string[];

            // izveidot masīvu

            Console.WriteLine("Ievadiet skaitli");
            Console.WriteLine("Ievadiet skaitli");

            Console.ReadLine();

            Console.WriteLine()





            int skaitlis = 4;

            int[] masivs = new int[skaitlis];
        ;

            masivs[0] = 1;
            masivs[1] = 4;
            masivs[2] = 5;

            int garums = masivs.Length;

            for (int i = 0; i < masivs.Length; i++)
            {
                masivs[i] = 99;
            }

        }

        public void MasivaZvaigzne()
        {

            String[] zvaigzne = new string[10];


            for (int i = 0; i< zvaigzne.Length; i++)
            {

                if (i == 0) 
                {
                    zvaigzne[i] = zvaigzne[i - 1] + "*";
                }

                zvaigzne[i] = zvaigzne[i-1] + "*";
                Console.WriteLine(zvaigzne[i]);
            }

            for(int i = zvaigzne.Length-1; i >=0; i--)
            {
                Console.WriteLine(zvaigzne[i]);
            }
        }

            // 1.ievada masīva garumu
            // 2. izveidojam masīvu
            // 3. cilvēks piepilda masīvu ar ievadi
            // 4. izdrukājam masīva vērtības





        public void MasivaUzdevums()
        {
            Console.WriteLine("Ievadiet masīva garumu!");
            int garums = Convert.ToInt16(Console.ReadLine());

            String[]masīvs = new string[garums];

            for (int i = 0; i < masīvs.Length; i++)
            {
                Console.WriteLine("Ievadiet masīva" + i + "." + "elementu");

                masīvs[i] = Console.ReadLine();
            }

            Console.WriteLine("Ievadiet masīva vērtības");
            masīvs[i] = Console.ReadLine();
            
            for (int i = 0; i <= masīvs.Length; i++)
            {
                Console.WriteLine("Masīvu vērtības ir:" + masīvs[i]);
            }
        }

    }
}
