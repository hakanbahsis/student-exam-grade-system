using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp.Entity;

namespace WindowsFormsApp.Formlar
{
    public partial class FrmOgrenciKayit : Form
    {
        public FrmOgrenciKayit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        OgrenciSinavEntities db = new OgrenciSinavEntities();
       
        private void FrmOgrenciKayit_Load(object sender, EventArgs e)
        {
            var bolumListe = db.TblBolumler.ToList();
            cmbBolum.DataSource=bolumListe;
            cmbBolum.DisplayMember = "BolumAd";
            cmbBolum.ValueMember = "BolumId";
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            txtAd.Text = cmbBolum.SelectedValue.ToString();
        }
    }
}
