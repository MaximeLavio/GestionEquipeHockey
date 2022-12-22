namespace GestionEquipeHockey.Formulaires
{
    partial class FormAfficherJoueurs
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
            this.lblTitreJoueurs = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnSauvegarderJoueurs = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lblTitreModifierJoueurs = new System.Windows.Forms.Label();
            this.lblCode = new System.Windows.Forms.Label();
            this.txtCode_joueur = new System.Windows.Forms.TextBox();
            this.btnContinuer = new System.Windows.Forms.Button();
            this.lblNomJoueur = new System.Windows.Forms.Label();
            this.lblPrenomJoueur = new System.Windows.Forms.Label();
            this.lblDateNaissanceJoueur = new System.Windows.Forms.Label();
            this.lblPoids = new System.Windows.Forms.Label();
            this.lblTaille = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblCote = new System.Windows.Forms.Label();
            this.txtNomJoueur = new System.Windows.Forms.TextBox();
            this.txtPrenomJoueur = new System.Windows.Forms.TextBox();
            this.txtPoids = new System.Windows.Forms.TextBox();
            this.txtTaille = new System.Windows.Forms.TextBox();
            this.numUpDownNumero = new System.Windows.Forms.NumericUpDown();
            this.comboBoxCote = new System.Windows.Forms.ComboBox();
            this.dtpDateNaissance = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNb_matchs = new System.Windows.Forms.TextBox();
            this.txtMises_echec = new System.Windows.Forms.TextBox();
            this.txtNb_passes = new System.Windows.Forms.TextBox();
            this.txtMinutes_punitions = new System.Windows.Forms.TextBox();
            this.txtNb_buts = new System.Windows.Forms.TextBox();
            this.btnModifier = new System.Windows.Forms.Button();
            this.lblPosition = new System.Windows.Forms.Label();
            this.comboBoxPosition = new System.Windows.Forms.ComboBox();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownNumero)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitreJoueurs
            // 
            this.lblTitreJoueurs.AutoSize = true;
            this.lblTitreJoueurs.Location = new System.Drawing.Point(26, 138);
            this.lblTitreJoueurs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitreJoueurs.Name = "lblTitreJoueurs";
            this.lblTitreJoueurs.Size = new System.Drawing.Size(55, 16);
            this.lblTitreJoueurs.TabIndex = 44;
            this.lblTitreJoueurs.Text = "Joueurs";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(29, 168);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(607, 290);
            this.dataGridView2.TabIndex = 43;
            // 
            // btnSauvegarderJoueurs
            // 
            this.btnSauvegarderJoueurs.BackColor = System.Drawing.Color.Transparent;
            this.btnSauvegarderJoueurs.Location = new System.Drawing.Point(29, 481);
            this.btnSauvegarderJoueurs.Name = "btnSauvegarderJoueurs";
            this.btnSauvegarderJoueurs.Size = new System.Drawing.Size(199, 29);
            this.btnSauvegarderJoueurs.TabIndex = 48;
            this.btnSauvegarderJoueurs.Text = "Sauvegarder modification";
            this.btnSauvegarderJoueurs.UseVisualStyleBackColor = false;
            this.btnSauvegarderJoueurs.Click += new System.EventHandler(this.btnSauvegarderJoueurs_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Joueur avec le plus de buts",
            "Joueur avec le plus de mises en échec"});
            this.comboBox2.Location = new System.Drawing.Point(402, 51);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(194, 24);
            this.comboBox2.TabIndex = 47;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(443, 83);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 30);
            this.button2.TabIndex = 45;
            this.button2.Text = "Afficher";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // lblTitreModifierJoueurs
            // 
            this.lblTitreModifierJoueurs.AutoSize = true;
            this.lblTitreModifierJoueurs.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreModifierJoueurs.Location = new System.Drawing.Point(793, 35);
            this.lblTitreModifierJoueurs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitreModifierJoueurs.Name = "lblTitreModifierJoueurs";
            this.lblTitreModifierJoueurs.Size = new System.Drawing.Size(669, 39);
            this.lblTitreModifierJoueurs.TabIndex = 8;
            this.lblTitreModifierJoueurs.Text = "Modifier ou supprimer un joueur de l\'équipe";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(883, 102);
            this.lblCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(98, 16);
            this.lblCode.TabIndex = 12;
            this.lblCode.Text = "Code du joueur";
            // 
            // txtCode_joueur
            // 
            this.txtCode_joueur.Location = new System.Drawing.Point(1021, 99);
            this.txtCode_joueur.Margin = new System.Windows.Forms.Padding(4);
            this.txtCode_joueur.Name = "txtCode_joueur";
            this.txtCode_joueur.Size = new System.Drawing.Size(200, 22);
            this.txtCode_joueur.TabIndex = 13;
            // 
            // btnContinuer
            // 
            this.btnContinuer.Location = new System.Drawing.Point(1254, 98);
            this.btnContinuer.Margin = new System.Windows.Forms.Padding(4);
            this.btnContinuer.Name = "btnContinuer";
            this.btnContinuer.Size = new System.Drawing.Size(100, 28);
            this.btnContinuer.TabIndex = 14;
            this.btnContinuer.Text = "Continuer";
            this.btnContinuer.UseVisualStyleBackColor = true;
            this.btnContinuer.Click += new System.EventHandler(this.btnContinuer_Click);
            // 
            // lblNomJoueur
            // 
            this.lblNomJoueur.AutoSize = true;
            this.lblNomJoueur.Location = new System.Drawing.Point(18, 100);
            this.lblNomJoueur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomJoueur.Name = "lblNomJoueur";
            this.lblNomJoueur.Size = new System.Drawing.Size(39, 16);
            this.lblNomJoueur.TabIndex = 42;
            this.lblNomJoueur.Text = "Nom ";
            // 
            // lblPrenomJoueur
            // 
            this.lblPrenomJoueur.AutoSize = true;
            this.lblPrenomJoueur.Location = new System.Drawing.Point(21, 144);
            this.lblPrenomJoueur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrenomJoueur.Name = "lblPrenomJoueur";
            this.lblPrenomJoueur.Size = new System.Drawing.Size(54, 16);
            this.lblPrenomJoueur.TabIndex = 44;
            this.lblPrenomJoueur.Text = "Prénom";
            // 
            // lblDateNaissanceJoueur
            // 
            this.lblDateNaissanceJoueur.AutoSize = true;
            this.lblDateNaissanceJoueur.Location = new System.Drawing.Point(21, 192);
            this.lblDateNaissanceJoueur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateNaissanceJoueur.Name = "lblDateNaissanceJoueur";
            this.lblDateNaissanceJoueur.Size = new System.Drawing.Size(120, 16);
            this.lblDateNaissanceJoueur.TabIndex = 45;
            this.lblDateNaissanceJoueur.Text = "Date de naissance";
            // 
            // lblPoids
            // 
            this.lblPoids.AutoSize = true;
            this.lblPoids.Location = new System.Drawing.Point(21, 238);
            this.lblPoids.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPoids.Name = "lblPoids";
            this.lblPoids.Size = new System.Drawing.Size(71, 16);
            this.lblPoids.TabIndex = 47;
            this.lblPoids.Text = "Poids (lbs)";
            // 
            // lblTaille
            // 
            this.lblTaille.AutoSize = true;
            this.lblTaille.Location = new System.Drawing.Point(21, 285);
            this.lblTaille.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTaille.Name = "lblTaille";
            this.lblTaille.Size = new System.Drawing.Size(44, 16);
            this.lblTaille.TabIndex = 49;
            this.lblTaille.Text = "Taille ";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(21, 335);
            this.lblNumero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(55, 16);
            this.lblNumero.TabIndex = 50;
            this.lblNumero.Text = "Numéro";
            // 
            // lblCote
            // 
            this.lblCote.AutoSize = true;
            this.lblCote.Location = new System.Drawing.Point(18, 381);
            this.lblCote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCote.Name = "lblCote";
            this.lblCote.Size = new System.Drawing.Size(78, 16);
            this.lblCote.TabIndex = 51;
            this.lblCote.Text = "Coté naturel";
            // 
            // txtNomJoueur
            // 
            this.txtNomJoueur.Location = new System.Drawing.Point(174, 96);
            this.txtNomJoueur.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomJoueur.Name = "txtNomJoueur";
            this.txtNomJoueur.Size = new System.Drawing.Size(188, 22);
            this.txtNomJoueur.TabIndex = 52;
            // 
            // txtPrenomJoueur
            // 
            this.txtPrenomJoueur.Location = new System.Drawing.Point(174, 139);
            this.txtPrenomJoueur.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrenomJoueur.Name = "txtPrenomJoueur";
            this.txtPrenomJoueur.Size = new System.Drawing.Size(188, 22);
            this.txtPrenomJoueur.TabIndex = 53;
            // 
            // txtPoids
            // 
            this.txtPoids.Location = new System.Drawing.Point(174, 233);
            this.txtPoids.Margin = new System.Windows.Forms.Padding(4);
            this.txtPoids.Name = "txtPoids";
            this.txtPoids.Size = new System.Drawing.Size(188, 22);
            this.txtPoids.TabIndex = 54;
            // 
            // txtTaille
            // 
            this.txtTaille.Location = new System.Drawing.Point(174, 281);
            this.txtTaille.Margin = new System.Windows.Forms.Padding(4);
            this.txtTaille.Name = "txtTaille";
            this.txtTaille.Size = new System.Drawing.Size(188, 22);
            this.txtTaille.TabIndex = 55;
            // 
            // numUpDownNumero
            // 
            this.numUpDownNumero.Location = new System.Drawing.Point(174, 331);
            this.numUpDownNumero.Margin = new System.Windows.Forms.Padding(4);
            this.numUpDownNumero.Name = "numUpDownNumero";
            this.numUpDownNumero.Size = new System.Drawing.Size(189, 22);
            this.numUpDownNumero.TabIndex = 56;
            // 
            // comboBoxCote
            // 
            this.comboBoxCote.FormattingEnabled = true;
            this.comboBoxCote.Items.AddRange(new object[] {
            "Droitier",
            "Gaucher"});
            this.comboBoxCote.Location = new System.Drawing.Point(174, 376);
            this.comboBoxCote.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxCote.Name = "comboBoxCote";
            this.comboBoxCote.Size = new System.Drawing.Size(188, 24);
            this.comboBoxCote.TabIndex = 57;
            // 
            // dtpDateNaissance
            // 
            this.dtpDateNaissance.Location = new System.Drawing.Point(174, 187);
            this.dtpDateNaissance.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDateNaissance.Name = "dtpDateNaissance";
            this.dtpDateNaissance.Size = new System.Drawing.Size(188, 22);
            this.dtpDateNaissance.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 25);
            this.label2.TabIndex = 59;
            this.label2.Text = "Informations sur le joueur";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(394, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 25);
            this.label3.TabIndex = 60;
            this.label3.Text = "Statistiques du joueur";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(396, 139);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 16);
            this.label4.TabIndex = 61;
            this.label4.Text = "Minutes de punitions";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(397, 224);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 16);
            this.label9.TabIndex = 43;
            this.label9.Text = "Nombre de passes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(396, 96);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 16);
            this.label5.TabIndex = 62;
            this.label5.Text = "Nombre de matches";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(397, 187);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 16);
            this.label8.TabIndex = 46;
            this.label8.Text = "Nombre de buts";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(395, 258);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(172, 16);
            this.label10.TabIndex = 48;
            this.label10.Text = "Nombre de mises en échec";
            // 
            // txtNb_matchs
            // 
            this.txtNb_matchs.Location = new System.Drawing.Point(597, 88);
            this.txtNb_matchs.Margin = new System.Windows.Forms.Padding(4);
            this.txtNb_matchs.Name = "txtNb_matchs";
            this.txtNb_matchs.Size = new System.Drawing.Size(188, 22);
            this.txtNb_matchs.TabIndex = 63;
            // 
            // txtMises_echec
            // 
            this.txtMises_echec.Location = new System.Drawing.Point(597, 258);
            this.txtMises_echec.Margin = new System.Windows.Forms.Padding(4);
            this.txtMises_echec.Name = "txtMises_echec";
            this.txtMises_echec.Size = new System.Drawing.Size(188, 22);
            this.txtMises_echec.TabIndex = 67;
            // 
            // txtNb_passes
            // 
            this.txtNb_passes.Location = new System.Drawing.Point(597, 216);
            this.txtNb_passes.Margin = new System.Windows.Forms.Padding(4);
            this.txtNb_passes.Name = "txtNb_passes";
            this.txtNb_passes.Size = new System.Drawing.Size(188, 22);
            this.txtNb_passes.TabIndex = 66;
            // 
            // txtMinutes_punitions
            // 
            this.txtMinutes_punitions.Location = new System.Drawing.Point(597, 139);
            this.txtMinutes_punitions.Margin = new System.Windows.Forms.Padding(4);
            this.txtMinutes_punitions.Name = "txtMinutes_punitions";
            this.txtMinutes_punitions.Size = new System.Drawing.Size(188, 22);
            this.txtMinutes_punitions.TabIndex = 64;
            // 
            // txtNb_buts
            // 
            this.txtNb_buts.Location = new System.Drawing.Point(597, 179);
            this.txtNb_buts.Margin = new System.Windows.Forms.Padding(4);
            this.txtNb_buts.Name = "txtNb_buts";
            this.txtNb_buts.Size = new System.Drawing.Size(188, 22);
            this.txtNb_buts.TabIndex = 65;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(509, 313);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(4);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(121, 28);
            this.btnModifier.TabIndex = 43;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(19, 429);
            this.lblPosition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(55, 16);
            this.lblPosition.TabIndex = 68;
            this.lblPosition.Text = "Position";
            // 
            // comboBoxPosition
            // 
            this.comboBoxPosition.FormattingEnabled = true;
            this.comboBoxPosition.Items.AddRange(new object[] {
            "Attaquant",
            "Défenseur"});
            this.comboBoxPosition.Location = new System.Drawing.Point(175, 424);
            this.comboBoxPosition.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxPosition.Name = "comboBoxPosition";
            this.comboBoxPosition.Size = new System.Drawing.Size(188, 24);
            this.comboBoxPosition.TabIndex = 69;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(509, 372);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(4);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(121, 28);
            this.btnSupprimer.TabIndex = 70;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnSupprimer);
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
            this.panel1.Location = new System.Drawing.Point(727, 168);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 486);
            this.panel1.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 25);
            this.label1.TabIndex = 91;
            this.label1.Text = "Rechercher dans la table par catégorie";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Orange;
            this.label6.Location = new System.Drawing.Point(888, 125);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(336, 16);
            this.label6.TabIndex = 95;
            this.label6.Text = "**Pour la supression seulement entrer le code du joueur";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Orange;
            this.label7.Location = new System.Drawing.Point(31, 513);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(520, 16);
            this.label7.TabIndex = 96;
            this.label7.Text = "** Ne pas oublier de sauvegarder pour garder vos ajouts,modifications ou supressi" +
    "ons";
            // 
            // FormAfficherJoueurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1600, 758);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSauvegarderJoueurs);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblTitreJoueurs);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnContinuer);
            this.Controls.Add(this.txtCode_joueur);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.lblTitreModifierJoueurs);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAfficherJoueurs";
            this.Text = "Afficher / Modifier un joueurs";
            this.Load += new System.EventHandler(this.FormModifierJoueurs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownNumero)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitreJoueurs;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnSauvegarderJoueurs;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblTitreModifierJoueurs;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox txtCode_joueur;
        private System.Windows.Forms.Button btnContinuer;
        private System.Windows.Forms.Label lblNomJoueur;
        private System.Windows.Forms.Label lblPrenomJoueur;
        private System.Windows.Forms.Label lblDateNaissanceJoueur;
        private System.Windows.Forms.Label lblPoids;
        private System.Windows.Forms.Label lblTaille;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblCote;
        private System.Windows.Forms.TextBox txtNomJoueur;
        private System.Windows.Forms.TextBox txtPrenomJoueur;
        private System.Windows.Forms.TextBox txtPoids;
        private System.Windows.Forms.TextBox txtTaille;
        private System.Windows.Forms.NumericUpDown numUpDownNumero;
        private System.Windows.Forms.ComboBox comboBoxCote;
        private System.Windows.Forms.DateTimePicker dtpDateNaissance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNb_matchs;
        private System.Windows.Forms.TextBox txtMises_echec;
        private System.Windows.Forms.TextBox txtNb_passes;
        private System.Windows.Forms.TextBox txtMinutes_punitions;
        private System.Windows.Forms.TextBox txtNb_buts;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.ComboBox comboBoxPosition;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}