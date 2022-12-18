using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEquipeHockey.Classes
{
    abstract public class Joueurs
    {
        // Attributs de la classe joueurs
        private string nom_joueur;         // Nom du joueur
        private string prenom_joueur;      // Prénom du joueur
        private DateTime date_naissance;   //Date de naissance du joueur
        private float poids;               // Poids du joueur en lbs
        private float taille;              // Taille du joueur en cm 
        private int numero;                // Numéro sur le chandail du joueur
        private string cote;               // Coté naturel du joueur -> Droiter ou Gaucher
        private string nom_equipe;         // Nom de l'équipe 
        private string ville_equipe;       // Nom de la ville ou demeure l'équipe 
        private string arena_equipe;       // Nom  de l'aréna de l'équipe
        private string pays_equipe;        // Pays ou demeure l'équipe 
        private int nb_matchs;             // Nombre de matches joué par le joueur
        private int minutes_punition;      // Nombre de minutes de punition accumulé par le joueur



        // Propriétés Get/Set des attributs
        public string Nom_Joueur
        {
            get { return nom_joueur; }
            set { nom_joueur = value; }
        }

        public string Prenom_Joueur
        {
            get { return prenom_joueur;}
            set { prenom_joueur = value; }
        }

        public DateTime Date_naissance
        {
            get { return date_naissance; }
            set { date_naissance = value; }
        }

        public float Poids
        {
            get { return poids; }
            set { poids = value; }
        }

        public float Taille
        {
            get { return taille; }
            set { taille = value; }
        }

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public string Cote
        {
            get { return cote; }
            set { cote = value; }
        }

        public string Nom_Equipe
        {
            get { return nom_equipe; }
        }
        public string Ville_Equipe
        {
            get { return ville_equipe; }
        }
        public string Arena_Equipe
        {
            get { return arena_equipe; }
        }
        public string Pays_Equipe
        {
            get { return pays_equipe; }
        }

        public int Nb_Matchs
        {
            get { return nb_matchs; }
            set { nb_matchs = value; }
        }

        public int Minutes_Punition
        {
            get { return minutes_punition;}
            set { minutes_punition = value; }           
        }




        // Constructeur de la classe Joueurs
        public Joueurs(string p_nom = "", string p_prenom = "", DateTime p_date_naissance = default, float p_poids = 0, float p_taille = 0,
            string p_position = "", int p_numero = 0, string p_cote = "", string p_nom_equipe = "Canadien", string p_ville_equipe = "Montréal",
            string p_arena_equipe = "Centre Bell", string p_pays_equipe = "Canada", int p_nb_matchs = 0, int p_minutes_punition = 0)
        {
            this.nom_joueur = p_nom;                      
            this.prenom_joueur = p_prenom;                 
            this.date_naissance = p_date_naissance; 
            this.poids = p_poids;  
            this.taille = p_taille; 
            this.numero = p_numero;
            this.cote = p_cote;
            this.nom_equipe = p_nom_equipe;
            this.ville_equipe = p_ville_equipe;
            this.arena_equipe = p_arena_equipe;
            this.pays_equipe = p_pays_equipe;
            this.nb_matchs = p_nb_matchs;
            this.minutes_punition = p_minutes_punition;
        }


        // Autres méthodes 

        abstract public int Calculer_Efficacite();
     
    }
}
