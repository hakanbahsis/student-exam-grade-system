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
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private OgrenciSinavEntities db = new OgrenciSinavEntities();
        private TblOgrenci ogrenci = new TblOgrenci();
        private void btnGiris_Click(object sender, EventArgs e)
        {
            ogrenci = db.TblOgrenci.Where(x => x.OgrNumara == txtNumara.Text && x.OgrSifre == txtSifre.Text)
                .SingleOrDefault();
            if (ogrenci==null)
            {
                MessageBox.Show("Giriş Başarısız. Lütfen Bilgileri Kontrol Ediniz.", "Hata", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }
            else if (ogrenci!=null)
            {
                FrmOgrenciPanel fr = new FrmOgrenciPanel();
                fr.numara = txtNumara.Text;
                fr.Show();
                this.Hide();
            }
        }
    }
}
