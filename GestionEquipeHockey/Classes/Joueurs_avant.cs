using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEquipeHockey.Classes
{
    public class Joueurs_avant : Joueurs
    {
        // Attributs de la classe Joueurs_avant
        private int nb_buts;           // Nombre de but que le joueur a compter
        private int nb_passes;         // Nombre de passes que le joueur a fait
        private int nb_mises_echec;    // Nombre de mises en échec effectué par le joueur

        // Propriétés Get/Set des attributs 
        public int Nb_Buts
        {
            get { return nb_buts; }
            set { nb_buts = value; }
        }

        public int Nb_Passes
        {
            get { return nb_passes; }
            set { nb_passes = value; }
        }

        public int Nb_Mises_Echec
        {
            get { return nb_mises_echec; }
            set { nb_mises_echec = value; }
        }



        // Constructeur de la class Joueurs_avant
        public Joueurs_avant(string p_code_joueur = "", string p_nom = "", string p_prenom = "", DateTime p_date_naissance = default, float p_poids = 0, float p_taille = 0,
            string p_position = "", int p_numero = 0, string p_cote = "", string p_nom_equipe = "Canadien", string p_ville_equipe = "Montréal",
            string p_arena_equipe = "Centre Bell", string p_pays_equipe = "Canada", int p_nb_matchs = 0, int p_minutes_punition = 0, int p_nb_buts = 0, int p_nb_passes = 0, int p_nb_mises_echec = 0) 
            : base (p_code_joueur, p_nom,p_prenom,p_date_naissance,p_poids,p_taille, p_position,p_numero, p_cote,p_nom_equipe,p_ville_equipe,
                    p_arena_equipe,p_pays_equipe,p_nb_matchs,p_minutes_punition)
        {
            
            this.nb_buts = p_nb_buts;
            this.nb_passes = p_nb_passes;
            this.nb_mises_echec = p_nb_mises_echec;
        }


        // Autres méthodes 

        /// <summary>
        /// Méthode qui calcule le nombre de points que le joueur a fait 
        /// </summary>
        /// <returns>Le nombre de point </returns>
        public int CalculerPoints()
        {
            return nb_buts + nb_passes;
        }

        /// <summary>
        /// Méthode qui calcule l'éfficacité du joueur 
        /// </summary>
        /// <returns>Le nombre de but en moyenne par match</returns>
        public override int Calculer_Efficacite()
        {
            return (nb_buts + nb_passes) / Nb_Matchs;
        }

    }
}
