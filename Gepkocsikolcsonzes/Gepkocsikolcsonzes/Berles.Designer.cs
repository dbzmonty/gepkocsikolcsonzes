namespace Gepkocsikolcsonzes
{
    partial class Berles
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
            this.cmbMarka = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNev = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpKezdete = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.nudNapok = new System.Windows.Forms.NumericUpDown();
            this.btnBerles = new System.Windows.Forms.Button();
            this.btnKilepes = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)(this.nudNapok)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbMarka
            // 
            this.cmbMarka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarka.FormattingEnabled = true;
            this.cmbMarka.Location = new System.Drawing.Point(36, 67);
            this.cmbMarka.Name = "cmbMarka";
            this.cmbMarka.Size = new System.Drawing.Size(208, 23);
            this.cmbMarka.TabIndex = 0;
            this.cmbMarka.SelectedIndexChanged += new System.EventHandler(this.cmbMarka_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Autó típusa:";
            // 
            // txtNev
            // 
            this.txtNev.Location = new System.Drawing.Point(411, 67);
            this.txtNev.Name = "txtNev";
            this.txtNev.Size = new System.Drawing.Size(207, 23);
            this.txtNev.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kölcsönző neve:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kölcsönzés kezdete:";
            // 
            // dtpKezdete
            // 
            this.dtpKezdete.Location = new System.Drawing.Point(411, 124);
            this.dtpKezdete.Name = "dtpKezdete";
            this.dtpKezdete.Size = new System.Drawing.Size(207, 23);
            this.dtpKezdete.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(324, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Napok száma:";
            // 
            // nudNapok
            // 
            this.nudNapok.Location = new System.Drawing.Point(411, 178);
            this.nudNapok.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudNapok.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNapok.Name = "nudNapok";
            this.nudNapok.Size = new System.Drawing.Size(120, 23);
            this.nudNapok.TabIndex = 8;
            this.nudNapok.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudNapok.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnBerles
            // 
            this.btnBerles.Location = new System.Drawing.Point(411, 371);
            this.btnBerles.Name = "btnBerles";
            this.btnBerles.Size = new System.Drawing.Size(100, 23);
            this.btnBerles.TabIndex = 9;
            this.btnBerles.Text = "Bérlés";
            this.btnBerles.UseVisualStyleBackColor = true;
            this.btnBerles.Click += new System.EventHandler(this.btnBerles_Click);
            // 
            // btnKilepes
            // 
            this.btnKilepes.Location = new System.Drawing.Point(518, 371);
            this.btnKilepes.Name = "btnKilepes";
            this.btnKilepes.Size = new System.Drawing.Size(100, 23);
            this.btnKilepes.TabIndex = 10;
            this.btnKilepes.Text = "Kilépés";
            this.btnKilepes.UseVisualStyleBackColor = true;
            this.btnKilepes.Click += new System.EventHandler(this.btnKilepes_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Rendszám:";
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView.FullRowSelect = true;
            this.listView.Location = new System.Drawing.Point(36, 147);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(221, 247);
            this.listView.TabIndex = 12;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;            
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
            // Berles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 457);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnKilepes);
            this.Controls.Add(this.btnBerles);
            this.Controls.Add(this.nudNapok);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpKezdete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNev);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbMarka);
            this.Name = "Berles";
            this.Text = "Bérlés";
            this.Load += new System.EventHandler(this.Berles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNapok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmbMarka;
        private Label label1;
        private TextBox txtNev;
        private Label label2;
        private Label label3;
        private DateTimePicker dtpKezdete;
        private Label label4;
        private NumericUpDown nudNapok;
        private Button btnBerles;
        private Button btnKilepes;
        private Label label5;
        private ListView listView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
    }
}