namespace GestionEquipeHockey.Formulaires
{
    partial class FormAjouterContrats
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
            this.lblTitreAjouterContrats = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCode_joueur = new System.Windows.Forms.TextBox();
            this.btnCodeJoueurContinuer = new System.Windows.Forms.Button();
            this.lblNumContrat = new System.Windows.Forms.Label();
            this.lblMontantAnnuel = new System.Windows.Forms.Label();
            this.lblFinContrat = new System.Windows.Forms.Label();
            this.lblDebutContrat = new System.Windows.Forms.Label();
            this.txtNumContrat = new System.Windows.Forms.TextBox();
            this.txtMontantAnnuel = new System.Windows.Forms.TextBox();
            this.dtpDebutContrat = new System.Windows.Forms.DateTimePicker();
            this.dtpFinContrat = new System.Windows.Forms.DateTimePicker();
            this.btnConfirmerContrat = new System.Windows.Forms.Button();
            this.checkJoueurs = new System.Windows.Forms.CheckBox();
            this.checkGardiens = new System.Windows.Forms.CheckBox();
            this.btnCodeGardiensContinuer = new System.Windows.Forms.Button();
            this.txtCode_gardien = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTitreAjouterContrats
            // 
            this.lblTitreAjouterContrats.AutoSize = true;
            this.lblTitreAjouterContrats.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreAjouterContrats.Location = new System.Drawing.Point(471, 132);
            this.lblTitreAjouterContrats.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitreAjouterContrats.Name = "lblTitreAjouterContrats";
            this.lblTitreAjouterContrats.Size = new System.Drawing.Size(467, 39);
            this.lblTitreAjouterContrats.TabIndex = 8;
            this.lblTitreAjouterContrats.Text = "Donner un contrat à un joueur";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(489, 210);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(454, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "**Entrer le code du joueur ou du gardien à qui vous voulez donner un contrat";
            // 
            // txtCode_joueur
            // 
            this.txtCode_joueur.Location = new System.Drawing.Point(594, 241);
            this.txtCode_joueur.Margin = new System.Windows.Forms.Padding(4);
            this.txtCode_joueur.Name = "txtCode_joueur";
            this.txtCode_joueur.Size = new System.Drawing.Size(200, 22);
            this.txtCode_joueur.TabIndex = 10;
            // 
            // btnCodeJoueurContinuer
            // 
            this.btnCodeJoueurContinuer.Location = new System.Drawing.Point(812, 238);
            this.btnCodeJoueurContinuer.Margin = new System.Windows.Forms.Padding(4);
            this.btnCodeJoueurContinuer.Name = "btnCodeJoueurContinuer";
            this.btnCodeJoueurContinuer.Size = new System.Drawing.Size(100, 28);
            this.btnCodeJoueurContinuer.TabIndex = 11;
            this.btnCodeJoueurContinuer.Text = "Continuer";
            this.btnCodeJoueurContinuer.UseVisualStyleBackColor = true;
            this.btnCodeJoueurContinuer.Click += new System.EventHandler(this.btnCodeJoueurContinuer_Click);
            // 
            // lblNumContrat
            // 
            this.lblNumContrat.AutoSize = true;
            this.lblNumContrat.Location = new System.Drawing.Point(520, 374);
            this.lblNumContrat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumContrat.Name = "lblNumContrat";
            this.lblNumContrat.Size = new System.Drawing.Size(116, 16);
            this.lblNumContrat.TabIndex = 12;
            this.lblNumContrat.Text = "Numéro du contrat";
            // 
            // lblMontantAnnuel
            // 
            this.lblMontantAnnuel.AutoSize = true;
            this.lblMontantAnnuel.Location = new System.Drawing.Point(520, 506);
            this.lblMontantAnnuel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMontantAnnuel.Name = "lblMontantAnnuel";
            this.lblMontantAnnuel.Size = new System.Drawing.Size(97, 16);
            this.lblMontantAnnuel.TabIndex = 13;
            this.lblMontantAnnuel.Text = "Montant annuel";
            // 
            // lblFinContrat
            // 
            this.lblFinContrat.AutoSize = true;
            this.lblFinContrat.Location = new System.Drawing.Point(520, 465);
            this.lblFinContrat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFinContrat.Name = "lblFinContrat";
            this.lblFinContrat.Size = new System.Drawing.Size(86, 16);
            this.lblFinContrat.TabIndex = 14;
            this.lblFinContrat.Text = "Fin du contrat";
            // 
            // lblDebutContrat
            // 
            this.lblDebutContrat.AutoSize = true;
            this.lblDebutContrat.Location = new System.Drawing.Point(520, 420);
            this.lblDebutContrat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDebutContrat.Name = "lblDebutContrat";
            this.lblDebutContrat.Size = new System.Drawing.Size(104, 16);
            this.lblDebutContrat.TabIndex = 15;
            this.lblDebutContrat.Text = "Début du contrat";
            // 
            // txtNumContrat
            // 
            this.txtNumContrat.Location = new System.Drawing.Point(643, 374);
            this.txtNumContrat.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumContrat.Name = "txtNumContrat";
            this.txtNumContrat.Size = new System.Drawing.Size(200, 22);
            this.txtNumContrat.TabIndex = 17;
            // 
            // txtMontantAnnuel
            // 
            this.txtMontantAnnuel.Location = new System.Drawing.Point(643, 506);
            this.txtMontantAnnuel.Margin = new System.Windows.Forms.Padding(4);
            this.txtMontantAnnuel.Name = "txtMontantAnnuel";
            this.txtMontantAnnuel.Size = new System.Drawing.Size(200, 22);
            this.txtMontantAnnuel.TabIndex = 18;
            // 
            // dtpDebutContrat
            // 
            this.dtpDebutContrat.Location = new System.Drawing.Point(643, 420);
            this.dtpDebutContrat.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDebutContrat.Name = "dtpDebutContrat";
            this.dtpDebutContrat.Size = new System.Drawing.Size(200, 22);
            this.dtpDebutContrat.TabIndex = 19;
            // 
            // dtpFinContrat
            // 
            this.dtpFinContrat.Location = new System.Drawing.Point(643, 465);
            this.dtpFinContrat.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFinContrat.Name = "dtpFinContrat";
            this.dtpFinContrat.Size = new System.Drawing.Size(200, 22);
            this.dtpFinContrat.TabIndex = 20;
            // 
            // btnConfirmerContrat
            // 
            this.btnConfirmerContrat.Location = new System.Drawing.Point(689, 565);
            this.btnConfirmerContrat.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirmerContrat.Name = "btnConfirmerContrat";
            this.btnConfirmerContrat.Size = new System.Drawing.Size(100, 28);
            this.btnConfirmerContrat.TabIndex = 21;
            this.btnConfirmerContrat.Text = "Confirmer";
            this.btnConfirmerContrat.UseVisualStyleBackColor = true;
            this.btnConfirmerContrat.Click += new System.EventHandler(this.btnConfirmerContrat_Click);
            // 
            // checkJoueurs
            // 
            this.checkJoueurs.AutoSize = true;
            this.checkJoueurs.Location = new System.Drawing.Point(492, 243);
            this.checkJoueurs.Name = "checkJoueurs";
            this.checkJoueurs.Size = new System.Drawing.Size(77, 20);
            this.checkJoueurs.TabIndex = 22;
            this.checkJoueurs.Text = "Joueurs";
            this.checkJoueurs.UseVisualStyleBackColor = true;
            this.checkJoueurs.CheckedChanged += new System.EventHandler(this.checkJoueurs_CheckedChanged);
            // 
            // checkGardiens
            // 
            this.checkGardiens.AutoSize = true;
            this.checkGardiens.Location = new System.Drawing.Point(492, 284);
            this.checkGardiens.Name = "checkGardiens";
            this.checkGardiens.Size = new System.Drawing.Size(84, 20);
            this.checkGardiens.TabIndex = 23;
            this.checkGardiens.Text = "Gardiens";
            this.checkGardiens.UseVisualStyleBackColor = true;
            this.checkGardiens.CheckedChanged += new System.EventHandler(this.checkGardiens_CheckedChanged);
            // 
            // btnCodeGardiensContinuer
            // 
            this.btnCodeGardiensContinuer.Location = new System.Drawing.Point(812, 281);
            this.btnCodeGardiensContinuer.Margin = new System.Windows.Forms.Padding(4);
            this.btnCodeGardiensContinuer.Name = "btnCodeGardiensContinuer";
            this.btnCodeGardiensContinuer.Size = new System.Drawing.Size(100, 28);
            this.btnCodeGardiensContinuer.TabIndex = 25;
            this.btnCodeGardiensContinuer.Text = "Continuer";
            this.btnCodeGardiensContinuer.UseVisualStyleBackColor = true;
            this.btnCodeGardiensContinuer.Click += new System.EventHandler(this.btnCodeGardiensContinuer_Click);
            // 
            // txtCode_gardien
            // 
            this.txtCode_gardien.Location = new System.Drawing.Point(594, 284);
            this.txtCode_gardien.Margin = new System.Windows.Forms.Padding(4);
            this.txtCode_gardien.Name = "txtCode_gardien";
            this.txtCode_gardien.Size = new System.Drawing.Size(200, 22);
            this.txtCode_gardien.TabIndex = 24;
            // 
            // FormAjouterContrats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1367, 683);
            this.Controls.Add(this.btnCodeGardiensContinuer);
            this.Controls.Add(this.txtCode_gardien);
            this.Controls.Add(this.checkGardiens);
            this.Controls.Add(this.checkJoueurs);
            this.Controls.Add(this.btnConfirmerContrat);
            this.Controls.Add(this.dtpFinContrat);
            this.Controls.Add(this.dtpDebutContrat);
            this.Controls.Add(this.txtMontantAnnuel);
            this.Controls.Add(this.txtNumContrat);
            this.Controls.Add(this.lblDebutContrat);
            this.Controls.Add(this.lblFinContrat);
            this.Controls.Add(this.lblMontantAnnuel);
            this.Controls.Add(this.lblNumContrat);
            this.Controls.Add(this.btnCodeJoueurContinuer);
            this.Controls.Add(this.txtCode_joueur);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitreAjouterContrats);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAjouterContrats";
            this.Text = "Ajouter des contrats";
            this.Load += new System.EventHandler(this.FormAjouterContrats_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitreAjouterContrats;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCode_joueur;
        private System.Windows.Forms.Button btnCodeJoueurContinuer;
        private System.Windows.Forms.Label lblNumContrat;
        private System.Windows.Forms.Label lblMontantAnnuel;
        private System.Windows.Forms.Label lblFinContrat;
        private System.Windows.Forms.Label lblDebutContrat;
        private System.Windows.Forms.TextBox txtNumContrat;
        private System.Windows.Forms.TextBox txtMontantAnnuel;
        private System.Windows.Forms.DateTimePicker dtpDebutContrat;
        private System.Windows.Forms.DateTimePicker dtpFinContrat;
        private System.Windows.Forms.Button btnConfirmerContrat;
        private System.Windows.Forms.CheckBox checkJoueurs;
        private System.Windows.Forms.CheckBox checkGardiens;
        private System.Windows.Forms.Button btnCodeGardiensContinuer;
        private System.Windows.Forms.TextBox txtCode_gardien;
    }
}