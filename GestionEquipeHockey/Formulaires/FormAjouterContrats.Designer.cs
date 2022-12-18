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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnContinuer = new System.Windows.Forms.Button();
            this.lblNumContrat = new System.Windows.Forms.Label();
            this.lblMontantAnnuel = new System.Windows.Forms.Label();
            this.lblFinContrat = new System.Windows.Forms.Label();
            this.lblDebutContrat = new System.Windows.Forms.Label();
            this.txtNumContrat = new System.Windows.Forms.TextBox();
            this.txtMontantAnnuel = new System.Windows.Forms.TextBox();
            this.dtpDebutContrat = new System.Windows.Forms.DateTimePicker();
            this.dtpFinContrat = new System.Windows.Forms.DateTimePicker();
            this.btnConfirmerContrat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitreAjouterContrats
            // 
            this.lblTitreAjouterContrats.AutoSize = true;
            this.lblTitreAjouterContrats.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreAjouterContrats.Location = new System.Drawing.Point(200, 44);
            this.lblTitreAjouterContrats.Name = "lblTitreAjouterContrats";
            this.lblTitreAjouterContrats.Size = new System.Drawing.Size(372, 31);
            this.lblTitreAjouterContrats.TabIndex = 8;
            this.lblTitreAjouterContrats.Text = "Donner un contrat à un joueur";
            this.lblTitreAjouterContrats.Click += new System.EventHandler(this.lblTitreAjouterJoueurs_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Code du joueur à qui donner le contrat";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(368, 101);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 20);
            this.textBox1.TabIndex = 10;
            // 
            // btnContinuer
            // 
            this.btnContinuer.Location = new System.Drawing.Point(543, 100);
            this.btnContinuer.Name = "btnContinuer";
            this.btnContinuer.Size = new System.Drawing.Size(75, 23);
            this.btnContinuer.TabIndex = 11;
            this.btnContinuer.Text = "Continuer";
            this.btnContinuer.UseVisualStyleBackColor = true;
            // 
            // lblNumContrat
            // 
            this.lblNumContrat.AutoSize = true;
            this.lblNumContrat.Location = new System.Drawing.Point(276, 192);
            this.lblNumContrat.Name = "lblNumContrat";
            this.lblNumContrat.Size = new System.Drawing.Size(95, 13);
            this.lblNumContrat.TabIndex = 12;
            this.lblNumContrat.Text = "Numéro du contrat";
            this.lblNumContrat.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblMontantAnnuel
            // 
            this.lblMontantAnnuel.AutoSize = true;
            this.lblMontantAnnuel.Location = new System.Drawing.Point(276, 299);
            this.lblMontantAnnuel.Name = "lblMontantAnnuel";
            this.lblMontantAnnuel.Size = new System.Drawing.Size(81, 13);
            this.lblMontantAnnuel.TabIndex = 13;
            this.lblMontantAnnuel.Text = "Montant annuel";
            this.lblMontantAnnuel.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblFinContrat
            // 
            this.lblFinContrat.AutoSize = true;
            this.lblFinContrat.Location = new System.Drawing.Point(276, 266);
            this.lblFinContrat.Name = "lblFinContrat";
            this.lblFinContrat.Size = new System.Drawing.Size(72, 13);
            this.lblFinContrat.TabIndex = 14;
            this.lblFinContrat.Text = "Fin du contrat";
            // 
            // lblDebutContrat
            // 
            this.lblDebutContrat.AutoSize = true;
            this.lblDebutContrat.Location = new System.Drawing.Point(276, 229);
            this.lblDebutContrat.Name = "lblDebutContrat";
            this.lblDebutContrat.Size = new System.Drawing.Size(87, 13);
            this.lblDebutContrat.TabIndex = 15;
            this.lblDebutContrat.Text = "Début du contrat";
            // 
            // txtNumContrat
            // 
            this.txtNumContrat.Location = new System.Drawing.Point(368, 192);
            this.txtNumContrat.Name = "txtNumContrat";
            this.txtNumContrat.Size = new System.Drawing.Size(151, 20);
            this.txtNumContrat.TabIndex = 17;
            // 
            // txtMontantAnnuel
            // 
            this.txtMontantAnnuel.Location = new System.Drawing.Point(368, 299);
            this.txtMontantAnnuel.Name = "txtMontantAnnuel";
            this.txtMontantAnnuel.Size = new System.Drawing.Size(151, 20);
            this.txtMontantAnnuel.TabIndex = 18;
            // 
            // dtpDebutContrat
            // 
            this.dtpDebutContrat.Location = new System.Drawing.Point(368, 229);
            this.dtpDebutContrat.Name = "dtpDebutContrat";
            this.dtpDebutContrat.Size = new System.Drawing.Size(151, 20);
            this.dtpDebutContrat.TabIndex = 19;
            // 
            // dtpFinContrat
            // 
            this.dtpFinContrat.Location = new System.Drawing.Point(368, 266);
            this.dtpFinContrat.Name = "dtpFinContrat";
            this.dtpFinContrat.Size = new System.Drawing.Size(151, 20);
            this.dtpFinContrat.TabIndex = 20;
            // 
            // btnConfirmerContrat
            // 
            this.btnConfirmerContrat.Location = new System.Drawing.Point(404, 347);
            this.btnConfirmerContrat.Name = "btnConfirmerContrat";
            this.btnConfirmerContrat.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmerContrat.TabIndex = 21;
            this.btnConfirmerContrat.Text = "Confirmer";
            this.btnConfirmerContrat.UseVisualStyleBackColor = true;
            // 
            // FormAjouterContrats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConfirmerContrat);
            this.Controls.Add(this.dtpFinContrat);
            this.Controls.Add(this.dtpDebutContrat);
            this.Controls.Add(this.txtMontantAnnuel);
            this.Controls.Add(this.txtNumContrat);
            this.Controls.Add(this.lblDebutContrat);
            this.Controls.Add(this.lblFinContrat);
            this.Controls.Add(this.lblMontantAnnuel);
            this.Controls.Add(this.lblNumContrat);
            this.Controls.Add(this.btnContinuer);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitreAjouterContrats);
            this.Name = "FormAjouterContrats";
            this.Text = "Ajouter des contrats";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitreAjouterContrats;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnContinuer;
        private System.Windows.Forms.Label lblNumContrat;
        private System.Windows.Forms.Label lblMontantAnnuel;
        private System.Windows.Forms.Label lblFinContrat;
        private System.Windows.Forms.Label lblDebutContrat;
        private System.Windows.Forms.TextBox txtNumContrat;
        private System.Windows.Forms.TextBox txtMontantAnnuel;
        private System.Windows.Forms.DateTimePicker dtpDebutContrat;
        private System.Windows.Forms.DateTimePicker dtpFinContrat;
        private System.Windows.Forms.Button btnConfirmerContrat;
    }
}