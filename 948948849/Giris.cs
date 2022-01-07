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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }
        SqlConnection bgl = new SqlConnection("Data Source=DESKTOP-OQHLDIN\\SQLEXPRESS;Initial Catalog=PERSONELBİLGİ;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void btncıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
            

            

        }

        private void MaaliGiris_Click(object sender, EventArgs e)
        {
            MaaliİslemlerGiris mig = new MaaliİslemlerGiris();
            mig.Show();
            this.Hide();
        }
    }
}
