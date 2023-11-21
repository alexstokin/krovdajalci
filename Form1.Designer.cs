
namespace Krvodajalci1
{
    partial class Form1
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
            this.dGV = new System.Windows.Forms.DataGridView();
            this.uredi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.brisi = new System.Windows.Forms.DataGridViewButtonColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dodajNovegaKrvodajalcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izpisiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topKrvodajaleckaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGV
            // 
            this.dGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uredi,
            this.brisi});
            this.dGV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dGV.Location = new System.Drawing.Point(0, 177);
            this.dGV.Name = "dGV";
            this.dGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV.Size = new System.Drawing.Size(1000, 282);
            this.dGV.TabIndex = 0;
            this.dGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_CellContentClick);
            // 
            // uredi
            // 
            this.uredi.HeaderText = "Urejanje";
            this.uredi.Name = "uredi";
            this.uredi.Text = "Uredi";
            this.uredi.UseColumnTextForButtonValue = true;
            this.uredi.Width = 60;
            // 
            // brisi
            // 
            this.brisi.HeaderText = "Brisanje";
            this.brisi.Name = "brisi";
            this.brisi.Text = "Brisi";
            this.brisi.UseColumnTextForButtonValue = true;
            this.brisi.Width = 60;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajNovegaKrvodajalcaToolStripMenuItem,
            this.izpisiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1000, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dodajNovegaKrvodajalcaToolStripMenuItem
            // 
            this.dodajNovegaKrvodajalcaToolStripMenuItem.Name = "dodajNovegaKrvodajalcaToolStripMenuItem";
            this.dodajNovegaKrvodajalcaToolStripMenuItem.Size = new System.Drawing.Size(155, 20);
            this.dodajNovegaKrvodajalcaToolStripMenuItem.Text = "Dodaj novega krvodajalca";
            this.dodajNovegaKrvodajalcaToolStripMenuItem.Click += new System.EventHandler(this.dodajNovegaKrvodajalcaToolStripMenuItem_Click);
            // 
            // izpisiToolStripMenuItem
            // 
            this.izpisiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.topKrvodajaleckaToolStripMenuItem});
            this.izpisiToolStripMenuItem.Name = "izpisiToolStripMenuItem";
            this.izpisiToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.izpisiToolStripMenuItem.Text = "Izpisi";
            this.izpisiToolStripMenuItem.Click += new System.EventHandler(this.izpisiToolStripMenuItem_Click);
            // 
            // topKrvodajaleckaToolStripMenuItem
            // 
            this.topKrvodajaleckaToolStripMenuItem.Name = "topKrvodajaleckaToolStripMenuItem";
            this.topKrvodajaleckaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.topKrvodajaleckaToolStripMenuItem.Text = "Top krvodajalec/ka";
            this.topKrvodajaleckaToolStripMenuItem.Click += new System.EventHandler(this.topKrvodajaleckaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 459);
            this.Controls.Add(this.dGV);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGV;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dodajNovegaKrvodajalcaToolStripMenuItem;
        private System.Windows.Forms.DataGridViewButtonColumn uredi;
        private System.Windows.Forms.DataGridViewButtonColumn brisi;
        private System.Windows.Forms.ToolStripMenuItem izpisiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topKrvodajaleckaToolStripMenuItem;
    }
}

