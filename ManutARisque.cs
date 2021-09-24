using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComptaChim
{
    public class ManutARisque : EmployeARisque
    {
        public ManutARisque(string nom, string prenom, int age, string entreeEntrep, int heures) : base(new Manutentionnaire(nom, prenom, age, entreeEntrep,heures))
        {
        }
    }
}
