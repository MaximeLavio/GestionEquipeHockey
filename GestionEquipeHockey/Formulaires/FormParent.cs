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

        /// <summary>
        /// Lors du click sur ce bouton envoie au formulaire Pour ajouter des joueurs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void joueursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formulaires.FormAjouterJoueurs f = new Formulaires.FormAjouterJoueurs();
            f.MdiParent = this;
            f.Show();
        }

        /// <summary>
        /// Lors du click sur ce bouton envoie au formulaire Pour ajouter des contrats
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void contratsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formulaires.FormAjouterContrats f = new Formulaires.FormAjouterContrats();
            f.MdiParent = this;
            f.Show();
        }

        /// <summary>
        /// Lors du click sur ce bouton envoie au formulaire Pour afficher les contrats
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void contratsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Formulaires.FormAfficherContrats f = new Formulaires.FormAfficherContrats();
            f.MdiParent = this;
            f.Show();
        }

        /// <summary>
        /// Lors du click sur ce bouton envoie au formulaire Pour afficher des joueurs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void joueursToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Formulaires.FormAfficherJoueurs f = new Formulaires.FormAfficherJoueurs();
            f.MdiParent = this;
            f.Show();
        }

        /// <summary>
        /// Lors du click sur ce bouton envoie au formulaire Pour afficher des gardiens
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gardiensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formulaires.FormAfficherGardiens f = new Formulaires.FormAfficherGardiens();
            f.MdiParent = this;
            f.Show();
        }
    }
}
