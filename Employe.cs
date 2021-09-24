using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComptaChim
{
    public abstract class Employe
    {
        internal string nom { get; set; }
        internal string prenom { get; set; }
        internal int age { get; set; }
        internal string entreeEntrep { get; set; }

        protected Employe(string nom, string prenom, int age, string entreeEntrep)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;
            this.entreeEntrep = entreeEntrep;
        }

        public virtual string GetTypeEmploye()
        {
            return "L'employé ";
        }
        public abstract double CalculerSalaire();
        public string GetNom()
        {
            return string.Concat(GetTypeEmploye(), nom, " ", prenom);
        }
    }
}
