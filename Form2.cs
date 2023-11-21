using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Krvodajalci1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }



        private void btnPotrdi_Click(object sender, EventArgs e)
        {
            //validiramo vnose - oseba mora biti polnoletna 
            if (tbxIme.Text == string.Empty ||
                tbxPriimek.Text == string.Empty ||
                tbxKraj.Text == string.Empty ||
                DateTime.Today.Year - dtpRojstvo.Value.Year  < 18 ||
                cbSpol.Text == "" ||
                cbKrvna.Text == "")
            {
                MessageBox.Show("Nepopolni podatki ali pa je oseba mladoletna. ");
                //preprečimo da se podobrazec zapre
                DialogResult = DialogResult.None;
            }
        }

        private void tbxIme_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
