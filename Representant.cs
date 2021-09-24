using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComptaChim
{
    public class Representant : Vendeur
    {
        public Representant(string nom, string prenom, int age, string entreeEntrep, int CA) : base(nom, prenom, age, entreeEntrep,CA)
        {
            bonus = 800;
        }

        public override double CalculerSalaire()
        {
            return CA * COEFCA + bonus;
        }

        public override string GetTypeEmploye()
        {
            return "Le représentant ";
        }
    }
}
