using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Private_fiels_example
{
    public class Personbil
    {
        private string Model;
        private string Mærke;
        private double KmPerLiter;
        private int Årgang;


        public void Initialiser(string model, string mærke,
    double kmPerLiter, int årgang)
        {
            // kopiering af værdier fra argumenter til interne felter
            this.Model = model;
            this.Mærke = mærke;
            this.KmPerLiter = kmPerLiter;
            // eksempel på validering
            if (årgang < DateTime.Now.Year - 100 ||
                årgang > DateTime.Now.Year + 1)
                throw new ArgumentException("Forkert årgang");
            else
                this.Årgang = årgang;
        }
    }
}
