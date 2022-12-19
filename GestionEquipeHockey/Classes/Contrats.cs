using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEquipeHockey.Classes
{
    public class Contrats : IContrat
    {
        // Attributs de la class Contrats
        private string code_joueur;     // Code du joueur
        private string num_contrat;     // Numéro du contrat
        private DateTime date_debut;    // Date du début du contrat
        private DateTime date_fin;      // Date de fin du contrat
        private float montant_annuel;   // Montant annuel
        private static int nb_contrats; // Nombre de contrats créer

        // Propriétés Get/Set des attributs 
        public string Code_Joueur
        {
            get { return code_joueur; }
            set { code_joueur = value; }
        }
        public string Num_Contrat
        {
            get { return num_contrat; }
            set { num_contrat = value; }
        }

        public DateTime Date_Debut
        {
            get { return date_debut; }
            set { date_debut = value; }
        }

        public DateTime Date_Fin
        {
            get { return date_fin; }
            set { date_fin = value; }
        }

        public float Montant_Annuel
        {
            get { return montant_annuel; }
            set { montant_annuel = value; }
        }

        public static int Nb_Contrats
        {
            get { return nb_contrats; }
            set { nb_contrats = value; }
        }


        // Constructeur de la class Joueurs_avant
        public Contrats(string p_code_joueur = "",string p_num_contrat = "", DateTime p_date_debut = default, DateTime p_date_fin = default, float p_montant_annuel = 0)
        {
            nb_contrats++;
            this.code_joueur = p_code_joueur;
            this.num_contrat = p_num_contrat;
            this.date_debut = p_date_debut;
            this.date_fin = p_date_fin;
            this.montant_annuel = p_montant_annuel;
        }


        // Autres méthodes 

        public float Montant_total()
        {
            return montant_annuel * (date_fin.Year - date_debut.Year);
        }
    }
}
