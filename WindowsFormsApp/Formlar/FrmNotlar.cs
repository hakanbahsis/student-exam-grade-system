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

            cmbDersAra.DisplayMember = "DersAd";
            cmbDersAra.ValueMember = "DersId";
            cmbDersAra.DataSource = db.TblDersler.ToList();

            cmbOgrenci.DisplayMember = "OgrAd";
            cmbOgrenci.ValueMember = "OgrId";
            cmbOgrenci.DataSource = db.TblOgrenci.ToList();

            //dataGridView1.DataSource = db.View_1.ToList(); //view ile listeleme
            dataGridView1.DataSource = db.Notlar(); //Procedure ile listeleme
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

        private void cmbDersAra_SelectedIndexChanged(object sender, EventArgs e)
        {
            var degerler = from x in db.TblNotlar
                select new
                {
                    x.NotId,
                    x.DersId,
                    x.TblDersler.DersAd,
                    x.OgrId,
                    x.TblOgrenci.OgrNumara,
                   Öğrenci_Adı= x.TblOgrenci.OgrAd+" "+x.TblOgrenci.OgrSoyad,
                    x.VizeNotu,
                    x.FinalNotu,
                    x.ButunlemeNotu,
                    x.Ortalama
                    
                };
           
            int ders = int.Parse(cmbDersAra.SelectedValue.ToString());
            dataGridView1.DataSource = degerler.Where(y => y.DersId ==ders).ToList();
            dataGridView1.Columns["NotId"].Visible = false;
            dataGridView1.Columns["DersId"].Visible = false;
            dataGridView1.Columns["OgrId"].Visible = false;
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            var deger = db.TblOgrenci.Where(x => x.OgrNumara == txtNo.Text).Select(y => y.OgrId).FirstOrDefault();
            var degerler = from x in db.TblNotlar
                select new
                {
                    x.NotId,
                    x.DersId,
                    x.TblDersler.DersAd,
                    x.OgrId,
                    Öğrenci_Adı = x.TblOgrenci.OgrAd + " " + x.TblOgrenci.OgrSoyad,
                    x.VizeNotu,
                    x.FinalNotu,
                    x.ButunlemeNotu,
                    x.Ortalama

                };
            dataGridView1.DataSource = degerler.Where(z => z.OgrId == deger).ToList();
            dataGridView1.Columns["NotId"].Visible = false;
            dataGridView1.Columns["DersId"].Visible = false;
            dataGridView1.Columns["OgrId"].Visible = false;
        }
    }
}
