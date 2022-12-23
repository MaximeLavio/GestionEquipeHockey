namespace GestionEquipeHockey.Formulaires
{
    partial class FormAfficherContrats
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSauvegarderContrat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.lblTitreJoueurs = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpFinContrat = new System.Windows.Forms.DateTimePicker();
            this.dtpDebutContrat = new System.Windows.Forms.DateTimePicker();
            this.txtMontantAnnuel = new System.Windows.Forms.TextBox();
            this.txtNumContrat = new System.Windows.Forms.TextBox();
            this.lblDebutContrat = new System.Windows.Forms.Label();
            this.lblFinContrat = new System.Windows.Forms.Label();
            this.lblMontantAnnuel = new System.Windows.Forms.Label();
            this.lblNumContrat = new System.Windows.Forms.Label();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCode_joueur = new System.Windows.Forms.TextBox();
            this.lblTitreContrats = new System.Windows.Forms.Label();
            this.btnContinuer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRecherche = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodeJoueurRecherche = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRechercherCodeJoueur = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSauvegarderContrat
            // 
            this.btnSauvegarderContrat.Location = new System.Drawing.Point(116, 586);
            this.btnSauvegarderContrat.Name = "btnSauvegarderContrat";
            this.btnSauvegarderContrat.Size = new System.Drawing.Size(199, 29);
            this.btnSauvegarderContrat.TabIndex = 81;
            this.btnSauvegarderContrat.Text = "Sauvegarder modification";
            this.btnSauvegarderContrat.UseVisualStyleBackColor = true;
            this.btnSauvegarderContrat.Click += new System.EventHandler(this.btnSauvegarderContrat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 50);
            this.label1.TabIndex = 79;
            this.label1.Text = "Rechercher par numéro de contrat\r\n\r\n";
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(607, 91);
            this.btnRechercher.Margin = new System.Windows.Forms.Padding(4);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(117, 27);
            this.btnRechercher.TabIndex = 78;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // lblTitreJoueurs
            // 
            this.lblTitreJoueurs.AutoSize = true;
            this.lblTitreJoueurs.Location = new System.Drawing.Point(-69, 164);
            this.lblTitreJoueurs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitreJoueurs.Name = "lblTitreJoueurs";
            this.lblTitreJoueurs.Size = new System.Drawing.Size(55, 16);
            this.lblTitreJoueurs.TabIndex = 77;
            this.lblTitreJoueurs.Text = "Joueurs";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(116, 265);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(607, 290);
            this.dataGridView2.TabIndex = 76;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.dtpFinContrat);
            this.panel1.Controls.Add(this.dtpDebutContrat);
            this.panel1.Controls.Add(this.txtMontantAnnuel);
            this.panel1.Controls.Add(this.txtNumContrat);
            this.panel1.Controls.Add(this.lblDebutContrat);
            this.panel1.Controls.Add(this.lblFinContrat);
            this.panel1.Controls.Add(this.lblMontantAnnuel);
            this.panel1.Controls.Add(this.lblNumContrat);
            this.panel1.Controls.Add(this.btnSupprimer);
            this.panel1.Controls.Add(this.btnModifier);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(932, 205);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 486);
            this.panel1.TabIndex = 75;
            // 
            // dtpFinContrat
            // 
            this.dtpFinContrat.Location = new System.Drawing.Point(144, 191);
            this.dtpFinContrat.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFinContrat.Name = "dtpFinContrat";
            this.dtpFinContrat.Size = new System.Drawing.Size(200, 22);
            this.dtpFinContrat.TabIndex = 78;
            // 
            // dtpDebutContrat
            // 
            this.dtpDebutContrat.Location = new System.Drawing.Point(144, 146);
            this.dtpDebutContrat.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDebutContrat.Name = "dtpDebutContrat";
            this.dtpDebutContrat.Size = new System.Drawing.Size(200, 22);
            this.dtpDebutContrat.TabIndex = 77;
            // 
            // txtMontantAnnuel
            // 
            this.txtMontantAnnuel.Location = new System.Drawing.Point(144, 232);
            this.txtMontantAnnuel.Margin = new System.Windows.Forms.Padding(4);
            this.txtMontantAnnuel.Name = "txtMontantAnnuel";
            this.txtMontantAnnuel.Size = new System.Drawing.Size(200, 22);
            this.txtMontantAnnuel.TabIndex = 76;
            // 
            // txtNumContrat
            // 
            this.txtNumContrat.Location = new System.Drawing.Point(144, 100);
            this.txtNumContrat.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumContrat.Name = "txtNumContrat";
            this.txtNumContrat.Size = new System.Drawing.Size(200, 22);
            this.txtNumContrat.TabIndex = 75;
            // 
            // lblDebutContrat
            // 
            this.lblDebutContrat.AutoSize = true;
            this.lblDebutContrat.Location = new System.Drawing.Point(21, 146);
            this.lblDebutContrat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDebutContrat.Name = "lblDebutContrat";
            this.lblDebutContrat.Size = new System.Drawing.Size(104, 16);
            this.lblDebutContrat.TabIndex = 74;
            this.lblDebutContrat.Text = "Début du contrat";
            // 
            // lblFinContrat
            // 
            this.lblFinContrat.AutoSize = true;
            this.lblFinContrat.Location = new System.Drawing.Point(21, 191);
            this.lblFinContrat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFinContrat.Name = "lblFinContrat";
            this.lblFinContrat.Size = new System.Drawing.Size(86, 16);
            this.lblFinContrat.TabIndex = 73;
            this.lblFinContrat.Text = "Fin du contrat";
            // 
            // lblMontantAnnuel
            // 
            this.lblMontantAnnuel.AutoSize = true;
            this.lblMontantAnnuel.Location = new System.Drawing.Point(21, 232);
            this.lblMontantAnnuel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMontantAnnuel.Name = "lblMontantAnnuel";
            this.lblMontantAnnuel.Size = new System.Drawing.Size(97, 16);
            this.lblMontantAnnuel.TabIndex = 72;
            this.lblMontantAnnuel.Text = "Montant annuel";
            // 
            // lblNumContrat
            // 
            this.lblNumContrat.AutoSize = true;
            this.lblNumContrat.Location = new System.Drawing.Point(21, 100);
            this.lblNumContrat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumContrat.Name = "lblNumContrat";
            this.lblNumContrat.Size = new System.Drawing.Size(116, 16);
            this.lblNumContrat.TabIndex = 71;
            this.lblNumContrat.Text = "Numéro du contrat";
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(132, 362);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(4);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(121, 28);
            this.btnSupprimer.TabIndex = 70;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(132, 303);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(4);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(121, 28);
            this.btnModifier.TabIndex = 43;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 25);
            this.label2.TabIndex = 59;
            this.label2.Text = "Informations sur le contrat";
            // 
            // txtCode_joueur
            // 
            this.txtCode_joueur.Location = new System.Drawing.Point(1054, 116);
            this.txtCode_joueur.Margin = new System.Windows.Forms.Padding(4);
            this.txtCode_joueur.Name = "txtCode_joueur";
            this.txtCode_joueur.Size = new System.Drawing.Size(200, 22);
            this.txtCode_joueur.TabIndex = 74;
            // 
            // lblTitreContrats
            // 
            this.lblTitreContrats.AutoSize = true;
            this.lblTitreContrats.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreContrats.Location = new System.Drawing.Point(904, 49);
            this.lblTitreContrats.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitreContrats.Name = "lblTitreContrats";
            this.lblTitreContrats.Size = new System.Drawing.Size(504, 39);
            this.lblTitreContrats.TabIndex = 72;
            this.lblTitreContrats.Text = "Modifier ou supprimer un contrat";
            // 
            // btnContinuer
            // 
            this.btnContinuer.Location = new System.Drawing.Point(1262, 113);
            this.btnContinuer.Margin = new System.Windows.Forms.Padding(4);
            this.btnContinuer.Name = "btnContinuer";
            this.btnContinuer.Size = new System.Drawing.Size(100, 28);
            this.btnContinuer.TabIndex = 83;
            this.btnContinuer.Text = "Continuer";
            this.btnContinuer.UseVisualStyleBackColor = true;
            this.btnContinuer.Click += new System.EventHandler(this.btnContinuer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 234);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 84;
            this.label3.Text = "Contrats";
            // 
            // txtRecherche
            // 
            this.txtRecherche.Location = new System.Drawing.Point(442, 91);
            this.txtRecherche.Margin = new System.Windows.Forms.Padding(4);
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(151, 22);
            this.txtRecherche.TabIndex = 85;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(112, 160);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(279, 75);
            this.label4.TabIndex = 86;
            this.label4.Text = "Rechercher par code de joueur\r\n\r\n\r\n";
            // 
            // txtCodeJoueurRecherche
            // 
            this.txtCodeJoueurRecherche.Location = new System.Drawing.Point(442, 166);
            this.txtCodeJoueurRecherche.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodeJoueurRecherche.Name = "txtCodeJoueurRecherche";
            this.txtCodeJoueurRecherche.Size = new System.Drawing.Size(151, 22);
            this.txtCodeJoueurRecherche.TabIndex = 87;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Orange;
            this.label5.Location = new System.Drawing.Point(953, 142);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(336, 16);
            this.label5.TabIndex = 95;
            this.label5.Text = "**Pour la supression seulement entrer le code du joueur";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Orange;
            this.label6.Location = new System.Drawing.Point(113, 618);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(520, 16);
            this.label6.TabIndex = 96;
            this.label6.Text = "** Ne pas oublier de sauvegarder pour garder vos ajouts,modifications ou supressi" +
    "ons";
            // 
            // btnRechercherCodeJoueur
            // 
            this.btnRechercherCodeJoueur.Location = new System.Drawing.Point(607, 163);
            this.btnRechercherCodeJoueur.Margin = new System.Windows.Forms.Padding(4);
            this.btnRechercherCodeJoueur.Name = "btnRechercherCodeJoueur";
            this.btnRechercherCodeJoueur.Size = new System.Drawing.Size(117, 25);
            this.btnRechercherCodeJoueur.TabIndex = 97;
            this.btnRechercherCodeJoueur.Text = "Rechercher";
            this.btnRechercherCodeJoueur.UseVisualStyleBackColor = true;
            this.btnRechercherCodeJoueur.Click += new System.EventHandler(this.btnRechercherCodeJoueur_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(948, 118);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 16);
            this.label7.TabIndex = 79;
            this.label7.Text = "Code du joueur";
            // 
            // FormAfficherContrats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1497, 797);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnRechercherCodeJoueur);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCodeJoueurRecherche);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRecherche);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnContinuer);
            this.Controls.Add(this.btnSauvegarderContrat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRechercher);
            this.Controls.Add(this.lblTitreJoueurs);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtCode_joueur);
            this.Controls.Add(this.lblTitreContrats);
            this.Name = "FormAfficherContrats";
            this.Text = "Afficher et Modifier les informations d\'un contrat";
            this.Load += new System.EventHandler(this.FormAfficherContrats_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSauvegarderContrat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.Label lblTitreJoueurs;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCode_joueur;
        private System.Windows.Forms.Label lblTitreContrats;
        private System.Windows.Forms.Button btnContinuer;
        private System.Windows.Forms.DateTimePicker dtpFinContrat;
        private System.Windows.Forms.DateTimePicker dtpDebutContrat;
        private System.Windows.Forms.TextBox txtMontantAnnuel;
        private System.Windows.Forms.TextBox txtNumContrat;
        private System.Windows.Forms.Label lblDebutContrat;
        private System.Windows.Forms.Label lblFinContrat;
        private System.Windows.Forms.Label lblMontantAnnuel;
        private System.Windows.Forms.Label lblNumContrat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRecherche;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodeJoueurRecherche;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRechercherCodeJoueur;
        private System.Windows.Forms.Label label7;
    }
}