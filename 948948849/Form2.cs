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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        kullanıcı_grişEntities1 db = new kullanıcı_grişEntities1();
       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris();
            giris.Show();
            this.Hide();
                
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Calisan cls = new Calisan();
            cls.AdSoyad = txtad.Text;
            cls.Cinsiyet = txtcinsiyet.Text;
            cls.DogumTarih = dateTimePicker1.Text;
            cls.Maas =int.Parse (txtmaas.Text);
            cls.Sifre = txtsifre.Text;
            cls.TC = txttc.Text;
            cls.TelNo = txttelno.Text;
            cls.Unvan = txtunvan.Text;

            db.Calisan.Add(cls);
            db.SaveChanges();

            MessageBox.Show("Çalışan Bilgileri Başarıyla Eklendi...");


        }

        private void txttelno_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
