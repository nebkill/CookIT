namespace CookIT
{
    partial class Module_ReceptView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitel = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblIngr = new System.Windows.Forms.Label();
            this.lblBenod = new System.Windows.Forms.Label();
            this.lblStap = new System.Windows.Forms.Label();
            this.lblAuteur = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitel.Location = new System.Drawing.Point(39, 35);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(66, 24);
            this.lblTitel.TabIndex = 0;
            this.lblTitel.Text = "Label1";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(39, 63);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(51, 17);
            this.lblDesc.TabIndex = 1;
            this.lblDesc.Text = "Label1";
            // 
            // lblIngr
            // 
            this.lblIngr.AutoSize = true;
            this.lblIngr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngr.Location = new System.Drawing.Point(39, 138);
            this.lblIngr.Name = "lblIngr";
            this.lblIngr.Size = new System.Drawing.Size(51, 17);
            this.lblIngr.TabIndex = 2;
            this.lblIngr.Text = "Label1";
            // 
            // lblBenod
            // 
            this.lblBenod.AutoSize = true;
            this.lblBenod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBenod.Location = new System.Drawing.Point(396, 138);
            this.lblBenod.Name = "lblBenod";
            this.lblBenod.Size = new System.Drawing.Size(51, 17);
            this.lblBenod.TabIndex = 3;
            this.lblBenod.Text = "Label1";
            // 
            // lblStap
            // 
            this.lblStap.AutoSize = true;
            this.lblStap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStap.Location = new System.Drawing.Point(39, 281);
            this.lblStap.Name = "lblStap";
            this.lblStap.Size = new System.Drawing.Size(51, 17);
            this.lblStap.TabIndex = 4;
            this.lblStap.Text = "Label1";
            // 
            // lblAuteur
            // 
            this.lblAuteur.AutoSize = true;
            this.lblAuteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuteur.Location = new System.Drawing.Point(650, 35);
            this.lblAuteur.Name = "lblAuteur";
            this.lblAuteur.Size = new System.Drawing.Size(54, 17);
            this.lblAuteur.TabIndex = 5;
            this.lblAuteur.Text = "Auteur:";
            // 
            // Module_ReceptView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblAuteur);
            this.Controls.Add(this.lblStap);
            this.Controls.Add(this.lblBenod);
            this.Controls.Add(this.lblIngr);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblTitel);
            this.Name = "Module_ReceptView";
            this.Size = new System.Drawing.Size(1260, 630);
            this.Load += new System.EventHandler(this.Module_ReceptView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblIngr;
        private System.Windows.Forms.Label lblBenod;
        private System.Windows.Forms.Label lblStap;
        private System.Windows.Forms.Label lblAuteur;
    }
}
