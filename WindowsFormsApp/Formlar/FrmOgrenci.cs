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
        OgrenciSinavEntities db = new OgrenciSinavEntities();
        void Listele()
        {
            var degerler = from x in db.TblOgrenci
                           select new
                           {
                               x.OgrId,
                               Adı = x.OgrAd,
                               Soyadı = x.OgrSoyad,
                               Numara = x.OgrNumara,
                               Sifre = x.OgrSifre,
                               Mail = x.OgrMail,
                               Resim = x.OgrResim,
                               x.OgrBolum,
                               Bölüm = x.TblBolumler.BolumAd,
                               x.OgrDurum

                           };
            dataGridView1.DataSource = degerler.Where(x=>x.OgrDurum==true).ToList();
        }
        private void FrmOgrenci_Load(object sender, EventArgs e)
        {
            MdiParent = this.MdiParent;
            Listele();
            dataGridView1.Columns["OgrId"].Visible = false;
            dataGridView1.Columns["OgrBolum"].Visible = false;
            dataGridView1.Columns["OgrDurum"].Visible = false;

            var bolumListe = db.TblBolumler.ToList();
            cmbBolum.DataSource = bolumListe;
            cmbBolum.ValueMember = "BolumId";
            cmbBolum.DisplayMember = "BolumAd";
        }
        int id;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtNumara.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtSifre.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtMail.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtResim.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            cmbBolum.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var x = db.TblOgrenci.Find(id);
            x.OgrDurum = false;
            db.SaveChanges();
            MessageBox.Show("Öğrenci başarılı bir şekilde silindi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            Listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            var t = db.TblOgrenci.Find(id);
            
                t.OgrAd = txtAd.Text;
                t.OgrSoyad = txtSoyad.Text;
                t.OgrNumara = txtNumara.Text;
                t.OgrSifre = txtSifre.Text;
                t.OgrMail = txtMail.Text;
                if (txtResim.Text == "")
                {
                    t.OgrResim = "Resim Yok";
                }
                else
                {
                    t.OgrResim = txtResim.Text;
                }

                t.OgrBolum = int.Parse(cmbBolum.SelectedValue.ToString());
                db.SaveChanges();
                MessageBox.Show("Öğrenci bilgileri başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            
            Listele();
        }

        private void txtResim_DoubleClick(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            var fileName = openFileDialog1.FileName;
            var ext = fileName.Substring(fileName.LastIndexOf("."));
            var extension = ext.ToLower();
            List<string> AllowFileExtensions = new List<string> { ".jpg", ".jpeg", ".gif", ".png" };
            if (!AllowFileExtensions.Contains(extension))
            {
                MessageBox.Show("Eklediğiniz resim formata uygun değil.");
            }
            else
            {
                txtResim.Text = fileName;
            }
        }
    }
}
