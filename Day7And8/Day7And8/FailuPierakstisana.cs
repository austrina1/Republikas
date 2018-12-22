using System;
using System.Collections.Generic;   
namespace Day7And8
{
    public class FailuPierakstisana
    {
        public FailuPierakstisana()
        {
        }

        public void Rakstit(List<String> lines)
        {
            using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(@"/Users/andrapetersone/Desktop/new.txt"))
            {
                foreach (string line in lines)
                {
                    file.WriteLine(line);
                }
            }
        }

                public void LasitUnRakstit() 
        { 
            // ielasām rindas no faila masiva ( tā kā piemērā)
            // tas bus string tipa masivs, kovertejam uz int
            // saskaitam a + b
        }
    }
}
