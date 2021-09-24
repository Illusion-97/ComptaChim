using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComptaChim
{
    public abstract class Employe
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int Age { get; set; }
        public string EntreeEntrep { get; set; }

        protected Employe(string nom, string prenom, int age, string entreeEntrep)
        {
            Nom = nom;
            Prenom = prenom;
            Age = age;
            EntreeEntrep = entreeEntrep;
        }

        public virtual string GetTypeEmploye()
        {
            return "L'employé ";
        }
        public abstract double CalculerSalaire();
        public string GetNom()
        {
            return string.Concat(GetTypeEmploye(), Nom, " ", Prenom);
        }
    }
}
