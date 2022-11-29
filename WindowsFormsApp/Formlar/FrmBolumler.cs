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
    public partial class FrmBolumler : Form
    {
        public FrmBolumler()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        OgrenciSinavEntities db = new OgrenciSinavEntities();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtBolumAd.Text=="")
            {
                errorProvider1.SetError(txtBolumAd,"Bölüm adı boş geçilemez.");
            }
            else
            {
                TblBolumler t = new TblBolumler();
                t.BolumAd = txtBolumAd.Text;
                db.TblBolumler.Add(t);
                db.SaveChanges();
                MessageBox.Show("Bölüm ekleme işlemi başarılı bir şekilde yapıldı.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}
