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
    public partial class FrmOgrenci : Form
    {
        public FrmOgrenci()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        OgrenciSinavEntities db=new OgrenciSinavEntities();
        void Listele()
        {
            var degerler = from x in db.TblOgrenci
                           select new
                           {
                               x.OgrId,
                               x.OgrAd,
                               x.OgrSoyad,
                               x.OgrNumara,
                               x.OgrSifre,
                               x.OgrMail,
                               x.OgrResim,
                               x.TblBolumler.BolumAd
                           };
            dataGridView1.DataSource = degerler.ToList();
        }
        private void FrmOgrenci_Load(object sender, EventArgs e)
        {
            Listele();

            var bolumListe = db.TblBolumler.ToList();
            cmbBolum.DataSource = bolumListe;
            cmbBolum.DisplayMember = "BolumAd";
            cmbBolum.ValueMember = "BolumId";

        }
    }
}
