using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComptaChim
{
    public class Technicien : Employe
    {
        const int SALAIREUNIT = 5;
        public int UnitProd { get; set; }
        public Technicien(string nom, string prenom, int age, string entreeEntrep, int unitProd) : base(nom, prenom, age, entreeEntrep)
        {
            this.UnitProd = unitProd;
        }

        public override double CalculerSalaire()
        {
            return UnitProd * SALAIREUNIT;
        }

        public override string GetTypeEmploye()
        {
            return "Le technicien ";
        }
    }
}
