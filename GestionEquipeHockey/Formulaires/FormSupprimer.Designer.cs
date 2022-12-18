namespace GestionEquipeHockey.Formulaires
{
    partial class FormSupprimer
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitreModifierJoueurs
            // 
            this.lblTitreModifierJoueurs.AutoSize = true;
            this.lblTitreModifierJoueurs.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitreModifierJoueurs.Location = new System.Drawing.Point(203, 119);
            this.lblTitreModifierJoueurs.Name = "lblTitreModifierJoueurs";
            this.lblTitreModifierJoueurs.Size = new System.Drawing.Size(393, 31);
            this.lblTitreModifierJoueurs.TabIndex = 9;
            this.lblTitreModifierJoueurs.Text = "Supprimer un joueur de l\'équipe";
            // 
            // btnContinuer
            // 
            this.btnContinuer.Location = new System.Drawing.Point(507, 190);
            this.btnContinuer.Name = "btnContinuer";
            this.btnContinuer.Size = new System.Drawing.Size(75, 23);
            this.btnContinuer.TabIndex = 17;
            this.btnContinuer.Text = "Continuer";
            this.btnContinuer.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(332, 191);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 20);
            this.textBox1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(191, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Code du joueur à supprimer";
            // 
            // FormSupprimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnContinuer);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitreModifierJoueurs);
            this.Name = "FormSupprimer";
            this.Text = "Supprimer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitreModifierJoueurs;
        private System.Windows.Forms.Button btnContinuer;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}