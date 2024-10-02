namespace YosraMezgar
{
    partial class Modifier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modifier));
            this.panel1 = new System.Windows.Forms.Panel();
            this.List_type_LIVRE = new System.Windows.Forms.ListBox();
            this.TxT_EDITEUR = new System.Windows.Forms.TextBox();
            this.TxT_annee_sorti = new System.Windows.Forms.TextBox();
            this.TxT_AUTEUR = new System.Windows.Forms.TextBox();
            this.TxT_titre = new System.Windows.Forms.TextBox();
            this.TxT_ISBN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.btn_modifier = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.List_type_LIVRE);
            this.panel1.Controls.Add(this.TxT_EDITEUR);
            this.panel1.Controls.Add(this.TxT_annee_sorti);
            this.panel1.Controls.Add(this.TxT_AUTEUR);
            this.panel1.Controls.Add(this.TxT_titre);
            this.panel1.Controls.Add(this.TxT_ISBN);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(27, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 361);
            this.panel1.TabIndex = 2;
            // 
            // List_type_LIVRE
            // 
            this.List_type_LIVRE.FormattingEnabled = true;
            this.List_type_LIVRE.Items.AddRange(new object[] {
            "Roman",
            "Action",
            "Comedie",
            "Horreur"});
            this.List_type_LIVRE.Location = new System.Drawing.Point(191, 263);
            this.List_type_LIVRE.Name = "List_type_LIVRE";
            this.List_type_LIVRE.Size = new System.Drawing.Size(266, 17);
            this.List_type_LIVRE.TabIndex = 12;
            // 
            // TxT_EDITEUR
            // 
            this.TxT_EDITEUR.Location = new System.Drawing.Point(191, 308);
            this.TxT_EDITEUR.Name = "TxT_EDITEUR";
            this.TxT_EDITEUR.Size = new System.Drawing.Size(266, 20);
            this.TxT_EDITEUR.TabIndex = 11;
            // 
            // TxT_annee_sorti
            // 
            this.TxT_annee_sorti.Location = new System.Drawing.Point(191, 213);
            this.TxT_annee_sorti.Name = "TxT_annee_sorti";
            this.TxT_annee_sorti.Size = new System.Drawing.Size(266, 20);
            this.TxT_annee_sorti.TabIndex = 9;
            // 
            // TxT_AUTEUR
            // 
            this.TxT_AUTEUR.Location = new System.Drawing.Point(191, 162);
            this.TxT_AUTEUR.Name = "TxT_AUTEUR";
            this.TxT_AUTEUR.Size = new System.Drawing.Size(266, 20);
            this.TxT_AUTEUR.TabIndex = 8;
            // 
            // TxT_titre
            // 
            this.TxT_titre.Location = new System.Drawing.Point(191, 106);
            this.TxT_titre.Name = "TxT_titre";
            this.TxT_titre.Size = new System.Drawing.Size(266, 20);
            this.TxT_titre.TabIndex = 7;
            // 
            // TxT_ISBN
            // 
            this.TxT_ISBN.Location = new System.Drawing.Point(191, 57);
            this.TxT_ISBN.Name = "TxT_ISBN";
            this.TxT_ISBN.Size = new System.Drawing.Size(266, 20);
            this.TxT_ISBN.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(50, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Editeur";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Type de livre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Année de sortie";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Auteur";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Titre de livre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ISBN";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_annuler);
            this.panel2.Controls.Add(this.btn_modifier);
            this.panel2.Location = new System.Drawing.Point(594, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(180, 360);
            this.panel2.TabIndex = 3;
            // 
            // btn_annuler
            // 
            this.btn_annuler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_annuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_annuler.Image = ((System.Drawing.Image)(resources.GetObject("btn_annuler.Image")));
            this.btn_annuler.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_annuler.Location = new System.Drawing.Point(30, 169);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(125, 48);
            this.btn_annuler.TabIndex = 1;
            this.btn_annuler.Text = "Annuler";
            this.btn_annuler.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_annuler.UseVisualStyleBackColor = false;
            // 
            // btn_modifier
            // 
            this.btn_modifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_modifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modifier.Image = ((System.Drawing.Image)(resources.GetObject("btn_modifier.Image")));
            this.btn_modifier.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_modifier.Location = new System.Drawing.Point(30, 91);
            this.btn_modifier.Name = "btn_modifier";
            this.btn_modifier.Size = new System.Drawing.Size(125, 50);
            this.btn_modifier.TabIndex = 0;
            this.btn_modifier.Text = "Modifier";
            this.btn_modifier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_modifier.UseVisualStyleBackColor = false;
            this.btn_modifier.Click += new System.EventHandler(this.btn_modifier_Click);
            // 
            // Modifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Modifier";
            this.Text = "Modifier";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_annuler;
        private System.Windows.Forms.Button btn_modifier;
        public System.Windows.Forms.ListBox List_type_LIVRE;
        public System.Windows.Forms.TextBox TxT_EDITEUR;
        public System.Windows.Forms.TextBox TxT_annee_sorti;
        public System.Windows.Forms.TextBox TxT_AUTEUR;
        public System.Windows.Forms.TextBox TxT_titre;
        public System.Windows.Forms.TextBox TxT_ISBN;
    }
}