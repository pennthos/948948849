using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _948948849
{
    public partial class Maalıİslemler : Form
    {
        public Maalıİslemler()
        {
            InitializeComponent();
        }

        kullanıcı_grişEntities db = new kullanıcı_grişEntities();
        kullanıcı_grişEntities1 db1 = new kullanıcı_grişEntities1();
        private void Maalıİslemler_Load(object sender, EventArgs e)
        {
            label5.Text = db.TBLSPARİS.Sum(x => x.TUTAR).ToString();
            label3.Text = (from x in db1.Calisan select x.AdSoyad).Count().ToString();
            label2.Text = db1.Calisan.Sum(a => a.Maas).ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
