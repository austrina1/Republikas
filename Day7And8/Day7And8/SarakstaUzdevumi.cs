using System;
using System.Collections.Generic;
namespace Day7And8
{
    public class SarakstaUzdevumi
    {
        public SarakstaUzdevumi()
        {
        }

            List<String> lietotaji = new List<String>();
        private List<int> lietotajuNumuri = new List<int>();
            private void IzvaditLietotajuSarakstu()
            {
              
                if (lietotaji.Count == 0)
                {
                    Console.WriteLine("Saraksts ir tukss");
                }
                else
                {
                    for (int i = 0; i < lietotaji.Count; i++)
                    {
                        Console.WriteLine(lietotajuNumuri[i] + "." + lietotaji[i]);
                    }
                }

            }
        private void Search()
        {

            Console.WriteLine("Ievadiet ID");
            int id = Convert.ToInt16(Console.ReadLine());

            bool atrasts = false;

            for(int i = 0; i < lietotaji.Count; i++)
            {
                if(id == lietotajuNumuri[i])
                {
                    Console.WriteLine("ID " + lietotajuNumuri[i] + " ir lietotājvārds " + lietotaji[i]);
                    atrasts = true;
                    break;

                }
                }

            if (!atrasts)
            {
                Console.WriteLine("ID nav atrasts");
            }
        }





        private void PievienotSarakstam()
            {
                Console.WriteLine("Ievadet lietotajvardu!");
                lietotaji.Add(Console.ReadLine());

            

            //lietotajuNumuri.Add(lietotaji.Count+1);
            if(lietotajuNumuri.Count == 0)
            {
                lietotajuNumuri.Add(1);
            }
            else
            {
                lietotajuNumuri.Add(lietotajuNumuri[lietotajuNumuri.Count - 1] + 1);
            }
        }
        private void Izdzest()
        {
            Console.WriteLine("Ievadiet ID");
            int id = Convert.ToInt16(Console.ReadLine());

            bool atrasts = false;

            for (int i = 0; i < lietotaji.Count; i++)
            {
                if (id == lietotajuNumuri[i])
                {
                    lietotaji.RemoveAt(i);
                    lietotajuNumuri.RemoveAt(i);

                    Console.WriteLine("Ieraksts dzēsts");

                    atrasts = true;
                    break;

                }
            }

            if (!atrasts)
            {
                Console.WriteLine("ID nav atrasts");
            }
        }





    

    public void Interfeiss()
            {
                String choice = "";
                while (choice != "0")
                {
                    Console.WriteLine("1, lai pievienotu, 2, lai izvaditu sarakstu,3, lai atrastu,4, lai izdzēstu, 0, lai izietu");
                    choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            PievienotSarakstam();
                            break;
                        case "2":
                            IzvaditLietotajuSarakstu();
                            break;
                            case "0":
                            break;
                    case "3":
                        Search();
                        break;
                    case "4":
                        Izdzest();
                        break;
                        default:
                            Console.WriteLine("Nepareiza ievade");
                            break;
                    }

                }

        ;
            }
        }
    }

