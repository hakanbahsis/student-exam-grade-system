using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp.Formlar
{
    public partial class FrmOkulGiris : Form
    {
        public FrmOkulGiris()
        {
            InitializeComponent();
        }

        private void btnAkademisyenGiris_Click(object sender, EventArgs e)
        {
            FrmAkademisyenGirisi fr = new FrmAkademisyenGirisi();
            fr.Show();
            this.Hide();
        }

        private void btnOgrenciGiris_Click(object sender, EventArgs e)
        {
            FrmGiris fr = new FrmGiris();
            fr.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
