﻿namespace GestionEquipeHockey.Formulaires
{
    partial class FormAjouterJoueurs
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
            this.lblNomJoueur = new System.Windows.Forms.Label();
            this.lblPrenomJoueur = new System.Windows.Forms.Label();
            this.lblDateNaissanceJoueur = new System.Windows.Forms.Label();
            this.lblPoids = new System.Windows.Forms.Label();
            this.lblTaille = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblCote = new System.Windows.Forms.Label();
            this.lblTitreAjouterJoueurs = new System.Windows.Forms.Label();
            this.txtNomJoueur = new System.Windows.Forms.TextBox();
            this.txtPrenomJoueur = new System.Windows.Forms.TextBox();
            this.txtPoids = new System.Windows.Forms.TextBox();
            this.txtTaille = new System.Windows.Forms.TextBox();
            this.numUpDownNumero = new System.Windows.Forms.NumericUpDown();
            this.comboBoxCote = new System.Windows.Forms.ComboBox();
            this.dtpDateNaissance = new System.Windows.Forms.DateTimePicker();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.btnAjouterJoueur = new System.Windows.Forms.Button();
            this.lblPosition = new System.Windows.Forms.Label();
            this.comboBoxPosition = new System.Windows.Forms.ComboBox();
            this.lblCode_joueur = new System.Windows.Forms.Label();
            this.txtAjoutCode_joueur = new System.Windows.Forms.TextBox();
            this.lblMessageReussi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownNumero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomJoueur
            // 
            this.lblNomJoueur.AutoSize = true;
            this.lblNomJoueur.Location = new System.Drawing.Point(513, 214);
            this.lblNomJoueur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomJoueur.Name = "lblNomJoueur";
            this.lblNomJoueur.Size = new System.Drawing.Size(39, 16);
            this.lblNomJoueur.TabIndex = 0;
            this.lblNomJoueur.Text = "Nom ";
            // 
            // lblPrenomJoueur
            // 
            this.lblPrenomJoueur.AutoSize = true;
            this.lblPrenomJoueur.Location = new System.Drawing.Point(516, 258);
            this.lblPrenomJoueur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrenomJoueur.Name = "lblPrenomJoueur";
            this.lblPrenomJoueur.Size = new System.Drawing.Size(54, 16);
            this.lblPrenomJoueur.TabIndex = 1;
            this.lblPrenomJoueur.Text = "Prénom";
            // 
            // lblDateNaissanceJoueur
            // 
            this.lblDateNaissanceJoueur.AutoSize = true;
            this.lblDateNaissanceJoueur.Location = new System.Drawing.Point(516, 306);
            this.lblDateNaissanceJoueur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateNaissanceJoueur.Name = "lblDateNaissanceJoueur";
            this.lblDateNaissanceJoueur.Size = new System.Drawing.Size(120, 16);
            this.lblDateNaissanceJoueur.TabIndex = 2;
            this.lblDateNaissanceJoueur.Text = "Date de naissance";
            // 
            // lblPoids
            // 
            this.lblPoids.AutoSize = true;
            this.lblPoids.Location = new System.Drawing.Point(516, 352);
            this.lblPoids.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPoids.Name = "lblPoids";
            this.lblPoids.Size = new System.Drawing.Size(71, 16);
            this.lblPoids.TabIndex = 3;
            this.lblPoids.Text = "Poids (lbs)";
            // 
            // lblTaille
            // 
            this.lblTaille.AutoSize = true;
            this.lblTaille.Location = new System.Drawing.Point(516, 398);
            this.lblTaille.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTaille.Name = "lblTaille";
            this.lblTaille.Size = new System.Drawing.Size(44, 16);
            this.lblTaille.TabIndex = 4;
            this.lblTaille.Text = "Taille ";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(516, 449);
            this.lblNumero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(55, 16);
            this.lblNumero.TabIndex = 5;
            this.lblNumero.Text = "Numéro";
            // 
            // lblCote
            // 
            this.lblCote.AutoSize = true;
            this.lblCote.Location = new System.Drawing.Point(513, 494);
            this.lblCote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCote.Name = "lblCote";
            this.lblCote.Size = new System.Drawing.Size(78, 16);
            this.lblCote.TabIndex = 6;
            this.lblCote.Text = "Coté naturel";
            // 
            // lblTitreAjouterJoueurs
            // 
            this.lblTitreAjouterJoueurs.AutoSize = true;
            this.lblTitreAjouterJoueurs.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreAjouterJoueurs.Location = new System.Drawing.Point(464, 63);
            this.lblTitreAjouterJoueurs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitreAjouterJoueurs.Name = "lblTitreAjouterJoueurs";
            this.lblTitreAjouterJoueurs.Size = new System.Drawing.Size(430, 39);
            this.lblTitreAjouterJoueurs.TabIndex = 7;
            this.lblTitreAjouterJoueurs.Text = "Ajouter un joueur à l\'équipe";
            // 
            // txtNomJoueur
            // 
            this.txtNomJoueur.Location = new System.Drawing.Point(669, 210);
            this.txtNomJoueur.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomJoueur.Name = "txtNomJoueur";
            this.txtNomJoueur.Size = new System.Drawing.Size(188, 22);
            this.txtNomJoueur.TabIndex = 8;
            // 
            // txtPrenomJoueur
            // 
            this.txtPrenomJoueur.Location = new System.Drawing.Point(669, 253);
            this.txtPrenomJoueur.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrenomJoueur.Name = "txtPrenomJoueur";
            this.txtPrenomJoueur.Size = new System.Drawing.Size(188, 22);
            this.txtPrenomJoueur.TabIndex = 9;
            // 
            // txtPoids
            // 
            this.txtPoids.Location = new System.Drawing.Point(669, 347);
            this.txtPoids.Margin = new System.Windows.Forms.Padding(4);
            this.txtPoids.Name = "txtPoids";
            this.txtPoids.Size = new System.Drawing.Size(188, 22);
            this.txtPoids.TabIndex = 10;
            // 
            // txtTaille
            // 
            this.txtTaille.Location = new System.Drawing.Point(669, 395);
            this.txtTaille.Margin = new System.Windows.Forms.Padding(4);
            this.txtTaille.Name = "txtTaille";
            this.txtTaille.Size = new System.Drawing.Size(188, 22);
            this.txtTaille.TabIndex = 11;
            // 
            // numUpDownNumero
            // 
            this.numUpDownNumero.Location = new System.Drawing.Point(669, 445);
            this.numUpDownNumero.Margin = new System.Windows.Forms.Padding(4);
            this.numUpDownNumero.Name = "numUpDownNumero";
            this.numUpDownNumero.Size = new System.Drawing.Size(189, 22);
            this.numUpDownNumero.TabIndex = 12;
            // 
            // comboBoxCote
            // 
            this.comboBoxCote.FormattingEnabled = true;
            this.comboBoxCote.Items.AddRange(new object[] {
            "Droitier",
            "Gaucher"});
            this.comboBoxCote.Location = new System.Drawing.Point(669, 489);
            this.comboBoxCote.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxCote.Name = "comboBoxCote";
            this.comboBoxCote.Size = new System.Drawing.Size(188, 24);
            this.comboBoxCote.TabIndex = 13;
            // 
            // dtpDateNaissance
            // 
            this.dtpDateNaissance.Location = new System.Drawing.Point(669, 301);
            this.dtpDateNaissance.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDateNaissance.Name = "dtpDateNaissance";
            this.dtpDateNaissance.Size = new System.Drawing.Size(188, 22);
            this.dtpDateNaissance.TabIndex = 14;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // btnAjouterJoueur
            // 
            this.btnAjouterJoueur.Location = new System.Drawing.Point(697, 589);
            this.btnAjouterJoueur.Margin = new System.Windows.Forms.Padding(4);
            this.btnAjouterJoueur.Name = "btnAjouterJoueur";
            this.btnAjouterJoueur.Size = new System.Drawing.Size(143, 28);
            this.btnAjouterJoueur.TabIndex = 15;
            this.btnAjouterJoueur.Text = "Ajouter";
            this.btnAjouterJoueur.UseVisualStyleBackColor = true;
            this.btnAjouterJoueur.Click += new System.EventHandler(this.btnAjouterJoueur_Click);
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(513, 541);
            this.lblPosition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(55, 16);
            this.lblPosition.TabIndex = 16;
            this.lblPosition.Text = "Position";
            // 
            // comboBoxPosition
            // 
            this.comboBoxPosition.FormattingEnabled = true;
            this.comboBoxPosition.Items.AddRange(new object[] {
            "Attaquant",
            "Défenseur",
            "Gardien"});
            this.comboBoxPosition.Location = new System.Drawing.Point(669, 536);
            this.comboBoxPosition.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxPosition.Name = "comboBoxPosition";
            this.comboBoxPosition.Size = new System.Drawing.Size(188, 24);
            this.comboBoxPosition.TabIndex = 17;
            // 
            // lblCode_joueur
            // 
            this.lblCode_joueur.AutoSize = true;
            this.lblCode_joueur.Location = new System.Drawing.Point(513, 172);
            this.lblCode_joueur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCode_joueur.Name = "lblCode_joueur";
            this.lblCode_joueur.Size = new System.Drawing.Size(80, 16);
            this.lblCode_joueur.TabIndex = 18;
            this.lblCode_joueur.Text = "Code joueur";
            // 
            // txtAjoutCode_joueur
            // 
            this.txtAjoutCode_joueur.Location = new System.Drawing.Point(670, 172);
            this.txtAjoutCode_joueur.Margin = new System.Windows.Forms.Padding(4);
            this.txtAjoutCode_joueur.Name = "txtAjoutCode_joueur";
            this.txtAjoutCode_joueur.Size = new System.Drawing.Size(188, 22);
            this.txtAjoutCode_joueur.TabIndex = 19;
            // 
            // lblMessageReussi
            // 
            this.lblMessageReussi.AutoSize = true;
            this.lblMessageReussi.Location = new System.Drawing.Point(878, 601);
            this.lblMessageReussi.Name = "lblMessageReussi";
            this.lblMessageReussi.Size = new System.Drawing.Size(0, 16);
            this.lblMessageReussi.TabIndex = 20;
            // 
            // FormAjouterJoueurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1351, 700);
            this.Controls.Add(this.lblMessageReussi);
            this.Controls.Add(this.txtAjoutCode_joueur);
            this.Controls.Add(this.lblCode_joueur);
            this.Controls.Add(this.comboBoxPosition);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.btnAjouterJoueur);
            this.Controls.Add(this.dtpDateNaissance);
            this.Controls.Add(this.comboBoxCote);
            this.Controls.Add(this.numUpDownNumero);
            this.Controls.Add(this.txtTaille);
            this.Controls.Add(this.txtPoids);
            this.Controls.Add(this.txtPrenomJoueur);
            this.Controls.Add(this.txtNomJoueur);
            this.Controls.Add(this.lblTitreAjouterJoueurs);
            this.Controls.Add(this.lblCote);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblTaille);
            this.Controls.Add(this.lblPoids);
            this.Controls.Add(this.lblDateNaissanceJoueur);
            this.Controls.Add(this.lblPrenomJoueur);
            this.Controls.Add(this.lblNomJoueur);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAjouterJoueurs";
            this.Text = "Ajouter des joueurs";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownNumero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomJoueur;
        private System.Windows.Forms.Label lblPrenomJoueur;
        private System.Windows.Forms.Label lblDateNaissanceJoueur;
        private System.Windows.Forms.Label lblPoids;
        private System.Windows.Forms.Label lblTaille;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblCote;
        private System.Windows.Forms.Label lblTitreAjouterJoueurs;
        private System.Windows.Forms.TextBox txtNomJoueur;
        private System.Windows.Forms.TextBox txtPrenomJoueur;
        private System.Windows.Forms.TextBox txtPoids;
        private System.Windows.Forms.TextBox txtTaille;
        private System.Windows.Forms.NumericUpDown numUpDownNumero;
        private System.Windows.Forms.ComboBox comboBoxCote;
        private System.Windows.Forms.DateTimePicker dtpDateNaissance;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button btnAjouterJoueur;
        private System.Windows.Forms.ComboBox comboBoxPosition;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.TextBox txtAjoutCode_joueur;
        private System.Windows.Forms.Label lblCode_joueur;
        private System.Windows.Forms.Label lblMessageReussi;
    }
}