using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Private_fiels_example
{
    class Program
    {
        static void Main(string[] args)
        {
            //Eksempel på en bil som ikke bliver oprettet
            try
            {
                //opretter en ny Personbil
                Personbil b1 = new Personbil();
                //Sætter værdier
                b1.Initialiser("Peugeot", "406", 13.4, 1900);
                //dette udskrvies hvis bilen er under 100 år gammel
                Console.WriteLine("Peugeot Bil oprettet");
            }
            //Hvis bilen er over 100 år gammel udskrvies denne exception
            catch (Exception ex)
            {
                Console.WriteLine("Der er desværre sket en fejl - " + ex.Message);
            }


            //Eksempel på en bil som bliver oprettet
            try
            {
                Personbil b2 = new Personbil();
                b2.Initialiser("BMW", "M5", 17.4, 2001);
                Console.WriteLine("BMW Bil oprettet");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Der er desværre sket en fejl - " + ex.Message);
            }

            Console.ReadKey();
        }
    }
}
