using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComptaChim
{
    public abstract class Commercial : Employe
    {
        public const double COEF = 0.2;
        public int CA { get; set; }
        public int Bonus { get; set; }
        protected Commercial(string nom, string prenom, int age, string entreeEntrep,int CA) : base(nom, prenom, age, entreeEntrep)
        {
            this.CA = CA;
        }
    }
}
