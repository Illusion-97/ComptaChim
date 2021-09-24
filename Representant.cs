using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComptaChim
{
    public class Representant : Commercial
    {
        public Representant(string nom, string prenom, int age, string entreeEntrep, int CA) : base(nom, prenom, age, entreeEntrep,CA)
        {
            Bonus = 800;
        }

        public override double CalculerSalaire()
        {
            return CA * Commercial.COEF + Bonus;
        }

        public override string GetTypeEmploye()
        {
            return "Le représentant ";
        }
    }
}
