using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComptaChim
{
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
