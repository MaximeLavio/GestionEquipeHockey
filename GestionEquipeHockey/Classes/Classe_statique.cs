using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEquipeHockey.Classes
{
    public static class Classe_statique
    {

        /// <summary>
        /// Méthode qui calcule l`âge du joueur selon la date actuel et la date de naissance du joueur
        /// </summary>
        /// <param name="p_date_naissance"> Date de naissance du joueur</param>
        /// <returns>Retourne l'âge du joueur</returns>
        public static int Age(DateTime p_date_naissance)
        {
            return DateTime.Now.Year - p_date_naissance.Year;
        }

        /// <summary>
        /// Méthode qui calcule la duré d'un contrat selon la date de début et de fin du contrat
        /// </summary>
        /// <param name="p_date_debut">Date de début du contrat</param>
        /// <param name="p_date_fin">Date de fin du contrat</param>
        /// <returns>Méthode qui retourne la durée du contrat d'un joueur</returns>
        public static int Dure(DateTime p_date_debut, DateTime p_date_fin)
        {
            return p_date_fin.Year - p_date_debut.Year;
        }

        // Liste pour ajouter des objets Gardiens
        public static List<Gardiens_but> listGardiens  = new List<Gardiens_but>();

        // Liste pour ajouter des objets Joueurs
        public static List<Joueurs_avant> listJoueurs = new List<Joueurs_avant>();

        // Liste pour ajouter des objets Contrats
        public static List<Contrats> listContrats = new List<Contrats>();

    }
}
