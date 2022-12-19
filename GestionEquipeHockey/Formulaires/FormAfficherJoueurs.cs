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
    public partial class FormAfficherJoueurs : Form
    {
        AdoNet Ado;
        public FormAfficherJoueurs()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Méthode pour réinitialiser les champs des formulaires
        /// </summary>
        public void ClearChamps()
        {
            txtCode_joueur.Text = "";
            txtNomJoueur.Text = "";
            txtPrenomJoueur.Text = "";
            dtpDateNaissance.Text = default;
            txtPoids.Text = "";
            txtTaille.Text = "";
            numUpDownNumero.Text = "";
            comboBoxCote.Text = "";
            comboBoxPosition.Text = "";
            txtNb_matchs.Text = 
            txtMinutes_punitions.Text = "";
            txtNb_buts.Text = "";
            txtNb_passes.Text = "";
            txtMises_echec.Text = "";
        }


        /// <summary>
        /// Méthode qui sert à supprimer un objet de la liste et de la base de données
        /// avant d'être réajouter suite à des modifications.
        /// </summary>
        /// <param name="numero"></param>
        public void Modifsupprimer(string numero)
        {

            //Parcourir les lignes de la table
            foreach (DataRow row in Ado.DtJoueurs.Rows)
            {
                //Si on trouve l'étudiant dans la table (on cherche par //numéro d'étudiant)
                if (row[0].ToString().Equals(numero))
                    row.Delete();
            }
            Joueurs_avant obj = null;
            foreach (Joueurs_avant joueur in Classe_statique.listJoueurs)
            {
                if (joueur.Code_Joueur == numero)
                {
                    obj = joueur;
                }
            }
            Classe_statique.listJoueurs.Remove(obj);
        }


        /// <summary>
        /// Méthode qui fait la gestion d'erreurs à l'aide de Regex pour les champs où
        /// l'utilisateur doit entrer des données
        /// </summary>
        /// <returns></returns>
        public bool VérificationChampsModif()
        {
            bool valid = true;

            // Vérifier si le Nom du joueur Commence par Majuscule suivit des minuscules
            // Sinon Message d'erreur
            Regex regex_nom = new Regex("^[A-Z]{1}[a-z]*$");
            bool re_nom = regex_nom.IsMatch(txtNomJoueur.Text);
            bool re_prenom = regex_nom.IsMatch(txtPrenomJoueur.Text);

            if (re_nom && re_prenom)
            {

            }
            else
            {
                MessageBox.Show("Le nom et le Prénom doivent commencer par une Majuscule suivi de munuscules.", "Error");
                valid = false;
            }

            // Vérifier si le Joueur à au moin 18 ans 
            // Sinon Message d'erreur
            if (Classe_statique.Age(Convert.ToDateTime(dtpDateNaissance.Value)) > 18)
            {

            }
            else
            {
                MessageBox.Show("Le joueur doit avoir un minimum 18 ans", "Error");
                valid = false;
            }

            // Vérifier le poids et la taille du joueur
            // Sinon Message d'erreur
            Regex regex_poids_taille = new Regex("^[0-9]*$");
            bool re_poids = regex_poids_taille.IsMatch(txtPoids.Text);
            bool re_taille = regex_poids_taille.IsMatch(txtTaille.Text);
            if (re_poids && re_taille)
            {

            }
            else
            {
                MessageBox.Show("Veuillez entrer le poids et la taille correctement", "Error");
                valid = false;
            }



            // Vérifier si le Numéro du joueur est entre 0 et 99 
            // Sinon Message d'erreur
            Regex regex_numero = new Regex("^[0-9]{1,2}$");
            bool re_numero = regex_numero.IsMatch(Convert.ToString(numUpDownNumero.Value));
            if (re_numero)
            {

            }
            else
            {
                MessageBox.Show("Le numéro du joueur doit être entre 0 et 99", "Error");
                valid = false;
            }

            // Vérifier que le joueur est droiter ou gaucher
            // Sinon Message d'erreur
            if (comboBoxCote.Text == "Droitier" || comboBoxCote.Text == "Gaucher")
            {

            }
            else
            {
                MessageBox.Show("Veuillez choisir parmi les options proposées", "Error");
                valid = false;
            }

            // Vérifier que les statistique sont des nombres
            // Sinon Message d'erreur
            Regex regex_stats = new Regex("^[0-9]{1,5}$");
            bool re_matchs = regex_stats.IsMatch(txtNb_matchs.Text);
            bool re_punitions = regex_stats.IsMatch(txtMinutes_punitions.Text);
            bool re_buts = regex_stats.IsMatch(txtNb_buts.Text);
            bool re_passes = regex_stats.IsMatch(txtNb_passes.Text);
            bool re_mises_echec = regex_stats.IsMatch(txtMises_echec.Text);

            if (re_matchs && re_punitions && re_buts && re_passes && re_mises_echec)
            {

            }
            else
            {
                MessageBox.Show("Les statistiques du joueur doivent être des nombres.", "Error");
                valid = false;
            }

            // Apès verification
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
        /// Méthode qui sert à confirmer si le code du joueur existe et fait partit de l'équipe
        /// </summary>
        /// <param name="code"></param>
        public void ModifJoueur(string code)
        {
            Joueurs_avant obj = null;
            foreach (Joueurs_avant joueur in Classe_statique.listJoueurs)
            {
                if (joueur.Code_Joueur == code)
                {
                    obj = joueur;
                    btnModifier.Enabled = true;
                    btnSupprimer.Enabled = true;
                }
            }
            if (obj == null)
            {
                MessageBox.Show("Le code joueur n'existe pas", "Error");
            }
            else
            {

                txtNomJoueur.Text = obj.Nom_Joueur;
                txtPrenomJoueur.Text = obj.Prenom_Joueur;
                dtpDateNaissance.Text = Convert.ToString(obj.Date_naissance);
                txtPoids.Text = Convert.ToString(obj.Poids);
                txtTaille.Text = Convert.ToString(obj.Taille);
                numUpDownNumero.Value = Convert.ToInt16(obj.Numero);
                comboBoxCote.Text = obj.Cote;
                txtNb_matchs.Text = Convert.ToString(obj.Nb_Matchs);
                txtMinutes_punitions.Text = Convert.ToString(obj.Minutes_Punition);
                txtNb_buts.Text = Convert.ToString(obj.Nb_Buts);
                txtNb_passes.Text = Convert.ToString(obj.Nb_Passes);
                txtMises_echec.Text = Convert.ToString(obj.Nb_Mises_Echec);
            }
        }

        /// <summary>
        /// Bouton qui appelle la méthode ModifJoueurs et qui permet de voir les boutons
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
                ModifJoueur(txtCode_joueur.Text);
            }
            else
            {
                MessageBox.Show("Le code du joueur doit être composé de 5 chiffres.", "Error");
            }
        }


        /// <summary>
        /// Méthode qui se déroule au chargement du formulaire.
        /// Sert à afficher les objets Gardiens dans un datagridView au chargement du formulaire
        /// Code tiré des notes de cours et exercices sur Léa (En mode déconnecter)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormModifierJoueurs_Load(object sender, EventArgs e)
        {
            btnModifier.Enabled = false;
            btnSupprimer.Enabled = false;


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


        /// <summary>
        /// Bouton qui affecte les modifications apportées à un objet.
        /// Réinitialise les champs avec la méthode ClearChamps().
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifier_Click(object sender, EventArgs e)
        {
          
            if (comboBoxPosition.Text == "Attaquant" || comboBoxPosition.Text == "Défenseur")
            {
                if (VérificationChampsModif())
                {
                    Modifsupprimer(txtCode_joueur.Text.Trim());

                    Joueurs_avant joueur = new Joueurs_avant();
                    joueur.Code_Joueur = txtCode_joueur.Text;
                    joueur.Nom_Joueur = txtNomJoueur.Text;
                    joueur.Prenom_Joueur = txtPrenomJoueur.Text;
                    joueur.Date_naissance = dtpDateNaissance.Value;
                    joueur.Poids = float.Parse(txtPoids.Text);
                    joueur.Taille = float.Parse(txtTaille.Text);
                    joueur.Numero = Convert.ToInt16(numUpDownNumero.Value);
                    joueur.Cote = comboBoxCote.Text;
                    joueur.Nb_Matchs = Convert.ToInt16(txtNb_matchs.Text);
                    joueur.Minutes_Punition = Convert.ToInt16(txtMinutes_punitions.Text);
                    joueur.Nb_Buts = Convert.ToInt16(txtNb_buts.Text);
                    joueur.Nb_Passes = Convert.ToInt16(txtNb_passes.Text);
                    joueur.Nb_Mises_Echec = Convert.ToInt16(txtMises_echec.Text);
                    Classe_statique.listJoueurs.Add(joueur);
                    ClearChamps();
                }

            }
        }


        /// <summary>
        /// Bouton qui sert à sauvegarder les modifications apporter au datagridview dans la base de donnée.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                foreach (DataRow row in Ado.DtJoueurs.Rows)
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
            Joueurs_avant obj = null;
            foreach (Joueurs_avant joueur in Classe_statique.listJoueurs)
            {
                if (joueur.Code_Joueur == txtCode_joueur.Text);
                {
                    obj = joueur;
                }
            }
            Classe_statique.listJoueurs.Remove(obj);

        }
    }
    }

