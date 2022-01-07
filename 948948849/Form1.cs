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
using System.Data.OleDb;

namespace _948948849
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataSet1TableAdapters.TBLSPARİSTableAdapter ds = new DataSet1TableAdapters.TBLSPARİSTableAdapter();
        SqlConnection bg = new SqlConnection(@"Data Source=DESKTOP-OQHLDIN\\SQLEXPRESS;Initial Catalog=kullanıcıgriş;Integrated Security=True");
        kullanıcı_grişEntities db = new kullanıcı_grişEntities();

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            TBLSPARİS s = new TBLSPARİS();
            s.MUSTERIADSOYAD = txtadsoyadı.Text;
            s.MUSTRİADRES = txtadres.Text;
            s.PİZZASECİMİ = cmbpizzasecim.Text;
            s.PİZZABOYUTU = cmbpizzaboyut.Text;
            s.KENARSECİMİ = cmbkenar.Text;
            s.TELEFON = txttel.Text; 
            s.PİZZASAYISI = nmrpizza.Value.ToString();
            s.İCECEK = cmbicecek.Text;
            s.İCECEKSAYISI = nmricecek.Value.ToString();
            s.EXTRAMALZEME = cmbextra.Text;
            s.TARİH = dateTimePicker1.Text;
            tutar();
            s.TUTAR =int.Parse (txttutar.Text);

            db.TBLSPARİS.Add(s);
            db.SaveChanges();

            

            MessageBox.Show("Siparişiniz Alındı...");

        //    bg.Open();

        //    SqlCommand komut = new SqlCommand("insert into TBLSPARİS (MUSTERİADSOYAD,MUSTRİADRES,PİZZASECİMİ,PİZZABOYUTU,PİZZASAYISI,İCECEK,İCECEKSAYISI,EXTRAMALZEME,TARİH) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p10)",bg);
        //    komut.Parameters.AddWithValue("@p1",txtadsoyadı.Text);
        //    komut.Parameters.AddWithValue("@p2",txtadres.Text);
        //    komut.Parameters.AddWithValue("@p3",cmbpizzasecim.Text);
        //    komut.Parameters.AddWithValue("@p4",cmbpizzaboyut.Text);
        //    komut.Parameters.AddWithValue("@p5",nmrpizza);
        //    komut.Parameters.AddWithValue("@p6",cmbicecek.Text);
        //    komut.Parameters.AddWithValue("@p7", nmricecek);

        //    komut.Parameters.AddWithValue("@p8",chbmozzarella);
        //   // komut.Parameters.AddWithValue("@p9",);
        //    komut.Parameters.AddWithValue("@p10",dateTimePicker1.Text);
            

           // dataGridView1.DataSource = ds.SiparisListele().ToList();
        }
        void temizle()
        {
            txtid.Text = "";
            txtadsoyadı.Text = "";
            txtadres.Text = "";
            txttel.Text="";
            txttutar.Text="";
            cmbextra.Text = "";
            cmbicecek.Text="";
            cmbkenar.Text = "";
            cmbpizzaboyut.Text="";
            cmbpizzasecim.Text = "";
            dateTimePicker1.Text = "";
            nmricecek.Value = 0;
            nmrpizza.Value = 0;

        }


        void tutar()
        {
            int a = 30;
            int ko = 28;
            int ka = 33;
            int m = 30;
            int p = 30;
            int orta = 10;
            int kucuk = 5;
            int büyük = 15;
            int icecek = 10;

            int toplam1 = Convert.ToInt32(nmricecek.Value.ToString()) * icecek + Convert.ToInt32(nmrpizza.Value.ToString()) * a + büyük;
            int toplam2 = Convert.ToInt32(nmricecek.Value.ToString()) * icecek + Convert.ToInt32(nmrpizza.Value.ToString()) * a + orta;
            int toplam3 = Convert.ToInt32(nmricecek.Value.ToString()) * icecek + Convert.ToInt32(nmrpizza.Value.ToString()) * a + kucuk;
            int toplam4 = Convert.ToInt32(nmricecek.Value.ToString()) * icecek + Convert.ToInt32(nmrpizza.Value.ToString()) * ko + büyük;
            int toplam5 = Convert.ToInt32(nmricecek.Value.ToString()) * icecek + Convert.ToInt32(nmrpizza.Value.ToString()) * ko + orta;
            int toplam6 = Convert.ToInt32(nmricecek.Value.ToString()) * icecek + Convert.ToInt32(nmrpizza.Value.ToString()) * ko + kucuk;
            int toplam7 = Convert.ToInt32(nmricecek.Value.ToString()) * icecek + Convert.ToInt32(nmrpizza.Value.ToString()) * ka + büyük;
            int toplam8 = Convert.ToInt32(nmricecek.Value.ToString()) * icecek + Convert.ToInt32(nmrpizza.Value.ToString()) * ka + orta;
            int toplam9 = Convert.ToInt32(nmricecek.Value.ToString()) * icecek + Convert.ToInt32(nmrpizza.Value.ToString()) * ka + kucuk;
            int toplam10 = Convert.ToInt32(nmricecek.Value.ToString()) * icecek + Convert.ToInt32(nmrpizza.Value.ToString()) * m + büyük;
            int toplam11 = Convert.ToInt32(nmricecek.Value.ToString()) * icecek + Convert.ToInt32(nmrpizza.Value.ToString()) * m + orta;
            int toplam12 = Convert.ToInt32(nmricecek.Value.ToString()) * icecek + Convert.ToInt32(nmrpizza.Value.ToString()) * m + kucuk;
            int toplam13 = Convert.ToInt32(nmricecek.Value.ToString()) * icecek + Convert.ToInt32(nmrpizza.Value.ToString()) * p + büyük;
            int toplam14 = Convert.ToInt32(nmricecek.Value.ToString()) * icecek + Convert.ToInt32(nmrpizza.Value.ToString()) * p + orta;
            int toplam15 = Convert.ToInt32(nmricecek.Value.ToString()) * icecek + Convert.ToInt32(nmrpizza.Value.ToString()) * p + kucuk;
            if (cmbpizzasecim.SelectedItem.ToString() == "Akdenizli (30 TL)" && cmbpizzaboyut.SelectedItem.ToString() == "Büyük (+15 TL)" && cmbicecek.SelectedItem.ToString() == "Coca Cola 1lt (10 TL)")
            {
                txttutar.Text = toplam1.ToString();
            }
            if (cmbpizzasecim.SelectedItem.ToString() == "Akdenizli (30 TL)" && cmbpizzaboyut.SelectedItem.ToString() == "Büyük (+15 TL)" && cmbicecek.SelectedItem.ToString() == "Fanta 1lt (10 TL)")
            {
                txttutar.Text = toplam1.ToString();
            }
            if (cmbpizzasecim.SelectedItem.ToString() == "Akdenizli (30 TL)" && cmbpizzaboyut.SelectedItem.ToString() == "Büyük (+15 TL)" && cmbicecek.SelectedItem.ToString() == "Sprite 1lt (10 TL)")
            {
                txttutar.Text = toplam1.ToString();
            }
            if (cmbpizzasecim.SelectedItem.ToString() == "Akdenizli (30 TL)" && cmbpizzaboyut.SelectedItem.ToString() == "Büyük (+15 TL)" && cmbicecek.SelectedItem.ToString() == "Soğuk Çay Şeftali 1lt (10 TL)")
            {
                txttutar.Text = toplam1.ToString();
            }
            if (cmbpizzasecim.SelectedItem.ToString() == "Akdenizli (30 TL)" && cmbpizzaboyut.SelectedItem.ToString() == "Orta (+10 TL)" && cmbicecek.SelectedItem.ToString() == "Coca Cola 1lt (10 TL)")
            {
                txttutar.Text = toplam2.ToString();
            }
            if (cmbpizzasecim.SelectedItem.ToString() == "Akdenizli (30 TL)" && cmbpizzaboyut.SelectedItem.ToString() == "Orta (+15 TL)" && cmbicecek.SelectedItem.ToString() == "Fanta 1lt (10 TL)")
            {
                txttutar.Text = toplam2.ToString();
            }

            if (cmbpizzasecim.SelectedItem.ToString() == "Akdenizli (30 TL)" && cmbpizzaboyut.SelectedItem.ToString() == "Orta (+15 TL)" && cmbicecek.SelectedItem.ToString() == "Sprite 1lt (10 TL)")
            {
                txttutar.Text = toplam2.ToString();
            }
            if (cmbpizzasecim.SelectedItem.ToString() == "Akdenizli (30 TL)" && cmbpizzaboyut.SelectedItem.ToString() == "Orta (+15 TL)" && cmbicecek.SelectedItem.ToString() == "Soğuk Çay Şeftali 1lt (10 TL)")
            {
                txttutar.Text = toplam2.ToString();
            }
            if (cmbpizzasecim.SelectedItem.ToString() == "Akdenizli (30 TL)" && cmbpizzaboyut.SelectedItem.ToString() == "Küçük (+15 TL)" && cmbicecek.SelectedItem.ToString() == "Coca Cola 1lt (10 TL)")
            {
                txttutar.Text = toplam3.ToString();
            }
            if (cmbpizzasecim.SelectedItem.ToString() == "Akdenizli (30 TL)" && cmbpizzaboyut.SelectedItem.ToString() == "Küçük (+15 TL)" && cmbicecek.SelectedItem.ToString() == "Fanta 1lt (10 TL)")
            {
                txttutar.Text = toplam3.ToString();
            }
            if (cmbpizzasecim.SelectedItem.ToString() == "Akdenizli (30 TL)" && cmbpizzaboyut.SelectedItem.ToString() == "Küçük (+15 TL)" && cmbicecek.SelectedItem.ToString() == "Sprite 1lt (10 TL)")
            {
                txttutar.Text = toplam3.ToString();
            }
            if (cmbpizzasecim.SelectedItem.ToString() == "Akdenizli (30 TL)" && cmbpizzaboyut.SelectedItem.ToString() == "Küçük (+15 TL)" && cmbicecek.SelectedItem.ToString() == "Soğuk Çay Şeftali 1lt (10 TL)")
            {
                txttutar.Text = toplam3.ToString();
            }
            if (cmbpizzasecim.SelectedItem.ToString() == "Kopernik(28 TL)" && cmbpizzaboyut.SelectedItem.ToString() == "Büyük (+15 TL)" && cmbicecek.SelectedItem.ToString() == "Coca Cola 1lt (10 TL)")
            {
                txttutar.Text = toplam4.ToString();
            }
            if (cmbpizzasecim.SelectedItem.ToString() == "Kopernik(28 TL)" && cmbpizzaboyut.SelectedItem.ToString() == "Büyük (+15 TL)" && cmbicecek.SelectedItem.ToString() == "Fanta 1lt (10 TL)")
            {
                txttutar.Text = toplam4.ToString();
            }
            if (cmbpizzasecim.SelectedItem.ToString() == "Kopernik(28 TL)" && cmbpizzaboyut.SelectedItem.ToString() == "Büyük (+15 TL)" && cmbicecek.SelectedItem.ToString() == "Sprite 1lt (10 TL)")
            {
                txttutar.Text = toplam4.ToString();
            }
            if (cmbpizzasecim.SelectedItem.ToString() == "Kopernik(28 TL)" && cmbpizzaboyut.SelectedItem.ToString() == "Büyük (+15 TL)" && cmbicecek.SelectedItem.ToString() == "Soğuk Çay Şeftali 1lt (10 TL)")
            {
                txttutar.Text = toplam4.ToString();
            }
            if (cmbpizzasecim.SelectedItem.ToString() == "Kopernik(28 TL)" && cmbpizzaboyut.SelectedItem.ToString() == "Orta (+15 TL)" && cmbicecek.SelectedItem.ToString() == "Coca Cola 1lt (10 TL)")
            {
                txttutar.Text = toplam5.ToString();
            }
            if (cmbpizzasecim.SelectedItem.ToString() == "Kopernik(28 TL)" && cmbpizzaboyut.SelectedItem.ToString() == "Orta (+15 TL)" && cmbicecek.SelectedItem.ToString() == "Fanta 1lt (10 TL)")
            {
                txttutar.Text = toplam5.ToString();
            }
            if (cmbpizzasecim.SelectedItem.ToString() == "Kopernik(28 TL)" && cmbpizzaboyut.SelectedItem.ToString() == "Orta (+15 TL)" && cmbicecek.SelectedItem.ToString() == "Sprite 1lt (10 TL)")
            {
                txttutar.Text = toplam5.ToString();
            }
            if (cmbpizzasecim.SelectedItem.ToString() == "Kopernik(28 TL)" && cmbpizzaboyut.SelectedItem.ToString() == "Orta (+15 TL)" && cmbicecek.SelectedItem.ToString() == "Soğuk Çay Şeftali 1lt (10 TL)")
            {
                txttutar.Text = toplam5.ToString();
            }
            if (cmbpizzasecim.SelectedItem.ToString() == "Kopernik(28 TL)" && cmbpizzaboyut.SelectedItem.ToString() == "Küçük (+15 TL)" && cmbicecek.SelectedItem.ToString() == "Coca Cola 1lt (10 TL)")
            {
                txttutar.Text = toplam6.ToString();
            }
            if (cmbpizzasecim.SelectedItem.ToString() == "Kopernik(28 TL)" && cmbpizzaboyut.SelectedItem.ToString() == "Küçük (+15 TL)" && cmbicecek.SelectedItem.ToString() == "Fanta 1lt (10 TL)")
            {
                txttutar.Text = toplam6.ToString();
            }
            if (cmbpizzasecim.SelectedItem.ToString() == "Kopernik(28 TL)" && cmbpizzaboyut.SelectedItem.ToString() == "Küçük (+15 TL)" && cmbicecek.SelectedItem.ToString() == "Sprite 1lt (10 TL)")
            {
                txttutar.Text = toplam6.ToString();
            }
            if (cmbpizzasecim.SelectedItem.ToString() == "Kopernik(28 TL)" && cmbpizzaboyut.SelectedItem.ToString() == "Küçük (+15 TL)" && cmbicecek.SelectedItem.ToString() == "Soğuk Çay Şeftali 1lt (10 TL)")
            {
                txttutar.Text = toplam6.ToString();
            }
            if (cmbpizzasecim.SelectedItem.ToString() == "Kavurmalı(33 TL)" && cmbpizzaboyut.SelectedItem.ToString() == "Büyük (+15 TL)" && cmbicecek.SelectedItem.ToString() == "Coca Cola 1lt (10 TL)")
            {
                txttutar.Text = toplam7.ToString();
            }
            if (cmbpizzasecim.SelectedItem.ToString() == "Kavurmalı(33 TL)" && cmbpizzaboyut.SelectedItem.ToString() == "Büyük (+15 TL)" && cmbicecek.SelectedItem.ToString() == "Fanta 1lt (10 TL)")
            {
                txttutar.Text = toplam7.ToString();
            }
            if (cmbpizzasecim.SelectedItem.ToString() == "Kavurmalı(33 TL)" && cmbpizzaboyut.SelectedItem.ToString() == "Büyük (+15 TL)" && cmbicecek.SelectedItem.ToString() == "Sprite 1lt (10 TL)")
            {
                txttutar.Text = toplam7.ToString();
            }
            if (cmbpizzasecim.SelectedItem.ToString() == "Kavurmalı(33 TL)" && cmbpizzaboyut.SelectedItem.ToString() == "Büyük (+15 TL)" && cmbicecek.SelectedItem.ToString() == "Soğuk Çay Şeftali 1lt (10 TL)")
            {
                txttutar.Text = toplam7.ToString();
            }
            if (cmbpizzasecim.SelectedItem.ToString() == "Kavurmalı(33 TL)" && cmbpizzaboyut.SelectedItem.ToString() == "Orta (+15 TL)" && cmbicecek.SelectedItem.ToString() == "Coca Cola 1lt (10 TL)")
            {
                txttutar.Text = toplam8.ToString();
            }
            if (cmbpizzasecim.SelectedItem.ToString() == "Kavurmalı(33 TL)" && cmbpizzaboyut.SelectedItem.ToString() == "Orta (+15 TL)" && cmbicecek.SelectedItem.ToString() == "Fanta 1lt (10 TL)")
            {
                txttutar.Text = toplam8.ToString();
            }
            if (cmbpizzasecim.SelectedItem.ToString() == "Kavurmalı(33 TL)" && cmbpizzaboyut.SelectedItem.ToString() == "Orta (+15 TL)" && cmbicecek.SelectedItem.ToString() == "Sprite 1lt (10 TL)")
            {
                txttutar.Text = toplam8.ToString();
            }
            if (cmbpizzasecim.SelectedItem.ToString() == "Kavurmalı(33 TL)" && cmbpizzaboyut.SelectedItem.ToString() == "Orta (+15 TL)" && cmbicecek.SelectedItem.ToString() == "Soğuk Çay Şeftali 1lt (10 TL)")
            {
                txttutar.Text = toplam8.ToString();
            }
            if (cmbpizzasecim.SelectedItem.ToString() == "Kavurmalı(33 TL)" && cmbpizzaboyut.SelectedItem.ToString() == "Küçük (+15 TL)" && cmbicecek.SelectedItem.ToString() == "Coca Cola 1lt (10 TL)")
            {
                txttutar.Text = toplam9.ToString();
            }
            if (cmbpizzasecim.SelectedItem.ToString() == "Kavurmalı(33 TL)" && cmbpizzaboyut.SelectedItem.ToString() == "Küçük (+15 TL)" && cmbicecek.SelectedItem.ToString() == "Fanta 1lt (10 TL)")
            {
                txttutar.Text = toplam9.ToString();
            }
            if (cmbpizzasecim.SelectedItem.ToString() == "Kavurmalı(33 TL)" && cmbpizzaboyut.SelectedItem.ToString() == "Küçük (+15 TL)" && cmbicecek.SelectedItem.ToString() == "Sprite 1lt (10 TL)")
            {
                txttutar.Text = toplam9.ToString();
            }
            if (cmbpizzasecim.SelectedItem.ToString() == "Kavurmalı(33 TL)" && cmbpizzaboyut.SelectedItem.ToString() == "Küçük (+15 TL)" && cmbicecek.SelectedItem.ToString() == "Soğuk Çay Şeftali 1lt (10 TL)")
            {
                txttutar.Text = toplam9.ToString();
            }
            if (cmbpizzasecim.SelectedItem.ToString() == "Meksikalı(30 TL)" && cmbpizzaboyut.SelectedItem.ToString() == "Büyük (+15 TL)" && cmbicecek.SelectedItem.ToString() == "Coca Cola 1lt (10 TL)")
            {
                txttutar.Text = toplam10.ToString();
            }
            if (cmbpizzasecim.SelectedItem.ToString() == "Meksikalı(30 TL)" && cmbpizzaboyut.SelectedItem.ToString() == "Büyük (+15 TL)" && cmbicecek.SelectedItem.ToString() == "Fanta 1lt (10 TL)")
            {
                txttutar.Text = toplam10.ToString();
            }
            if (cmbpizzasecim.SelectedItem.ToString() == "Meksikalı(30 TL)" && cmbpizzaboyut.SelectedItem.ToString() == "Büyük (+15 TL)" && cmbicecek.SelectedItem.ToString() == "Sprite 1lt (10 TL)")
            {
                txttutar.Text = toplam10.ToString();
            }
            if (cmbpizzasecim.SelectedItem.ToString() == "Meksikalı(30 TL)" && cmbpizzaboyut.SelectedItem.ToString() == "Büyük (+15 TL)" && cmbicecek.SelectedItem.ToString() == "Soğuk Çay Şeftali 1lt (10 TL)")
            {
                txttutar.Text = toplam10.ToString();
            }
            if (cmbpizzasecim.SelectedItem.ToString() == "Meksikalı(30 TL)" && cmbpizzaboyut.SelectedItem.ToString() == "Orta (+15 TL)" && cmbicecek.SelectedItem.ToString() == "Coca Cola 1lt (10 TL)")
            {
                txttutar.Text = toplam11.ToString();
            }
            if (cmbpizzasecim.SelectedItem.ToString() == "Meksikalı(30 TL)" && cmbpizzaboyut.SelectedItem.ToString() == "Orta (+15 TL)" && cmbicecek.SelectedItem.ToString() == "Fanta 1lt (10 TL)")
            {
                txttutar.Text = toplam11.ToString();
            }
            if (cmbpizzasecim.SelectedItem.ToString() == "Meksikalı(30 TL)" && cmbpizzaboyut.SelectedItem.ToString() == "Orta (+15 TL)" && cmbicecek.SelectedItem.ToString() == "Sprite 1lt (10 TL)")
            {
                txttutar.Text = toplam11.ToString();
            }
            if (cmbpizzasecim.SelectedItem.ToString() == "Meksikalı(30 TL)" && cmbpizzaboyut.SelectedItem.ToString() == "Orta (+15 TL)" && cmbicecek.SelectedItem.ToString() == "Soğuk Çay Şeftali 1lt (10 TL)")
            {
                txttutar.Text = toplam11.ToString();
            }
            if (cmbpizzasecim.SelectedItem.ToString() == "Meksikalı(30 TL)" && cmbpizzaboyut.SelectedItem.ToString() == "Küçük (+15 TL)" && cmbicecek.SelectedItem.ToString() == "Coca Cola 1lt (10 TL)")
            {
                txttutar.Text = toplam12.ToString();
            }
            if (cmbpizzasecim.SelectedItem.ToString() == "Meksikalı(30 TL)" && cmbpizzaboyut.SelectedItem.ToString() == "Küçük (+15 TL)" && cmbicecek.SelectedItem.ToString() == "Fanta 1lt (10 TL)")
            {
                txttutar.Text = toplam12.ToString();
            }
            if (cmbpizzasecim.SelectedItem.ToString() == "Meksikalı(30 TL)" && cmbpizzaboyut.SelectedItem.ToString() == "Küçük (+15 TL)" && cmbicecek.SelectedItem.ToString() == "Sprite 1lt (10 TL)")
            {
                txttutar.Text = toplam12.ToString();
            }
            if (cmbpizzasecim.SelectedItem.ToString() == "Meksikalı(30 TL)" && cmbpizzaboyut.SelectedItem.ToString() == "Küçük (+15 TL)" && cmbicecek.SelectedItem.ToString() == "Soğuk Çay Şeftali 1lt (10 TL)")
            {
                txttutar.Text = toplam12.ToString();
            }
            if (cmbpizzasecim.SelectedItem.ToString() == "Pastırmalı(35 TL)" && cmbpizzaboyut.SelectedItem.ToString() == "Büyük (+15 TL)" && cmbicecek.SelectedItem.ToString() == "Coca Cola 1lt (10 TL)")
            {
                txttutar.Text = toplam13.ToString();
            }
            if (cmbpizzasecim.SelectedItem.ToString() == "Pastırmalı(35 TL)" && cmbpizzaboyut.SelectedItem.ToString() == "Büyük (+15 TL)" && cmbicecek.SelectedItem.ToString() == "Fanta 1lt (10 TL)")
            {
                txttutar.Text = toplam13.ToString();
            }
            if (cmbpizzasecim.SelectedItem.ToString() == "Pastırmalı(35 TL)" && cmbpizzaboyut.SelectedItem.ToString() == "Büyük (+15 TL)" && cmbicecek.SelectedItem.ToString() == "Sprite 1lt (10 TL)")
            {
                txttutar.Text = toplam13.ToString();
            }
            if (cmbpizzasecim.SelectedItem.ToString() == "Pastırmalı(35 TL)" && cmbpizzaboyut.SelectedItem.ToString() == "Büyük (+15 TL)" && cmbicecek.SelectedItem.ToString() == "Soğuk Çay Şeftali 1lt (10 TL)")
            {
                txttutar.Text = toplam13.ToString();
            }
            if (cmbpizzasecim.SelectedItem.ToString() == "Pastırmalı(35 TL)" && cmbpizzaboyut.SelectedItem.ToString() == "Orta (+15 TL)" && cmbicecek.SelectedItem.ToString() == "Coca Cola 1lt (10 TL)")
            {
                txttutar.Text = toplam14.ToString();
            }
            if (cmbpizzasecim.SelectedItem.ToString() == "Pastırmalı(35 TL)" && cmbpizzaboyut.SelectedItem.ToString() == "Orta (+15 TL)" && cmbicecek.SelectedItem.ToString() == "Fanta 1lt (10 TL)")
            {
                txttutar.Text = toplam14.ToString();
            }
            if (cmbpizzasecim.SelectedItem.ToString() == "Pastırmalı(35 TL)" && cmbpizzaboyut.SelectedItem.ToString() == "Orta (+15 TL)" && cmbicecek.SelectedItem.ToString() == "Sprite 1lt (10 TL)")
            {
                txttutar.Text = toplam14.ToString();
            }
            if (cmbpizzasecim.SelectedItem.ToString() == "Pastırmalı(35 TL)" && cmbpizzaboyut.SelectedItem.ToString() == "Orta (+15 TL)" && cmbicecek.SelectedItem.ToString() == "Soğuk Çay Şeftali 1lt (10 TL)")
            {
                txttutar.Text = toplam14.ToString();
            }
            if (cmbpizzasecim.SelectedItem.ToString() == "Pastırmalı(35 TL)" && cmbpizzaboyut.SelectedItem.ToString() == "Küçük (+15 TL)" && cmbicecek.SelectedItem.ToString() == "Coca Cola 1lt (10 TL)")
            {
                txttutar.Text = toplam15.ToString();
            }
            if (cmbpizzasecim.SelectedItem.ToString() == "Pastırmalı(35 TL)" && cmbpizzaboyut.SelectedItem.ToString() == "Küçük (+15 TL)" && cmbicecek.SelectedItem.ToString() == "Fanta 1lt (10 TL)")
            {
                txttutar.Text = toplam15.ToString();
            }
            if (cmbpizzasecim.SelectedItem.ToString() == "Pastırmalı(35 TL)" && cmbpizzaboyut.SelectedItem.ToString() == "Küçük (+15 TL)" && cmbicecek.SelectedItem.ToString() == "Sprite 1lt (10 TL)")
            {
                txttutar.Text = toplam15.ToString();
            }
            if (cmbpizzasecim.SelectedItem.ToString() == "Pastırmalı(35 TL)" && cmbpizzaboyut.SelectedItem.ToString() == "Küçük (+15 TL)" && cmbicecek.SelectedItem.ToString() == "Soğuk Çay Şeftali 1lt (10 TL)")
            {
                txttutar.Text = toplam15.ToString();
            }


        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.SiparisListele().ToList();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris();
            giris.Show();
            this.Hide();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtid.Text);
            var upt = db.TBLSPARİS.Find(x);
            upt.MUSTERIADSOYAD = txtadsoyadı.Text;
            upt.MUSTRİADRES = txtadres.Text;
            upt.KENARSECİMİ = cmbkenar.Text;
            upt.EXTRAMALZEME = cmbextra.Text;
            upt.PİZZABOYUTU = cmbpizzaboyut.Text;
            upt.PİZZASAYISI = nmrpizza.Value.ToString();
            upt.PİZZASECİMİ = cmbpizzasecim.Text;
            upt.TARİH = dateTimePicker1.Text;
            upt.TELEFON = txttel.Text;
            upt.TUTAR = int.Parse (txttutar.Text);
            upt.İCECEK = cmbicecek.Text;
            upt.İCECEKSAYISI = nmricecek.Value.ToString();
            db.SaveChanges();
            MessageBox.Show("Sipariş Bilgileriniz Güncellendi...", "Bilgi", MessageBoxButtons.OK);
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void cmbpizzasecim_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtadsoyadı.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtadres.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbpizzasecim.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            cmbpizzaboyut.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            nmrpizza.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            cmbicecek.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            nmricecek.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            cmbextra.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
            txttutar.Text = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[secilen].Cells[10].Value.ToString();
            txttel.Text = dataGridView1.Rows[secilen].Cells[11].Value.ToString();
            cmbkenar.Text = dataGridView1.Rows[secilen].Cells[12].Value.ToString();
            

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtid.Text);
            var del = db.TBLSPARİS.Find(x);
            db.TBLSPARİS.Remove(del);
            db.SaveChanges();
            MessageBox.Show("Siparişiniz Silindi...", "Bilgi", MessageBoxButtons.OK);
        }

        private void cmbextra_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtadsoyadı_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void txttel_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
