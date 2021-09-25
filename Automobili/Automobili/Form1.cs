using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections; // zbog arraylist

namespace Automobili
{
    public partial class Form1 : Form
    {
        ArrayList listaAutomobila = new ArrayList();
        public Form1()
        {
            InitializeComponent();
            txtboxNovi.Enabled = false;
            btnUnesi.Enabled = false;
        }

        
        private void btnNovi_Click(object sender, EventArgs e)
        {
            txtboxNovi.Enabled = true;
            btnUnesi.Enabled = true;
            txtboxNovi.ResetText();

        }
        
        private void txtboxNovi_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            txtboxNovi.Enabled = false;
            btnUnesi.Enabled = false;
            Automobil a = new Automobil(txtboxNovi.Text);
            listaAutomobila.Add(a);
            rtxtboxAuta.AppendText(listaAutomobila.IndexOf(a)+1+"."+a.DajMarku()+"\n");

        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            listaAutomobila.Clear();
            rtxtboxAuta.Clear();
        }
    }
}
