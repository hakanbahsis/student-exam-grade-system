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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBolumListesi_Click(object sender, EventArgs e)
        {
            FrmBolumListesi fr = new FrmBolumListesi();
            fr.Show();
        }

        private void btnYeniBolum_Click(object sender, EventArgs e)
        {
            FrmBolumler fr = new FrmBolumler();
            fr.Show();
        }

        private void btnNotlar_Click(object sender, EventArgs e)
        {
            FrmNotlar fr = new FrmNotlar();
            fr.Show();
        }

        private void btnOgrenciFormu_Click(object sender, EventArgs e)
        {
            FrmOgrenci fr=new FrmOgrenci();
            fr.Show();
        }

        private void btnOgrenciKayit_Click(object sender, EventArgs e)
        {
            FrmOgrenciKayit fr=new FrmOgrenciKayit();
            fr.Show();
        }

        private void btnDersListesi_Click(object sender, EventArgs e)
        {
            FrmDersListesi fr = new FrmDersListesi();
            fr.Show();
        }

        private void btnYeniDers_Click(object sender, EventArgs e)
        {
            FrmYeniDers fr = new FrmYeniDers();
            fr.Show();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {

        }

        private void BtnYardim_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mesaj", "Yardım",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
