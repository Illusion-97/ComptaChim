using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComptaChim
{
    public abstract class Commercial : Employe
    {
        public int CA { get; set; }
        protected Commercial(string nom, string prenom, int age, string entreeEntrep,int CA) : base(nom, prenom, age, entreeEntrep)
        {
            this.CA = CA;
        }
        public override double CalculerSalaire()
        {return CA * Constants.COEFF_COMMERCIAL + Constants.BONUS_COMMERCIAL[GetType()];
        }
    }
}
