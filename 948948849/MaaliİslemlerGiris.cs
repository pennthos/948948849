using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _948948849
{
    public partial class MaaliİslemlerGiris : Form
    {
        public MaaliİslemlerGiris()
        {
            InitializeComponent();
        }
        SqlConnection bgl = new SqlConnection("Data Source=DESKTOP-OQHLDIN\\SQLEXPRESS;Initial Catalog=PERSONELBİLGİ;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand komut = new SqlCommand("Select * From Table_1 where AdSoyad = @p1 and Şifre = @p2", bgl);
            komut.Parameters.AddWithValue("@p1", textBox1.Text);
            komut.Parameters.AddWithValue("@p2", textBox2.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                Maalıİslemler mi = new Maalıİslemler();
                mi.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Kullanıcı Adı Veya Şifre Hatalı!!!", "Bilgi", MessageBoxButtons.OK);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris();
            giris.Show();
            this.Hide();
        }
    }
}
