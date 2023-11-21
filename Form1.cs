using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Krvodajalci1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        BindingList<Krvodajalci> zbirka = new BindingList<Krvodajalci>(); 
        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader beri = File.OpenText("osebe.txt");
            string vr = beri.ReadLine();
            string[] tab;
            while (vr != null)
            {
                tab = vr.Split(';');
                //Iz podatkov v tabeli ustvarimo objekt krvodajalca
                Krvodajalci k1 = new Krvodajalci(tab[0], tab[1], tab[2],
                    Convert.ToDateTime(tab[3]), 
                    Convert.ToChar(tab[4]), tab[5], 
                    Convert.ToInt32(tab[6]), 
                    Convert.ToDateTime(tab[7]));

                //Dodamo krvodajalca v zbirko
                zbirka.Add(k1);

                //Preberemo naslednjo vrstico
                vr = beri.ReadLine(); 
            }
            //Povežemo dataGridView z zbirko
            dGV.DataSource = zbirka;

            //Premaknemo prve tri stolpce na konec dGV-ja
            dGV.Columns["KrvnaSkupina"].DisplayIndex = dGV.Columns.Count - 1;
            dGV.Columns["SteviloDarovanj"].DisplayIndex = dGV.Columns.Count - 1;
            dGV.Columns["ZadnjeDarovanje"].DisplayIndex = dGV.Columns.Count - 1;
            dGV.Columns[0].DisplayIndex = dGV.Columns.Count -1;
            dGV.Columns[1].DisplayIndex = dGV.Columns.Count - 1;

            //Zmanjšamo width stolpcev
            dGV.Columns["Spol"].Width = 35;
            dGV.Columns["KrvnaSkupina"].Width = 80;
        }

        private void dodajNovegaKrvodajalcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Form2 podobrazec = new Form2();
            if (podobrazec.ShowDialog() == DialogResult.OK )// gumb potrdi
            {
                //naredimo objekt krvodajalca iz podatkov v podobrazcu
                Krvodajalci kri_daje = new Krvodajalci(
                    podobrazec.tbxIme.Text,
                    podobrazec.tbxPriimek.Text,
                    podobrazec.tbxKraj.Text,
                    podobrazec.dtpRojstvo.Value.Date,
                    Convert.ToChar(podobrazec.cbSpol.Text),
                    podobrazec.cbKrvna.Text,
                    Convert.ToInt32(podobrazec.numericUpDown1.Value),
                    podobrazec.dtpZadnjeDar.Value.Date);
                //dodamo krvodajalca v zbirko
                zbirka.Add(kri_daje);
            }
        }

        private void dGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0) //gumb uredi
            {
                Form2 podobrazec = new Form2();
                podobrazec.tbxIme.Text = zbirka[e.RowIndex].Ime;
                podobrazec.tbxPriimek.Text = zbirka[e.RowIndex].Priimek;
                podobrazec.tbxKraj.Text = zbirka[e.RowIndex].Kraj;
                podobrazec.dtpRojstvo.Value = zbirka[e.RowIndex].DatumRojstva;
                podobrazec.cbSpol.Text = Convert.ToString(zbirka[e.RowIndex].Spol);
                podobrazec.cbKrvna.Text = zbirka[e.RowIndex].KrvnaSkupina;
                podobrazec.numericUpDown1.Value = zbirka[e.RowIndex].SteviloDarovanj;
                podobrazec.dtpZadnjeDar.Value = zbirka[e.RowIndex].ZadnjeDarovanje;
                if (podobrazec.ShowDialog() == DialogResult.OK)// gumb potrdi
                {
                    //naredimo objekt krvodajalca iz podatkov v podobrazcu
                    Krvodajalci kri_daje = new Krvodajalci(
                        podobrazec.tbxIme.Text,
                        podobrazec.tbxPriimek.Text,
                        podobrazec.tbxKraj.Text,
                        podobrazec.dtpRojstvo.Value.Date,
                        Convert.ToChar(podobrazec.cbSpol.Text),
                        podobrazec.cbKrvna.Text,
                        Convert.ToInt32(podobrazec.numericUpDown1.Value),
                        podobrazec.dtpZadnjeDar.Value.Date);
                    //prepišemo krvodajalca v zbirki
                    zbirka[e.RowIndex] = kri_daje;
                }
            }
            if (e.ColumnIndex == 1)//gumb izbriši
            {
                if(MessageBox.Show("Želite izbrisati osebo " +
                    dGV.Rows[e.RowIndex].Cells["Ime"].Value + " " +
                    zbirka[e.RowIndex].Priimek ,
                    "Brisanje", 
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // lahko izbrišemo iz zbirke ali iz dataGridView-a
                    zbirka.RemoveAt(e.RowIndex);
                    // dGV.Rows.Remove(dGV.CurrentRow);
                }
            }
        }

        private void izpisiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        int maxDar = int.MinValue;
        private void topKrvodajaleckaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < zbirka.Count; i++)
            {
                if (zbirka[i].SteviloDarovanj > maxDar)
                {
                    maxDar = zbirka[i].SteviloDarovanj;
                }
            }
            string maxDarovalci = "";
            for (int i = 0; i < zbirka.Count; i++)
            {
                if (zbirka[i].SteviloDarovanj == maxDar)
                {
                    maxDarovalci += zbirka[i].Ime + " " + zbirka[i].Priimek + "\n";
                }
            }
            MessageBox.Show("Top darovalci, ki so " + maxDar + " dali kri so :" +
                "\n" + maxDarovalci);
            maxDar = int.MinValue;
        }
    }
}
