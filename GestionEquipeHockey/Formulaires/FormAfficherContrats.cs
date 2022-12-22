using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionEquipeHockey.Classes;

namespace GestionEquipeHockey.Formulaires
{
    public partial class FormAfficherContrats : Form
    {
        AdoNet Ado;
        public FormAfficherContrats()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Méthode qui sert à effacé les champs, réinitialiser les champs 
        /// </summary>
        public void ClearChamps()
        {
            txtNumContrat.Text = "";
            dtpDebutContrat.Text = "";
            dtpFinContrat.Text = "";
            txtMontantAnnuel.Text = "";
        }

        /// <summary>
        /// Méthode qui se déroule au chargement du formulaire.
        /// Sert à afficher les objets contrats dans un datagridView au chargement du formulaire
        /// Code tiré des notes de cours et exercices sur Léa (En mode déconnecter)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormAfficherContrats_Load(object sender, EventArgs e)
        {
            panel1.Hide();

            //Instancier un objet Ado qui sera utilisé pour se connecter à la base de données //et y accéder
            Ado = new AdoNet();

            //Écriture de la requête Sql qui va être utilisé dans l’objet Command
            string newQuery = "Select * from Contrats;";

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
            Ado.DtContrats= Ado.DsGestionHockey.Tables[0];

            //Afficher la table Ado.DtEtudiant dans notre dataGridView : il suffit d’associer //la table obtenue Ado.DtEtudiant au DataSource de notre dataGridView
            this.dataGridView2.DataSource = Ado.DtContrats;
            //this.datagridview.headercolumn kek choses pour changer titre colomn

            //Mettre les valeurs entrées par l'utilisateur dans l'objet DataRow UnEtudiant
            try
            {
                foreach (Contrats contrat in Classe_statique.listContrats)
                {
                    DataRow UnContrat = Ado.DtContrats.NewRow();

                    UnContrat[0] = contrat.Code_Joueur;
                    UnContrat[1] = contrat.Code_Gardien;
                    UnContrat[2] = contrat.Num_Contrat;
                    UnContrat[3] = contrat.Date_Debut;
                    UnContrat[4] = contrat.Date_Fin;
                    UnContrat[5] = contrat.Montant_Annuel;

                    Ado.DtContrats.Rows.Add(UnContrat);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        /// <summary>
        /// Bouton qui sert à sauvegarder les modifications apporter au datagridview dans la base de donnée.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSauvegarderContrat_Click(object sender, EventArgs e)
        {
            //Gestion d'exception dans le cas où il y a problème avec le serveur
            try
            {
                // SqlCommandBuilder est la classe qui me permet de sauvegarder       // dans une Base de données.
                //Son constructeur prend en paramètres le data adapter Adapter. 
                SqlCommandBuilder builder = new SqlCommandBuilder(Ado.Adapter);
                //Appeler la méthode Update de l’adapteur.
                //Elle prend en paramètres le DataSet, et le nom de la table.	
                Ado.Adapter.Update(Ado.DsGestionHockey, Ado.DtContrats.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        /// <summary>
        /// Buoton qui sert à supprimer un objet du datagridview et de la basse de donné (si sauvegarder).
        /// Retire également l'objet de la liste. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            try
            {
                //Parcourir les lignes de la table
                foreach (DataRow row in Ado.DtContrats.Rows)
                {
                    try
                    {
                        //Si on trouve l'étudiant dans la table (on cherche par //numéro d'étudiant)
                        if (row[0].ToString().Equals(txtCode_joueur.Text.Trim()))
                            row.Delete();
                    }
                    catch
                    {
                        MessageBox.Show("Veuillez dabord sauvegarder les modifications!", "Error");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Veuillez dabord sauvegarder les modifications!", "Error");
            }
            Contrats obj = null;
            foreach (Contrats contrat in Classe_statique.listContrats)
            {
                if (contrat.Code_Joueur == txtCode_joueur.Text) 
                {
                    obj = contrat;
                }
            }
            Classe_statique.listContrats.Remove(obj);
        }

        /// <summary>
        /// Méthode qui sert à confirmer si le code du joueur existe et fait partit de l'équipe
        /// </summary>
        /// <param name="code"></param>
        public void ModifContrat(string code)
        {
            Gardiens_but obj = null;
            foreach (Gardiens_but gardien in Classe_statique.listGardiens)
            {
                if (gardien.Code_Joueur == code)
                {
                    obj = gardien;
                    panel1.Show();
                }
            }
            Joueurs_avant joue = null;
            foreach (Joueurs_avant joueur in Classe_statique.listJoueurs)
            {
                if (joueur.Code_Joueur == code)
                {
                    joue = joueur;
                    panel1.Show();
                }
            }
            if (joue == null && obj == null)
            {
                MessageBox.Show("Le code joueur n'existe pas", "Error");
            }
        }

        /// <summary>
        /// Bouton qui appelle la méthode ModifContrat et qui permet de voir le panel 
        /// qui donne ensuite acces à faire des modifications. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnContinuer_Click(object sender, EventArgs e)
        {
            // Vérifier si le code du joueur est chiffre de longeur 5
            // Sinon Message d'erreur
            Regex regex_code = new Regex("^[0-9]{5}$");
            bool re_code = regex_code.IsMatch(txtCode_joueur.Text);
            if (re_code)
            {
                ModifContrat(txtCode_joueur.Text);
            }
            else
            {
                MessageBox.Show("Le code du joueur doit être composé de 5 chiffres.", "Error");
            }
        }

        /// <summary>
        /// Méthode qui fait la gestion d'erreurs à l'aide de Regex pour les champs où
        /// l'utilisateur doit entrer des données
        /// </summary>
        /// <returns></returns>
        public bool VérificationChamps()
        {
            bool valid = true;

            // Vérifier si le numéro du contrat comporte 10 caractères
            // Sinon Message d'erreur
            Regex regex_code = new Regex("^[a-z0-9]{10}$");
            bool re_code = regex_code.IsMatch(txtNumContrat.Text);
            if (re_code)
            {

            }
            else
            {
                MessageBox.Show("Le numéro du contrat doit être de 10 caractères.", "Error");
                valid = false;
            }

            // Vérifier la date de début et de fin 
            // Sinon message erreur
            if (Classe_statique.Dure(dtpDebutContrat.Value, dtpFinContrat.Value) > 0)
            {

            }
            else
            {
                MessageBox.Show("La date de début doit être inférieur à celle de fin.", "Error");
                valid = false;
            }

            // Vérifier que le montant annuel est un nombre
            // Sinon Message d'erreur
            Regex regex_montant = new Regex("^[0-9]{1,20}$");
            bool re_montant = regex_montant.IsMatch(txtMontantAnnuel.Text);
            if (re_montant)
            {

            }
            else
            {
                MessageBox.Show("Veuillez saisir un nombre pour le montant.", "Error");
                valid = false;
            }

            // Après vérification
            if (valid)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Méthode qui sert à supprimer un objet de la liste et de la base de données
        /// avant d'être réajouter suite à des modifications.
        /// </summary>
        /// <param name="numero"></param>
        public void Modifsupprimer(string numero)
        {

            //Parcourir les lignes de la table
            foreach (DataRow row in Ado.DtContrats.Rows)
            {
                //Si on trouve l'étudiant dans la table (on cherche par //numéro d'étudiant)
                if (row[0].ToString().Equals(numero))
                    row.Delete();
            }
            Contrats obj = null;
            foreach (Contrats contrat in Classe_statique.listContrats)
            {
                if (contrat.Code_Joueur == numero)
                {
                    obj = contrat;
                }
            }
            Classe_statique.listContrats.Remove(obj);
        }

        /// <summary>
        /// Méthode qui affecte les modifications apportées à un objet.
        /// Réinitialise les champs avec la méthode ClearChamps().
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (VérificationChamps())
            {
                Modifsupprimer(txtCode_joueur.Text); 

                Contrats contrat = new Contrats();
                contrat.Num_Contrat = txtNumContrat.Text;
                contrat.Date_Debut = dtpDebutContrat.Value;
                contrat.Date_Fin = dtpFinContrat.Value;
                contrat.Montant_Annuel = float.Parse(txtMontantAnnuel.Text);
                contrat.Code_Joueur = txtCode_joueur.Text;
                Classe_statique.listContrats.Add(contrat);
                ClearChamps();
            }
        }

        /// <summary>
        /// Bouton qui sert à rechercher selon certain critère dans le datagridview
        /// Code tiré des notes de cours et exercices sur Léa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRechercher_Click(object sender, EventArgs e)
        {
            //Parcourir les lignes du DataTable DtEtudiants
            foreach (DataRow row in Ado.DtContrats.Rows)
            {
                //Si le numéro de contrat existe dans la table, Afficher les informations dans un MessageBox. Row[0] correspond au champ Numéro
                if (row[2].ToString() == txtRecherche.Text)
                    MessageBox.Show("Le code du joueur :  " + row[0] + "\n"
                                      + "Le numéro de contrat : " + row[2] + "\n"
                                      + "La date de début : " + row[3] + "\n"
                                      + "La date de fin: " + row[4] + "\n"
                                      + "Le montant annuel: " + row[5]+ "\n","Résultat de la recherche", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //Parcourir les lignes du DataTable 
            foreach (DataRow row in Ado.DtContrats.Rows)
            {
                //Si le code du joueur existe dans la table, Afficher les informations dans un MessageBox. Row[0] correspond au champ Numéro
                if (row[0].ToString() == txtCodeJoueurRecherche.Text)
                    MessageBox.Show("Le code du joueur :  " + row[0] + "\n"
                                      + "Le numéro de contrat : " + row[2] + "\n"
                                      + "La date de début : " + row[3] + "\n"
                                      + "La date de fin: " + row[4] + "\n"
                                      + "Le montant annuel: " + row[5] + "\n", "Résultat de la recherche", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
