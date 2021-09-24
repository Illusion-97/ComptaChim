using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComptaChim
{
    public class Constants
    {
        public static readonly Dictionary<Type,string> TITLES_EMPLOYES = new Dictionary<Type, string>()
        {
            {typeof(Employe), "L'employe "},
            {typeof(Commercial), "Le commercial "},
            {typeof(Vendeur), "Le vendeur "},
            {typeof(Representant), "Le representant "},
            {typeof(Technicien), "Le technicien  "},
            {typeof(TechnARisque), "Le technicien à risque  "},
            {typeof(Manutentionnaire), "Le manut. "},
            {typeof(ManutARisque), "Le manut. à risque "}
        };
        public const double COEFF_COMMERCIAL = 0.2;
        public static readonly Dictionary<Type,int> BONUS_COMMERCIAL = new Dictionary<Type, int>()
        {
            {typeof(Vendeur), 400 },
            {typeof(Representant), 800 }
        };
        public const int SALAIRE_UNIT_TECHN = 5;
        public const int SALAIRE_HORAIRE_MANUT = 65;
        public const int PRIME_DE_RISQUE = 200;
    }
}
