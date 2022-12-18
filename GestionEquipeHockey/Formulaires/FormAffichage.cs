using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionEquipeHockey.Classes;

namespace GestionEquipeHockey.Formulaires
{
    public partial class FormAffichage : Form
    {
        AdoNet Ado;
        public FormAffichage()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormAffichage_Load(object sender, EventArgs e)
        {
            //Instancier un objet Ado qui sera utilisé pour se connecter à la base de données //et y accéder
            Ado = new AdoNet();

            //Écriture de la requête Sql qui va être utilisé dans l’objet Command
            string Query = "Select * from Gardiens;";

            //Préparer l'objet Command en mettant dans la CommandText la chaîne Query préparée 
            Ado.Command.CommandText = Query;

            //Mettre dans la propriété Connection de l’objet Command l’objet Connection qu’on a //préparé (instancié)
            Ado.Command.Connection = Ado.Connection;

            //Préparer l'objet Adapter qui sert d’intermédiaire entre la source de données et le DataSet. SelectCommand est utilisée car notre commande est une commande //Select
            Ado.Adapter.SelectCommand = Ado.Command;

            //Remplir le DataSet Ado.DsScolarite avec le résultat de la requête Query (Dans ce //cas le résultat est la table Etudiants). Pour cela il faut utiliser la méthode //Fill
            Ado.Adapter.Fill(Ado.DsGestionHockey);

            //la table Etudiants est la première table (indice 0) du DataSet DsScolarite. Si au //lieu d’utiliser une requête SQL on utilise une procédure stockée qui 
            // retourne plusieurs tables, ces tables seront dans le DataSet Ado.DsScolarite
            // et pour y accéder il suffit d’utiliser le bon indice : 0,1,2, etc. Dans notre //cas, la requête retourne une seule table. On met ce résultat dans la DataTable // DtEtudiant
            Ado.DtGardiens = Ado.DsGestionHockey.Tables[0];

            //Afficher la table Ado.DtEtudiant dans notre dataGridView : il suffit d’associer //la table obtenue Ado.DtEtudiant au DataSource de notre dataGridView
            this.dataGridView1.DataSource = Ado.DtGardiens;
            //this.datagridview.headercolumn kek choses pour changer titre colomn





            //Ajouter une ligne à notre DataGridView
            //Toutes les modifications faites sur le DataTable sont automatiquement 
            // répliquées dans le DataGridView et vise versa

            //Instancier un objet DataRow (une ligne de la table) : DataRow UnEtudiant
            // Le classe DataRow se trouve dans System.Data
            //Affecter à l'objet DataRow Unetudiant le même schéma que la table
            // c'est à dire : Numero,Nom,Prénom

            

            //Mettre les valeurs entrées par l'utilisateur dans l'objet DataRow UnEtudiant
            try
            {
                foreach (Gardiens_but joueur in Classe_statique.listGardiens)
                {
                    DataRow UnJoueur = Ado.DtGardiens.NewRow(); 

                    UnJoueur[1] = joueur.Nom_Joueur;
                    UnJoueur[2] = joueur.Prenom_Joueur;
                    UnJoueur[3] = joueur.Date_naissance;
                    UnJoueur[4] = joueur.Poids;
                    UnJoueur[5] = joueur.Taille;
                    UnJoueur[6] = joueur.Numero;
                    UnJoueur[7] = joueur.Cote;
                    UnJoueur[8] = joueur.Nom_Equipe;
                    UnJoueur[9] = joueur.Ville_Equipe;
                    UnJoueur[10] = joueur.Arena_Equipe;
                    UnJoueur[11] = joueur.Pays_Equipe;
                    UnJoueur[12] = joueur.Nb_Matchs;
                    UnJoueur[13] = joueur.Minutes_Punition;
                    UnJoueur[14] = joueur.Nb_Arrets;
                    UnJoueur[15] = joueur.Nb_Tire_Recus;
                    

                    Ado.DtGardiens.Rows.Add(UnJoueur);
                }               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



            //Instancier un objet Ado qui sera utilisé pour se connecter à la base de données //et y accéder
            Ado = new AdoNet();

            //Écriture de la requête Sql qui va être utilisé dans l’objet Command
            string newQuery = "Select * from Joueurs_avant;";

            //Préparer l'objet Command en mettant dans la CommandText la chaîne Query préparée 
            Ado.Command.CommandText = newQuery;

            //Mettre dans la propriété Connection de l’objet Command l’objet Connection qu’on a //préparé (instancié)
            Ado.Command.Connection = Ado.Connection;

            //Préparer l'objet Adapter qui sert d’intermédiaire entre la source de données et le DataSet. SelectCommand est utilisée car notre commande est une commande //Select
            Ado.Adapter.SelectCommand = Ado.Command;

            //Remplir le DataSet Ado.DsScolarite avec le résultat de la requête Query (Dans ce //cas le résultat est la table Etudiants). Pour cela il faut utiliser la méthode //Fill
            Ado.Adapter.Fill(Ado.DsGestionHockey);

            //la table Etudiants est la première table (indice 0) du DataSet DsScolarite. Si au //lieu d’utiliser une requête SQL on utilise une procédure stockée qui 
            // retourne plusieurs tables, ces tables seront dans le DataSet Ado.DsScolarite
            // et pour y accéder il suffit d’utiliser le bon indice : 0,1,2, etc. Dans notre //cas, la requête retourne une seule table. On met ce résultat dans la DataTable // DtEtudiant
            Ado.DtJoueurs = Ado.DsGestionHockey.Tables[0];

            //Afficher la table Ado.DtEtudiant dans notre dataGridView : il suffit d’associer //la table obtenue Ado.DtEtudiant au DataSource de notre dataGridView
            this.dataGridView2.DataSource = Ado.DtJoueurs;
            //this.datagridview.headercolumn kek choses pour changer titre colomn














            //Mettre les valeurs entrées par l'utilisateur dans l'objet DataRow UnEtudiant
            try
            {
                foreach (Joueurs_avant joueur in Classe_statique.listJoueurs)
                {
                    DataRow UnJoueur = Ado.DtJoueurs.NewRow();

                    UnJoueur[0] = joueur.Code_Joueur;
                    UnJoueur[1] = joueur.Nom_Joueur;
                    UnJoueur[2] = joueur.Prenom_Joueur;
                    UnJoueur[3] = joueur.Date_naissance;
                    UnJoueur[4] = joueur.Poids;
                    UnJoueur[5] = joueur.Taille;
                    UnJoueur[6] = joueur.Numero;
                    UnJoueur[7] = joueur.Cote;
                    UnJoueur[8] = joueur.Nom_Equipe;
                    UnJoueur[9] = joueur.Ville_Equipe;
                    UnJoueur[10] = joueur.Arena_Equipe;
                    UnJoueur[11] = joueur.Pays_Equipe;
                    UnJoueur[12] = joueur.Nb_Matchs;
                    UnJoueur[13] = joueur.Minutes_Punition;
                    UnJoueur[14] = joueur.Nb_Buts;
                    UnJoueur[15] = joueur.Nb_Passes;
                    UnJoueur[16] = joueur.Nb_Mises_Echec;

                    Ado.DtJoueurs.Rows.Add(UnJoueur);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSauvegarderGardiens_Click(object sender, EventArgs e)
        {
            //Gestion d'exception dans le cas où il y a problème avec le serveur
            try
            {
                // SqlCommandBuilder est la classe qui me permet de sauvegarder       // dans une Base de données.
                //Son constructeur prend en paramètres le data adapter Adapter. 
                SqlCommandBuilder builder = new SqlCommandBuilder(Ado.Adapter);
                //Appeler la méthode Update de l’adapteur.
                //Elle prend en paramètres le DataSet, et le nom de la table.	
                Ado.Adapter.Update(Ado.DsGestionHockey, Ado.DtGardiens.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSauvegarderJoueurs_Click(object sender, EventArgs e)
        {
            //Gestion d'exception dans le cas où il y a problème avec le serveur
            try
            {
                // SqlCommandBuilder est la classe qui me permet de sauvegarder       // dans une Base de données.
                //Son constructeur prend en paramètres le data adapter Adapter. 
                SqlCommandBuilder builder = new SqlCommandBuilder(Ado.Adapter);
                //Appeler la méthode Update de l’adapteur.
                //Elle prend en paramètres le DataSet, et le nom de la table.	
                Ado.Adapter.Update(Ado.DsGestionHockey, Ado.DtJoueurs.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnActualiser_Click(object sender, EventArgs e)
        {
            foreach (Joueurs_avant joueur in Classe_statique.listJoueurs)
            {
                //Parcourir les lignes de la table Ado.DtEtudiants
                foreach (DataRow row in Ado.DtJoueurs.Rows)
                {
                    //Apporter toutes les modifications sur tous les champs de la ligne
                    row[0] = joueur.Code_Joueur;
                    row[1] = joueur.Nom_Joueur;
                    row[2] = joueur.Prenom_Joueur;
                    row[3] = joueur.Date_naissance;

                }
            }

           

        }
    }
}
