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

        public void AjouterEmploye(Employe e) { employes.Add(e); }
        public void AfficherSalaires()
        {
            foreach (Employe e in employes)
            {
                Console.WriteLine("{0} gagne {1} Euros.",e.GetNom(),e.CalculerSalaire());
            }
        }
        public double SalaireMoyen()
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
