using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComptaChim
{
    public class TechnARisque : EmployeARisque
    {
        public TechnARisque(string nom, string prenom, int age, string entreeEntrep, int unitProd) : base(new Technicien(nom, prenom, age, entreeEntrep, unitProd))
        {
        }
    }
}
