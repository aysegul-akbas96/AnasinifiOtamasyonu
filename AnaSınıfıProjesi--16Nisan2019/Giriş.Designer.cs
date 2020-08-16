namespace AnaSınıfıProjesi__16Nisan2019
{
    partial class Giriş
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.veliGirişiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıGirişiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.veliGirişiToolStripMenuItem,
            this.kullanıcıGirişiToolStripMenuItem,
            this.raporlamaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(846, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // veliGirişiToolStripMenuItem
            // 
            this.veliGirişiToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.veliGirişiToolStripMenuItem.ForeColor = System.Drawing.Color.Purple;
            this.veliGirişiToolStripMenuItem.Name = "veliGirişiToolStripMenuItem";
            this.veliGirişiToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.veliGirişiToolStripMenuItem.Text = "VeliGirişi";
            this.veliGirişiToolStripMenuItem.Click += new System.EventHandler(this.veliGirişiToolStripMenuItem_Click);
            // 
            // kullanıcıGirişiToolStripMenuItem
            // 
            this.kullanıcıGirişiToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullanıcıGirişiToolStripMenuItem.ForeColor = System.Drawing.Color.Purple;
            this.kullanıcıGirişiToolStripMenuItem.Name = "kullanıcıGirişiToolStripMenuItem";
            this.kullanıcıGirişiToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.kullanıcıGirişiToolStripMenuItem.Text = "KullanıcıGirişi";
            this.kullanıcıGirişiToolStripMenuItem.Click += new System.EventHandler(this.kullanıcıGirişiToolStripMenuItem_Click);
            // 
            // raporlamaToolStripMenuItem
            // 
            this.raporlamaToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.raporlamaToolStripMenuItem.ForeColor = System.Drawing.Color.Purple;
            this.raporlamaToolStripMenuItem.Name = "raporlamaToolStripMenuItem";
            this.raporlamaToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.raporlamaToolStripMenuItem.Text = "Raporlama";
            this.raporlamaToolStripMenuItem.Click += new System.EventHandler(this.raporlamaToolStripMenuItem_Click);
            // 
            // Giriş
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AnaSınıfıProjesi__16Nisan2019.Properties.Resources._7759aa09b9287ff;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(846, 279);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Giriş";
            this.Text = "Giriş";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem veliGirişiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıGirişiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem raporlamaToolStripMenuItem;
    }
}