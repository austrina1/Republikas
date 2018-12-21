using System;
namespace Day6
{
    public class Piemēri
    {
        public Piemēri()
        {
        }
        public void Koordinātes()
        {
            // String tipa 2d masīvs
            /*111
             222
             333
             */

            int[,] a = new int[3,3];


            for (int i = 0; i < 3; i++) //definicija
            {

                for (int j = 0; j < 3; j++)
                {
                    a[i, j] = i + 1;
                    // Console.WriteLine(a[i,j] + " "); (varētu iztikt bez lejas for cikla, ja ir šī rinda)
                }

                             
            }

            for (int i = 0; i < 3; i++) //izvade
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();

            }

        }

        public void SkaitluMasivs()
        {
            //int tipa 2D masivs
            // cilvēkam skaitli ir jāievada pašam
            // pēc tam masīvu izvadam
            // Ievadiet masīva vērtību (i,j)
            // ja skaitlis > 5 aizstājam skaitli ar 6 un ja skaitlis < 5 aizstājam ar 4


            int[,] parastsMasivs = new int[3, 5];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Ievadiet vērtību (" + i +"," + j + ")");
                    parastsMasivs[i, j] = Convert.ToInt16(Console.ReadLine());
                }
            }

                for(int i = 0; i < 3; i++)
                {


                    for(int j = 0; j < 3; j++)
                    {
                    if (parastsMasivs[i,j] > 5) 
                    {
                        parastsMasivs[i, j] = 6;
                    }
                    else if (parastsMasivs[i,j] < 5)
                            {
                        parastsMasivs[i, j] = 4;
                            }


                    Console.Write(parastsMasivs[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }

