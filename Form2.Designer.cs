
namespace Krvodajalci1
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxIme = new System.Windows.Forms.TextBox();
            this.tbxPriimek = new System.Windows.Forms.TextBox();
            this.tbxKraj = new System.Windows.Forms.TextBox();
            this.dtpRojstvo = new System.Windows.Forms.DateTimePicker();
            this.cbSpol = new System.Windows.Forms.ComboBox();
            this.cbKrvna = new System.Windows.Forms.ComboBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpZadnjeDar = new System.Windows.Forms.DateTimePicker();
            this.btnPreklici = new System.Windows.Forms.Button();
            this.btnPotrdi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Priimek: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kraj: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Datum Rojstva: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Spol: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Krvna Skupina: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Število darovanj: ";
            // 
            // tbxIme
            // 
            this.tbxIme.Location = new System.Drawing.Point(130, 32);
            this.tbxIme.Name = "tbxIme";
            this.tbxIme.Size = new System.Drawing.Size(100, 20);
            this.tbxIme.TabIndex = 7;
            this.tbxIme.TextChanged += new System.EventHandler(this.tbxIme_TextChanged);
            // 
            // tbxPriimek
            // 
            this.tbxPriimek.Location = new System.Drawing.Point(130, 63);
            this.tbxPriimek.Name = "tbxPriimek";
            this.tbxPriimek.Size = new System.Drawing.Size(100, 20);
            this.tbxPriimek.TabIndex = 8;
            // 
            // tbxKraj
            // 
            this.tbxKraj.Location = new System.Drawing.Point(130, 87);
            this.tbxKraj.Name = "tbxKraj";
            this.tbxKraj.Size = new System.Drawing.Size(100, 20);
            this.tbxKraj.TabIndex = 9;
            // 
            // dtpRojstvo
            // 
            this.dtpRojstvo.Location = new System.Drawing.Point(132, 113);
            this.dtpRojstvo.Name = "dtpRojstvo";
            this.dtpRojstvo.Size = new System.Drawing.Size(200, 20);
            this.dtpRojstvo.TabIndex = 14;
            // 
            // cbSpol
            // 
            this.cbSpol.FormattingEnabled = true;
            this.cbSpol.Items.AddRange(new object[] {
            "M",
            "Ž"});
            this.cbSpol.Location = new System.Drawing.Point(130, 147);
            this.cbSpol.Name = "cbSpol";
            this.cbSpol.Size = new System.Drawing.Size(121, 21);
            this.cbSpol.TabIndex = 15;
            // 
            // cbKrvna
            // 
            this.cbKrvna.FormattingEnabled = true;
            this.cbKrvna.Location = new System.Drawing.Point(130, 174);
            this.cbKrvna.Name = "cbKrvna";
            this.cbKrvna.Size = new System.Drawing.Size(121, 21);
            this.cbKrvna.TabIndex = 16;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(132, 201);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(40, 20);
            this.numericUpDown1.TabIndex = 17;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Zadnje darovanje: ";
            // 
            // dtpZadnjeDar
            // 
            this.dtpZadnjeDar.Location = new System.Drawing.Point(130, 232);
            this.dtpZadnjeDar.Name = "dtpZadnjeDar";
            this.dtpZadnjeDar.Size = new System.Drawing.Size(200, 20);
            this.dtpZadnjeDar.TabIndex = 19;
            // 
            // btnPreklici
            // 
            this.btnPreklici.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPreklici.Location = new System.Drawing.Point(59, 267);
            this.btnPreklici.Name = "btnPreklici";
            this.btnPreklici.Size = new System.Drawing.Size(113, 36);
            this.btnPreklici.TabIndex = 20;
            this.btnPreklici.Text = "Prekliči";
            this.btnPreklici.UseVisualStyleBackColor = true;
            // 
            // btnPotrdi
            // 
            this.btnPotrdi.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnPotrdi.Location = new System.Drawing.Point(192, 267);
            this.btnPotrdi.Name = "btnPotrdi";
            this.btnPotrdi.Size = new System.Drawing.Size(120, 36);
            this.btnPotrdi.TabIndex = 21;
            this.btnPotrdi.Text = "Potrdi";
            this.btnPotrdi.UseVisualStyleBackColor = true;
            this.btnPotrdi.Click += new System.EventHandler(this.btnPotrdi_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPotrdi);
            this.Controls.Add(this.btnPreklici);
            this.Controls.Add(this.dtpZadnjeDar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.cbKrvna);
            this.Controls.Add(this.cbSpol);
            this.Controls.Add(this.dtpRojstvo);
            this.Controls.Add(this.tbxKraj);
            this.Controls.Add(this.tbxPriimek);
            this.Controls.Add(this.tbxIme);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox tbxIme;
        public System.Windows.Forms.TextBox tbxPriimek;
        public System.Windows.Forms.TextBox tbxKraj;
        public System.Windows.Forms.DateTimePicker dtpRojstvo;
        public System.Windows.Forms.ComboBox cbSpol;
        public System.Windows.Forms.ComboBox cbKrvna;
        public System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.DateTimePicker dtpZadnjeDar;
        private System.Windows.Forms.Button btnPreklici;
        private System.Windows.Forms.Button btnPotrdi;
    }
}