using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
            cmbBolum.DataSource = bolumListe;
            cmbBolum.DisplayMember = "BolumAd";
            cmbBolum.ValueMember = "BolumId";
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtSifre.Text == txtSifreTekrar.Text)
            {
                TblOgrenci t = new TblOgrenci();
                t.OgrAd = txtAd.Text;
                t.OgrSoyad = txtSoyad.Text;
                t.OgrNumara = txtNumara.Text;
                t.OgrSifre = txtSifre.Text;
                t.OgrMail = txtMail.Text;
                if (txtResim.Text=="")
                {
                    t.OgrResim = "Resim Yok";
                }
                else
                {
                    t.OgrResim = txtResim.Text;
                }
                
                t.OgrBolum = int.Parse(cmbBolum.SelectedValue.ToString());
                db.TblOgrenci.Add(t);
                db.SaveChanges();
                MessageBox.Show("Öğrenci bilgileri başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen şifreleri kontrol ediniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void txtResim_MouseDoubleClick(object sender, MouseEventArgs e)
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
