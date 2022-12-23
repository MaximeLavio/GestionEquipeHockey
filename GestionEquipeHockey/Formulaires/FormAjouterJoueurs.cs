using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionEquipeHockey.Classes;

namespace GestionEquipeHockey.Formulaires
{
    public partial class FormAjouterJoueurs : Form
    {
    
        public FormAjouterJoueurs()
        {
            InitializeComponent();       
        }
    
        /// <summary>
        /// Méthode pour réinitialiser les champs des formulaires
        /// </summary>
        public void ClearChamps()
        {
            txtAjoutCode_joueur.Text = "";
            txtNomJoueur.Text = "";
            txtPrenomJoueur.Text = "";
            dtpDateNaissance.Text = default;
            txtPoids.Text = "";
            txtTaille.Text = "";
            numUpDownNumero.Text = "";
            comboBoxCote.Text = "";
            comboBoxPosition.Text = "";
        }


        /// <summary>
        /// Méthode qui fait la gestion d'erreurs à l'aide de Regex pour les champs où
        /// l'utilisateur doit entrer des données
        /// </summary>
        /// <returns></returns>
        public bool VérificationChamps()
        {
            bool valid = true;

            // Vérifier si le code du joueur est chiffre de longeur 5
            // Sinon Message d'erreur
            Regex regex_code = new Regex("^[0-9]{5}$");
            bool re_code = regex_code.IsMatch(txtAjoutCode_joueur.Text);
            if (re_code)
            {

            }
            else
            {
                MessageBox.Show("Le code du joueur doit être composé de 5 chiffres.", "Error");
                valid = false;
            }


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
            Regex regex_poids_taille = new Regex("^[0-9]{1,5}$");
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
        /// Bouton qui créer un objet Joueur ou Gardiens une fois tout les demandes et gestions d'erreur fait. 
        /// Ajoute également l'objet à la liste selon le cas.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouterJoueur_Click(object sender, EventArgs e)
        {
            if (comboBoxPosition.Text == "Gardien")
            {
                if (VérificationChamps())
                {
                    Gardiens_but obj = null;
                    foreach (Gardiens_but gard in Classe_statique.listGardiens)
                    {
                        if (gard.Code_Joueur == txtAjoutCode_joueur.Text)
                        {
                            MessageBox.Show("Un joueur avec ce code existe déja", "Error");
                            obj = gard;
                        }
                    }
                    if (obj == null)
                    {
                        Gardiens_but gardien = new Gardiens_but();
                        gardien.Code_Joueur = txtAjoutCode_joueur.Text;
                        gardien.Nom_Joueur = txtNomJoueur.Text;
                        gardien.Prenom_Joueur = txtPrenomJoueur.Text;
                        gardien.Date_naissance = dtpDateNaissance.Value;
                        gardien.Poids = float.Parse(txtPoids.Text);
                        gardien.Taille = float.Parse(txtTaille.Text);
                        gardien.Numero = Convert.ToInt16(numUpDownNumero.Value);
                        gardien.Cote = comboBoxCote.Text;
                        Classe_statique.listGardiens.Add(gardien);
                        MessageBox.Show("Gardien ajouter avec succès!", "Succès");
                        ClearChamps();
                    }                
                }
                
            }
            else if (comboBoxPosition.Text == "Attaquant" || comboBoxPosition.Text == "Défenseur")
            {
                if (VérificationChamps())
                {
                    Joueurs_avant obj = null;
                    foreach (Joueurs_avant joue in Classe_statique.listJoueurs)
                    {
                        if (joue.Code_Joueur == txtAjoutCode_joueur.Text)
                        {
                            MessageBox.Show("Un joueur avec ce code existe déja", "Error");
                            obj = joue;
                        }
                    }
                    if (obj == null)
                    {
                        Joueurs_avant joueur = new Joueurs_avant();
                        joueur.Code_Joueur = txtAjoutCode_joueur.Text;
                        joueur.Nom_Joueur = txtNomJoueur.Text;
                        joueur.Prenom_Joueur = txtPrenomJoueur.Text;
                        joueur.Date_naissance = dtpDateNaissance.Value;
                        joueur.Poids = float.Parse(txtPoids.Text);
                        joueur.Taille = float.Parse(txtTaille.Text);
                        joueur.Numero = Convert.ToInt16(numUpDownNumero.Value);
                        joueur.Cote = comboBoxCote.Text;
                        Classe_statique.listJoueurs.Add(joueur);
                        MessageBox.Show("Joueur ajouter avec succès!", "Succès");
                        ClearChamps();
                    }            
                }          
            }            
        }
    }
}
