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
            this.pbBarBG = new System.Windows.Forms.PictureBox();
            this.pLoadPanel = new System.Windows.Forms.Panel();
            this.pbTray = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbBarBG)).BeginInit();
            this.pLoadPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTray)).BeginInit();
            this.SuspendLayout();
            // 
            // pbBarBG
            // 
            this.pbBarBG.Location = new System.Drawing.Point(0, 0);
            this.pbBarBG.Name = "pbBarBG";
            this.pbBarBG.Size = new System.Drawing.Size(800, 50);
            this.pbBarBG.TabIndex = 0;
            this.pbBarBG.TabStop = false;
            // 
            // pLoadPanel
            // 
            this.pLoadPanel.Controls.Add(this.button1);
            this.pLoadPanel.Location = new System.Drawing.Point(0, 49);
            this.pLoadPanel.Name = "pLoadPanel";
            this.pLoadPanel.Size = new System.Drawing.Size(800, 401);
            this.pLoadPanel.TabIndex = 1;
            // 
            // pbTray
            // 
            this.pbTray.Location = new System.Drawing.Point(755, 12);
            this.pbTray.Name = "pbTray";
            this.pbTray.Size = new System.Drawing.Size(33, 30);
            this.pbTray.TabIndex = 3;
            this.pbTray.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(304, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbTray);
            this.Controls.Add(this.pLoadPanel);
            this.Controls.Add(this.pbBarBG);
            this.Name = "MainForm";
            this.Text = "CookIT";
            ((System.ComponentModel.ISupportInitialize)(this.pbBarBG)).EndInit();
            this.pLoadPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbTray)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBarBG;
        private System.Windows.Forms.Panel pLoadPanel;
        private System.Windows.Forms.PictureBox pbTray;
        private System.Windows.Forms.Button button1;
    }
}

