namespace kfImage
{
    partial class fenImage
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBlackWhite = new System.Windows.Forms.Button();
            this.btnImage = new System.Windows.Forms.Button();
            this.btnBinaire = new System.Windows.Forms.Button();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.btnRAZ = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tckLumiere = new System.Windows.Forms.TrackBar();
            this.txtPas = new System.Windows.Forms.TextBox();
            this.btnLumiere = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tckLumiere)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBlackWhite
            // 
            this.btnBlackWhite.Location = new System.Drawing.Point(38, 66);
            this.btnBlackWhite.Name = "btnBlackWhite";
            this.btnBlackWhite.Size = new System.Drawing.Size(75, 23);
            this.btnBlackWhite.TabIndex = 0;
            this.btnBlackWhite.Text = "N/B";
            this.btnBlackWhite.UseVisualStyleBackColor = true;
            this.btnBlackWhite.Click += new System.EventHandler(this.btnBlackWhite_Click);
            // 
            // btnImage
            // 
            this.btnImage.Location = new System.Drawing.Point(38, 37);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(139, 23);
            this.btnImage.TabIndex = 1;
            this.btnImage.Text = "Chargement Image";
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // btnBinaire
            // 
            this.btnBinaire.Location = new System.Drawing.Point(119, 66);
            this.btnBinaire.Name = "btnBinaire";
            this.btnBinaire.Size = new System.Drawing.Size(75, 23);
            this.btnBinaire.TabIndex = 2;
            this.btnBinaire.Text = "Binairisation";
            this.btnBinaire.UseVisualStyleBackColor = true;
            this.btnBinaire.Click += new System.EventHandler(this.btnBinaire_Click);
            // 
            // picImage
            // 
            this.picImage.Location = new System.Drawing.Point(38, 116);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(934, 667);
            this.picImage.TabIndex = 3;
            this.picImage.TabStop = false;
            // 
            // btnRAZ
            // 
            this.btnRAZ.Location = new System.Drawing.Point(201, 37);
            this.btnRAZ.Name = "btnRAZ";
            this.btnRAZ.Size = new System.Drawing.Size(75, 23);
            this.btnRAZ.TabIndex = 4;
            this.btnRAZ.Text = "RAZ";
            this.btnRAZ.UseVisualStyleBackColor = true;
            this.btnRAZ.Click += new System.EventHandler(this.btnRAZ_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(201, 65);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Sauvegarder";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tckLumiere
            // 
            this.tckLumiere.Location = new System.Drawing.Point(305, 65);
            this.tckLumiere.Maximum = 20;
            this.tckLumiere.Name = "tckLumiere";
            this.tckLumiere.Size = new System.Drawing.Size(667, 45);
            this.tckLumiere.TabIndex = 6;
            this.tckLumiere.Scroll += new System.EventHandler(this.tckLumiere_Scroll);
            // 
            // txtPas
            // 
            this.txtPas.Location = new System.Drawing.Point(305, 37);
            this.txtPas.Name = "txtPas";
            this.txtPas.Size = new System.Drawing.Size(72, 20);
            this.txtPas.TabIndex = 7;
            this.txtPas.Text = "5";
            // 
            // btnLumiere
            // 
            this.btnLumiere.Location = new System.Drawing.Point(384, 37);
            this.btnLumiere.Name = "btnLumiere";
            this.btnLumiere.Size = new System.Drawing.Size(75, 23);
            this.btnLumiere.TabIndex = 8;
            this.btnLumiere.Text = "Lumiere";
            this.btnLumiere.UseVisualStyleBackColor = true;
            this.btnLumiere.Click += new System.EventHandler(this.btnLumiere_Click);
            // 
            // fenImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 809);
            this.Controls.Add(this.btnLumiere);
            this.Controls.Add(this.txtPas);
            this.Controls.Add(this.tckLumiere);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRAZ);
            this.Controls.Add(this.picImage);
            this.Controls.Add(this.btnBinaire);
            this.Controls.Add(this.btnImage);
            this.Controls.Add(this.btnBlackWhite);
            this.Name = "fenImage";
            this.Text = "Image";
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tckLumiere)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBlackWhite;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.Button btnBinaire;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.Button btnRAZ;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TrackBar tckLumiere;
        private System.Windows.Forms.TextBox txtPas;
        private System.Windows.Forms.Button btnLumiere;
    }
}

