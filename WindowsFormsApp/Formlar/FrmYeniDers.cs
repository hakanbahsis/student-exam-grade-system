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
    public partial class FrmYeniDers : Form
    {
        public FrmYeniDers()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        OgrenciSinavEntities db=new OgrenciSinavEntities();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            TblDersler t=new TblDersler();
            t.DersAd = txtDersAd.Text;
            db.TblDersler.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ders Kaydedildi.", "Bilgi", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
