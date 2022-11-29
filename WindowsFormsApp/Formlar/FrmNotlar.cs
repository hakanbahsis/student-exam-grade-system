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
    public partial class FrmNotlar : Form
    {
        public FrmNotlar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private OgrenciSinavEntities db = new OgrenciSinavEntities();
        private void FrmNotlar_Load(object sender, EventArgs e)
        {
            cmbDers.DisplayMember = "DersAd";
            cmbDers.ValueMember = "DersId";
            cmbDers.DataSource = db.TblDersler.ToList();

            cmbOgrenci.DisplayMember = "OgrAd";
            cmbOgrenci.ValueMember = "OgrId";
            cmbOgrenci.DataSource = db.TblOgrenci.ToList();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            TblNotlar t = new TblNotlar();
            t.VizeNotu = byte.Parse(txtVize.Text);
            t.FinalNotu = byte.Parse(txtFinal.Text);
            t.ButunlemeNotu = byte.Parse(txtBut.Text);
            t.DersId = int.Parse(cmbDers.SelectedValue.ToString());
            t.OgrId = int.Parse(cmbOgrenci.SelectedValue.ToString());
            db.TblNotlar.Add(t);
            db.SaveChanges();
            MessageBox.Show("Öğrenci not bilgisi sisteme kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            byte vize, final, but;
            double ortalama;

            
            if (txtBut.Text == "")
            {
                vize = byte.Parse(txtVize.Text);
                final = byte.Parse(txtFinal.Text);
                ortalama = (vize * 0.4) + (final * 0.6);
                txtBut.Enabled=false;
                txtOrtalama.Text = ortalama.ToString();
            }

            if (txtBut.Text != "")
            {
                txtFinal.Enabled=false;
                vize = byte.Parse(txtVize.Text);
                but = byte.Parse(txtBut.Text);
                ortalama = (vize * 0.4) + (but * 0.6);
                txtOrtalama.Text = ortalama.ToString();
            }
        }
    }
}
