using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComptaChim
{
    public class Manutentionnaire : Employe
    {
        const int SALAIREHORAIRE = 65;
        public int Heures { get; }
        public Manutentionnaire(string nom, string prenom, int age, string entreeEntrep, int heures) : base(nom, prenom, age, entreeEntrep)
        {
            Heures = heures;
        }

        public override double CalculerSalaire()
        {
            return Heures * SALAIREHORAIRE;
        }

        public override string GetTypeEmploye()
        {
            return "Le manut. ";
        }
    }
}
