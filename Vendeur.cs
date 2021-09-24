using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComptaChim
{
    public class Vendeur : Employe
    {
        internal const double COEFCA = 0.2;
        internal int bonus = 400;
        internal int CA { get; }
        public Vendeur(string nom, string prenom, int age, string entreeEntrep,int CA) : base(nom, prenom, age, entreeEntrep)
        {
            this.CA = CA;
        }

        public override double CalculerSalaire()
        {
            return CA * COEFCA + bonus;
        }

        public override string GetTypeEmploye()
        {
            return "Le vendeur ";
        }
    }
}
