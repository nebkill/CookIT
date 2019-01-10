namespace CookIT
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pbBarBG = new System.Windows.Forms.PictureBox();
            this.pLoadPanel = new System.Windows.Forms.Panel();
            this.dgvVoorbeeld = new System.Windows.Forms.DataGridView();
            this.pbTray = new System.Windows.Forms.PictureBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.pbZoek = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbBarBG)).BeginInit();
            this.pLoadPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVoorbeeld)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTray)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbZoek)).BeginInit();
            this.SuspendLayout();
            // 
            // pbBarBG
            // 
            this.pbBarBG.Location = new System.Drawing.Point(0, 0);
            this.pbBarBG.Margin = new System.Windows.Forms.Padding(4);
            this.pbBarBG.Name = "pbBarBG";
            this.pbBarBG.Size = new System.Drawing.Size(1680, 62);
            this.pbBarBG.TabIndex = 0;
            this.pbBarBG.TabStop = false;
            // 
            // pLoadPanel
            // 
            this.pLoadPanel.Controls.Add(this.dgvVoorbeeld);
            this.pLoadPanel.Location = new System.Drawing.Point(0, 60);
            this.pLoadPanel.Margin = new System.Windows.Forms.Padding(4);
            this.pLoadPanel.Name = "pLoadPanel";
            this.pLoadPanel.Size = new System.Drawing.Size(1680, 775);
            this.pLoadPanel.TabIndex = 1;
            // 
            // dgvVoorbeeld
            // 
            this.dgvVoorbeeld.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVoorbeeld.Location = new System.Drawing.Point(94, 66);
            this.dgvVoorbeeld.Name = "dgvVoorbeeld";
            this.dgvVoorbeeld.RowTemplate.Height = 24;
            this.dgvVoorbeeld.Size = new System.Drawing.Size(97, 51);
            this.dgvVoorbeeld.TabIndex = 0;
            // 
            // pbTray
            // 
            this.pbTray.Image = ((System.Drawing.Image)(resources.GetObject("pbTray.Image")));
            this.pbTray.Location = new System.Drawing.Point(1623, 15);
            this.pbTray.Margin = new System.Windows.Forms.Padding(4);
            this.pbTray.Name = "pbTray";
            this.pbTray.Size = new System.Drawing.Size(47, 27);
            this.pbTray.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTray.TabIndex = 3;
            this.pbTray.TabStop = false;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(19, 6);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(57, 50);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 4;
            this.pbLogo.TabStop = false;
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(532, 12);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(560, 40);
            this.tbSearch.TabIndex = 5;
            // 
            // pbZoek
            // 
            this.pbZoek.Location = new System.Drawing.Point(1099, 12);
            this.pbZoek.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbZoek.Name = "pbZoek";
            this.pbZoek.Size = new System.Drawing.Size(89, 41);
            this.pbZoek.TabIndex = 6;
            this.pbZoek.TabStop = false;
            this.pbZoek.Click += new System.EventHandler(this.pbZoek_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1685, 838);
            this.Controls.Add(this.pbZoek);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.pbTray);
            this.Controls.Add(this.pLoadPanel);
            this.Controls.Add(this.pbBarBG);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "CookIT";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBarBG)).EndInit();
            this.pLoadPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVoorbeeld)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTray)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbZoek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBarBG;
        private System.Windows.Forms.Panel pLoadPanel;
        private System.Windows.Forms.PictureBox pbTray;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.PictureBox pbZoek;
        private System.Windows.Forms.DataGridView dgvVoorbeeld;
    }
}

