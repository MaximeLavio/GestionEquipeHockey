namespace GestionEquipeHockey.Formulaires
{
    partial class FormAffichage
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.lblTitreGardiens = new System.Windows.Forms.Label();
            this.lblTitreJoueurs = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSauvegarderGardiens = new System.Windows.Forms.Button();
            this.btnSauvegarderJoueurs = new System.Windows.Forms.Button();
            this.btnActualiser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 45);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(607, 290);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(858, 76);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Afficher";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(657, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rechercher par catégorie";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Contrat",
            "Points",
            "Position",
            "Buts ",
            "Age"});
            this.comboBox1.Location = new System.Drawing.Point(660, 76);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 3;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(24, 426);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(607, 290);
            this.dataGridView2.TabIndex = 4;
            // 
            // lblTitreGardiens
            // 
            this.lblTitreGardiens.AutoSize = true;
            this.lblTitreGardiens.Location = new System.Drawing.Point(33, 25);
            this.lblTitreGardiens.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitreGardiens.Name = "lblTitreGardiens";
            this.lblTitreGardiens.Size = new System.Drawing.Size(62, 16);
            this.lblTitreGardiens.TabIndex = 5;
            this.lblTitreGardiens.Text = "Gardiens";
            // 
            // lblTitreJoueurs
            // 
            this.lblTitreJoueurs.AutoSize = true;
            this.lblTitreJoueurs.Location = new System.Drawing.Point(21, 396);
            this.lblTitreJoueurs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitreJoueurs.Name = "lblTitreJoueurs";
            this.lblTitreJoueurs.Size = new System.Drawing.Size(55, 16);
            this.lblTitreJoueurs.TabIndex = 6;
            this.lblTitreJoueurs.Text = "Joueurs";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Contrat",
            "Points",
            "Position",
            "Buts ",
            "Age"});
            this.comboBox2.Location = new System.Drawing.Point(660, 452);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(160, 24);
            this.comboBox2.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(657, 426);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Rechercher par catégorie";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(849, 446);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 30);
            this.button2.TabIndex = 7;
            this.button2.Text = "Afficher";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnSauvegarderGardiens
            // 
            this.btnSauvegarderGardiens.Location = new System.Drawing.Point(991, 76);
            this.btnSauvegarderGardiens.Name = "btnSauvegarderGardiens";
            this.btnSauvegarderGardiens.Size = new System.Drawing.Size(199, 30);
            this.btnSauvegarderGardiens.TabIndex = 10;
            this.btnSauvegarderGardiens.Text = "Sauvegarder modification";
            this.btnSauvegarderGardiens.UseVisualStyleBackColor = true;
            this.btnSauvegarderGardiens.Click += new System.EventHandler(this.btnSauvegarderGardiens_Click);
            // 
            // btnSauvegarderJoueurs
            // 
            this.btnSauvegarderJoueurs.Location = new System.Drawing.Point(991, 446);
            this.btnSauvegarderJoueurs.Name = "btnSauvegarderJoueurs";
            this.btnSauvegarderJoueurs.Size = new System.Drawing.Size(199, 30);
            this.btnSauvegarderJoueurs.TabIndex = 12;
            this.btnSauvegarderJoueurs.Text = "Sauvegarder modification";
            this.btnSauvegarderJoueurs.UseVisualStyleBackColor = true;
            this.btnSauvegarderJoueurs.Click += new System.EventHandler(this.btnSauvegarderJoueurs_Click);
            // 
            // btnActualiser
            // 
            this.btnActualiser.Location = new System.Drawing.Point(858, 128);
            this.btnActualiser.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualiser.Name = "btnActualiser";
            this.btnActualiser.Size = new System.Drawing.Size(117, 30);
            this.btnActualiser.TabIndex = 13;
            this.btnActualiser.Text = "Actualiser";
            this.btnActualiser.UseVisualStyleBackColor = true;
            this.btnActualiser.Click += new System.EventHandler(this.btnActualiser_Click);
            // 
            // FormAffichage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1486, 729);
            this.Controls.Add(this.btnActualiser);
            this.Controls.Add(this.btnSauvegarderJoueurs);
            this.Controls.Add(this.btnSauvegarderGardiens);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblTitreJoueurs);
            this.Controls.Add(this.lblTitreGardiens);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAffichage";
            this.Text = "Informations sur l\'équipe";
            this.Load += new System.EventHandler(this.FormAffichage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label lblTitreGardiens;
        private System.Windows.Forms.Label lblTitreJoueurs;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSauvegarderGardiens;
        private System.Windows.Forms.Button btnSauvegarderJoueurs;
        private System.Windows.Forms.Button btnActualiser;
    }
}