using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComptaChim
{
    public class Technicien : Employe
    {
        public int UnitProd { get; set; }
        public Technicien(string nom, string prenom, int age, string entreeEntrep, int unitProd) : base(nom, prenom, age, entreeEntrep)
        {
            UnitProd = unitProd;
        }

        public override double CalculerSalaire()
        {
            return UnitProd * Constants.SALAIRE_UNIT_TECHN;
        }
    }
}
