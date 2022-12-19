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
    public partial class FormAjouterContrats : Form
    {
        public FormAjouterContrats()
        {
            InitializeComponent();
        }

        public void ClearChamps()
        {
            txtNumContrat.Text = "";
            dtpDebutContrat.Text = "";
            dtpFinContrat.Text = "";
            txtMontantAnnuel.Text = "";
        }


        public void VerifCode(string code)
        {
            Gardiens_but obj = null;
            foreach (Gardiens_but gardien in Classe_statique.listGardiens)
            {
                if (gardien.Code_Joueur == code)
                {
                    obj = gardien;
                    btnConfirmerContrat.Enabled = true;
                }
            }
            Joueurs_avant joue = null;
            foreach (Joueurs_avant joueur in Classe_statique.listJoueurs)
            {
                if (joueur.Code_Joueur == code)
                {
                    joue = joueur;
                    btnConfirmerContrat.Enabled = true;
                }
            }
            if (joue == null && obj == null)
            {
                MessageBox.Show("Le code joueur n'existe pas", "Error");
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
                VerifCode(txtCode_joueur.Text);
            }
            else
            {
                MessageBox.Show("Le code du joueur doit être composé de 5 chiffres.", "Error");
            }
        }

        private void FormAjouterContrats_Load(object sender, EventArgs e)
        {
            btnConfirmerContrat.Enabled = false;



        }

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
            if (valid)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        private void btnConfirmerContrat_Click(object sender, EventArgs e)
        {
            if (VérificationChamps())
            {
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
    }
}
