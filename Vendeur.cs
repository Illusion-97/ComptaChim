using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComptaChim
{
    public class Vendeur : Commercial
    {
        public Vendeur(string nom, string prenom, int age, string entreeEntrep,int CA) : base(nom, prenom, age, entreeEntrep,CA)
        {
        }
    }
}
