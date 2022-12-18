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

namespace GestionEquipeHockey.Formulaires
{
    public partial class FormParent : Form
    {
        public FormParent()
        {
            InitializeComponent();
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formulaires.FormSupprimer f = new Formulaires.FormSupprimer();
            f.MdiParent = this;
            f.Show();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void afficherInformationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formulaires.FormAffichage f = new Formulaires.FormAffichage();
            f.MdiParent = this;
            f.Show();
        }

        private void joueursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formulaires.FormAjouterJoueurs f = new Formulaires.FormAjouterJoueurs();
            f.MdiParent = this;
            f.Show();
        }

        private void contratsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formulaires.FormAjouterContrats f = new Formulaires.FormAjouterContrats();
            f.MdiParent = this;
            f.Show();
        }

        private void sauvegarderToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void modifierJoueursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formulaires.FormModifierJoueurs f = new Formulaires.FormModifierJoueurs();
            f.MdiParent = this;
            f.Show();
        }

        private void modifierGardiensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formulaires.FormModifierGardiens f = new Formulaires.FormModifierGardiens();
            f.MdiParent = this;
            f.Show();
        }

        private void modifierContratsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formulaires.FormModifierContrats f = new Formulaires.FormModifierContrats();
            f.MdiParent = this;
            f.Show();
        }

        private void sauvegarderToolStripMenuItem2_Click(object sender, EventArgs e)
        {
         
        }

        private void FormParent_Load(object sender, EventArgs e)
        {

        }
    }
}
