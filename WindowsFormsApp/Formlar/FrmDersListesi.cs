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
    public partial class FrmDersListesi : Form
    {
        public FrmDersListesi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private OgrenciSinavEntities db = new OgrenciSinavEntities();

        void Listele()
        {
            var dersListesi = from x in db.TblDersler
                select new
                {
                    x.DersId,
                    x.DersAd
                };
            dataGridView1.DataSource = dersListesi.ToList();
        }
        private void FrmDersListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
