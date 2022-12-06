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
    public partial class FrmOgrenciPanel : Form
    {
        public FrmOgrenciPanel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

        public string numara;
        private int id;
        private OgrenciSinavEntities db = new OgrenciSinavEntities();

        void OgrenciBilgiGetir()
        {
            txtNumara.Text = numara;
            id = db.TblOgrenci.Where(x => x.OgrNumara == numara).Select(y => y.OgrId).FirstOrDefault();
            txtAd.Text = db.TblOgrenci.Where(x => x.OgrNumara == numara).Select(y => y.OgrAd).FirstOrDefault();
            txtSoyad.Text = db.TblOgrenci.Where(x => x.OgrNumara == numara).Select(y => y.OgrSoyad).FirstOrDefault();
            txtSifre.Text = db.TblOgrenci.Where(x => x.OgrNumara == numara).Select(y => y.OgrSifre).FirstOrDefault();
            txtMail.Text = db.TblOgrenci.Where(x => x.OgrNumara == numara).Select(y => y.OgrMail).FirstOrDefault();
           // txtResim.Text = db.TblOgrenci.Where(x => x.OgrNumara == numara).Select(y => y.OgrResim).FirstOrDefault();
            txtAd.Text = db.TblOgrenci.Where(x => x.OgrNumara == numara).Select(y => y.OgrAd).FirstOrDefault();
            txtBolum.Text = db.TblOgrenci.Where(x => x.OgrNumara == numara).Select(y => y.OgrBolum).FirstOrDefault().ToString();
        }

        void SinavNotlari()
        {
            var sinav = from x in db.TblNotlar
                select new
                {
                    x.TblDersler.DersAd,
                    x.OgrId,
                    x.VizeNotu,
                    x.FinalNotu,
                    x.ButunlemeNotu,
                    x.Ortalama
                };
            
            dataGridView1.DataSource = sinav.Where(y=>y.OgrId==id).ToList();
            dataGridView1.Columns["OgrId"].Visible = false;
            dataGridView1.Columns[0].HeaderText = "Ders Adı";
            dataGridView1.Columns[0].Width = 250;
            dataGridView1.Columns[2].HeaderText = "Vize";
            dataGridView1.Columns[2].Width = 80;
            dataGridView1.Columns[3].HeaderText = "Final";
            dataGridView1.Columns[3].Width = 80;
            dataGridView1.Columns[4].HeaderText = "Bütünleme";
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.Columns[5].Width = 100;

        }
        private void FrmOgrenciPanel_Load(object sender, EventArgs e)
        {
            OgrenciBilgiGetir();
            SinavNotlari();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtYeniSifre.Text==txtSifreTekrar.Text)
            {
                var deger = db.TblOgrenci.Find(id);
                deger.OgrSifre = txtYeniSifre.Text;
                db.SaveChanges();
                MessageBox.Show("Şifre Değiştirildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Şifreler Uyuşmuyor.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
