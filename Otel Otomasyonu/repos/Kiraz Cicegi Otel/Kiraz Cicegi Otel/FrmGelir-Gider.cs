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
    public partial class FrmGelir_Gider : Form
    {
        public FrmGelir_Gider()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-T55S7FP\SQLEXPRESS;Initial Catalog=KirazCicegiOtel;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void BtnGelirEkle_Click(object sender, EventArgs e)
        {
            if (TxtGelirTutari.Text.All(char.IsDigit) == false || string.IsNullOrEmpty(TxtGelirAdi.Text) || string.IsNullOrEmpty(TxtGelirTutari.Text))
            {                
                MessageBox.Show("Bilgileri Kontrol Ediniz.");
            }
            
            else
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into DigerGelirler values(@GelirAdi,@Tutar)", baglanti);
                komut.Parameters.AddWithValue("@GelirAdi", TxtGelirAdi.Text);
                komut.Parameters.AddWithValue("@Tutar", TxtGelirTutari.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Ek gelir kaydı yapıldı.");
                baglanti.Close();

                baglanti.Open();
                SqlCommand komut1 = new SqlCommand("select sum(Tutar) as topEkgelir from DigerGelirler ", baglanti);
                SqlDataReader oku1 = komut1.ExecuteReader();
                while (oku1.Read())
                {
                    LblEkGelir.Text = oku1["topEkgelir"].ToString();
                }
                baglanti.Close();
            }
        }

        private void FrmGelir_Gider_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select sum(Ucret) as topOdaGelir from MusteriEkle ", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                LblOdaGelir.Text = oku["topOdaGelir"].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select sum(Tutar) as topEkgelir from DigerGelirler ", baglanti);
            SqlDataReader oku1 = komut1.ExecuteReader();
            while (oku1.Read())
            {
                LblEkGelir.Text = oku1["topEkgelir"].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select sum(ToplamTutar) as topYiyecekTutar from Yiyecek ", baglanti);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                LblYiyecek.Text = oku2["topYiyecekTutar"].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select sum(ToplamTutar) as topIcecekTutar from Icecek ", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                LblIcecek.Text = oku3["topIcecekTutar"].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select sum(ToplamTutar) as topTemizlikTutar from TemizlikUrunleri ", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();
            while (oku4.Read())
            {
                LblTemizlik.Text = oku4["topTemizlikTutar"].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("select sum(ToplamTutar) as topDigerTutar from DigerUrunler ", baglanti);
            SqlDataReader oku5 = komut5.ExecuteReader();
            while (oku5.Read())
            {
                LblDiger.Text = oku5["topDigerTutar"].ToString();
            }
            baglanti.Close();

            int ToplamAlinanUrunler;
            ToplamAlinanUrunler=Convert.ToInt32(LblYiyecek.Text)+Convert.ToInt32(LblIcecek.Text)+Convert.ToInt32(LblTemizlik.Text)+Convert.ToInt32(LblDiger.Text);
            LblAlinanUrunlerToplam.Text = ToplamAlinanUrunler.ToString();

            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select sum(FaturaTutari) as topFaturaTutar from Faturalar ", baglanti);
            SqlDataReader oku6 = komut6.ExecuteReader();
            while (oku6.Read())
            {
                LblFaturaTutar.Text = oku6["topFaturaTutar"].ToString();
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("select sum(Tutar) as topMaas from PersonelMaas ", baglanti);
            SqlDataReader oku7 = komut7.ExecuteReader();
            while (oku7.Read())
            {
                LblPersonelMaasTutar.Text = oku7["topMaas"].ToString();
            }
            baglanti.Close();

            LblGelirTop.Text = (Convert.ToInt32(LblOdaGelir.Text) + Convert.ToInt32(LblEkGelir.Text)).ToString();
            LblGiderTop.Text = (Convert.ToInt32(LblAlinanUrunlerToplam.Text)+Convert.ToInt32(LblFaturaTutar.Text)+Convert.ToInt32(LblPersonelMaasTutar.Text)).ToString();

            LblSonuc.Text=(Convert.ToInt32(LblGelirTop.Text)-Convert.ToInt32(LblGiderTop.Text)).ToString();
            if (Convert.ToInt32(LblSonuc.Text)>0)
            {
                LblSonuc.ForeColor =Color.FromArgb(0,255,0);
            }
            else if (Convert.ToInt32(LblSonuc.Text) < 0)
            {
                LblSonuc.ForeColor = Color.FromArgb(255, 0, 0);
            }
        }
    }

}
