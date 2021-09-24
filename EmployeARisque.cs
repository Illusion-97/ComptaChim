using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComptaChim
{
    public class EmployeARisque : Employe
    {
        public Employe Employe { get; set; }

        public EmployeARisque(Employe employe) : base(employe.Nom, employe.Prenom, employe.Age, employe.EntreeEntrep)
        {
            Employe = employe;
        }

        public override double CalculerSalaire()
        {
            return Employe.CalculerSalaire() + Constants.PRIME_DE_RISQUE;
        }

        public override string GetNom()
        {
            return Employe.GetNom();
        }
    }
}
