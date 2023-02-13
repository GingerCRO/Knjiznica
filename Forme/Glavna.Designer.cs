namespace Knjiznica
{
    partial class Glavna
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
            this.učeniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.knjigeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbPosudbe = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPosudi = new System.Windows.Forms.Button();
            this.btnIzmijeni = new System.Windows.Forms.Button();
            this.btnVrati = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.učeniciToolStripMenuItem,
            this.knjigeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // učeniciToolStripMenuItem
            // 
            this.učeniciToolStripMenuItem.Name = "učeniciToolStripMenuItem";
            this.učeniciToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.učeniciToolStripMenuItem.Text = "Učenici";
            this.učeniciToolStripMenuItem.Click += new System.EventHandler(this.učeniciToolStripMenuItem_Click);
            // 
            // knjigeToolStripMenuItem
            // 
            this.knjigeToolStripMenuItem.Name = "knjigeToolStripMenuItem";
            this.knjigeToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.knjigeToolStripMenuItem.Text = "Knjige";
            this.knjigeToolStripMenuItem.Click += new System.EventHandler(this.knjigeToolStripMenuItem_Click);
            // 
            // lbPosudbe
            // 
            this.lbPosudbe.FormattingEnabled = true;
            this.lbPosudbe.Location = new System.Drawing.Point(28, 75);
            this.lbPosudbe.Name = "lbPosudbe";
            this.lbPosudbe.Size = new System.Drawing.Size(611, 355);
            this.lbPosudbe.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Posuđene knjige";
            // 
            // btnPosudi
            // 
            this.btnPosudi.Location = new System.Drawing.Point(682, 86);
            this.btnPosudi.Name = "btnPosudi";
            this.btnPosudi.Size = new System.Drawing.Size(75, 23);
            this.btnPosudi.TabIndex = 3;
            this.btnPosudi.Text = "Posudi";
            this.btnPosudi.UseVisualStyleBackColor = true;
            this.btnPosudi.Click += new System.EventHandler(this.btnPosudi_Click);
            // 
            // btnIzmijeni
            // 
            this.btnIzmijeni.Location = new System.Drawing.Point(682, 139);
            this.btnIzmijeni.Name = "btnIzmijeni";
            this.btnIzmijeni.Size = new System.Drawing.Size(75, 23);
            this.btnIzmijeni.TabIndex = 4;
            this.btnIzmijeni.Text = "Izmijeni";
            this.btnIzmijeni.UseVisualStyleBackColor = true;
            this.btnIzmijeni.Click += new System.EventHandler(this.btnIzmijeni_Click);
            // 
            // btnVrati
            // 
            this.btnVrati.Location = new System.Drawing.Point(682, 194);
            this.btnVrati.Name = "btnVrati";
            this.btnVrati.Size = new System.Drawing.Size(75, 23);
            this.btnVrati.TabIndex = 5;
            this.btnVrati.Text = "Vrati";
            this.btnVrati.UseVisualStyleBackColor = true;
            this.btnVrati.Click += new System.EventHandler(this.btnVrati_Click);
            // 
            // Glavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVrati);
            this.Controls.Add(this.btnIzmijeni);
            this.Controls.Add(this.btnPosudi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbPosudbe);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Glavna";
            this.Text = "Knjiznica";
            this.Load += new System.EventHandler(this.Glavna_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem učeniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem knjigeToolStripMenuItem;
        private System.Windows.Forms.ListBox lbPosudbe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPosudi;
        private System.Windows.Forms.Button btnIzmijeni;
        private System.Windows.Forms.Button btnVrati;
    }
}

