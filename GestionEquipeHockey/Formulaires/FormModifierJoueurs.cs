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
    public partial class FormModifierJoueurs : Form
    {
        public FormModifierJoueurs()
        {
            InitializeComponent();
        }

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
    
        private void lblTitreModifierJoueurs_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public void Modifsupprimer(string numero)
        {
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

            // Vérifier si le poids et la taille du joueur sont de type float
            // Sinon Message d'erreur



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

        public void ModifJoueur(string code)
        {
            Joueurs_avant obj = null;
            foreach (Joueurs_avant joueur in Classe_statique.listJoueurs)
            {
                if (joueur.Code_Joueur == code)
                {
                    obj = joueur;
                    btnModifier.Enabled = true;
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

        private void FormModifierJoueurs_Load(object sender, EventArgs e)
        {
            btnModifier.Enabled = false;
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (comboBoxPosition.Text == "Gardien")
            {
                if (VérificationChampsModif())
                {
                   

                    Gardiens_but gardien = new Gardiens_but();
                    gardien.Code_Joueur = txtCode_joueur.Text;
                    gardien.Nom_Joueur = txtNomJoueur.Text;
                    gardien.Prenom_Joueur = txtPrenomJoueur.Text;
                    gardien.Date_naissance = dtpDateNaissance.Value;
                    gardien.Poids = float.Parse(txtPoids.Text);
                    gardien.Taille = float.Parse(txtTaille.Text);
                    gardien.Numero = Convert.ToInt16(numUpDownNumero.Value);
                    gardien.Cote = comboBoxCote.Text;
                    Classe_statique.listGardiens.Add(gardien);
                    ClearChamps();

                }

            }
            else if (comboBoxPosition.Text == "Attaquant" || comboBoxPosition.Text == "Défenseur")
            {
                if (VérificationChampsModif())
                {
                    Modifsupprimer(txtCode_joueur.Text);

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
    }
    }

