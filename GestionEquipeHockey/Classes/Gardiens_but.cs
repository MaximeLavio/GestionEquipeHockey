using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEquipeHockey.Classes
{
    public class Gardiens_but : Joueurs
    {
        // Attributs de la class Gardiens_but
        private int nb_arret;       // Nombre d'arrets effectué par le gardien 
        private int nb_tire_recus;  // Nombre de tires dirigé sur le gardien 


        // Propriétés Get/Set des attributs 
        public int Nb_Arrets
        {
            get { return nb_arret; }
            set { nb_arret = value; }
        }

        public int Nb_Tire_Recus
        {
            get { return nb_tire_recus;}
            set { nb_tire_recus = value;}
        }


        // Constructeur de la class Joueurs_avant
        public Gardiens_but(string p_code_joueur = "", string p_nom = "", string p_prenom = "", DateTime p_date_naissance = default, float p_poids = 0, float p_taille = 0,
            string p_position = "", int p_numero = 0, string p_cote = "", string p_nom_equipe = "Canadien", string p_ville_equipe = "Montréal",
            string p_arena_equipe = "Centre Bell", string p_pays_equipe = "Canada", int p_nb_matchs = 0, int p_minutes_punition = 0, int p_nb_arret = 0, int p_nb_tire_recus = 0)
            : base (p_code_joueur, p_nom, p_prenom, p_date_naissance, p_poids, p_taille, p_position, p_numero, p_cote, p_nom_equipe, p_ville_equipe,
                    p_arena_equipe, p_pays_equipe, p_nb_matchs, p_minutes_punition)
        {
            
            this.nb_arret = p_nb_arret;
            this.nb_tire_recus = p_nb_tire_recus;
        }
       

        // Autres méthodes 

        /// <summary>
        /// Méthode qui calcule le nombre de buts alloué par le gardien de but 
        /// </summary>
        /// <returns>Le nombre de buts alloué</returns>
        public int Buts_Alloue()
        {
            return nb_tire_recus - nb_arret;
        }

        /// <summary>
        /// Méthode qui calcule l'efficacité du gardien
        /// </summary>
        /// <returns> Le pourcentage d'efficacité du gardien</returns>
        public override int Calculer_Efficacite()
        {
            return (nb_arret / nb_tire_recus) * 100;
        }
    }
}
