using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComptaChim
{
    public class ManutARisque : Manutentionnaire
    {
        const int PRIMEDERISQUE = 200;
        public ManutARisque(string nom, string prenom, int age, string entreeEntrep, int heures) : base(nom, prenom, age, entreeEntrep,heures)
        {
        }

        public override double CalculerSalaire()
        {
            return base.CalculerSalaire() + PRIMEDERISQUE;
        }
    }
}
