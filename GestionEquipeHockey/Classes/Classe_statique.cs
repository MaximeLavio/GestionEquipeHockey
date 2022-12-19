using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEquipeHockey.Classes
{
    public static class Classe_statique
    {
        public static int Age(DateTime p_date_naissance)
        {
            return DateTime.Now.Year - p_date_naissance.Year;
        }

        public static int Dure(DateTime p_date_debut, DateTime p_date_fin)
        {
            return p_date_fin.Year - p_date_debut.Year;
        }

        public static List<Gardiens_but> listGardiens  = new List<Gardiens_but>();

        public static List<Joueurs_avant> listJoueurs = new List<Joueurs_avant>();

        public static List<Contrats> listContrats = new List<Contrats>();

    }
}
