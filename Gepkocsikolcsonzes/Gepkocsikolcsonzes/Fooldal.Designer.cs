namespace Gepkocsikolcsonzes
{
    partial class Fooldal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fooldal));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TSMI_Gepkocsik = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Kolcsonzes = new System.Windows.Forms.ToolStripMenuItem();
            this.rovidtavuBerlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hosszutavuBerlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Kilepes = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.lblMarka = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 439);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Gepkocsik,
            this.TSMI_Kolcsonzes,
            this.TSMI_Kilepes});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TSMI_Gepkocsik
            // 
            this.TSMI_Gepkocsik.Name = "TSMI_Gepkocsik";
            this.TSMI_Gepkocsik.Size = new System.Drawing.Size(73, 20);
            this.TSMI_Gepkocsik.Text = "Gépkocsik";
            // 
            // TSMI_Kolcsonzes
            // 
            this.TSMI_Kolcsonzes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rovidtavuBerlesToolStripMenuItem,
            this.hosszutavuBerlesToolStripMenuItem});
            this.TSMI_Kolcsonzes.Name = "TSMI_Kolcsonzes";
            this.TSMI_Kolcsonzes.Size = new System.Drawing.Size(77, 20);
            this.TSMI_Kolcsonzes.Text = "Kölcsönzés";
            // 
            // rovidtavuBerlesToolStripMenuItem
            // 
            this.rovidtavuBerlesToolStripMenuItem.Name = "rovidtavuBerlesToolStripMenuItem";
            this.rovidtavuBerlesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rovidtavuBerlesToolStripMenuItem.Text = "Rövidtávú bérlés";
            this.rovidtavuBerlesToolStripMenuItem.Click += new System.EventHandler(this.rovidtavuBerlesToolStripMenuItem_Click);
            // 
            // hosszutavuBerlesToolStripMenuItem
            // 
            this.hosszutavuBerlesToolStripMenuItem.Name = "hosszutavuBerlesToolStripMenuItem";
            this.hosszutavuBerlesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hosszutavuBerlesToolStripMenuItem.Text = "Hosszútávú bérlés";
            this.hosszutavuBerlesToolStripMenuItem.Click += new System.EventHandler(this.hosszutavuBerlesToolStripMenuItem_Click);
            // 
            // TSMI_Kilepes
            // 
            this.TSMI_Kilepes.Name = "TSMI_Kilepes";
            this.TSMI_Kilepes.Size = new System.Drawing.Size(56, 20);
            this.TSMI_Kilepes.Text = "Kilépés";
            this.TSMI_Kilepes.Click += new System.EventHandler(this.TSMI_Kilepes_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(68, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(359, 232);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Location = new System.Drawing.Point(493, 102);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(229, 232);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Rendszám";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Fogyasztás";
            this.columnHeader2.Width = 80;
            // 
            // lblMarka
            // 
            this.lblMarka.AutoSize = true;
            this.lblMarka.Location = new System.Drawing.Point(498, 74);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(43, 15);
            this.lblMarka.TabIndex = 4;
            this.lblMarka.Text = "Márka:";
            // 
            // Fooldal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.lblMarka);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Fooldal";
            this.Text = "Gépkocsikölcsönzés";
            this.Load += new System.EventHandler(this.Fooldal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StatusStrip statusStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem TSMI_Gepkocsik;
        private ToolStripMenuItem TSMI_Kolcsonzes;
        private ToolStripMenuItem rovidtavuBerlesToolStripMenuItem;
        private ToolStripMenuItem hosszutavuBerlesToolStripMenuItem;
        private ToolStripMenuItem TSMI_Kilepes;
        private PictureBox pictureBox1;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private Label lblMarka;
    }
}