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
    public partial class FrmAkademisyenGirisi : Form
    {
        public FrmAkademisyenGirisi()
        {
            InitializeComponent();
        }

        private OgrenciSinavEntities db = new OgrenciSinavEntities();
        TblAkademisyen akademisyen=new TblAkademisyen();
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            akademisyen =
                db.TblAkademisyen.Where(x => x.AkademisyenNumara == txtNumara.Text && x.AkademisyenSifre == txtSifre.Text).SingleOrDefault();
            if (akademisyen==null)
            {
                MessageBox.Show("Giriş Başarısız. Lütfen Bilgileri Kontrol Ediniz.", "Hata", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else if (akademisyen !=null)
            {
                FrmMenu fr = new FrmMenu();
                fr.Show();
                this.Hide();
            }
           
        }
    }
}
