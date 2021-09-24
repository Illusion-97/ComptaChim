using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComptaChim
{
    public class TechnARisque : Technicien
    {
        public TechnARisque(string nom, string prenom, int age, string entreeEntrep, int unitProd) : base(nom, prenom, age, entreeEntrep,unitProd)
        {
        }

        public override double CalculerSalaire()
        {
            return base.CalculerSalaire() + EmployeARisque.PRIME_DE_RISQUE;
        }
    }
}
