using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComptaChim
{
    public abstract class Employe
    {
        public string nom { get; set; }
        public string prenom { get; set; }
        public int age { get; set; }
        public string entreeEntrep { get; set; }

        protected Employe(string nom, string prenom, int age, string entreeEntrep)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;
            this.entreeEntrep = entreeEntrep;
        }

        public abstract double CalculerSalaire();
        public string GetNom(string type = "L'employé ")
        {
            return string.Concat(type, nom, " ", prenom);
        }
    }
    public abstract class EmployeARisque : Employe
    {
        internal int primeDeRisque = 200;
        protected EmployeARisque(string nom, string prenom, int age, string entreeEntrep) : base(nom, prenom, age, entreeEntrep)
        {
        }
    }

    public class Vendeur : Employe
    {
        internal int CA { get; }
        public Vendeur(string nom, string prenom, int age, string entreeEntrep,int CA) : base(nom, prenom, age, entreeEntrep)
        {
            this.CA = CA;
        }

        public override double CalculerSalaire()
        {
            return CA * 0.2 + 400;
        }

        public new string GetNom(string type = "Le Vendeur ")
        {
            return GetNom(type);
        }
    }
    public class Representant : Vendeur
    {
        public Representant(string nom, string prenom, int age, string entreeEntrep, int CA) : base(nom, prenom, age, entreeEntrep,CA)
        {
        }

        public override double CalculerSalaire()
        {
            return CA * 0.2 + 800;
        }

        public string GetNom()
        {
            return GetNom("Le Représentant ");
        }
    }
    public class Technicien : EmployeARisque
    {
        internal int unitProd { get; }
        public Technicien(string nom, string prenom, int age, string entreeEntrep, int unitProd) : base(nom, prenom, age, entreeEntrep)
        {
            this.unitProd = unitProd;
        }

        public override double CalculerSalaire()
        {
            return unitProd * 5;
        }

        public string GetNom()
        {
            return GetNom("Le Technicien ");
        }
    }
    public class Manutentionnaire : EmployeARisque
    {
        private int heures { get; }
        public Manutentionnaire(string nom, string prenom, int age, string entreeEntrep, int heures) : base(nom, prenom, age, entreeEntrep)
        {
            this.heures = heures;
        }

        public override double CalculerSalaire()
        {
            return heures * 65;
        }

        public string GetNom()
        {
            return GetNom("Le Manut. ");
        }
    }
    public class TechnARisque : Technicien
    {
        public TechnARisque(string nom, string prenom, int age, string entreeEntrep, int unitProd) : base(nom, prenom, age, entreeEntrep,unitProd)
        {
        }

        public override double CalculerSalaire()
        {
            return base.CalculerSalaire() + primeDeRisque;
        }
    }
    public class ManutARisque : Manutentionnaire
    {
        public ManutARisque(string nom, string prenom, int age, string entreeEntrep, int heures) : base(nom, prenom, age, entreeEntrep,heures)
        {
        }

        public override double CalculerSalaire()
        {
            return base.CalculerSalaire() + primeDeRisque;
        }
    }

    public class Personnel
    {
        List<Employe> employes = new List<Employe>();

        public void ajouterEmploye(Employe e) { employes.Add(e); }
        public void afficherSalaires()
        {
            foreach (Employe e in employes)
            {
                Console.WriteLine("{0} gagne {1} Euros.",e.GetNom(),e.CalculerSalaire());
            }
        }
        public double salaireMoyen()
        {
            double total = 0;
            if (employes.Count > 0)
            {
                foreach (Employe e in employes)
                {
                    total += e.CalculerSalaire();
                }
                return total / employes.Count;
            }
            return total;
        }
    }
}
