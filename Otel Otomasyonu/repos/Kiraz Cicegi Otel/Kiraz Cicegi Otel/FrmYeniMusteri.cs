using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Kiraz_Cicegi_Otel
{
    public partial class FrmYeniMusteri : Form
    {
        public FrmYeniMusteri()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-T55S7FP\SQLEXPRESS;Initial Catalog=KirazCicegiOtel;Integrated Security=True");
        //Yol olduğunu belirtmek için @ işareti koyduk. @ işareti yerine \ olan yere \\ koymak da sorunu çözer.



        private void BtnOda101_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "101";
        }

        private void BtnOda102_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "102";
        }

        private void BtnOda103_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "103";
        }

        private void BtnOda104_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "104";
        }

        private void BtnOda105_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "105";
        }

        private void BtnOda106_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "106";
        }

        private void BtnOda107_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "107";
        }

        private void BtnOda108_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "108";
        }

        private void BtnOda109_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "109";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeşil renk boş odaları gösterir.");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı renk dolu odaları gösterir.");
        }

        private void DTPCikisTarihi_ValueChanged(object sender, EventArgs e)
        {
            int Ucret;
            DateTime KucukTarih = Convert.ToDateTime(DTPGirisTarihi.Text);
            DateTime BuyukTarih = Convert.ToDateTime(DTPCikisTarihi.Text);

            TimeSpan Sonuc = BuyukTarih - KucukTarih;

            LblGunSayisi.Text = Sonuc.TotalDays.ToString();

            Ucret = Convert.ToInt32(LblGunSayisi.Text) * 100;
            TxtUcret.Text = Ucret.ToString();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(MskTxtKimlikNo.Text)
                || String.IsNullOrEmpty(TxtAdi.Text)
                || String.IsNullOrEmpty(TxtSoyadi.Text)
                || String.IsNullOrEmpty(CBoxCinsiyet.Text)
                || String.IsNullOrEmpty(MskTxtKimlikNo.Text)
                || String.IsNullOrEmpty(MskTxtTelefon.Text)
                || String.IsNullOrEmpty(TxtMail.Text)
                || String.IsNullOrEmpty(TxtOdaNo.Text)
                || String.IsNullOrEmpty(DTPGirisTarihi.Text)
                || String.IsNullOrEmpty(DTPCikisTarihi.Text)
                || String.IsNullOrEmpty(TxtUcret.Text))

            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.");
            }
            else
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into  MusteriEkle values(@TC,@Adi,@Soyadi,@Cinsiyet,@Telefon,@Mail,@OdaNo,@Ucret,@GirisTarihi,@CikisTarihi)", baglanti);
                komut.Parameters.AddWithValue("@TC", MskTxtKimlikNo.Text);
                komut.Parameters.AddWithValue("@Adi", TxtAdi.Text);
                komut.Parameters.AddWithValue("@Soyadi", TxtSoyadi.Text);
                komut.Parameters.AddWithValue("@Cinsiyet", CBoxCinsiyet.Text);
                komut.Parameters.AddWithValue("@Telefon", MskTxtTelefon.Text);
                komut.Parameters.AddWithValue("@Mail", TxtMail.Text);
                komut.Parameters.AddWithValue("@OdaNo", TxtOdaNo.Text);
                komut.Parameters.AddWithValue("@Ucret", TxtUcret.Text);
                komut.Parameters.AddWithValue("@GirisTarihi", DTPGirisTarihi.Value.ToString("yyyy-MM-dd"));
                komut.Parameters.AddWithValue("@CikisTarihi", DTPCikisTarihi.Value.ToString("yyyy-MM-dd"));

                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Müşteri Kaydı Yapıldı.");
                this.Hide();

            }
        }
        private void FrmYeniMusteri_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from MusteriEkle", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                if (oku["OdaNo"].ToString() == "101")
                {
                    BtnOda101.Text = "DOLU";
                    BtnOda101.BackColor = Color.Red;
                    BtnOda101.Enabled = false;
                }

                if (oku["OdaNo"].ToString() == "102")
                {
                    BtnOda102.Text = "DOLU";
                    BtnOda102.BackColor = Color.Red;
                    BtnOda102.Enabled = false;
                }

                if (oku["OdaNo"].ToString() == "103")
                {
                    BtnOda103.Text = "DOLU";
                    BtnOda103.BackColor = Color.Red;
                    BtnOda103.Enabled = false;
                }

                if (oku["OdaNo"].ToString() == "104")
                {
                    BtnOda104.Text = "DOLU";
                    BtnOda104.BackColor = Color.Red;
                    BtnOda104.Enabled = false;
                }

                if (oku["OdaNo"].ToString() == "105")
                {
                    BtnOda105.Text = "DOLU";
                    BtnOda105.BackColor = Color.Red;
                    BtnOda105.Enabled = false;
                }

                if (oku["OdaNo"].ToString() == "106")
                {
                    BtnOda106.Text = "DOLU";
                    BtnOda106.BackColor = Color.Red;
                    BtnOda106.Enabled = false;
                }

                if (oku["OdaNo"].ToString() == "107")
                {
                    BtnOda107.Text = "DOLU";
                    BtnOda107.BackColor = Color.Red;
                    BtnOda107.Enabled = false;
                }

                if (oku["OdaNo"].ToString() == "108")
                {
                    BtnOda108.Text = "DOLU";
                    BtnOda108.BackColor = Color.Red;
                    BtnOda108.Enabled = false;
                }

                if (oku["OdaNo"].ToString() == "109")
                {
                    BtnOda109.Text = "DOLU";
                    BtnOda109.BackColor = Color.Red;
                    BtnOda109.Enabled = false;
                }
            }
            baglanti.Close();
        }

    }
}

//Data Source=DESKTOP-T55S7FP\SQLEXPRESS;Initial Catalog=KirazCicegiOtel;Integrated Security=True