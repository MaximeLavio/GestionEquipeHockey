namespace GestionEquipeHockey.Formulaires
{
    partial class FormModifierJoueurs
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
            this.lblTitreModifierJoueurs = new System.Windows.Forms.Label();
            this.btnContinuer = new System.Windows.Forms.Button();
            this.txtCode_joueur = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNb_buts = new System.Windows.Forms.TextBox();
            this.txtMinutes_punitions = new System.Windows.Forms.TextBox();
            this.txtNb_passes = new System.Windows.Forms.TextBox();
            this.txtMises_echec = new System.Windows.Forms.TextBox();
            this.txtNb_matchs = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDateNaissance = new System.Windows.Forms.DateTimePicker();
            this.comboBoxCote = new System.Windows.Forms.ComboBox();
            this.numUpDownNumero = new System.Windows.Forms.NumericUpDown();
            this.txtTaille = new System.Windows.Forms.TextBox();
            this.txtPoids = new System.Windows.Forms.TextBox();
            this.txtPrenomJoueur = new System.Windows.Forms.TextBox();
            this.txtNomJoueur = new System.Windows.Forms.TextBox();
            this.lblCote = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblTaille = new System.Windows.Forms.Label();
            this.lblPoids = new System.Windows.Forms.Label();
            this.lblDateNaissanceJoueur = new System.Windows.Forms.Label();
            this.lblPrenomJoueur = new System.Windows.Forms.Label();
            this.lblNomJoueur = new System.Windows.Forms.Label();
            this.btnModifier = new System.Windows.Forms.Button();
            this.comboBoxPosition = new System.Windows.Forms.ComboBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownNumero)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitreModifierJoueurs
            // 
            this.lblTitreModifierJoueurs.AutoSize = true;
            this.lblTitreModifierJoueurs.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreModifierJoueurs.Location = new System.Drawing.Point(544, 64);
            this.lblTitreModifierJoueurs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitreModifierJoueurs.Name = "lblTitreModifierJoueurs";
            this.lblTitreModifierJoueurs.Size = new System.Drawing.Size(462, 39);
            this.lblTitreModifierJoueurs.TabIndex = 8;
            this.lblTitreModifierJoueurs.Text = "Modifier un joueur de l\'équipe";
            this.lblTitreModifierJoueurs.Click += new System.EventHandler(this.lblTitreModifierJoueurs_Click);
            // 
            // btnContinuer
            // 
            this.btnContinuer.Location = new System.Drawing.Point(929, 138);
            this.btnContinuer.Margin = new System.Windows.Forms.Padding(4);
            this.btnContinuer.Name = "btnContinuer";
            this.btnContinuer.Size = new System.Drawing.Size(100, 28);
            this.btnContinuer.TabIndex = 14;
            this.btnContinuer.Text = "Continuer";
            this.btnContinuer.UseVisualStyleBackColor = true;
            this.btnContinuer.Click += new System.EventHandler(this.btnContinuer_Click);
            // 
            // txtCode_joueur
            // 
            this.txtCode_joueur.Location = new System.Drawing.Point(696, 139);
            this.txtCode_joueur.Margin = new System.Windows.Forms.Padding(4);
            this.txtCode_joueur.Name = "txtCode_joueur";
            this.txtCode_joueur.Size = new System.Drawing.Size(200, 22);
            this.txtCode_joueur.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(520, 143);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Code du joueur à modifier";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBoxPosition);
            this.panel1.Controls.Add(this.lblPosition);
            this.panel1.Controls.Add(this.btnModifier);
            this.panel1.Controls.Add(this.txtNb_buts);
            this.panel1.Controls.Add(this.txtMinutes_punitions);
            this.panel1.Controls.Add(this.txtNb_passes);
            this.panel1.Controls.Add(this.txtMises_echec);
            this.panel1.Controls.Add(this.txtNb_matchs);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtpDateNaissance);
            this.panel1.Controls.Add(this.comboBoxCote);
            this.panel1.Controls.Add(this.numUpDownNumero);
            this.panel1.Controls.Add(this.txtTaille);
            this.panel1.Controls.Add(this.txtPoids);
            this.panel1.Controls.Add(this.txtPrenomJoueur);
            this.panel1.Controls.Add(this.txtNomJoueur);
            this.panel1.Controls.Add(this.lblCote);
            this.panel1.Controls.Add(this.lblNumero);
            this.panel1.Controls.Add(this.lblTaille);
            this.panel1.Controls.Add(this.lblPoids);
            this.panel1.Controls.Add(this.lblDateNaissanceJoueur);
            this.panel1.Controls.Add(this.lblPrenomJoueur);
            this.panel1.Controls.Add(this.lblNomJoueur);
            this.panel1.Location = new System.Drawing.Point(360, 173);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1116, 475);
            this.panel1.TabIndex = 42;
            // 
            // txtNb_buts
            // 
            this.txtNb_buts.Location = new System.Drawing.Point(828, 187);
            this.txtNb_buts.Margin = new System.Windows.Forms.Padding(4);
            this.txtNb_buts.Name = "txtNb_buts";
            this.txtNb_buts.Size = new System.Drawing.Size(188, 22);
            this.txtNb_buts.TabIndex = 65;
            // 
            // txtMinutes_punitions
            // 
            this.txtMinutes_punitions.Location = new System.Drawing.Point(828, 147);
            this.txtMinutes_punitions.Margin = new System.Windows.Forms.Padding(4);
            this.txtMinutes_punitions.Name = "txtMinutes_punitions";
            this.txtMinutes_punitions.Size = new System.Drawing.Size(188, 22);
            this.txtMinutes_punitions.TabIndex = 64;
            // 
            // txtNb_passes
            // 
            this.txtNb_passes.Location = new System.Drawing.Point(828, 224);
            this.txtNb_passes.Margin = new System.Windows.Forms.Padding(4);
            this.txtNb_passes.Name = "txtNb_passes";
            this.txtNb_passes.Size = new System.Drawing.Size(188, 22);
            this.txtNb_passes.TabIndex = 66;
            // 
            // txtMises_echec
            // 
            this.txtMises_echec.Location = new System.Drawing.Point(828, 266);
            this.txtMises_echec.Margin = new System.Windows.Forms.Padding(4);
            this.txtMises_echec.Name = "txtMises_echec";
            this.txtMises_echec.Size = new System.Drawing.Size(188, 22);
            this.txtMises_echec.TabIndex = 67;
            // 
            // txtNb_matchs
            // 
            this.txtNb_matchs.Location = new System.Drawing.Point(828, 96);
            this.txtNb_matchs.Margin = new System.Windows.Forms.Padding(4);
            this.txtNb_matchs.Name = "txtNb_matchs";
            this.txtNb_matchs.Size = new System.Drawing.Size(188, 22);
            this.txtNb_matchs.TabIndex = 63;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(626, 266);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(172, 16);
            this.label10.TabIndex = 48;
            this.label10.Text = "Nombre de mises en échec";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(628, 195);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 16);
            this.label8.TabIndex = 46;
            this.label8.Text = "Nombre de buts";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(627, 104);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 16);
            this.label5.TabIndex = 62;
            this.label5.Text = "Nombre de matches";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(628, 232);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 16);
            this.label9.TabIndex = 43;
            this.label9.Text = "Nombre de passes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(627, 147);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 16);
            this.label4.TabIndex = 61;
            this.label4.Text = "Minutes de punitions";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(625, 45);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 25);
            this.label3.TabIndex = 60;
            this.label3.Text = "Statistiques du joueur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(157, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 25);
            this.label2.TabIndex = 59;
            this.label2.Text = "Informations sur le joueur";
            // 
            // dtpDateNaissance
            // 
            this.dtpDateNaissance.Location = new System.Drawing.Point(312, 195);
            this.dtpDateNaissance.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDateNaissance.Name = "dtpDateNaissance";
            this.dtpDateNaissance.Size = new System.Drawing.Size(188, 22);
            this.dtpDateNaissance.TabIndex = 58;
            // 
            // comboBoxCote
            // 
            this.comboBoxCote.FormattingEnabled = true;
            this.comboBoxCote.Items.AddRange(new object[] {
            "Droitier",
            "Gaucher"});
            this.comboBoxCote.Location = new System.Drawing.Point(312, 384);
            this.comboBoxCote.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxCote.Name = "comboBoxCote";
            this.comboBoxCote.Size = new System.Drawing.Size(188, 24);
            this.comboBoxCote.TabIndex = 57;
            // 
            // numUpDownNumero
            // 
            this.numUpDownNumero.Location = new System.Drawing.Point(312, 339);
            this.numUpDownNumero.Margin = new System.Windows.Forms.Padding(4);
            this.numUpDownNumero.Name = "numUpDownNumero";
            this.numUpDownNumero.Size = new System.Drawing.Size(189, 22);
            this.numUpDownNumero.TabIndex = 56;
            // 
            // txtTaille
            // 
            this.txtTaille.Location = new System.Drawing.Point(312, 289);
            this.txtTaille.Margin = new System.Windows.Forms.Padding(4);
            this.txtTaille.Name = "txtTaille";
            this.txtTaille.Size = new System.Drawing.Size(188, 22);
            this.txtTaille.TabIndex = 55;
            // 
            // txtPoids
            // 
            this.txtPoids.Location = new System.Drawing.Point(312, 241);
            this.txtPoids.Margin = new System.Windows.Forms.Padding(4);
            this.txtPoids.Name = "txtPoids";
            this.txtPoids.Size = new System.Drawing.Size(188, 22);
            this.txtPoids.TabIndex = 54;
            // 
            // txtPrenomJoueur
            // 
            this.txtPrenomJoueur.Location = new System.Drawing.Point(312, 147);
            this.txtPrenomJoueur.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrenomJoueur.Name = "txtPrenomJoueur";
            this.txtPrenomJoueur.Size = new System.Drawing.Size(188, 22);
            this.txtPrenomJoueur.TabIndex = 53;
            // 
            // txtNomJoueur
            // 
            this.txtNomJoueur.Location = new System.Drawing.Point(312, 104);
            this.txtNomJoueur.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomJoueur.Name = "txtNomJoueur";
            this.txtNomJoueur.Size = new System.Drawing.Size(188, 22);
            this.txtNomJoueur.TabIndex = 52;
            // 
            // lblCote
            // 
            this.lblCote.AutoSize = true;
            this.lblCote.Location = new System.Drawing.Point(156, 389);
            this.lblCote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCote.Name = "lblCote";
            this.lblCote.Size = new System.Drawing.Size(78, 16);
            this.lblCote.TabIndex = 51;
            this.lblCote.Text = "Coté naturel";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(159, 343);
            this.lblNumero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(55, 16);
            this.lblNumero.TabIndex = 50;
            this.lblNumero.Text = "Numéro";
            // 
            // lblTaille
            // 
            this.lblTaille.AutoSize = true;
            this.lblTaille.Location = new System.Drawing.Point(159, 293);
            this.lblTaille.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTaille.Name = "lblTaille";
            this.lblTaille.Size = new System.Drawing.Size(44, 16);
            this.lblTaille.TabIndex = 49;
            this.lblTaille.Text = "Taille ";
            // 
            // lblPoids
            // 
            this.lblPoids.AutoSize = true;
            this.lblPoids.Location = new System.Drawing.Point(159, 246);
            this.lblPoids.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPoids.Name = "lblPoids";
            this.lblPoids.Size = new System.Drawing.Size(71, 16);
            this.lblPoids.TabIndex = 47;
            this.lblPoids.Text = "Poids (lbs)";
            // 
            // lblDateNaissanceJoueur
            // 
            this.lblDateNaissanceJoueur.AutoSize = true;
            this.lblDateNaissanceJoueur.Location = new System.Drawing.Point(159, 200);
            this.lblDateNaissanceJoueur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateNaissanceJoueur.Name = "lblDateNaissanceJoueur";
            this.lblDateNaissanceJoueur.Size = new System.Drawing.Size(120, 16);
            this.lblDateNaissanceJoueur.TabIndex = 45;
            this.lblDateNaissanceJoueur.Text = "Date de naissance";
            // 
            // lblPrenomJoueur
            // 
            this.lblPrenomJoueur.AutoSize = true;
            this.lblPrenomJoueur.Location = new System.Drawing.Point(159, 152);
            this.lblPrenomJoueur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrenomJoueur.Name = "lblPrenomJoueur";
            this.lblPrenomJoueur.Size = new System.Drawing.Size(54, 16);
            this.lblPrenomJoueur.TabIndex = 44;
            this.lblPrenomJoueur.Text = "Prénom";
            // 
            // lblNomJoueur
            // 
            this.lblNomJoueur.AutoSize = true;
            this.lblNomJoueur.Location = new System.Drawing.Point(156, 108);
            this.lblNomJoueur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomJoueur.Name = "lblNomJoueur";
            this.lblNomJoueur.Size = new System.Drawing.Size(39, 16);
            this.lblNomJoueur.TabIndex = 42;
            this.lblNomJoueur.Text = "Nom ";
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(740, 321);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(4);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(121, 28);
            this.btnModifier.TabIndex = 43;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // comboBoxPosition
            // 
            this.comboBoxPosition.FormattingEnabled = true;
            this.comboBoxPosition.Items.AddRange(new object[] {
            "Attaquant",
            "Défenseur",
            "Gardien"});
            this.comboBoxPosition.Location = new System.Drawing.Point(313, 432);
            this.comboBoxPosition.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxPosition.Name = "comboBoxPosition";
            this.comboBoxPosition.Size = new System.Drawing.Size(188, 24);
            this.comboBoxPosition.TabIndex = 69;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(157, 437);
            this.lblPosition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(55, 16);
            this.lblPosition.TabIndex = 68;
            this.lblPosition.Text = "Position";
            // 
            // FormModifierJoueurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 758);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnContinuer);
            this.Controls.Add(this.txtCode_joueur);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitreModifierJoueurs);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormModifierJoueurs";
            this.Text = "Modifier un joueur";
            this.Load += new System.EventHandler(this.FormModifierJoueurs_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownNumero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitreModifierJoueurs;
        private System.Windows.Forms.Button btnContinuer;
        private System.Windows.Forms.TextBox txtCode_joueur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNb_buts;
        private System.Windows.Forms.TextBox txtMinutes_punitions;
        private System.Windows.Forms.TextBox txtNb_passes;
        private System.Windows.Forms.TextBox txtMises_echec;
        private System.Windows.Forms.TextBox txtNb_matchs;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDateNaissance;
        private System.Windows.Forms.ComboBox comboBoxCote;
        private System.Windows.Forms.NumericUpDown numUpDownNumero;
        private System.Windows.Forms.TextBox txtTaille;
        private System.Windows.Forms.TextBox txtPoids;
        private System.Windows.Forms.TextBox txtPrenomJoueur;
        private System.Windows.Forms.TextBox txtNomJoueur;
        private System.Windows.Forms.Label lblCote;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblTaille;
        private System.Windows.Forms.Label lblPoids;
        private System.Windows.Forms.Label lblDateNaissanceJoueur;
        private System.Windows.Forms.Label lblPrenomJoueur;
        private System.Windows.Forms.Label lblNomJoueur;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.ComboBox comboBoxPosition;
        private System.Windows.Forms.Label lblPosition;
    }
}