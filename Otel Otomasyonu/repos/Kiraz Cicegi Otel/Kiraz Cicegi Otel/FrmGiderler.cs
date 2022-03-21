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
    public partial class FrmGiderler : Form
    {
        public FrmGiderler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-T55S7FP\SQLEXPRESS;Initial Catalog=KirazCicegiOtel;Integrated Security=True");

        private void yiyeceklerigoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Yiyecek", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["UrunAdi"].ToString() + " " + oku["Miktar"].ToString();
                ekle.SubItems.Add(oku["ToplamTutar"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void iceceklerigoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Icecek", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["UrunAdi"].ToString() + " " + oku["Miktar"].ToString();
                ekle.SubItems.Add(oku["ToplamTutar"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void temizlikurunlerigoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from TemizlikUrunleri", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["UrunAdi"].ToString() + " " + oku["Miktar"].ToString();
                ekle.SubItems.Add(oku["ToplamTutar"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void digerurunlerigoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from DigerUrunler", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["UrunAdi"].ToString() + " " + oku["Miktar"].ToString();
                ekle.SubItems.Add(oku["ToplamTutar"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }
        private void faturagoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Faturalar", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["FaturaAdi"].ToString();
                ekle.SubItems.Add(oku["FaturaTutari"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void personelmaasgoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from PersonelMaas", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["AdSoyad"].ToString();
                ekle.SubItems.Add(oku["Tutar"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                GrBoxYiyecek.Enabled = true;
                GrpBoxIcecek.Enabled = false;
                GrpBoxTemizlikUrun.Enabled = false;
                GrpBoxDigerUrun.Enabled = false;
                GrpBoxFaturalar.Enabled = false;
                GrpBoxPersonelMaas.Enabled = false;
                BtnKaydet.Enabled = true;
                yiyeceklerigoster();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                GrBoxYiyecek.Enabled = false;
                GrpBoxIcecek.Enabled = true;
                GrpBoxTemizlikUrun.Enabled = false;
                GrpBoxDigerUrun.Enabled = false;
                BtnKaydet.Enabled = true;
                GrpBoxFaturalar.Enabled = false;
                GrpBoxPersonelMaas.Enabled = false;
                iceceklerigoster();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                GrBoxYiyecek.Enabled = false;
                GrpBoxIcecek.Enabled = false;
                GrpBoxTemizlikUrun.Enabled = true;
                GrpBoxDigerUrun.Enabled = false;
                BtnKaydet.Enabled = true;
                GrpBoxFaturalar.Enabled = false;
                GrpBoxPersonelMaas.Enabled = false;
                temizlikurunlerigoster();
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                GrBoxYiyecek.Enabled = false;
                GrpBoxIcecek.Enabled = false;
                GrpBoxTemizlikUrun.Enabled = false;
                GrpBoxDigerUrun.Enabled = true;
                BtnKaydet.Enabled = true;
                GrpBoxFaturalar.Enabled = false;
                GrpBoxPersonelMaas.Enabled = false;
                digerurunlerigoster();
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                GrBoxYiyecek.Enabled = false;
                GrpBoxIcecek.Enabled = false;
                GrpBoxTemizlikUrun.Enabled = false;
                GrpBoxDigerUrun.Enabled = false;
                BtnKaydet.Enabled = true;
                GrpBoxFaturalar.Enabled = true;
                GrpBoxPersonelMaas.Enabled = false;
                faturagoster();
            }
            else if (comboBox1.SelectedIndex == 5)
            {
                GrBoxYiyecek.Enabled = false;
                GrpBoxIcecek.Enabled = false;
                GrpBoxTemizlikUrun.Enabled = false;
                GrpBoxDigerUrun.Enabled = false;
                BtnKaydet.Enabled = true;
                GrpBoxFaturalar.Enabled = false;
                GrpBoxPersonelMaas.Enabled = true;
                personelmaasgoster();
            }

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into  Yiyecek values(@UrunAdi,@Miktar,@ToplamTutar)", baglanti);
                komut.Parameters.AddWithValue("@UrunAdi", TxtYiyUrunAdi.Text);
                komut.Parameters.AddWithValue("@Miktar", TxtYiyMiktar.Text);
                komut.Parameters.AddWithValue("@ToplamTutar", TxtYiyTopTutar.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Yiyecek kaydı yapıldı.");
            }
            else
            if (comboBox1.SelectedIndex == 1)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into  Icecek values(@UrunAdi,@Miktar,@ToplamTutar)", baglanti);
                komut.Parameters.AddWithValue("@UrunAdi", TxtIcUrunAdi.Text);
                komut.Parameters.AddWithValue("@Miktar", TxtIcMiktar.Text);
                komut.Parameters.AddWithValue("@ToplamTutar", TxtIcTopTutar.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("İçecek kaydı yapıldı.");
            }
            else
            if (comboBox1.SelectedIndex == 2)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into  TemizlikUrunleri values(@UrunAdi,@Miktar,@ToplamTutar)", baglanti);
                komut.Parameters.AddWithValue("@UrunAdi", TxtTemizUrunAdi.Text);
                komut.Parameters.AddWithValue("@Miktar", TxtTemizMiktar.Text);
                komut.Parameters.AddWithValue("@ToplamTutar", TxtTemizTopTutar.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Temizlik ürünü kaydı yapıldı.");
            }
            else
            if (comboBox1.SelectedIndex == 3)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into  DigerUrunler values(@UrunAdi,@Miktar,@ToplamTutar)", baglanti);
                komut.Parameters.AddWithValue("@UrunAdi", TxtDigerUrunAdi.Text);
                komut.Parameters.AddWithValue("@Miktar", TxtDigerMiktar.Text);
                komut.Parameters.AddWithValue("@ToplamTutar", TxtDigerTopTutar.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Diğer ürün kaydı yapıldı.");
            }
            else
            if (comboBox1.SelectedIndex == 4)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into  Faturalar values(@FaturaAdi,@FaturaTutari)", baglanti);
                komut.Parameters.AddWithValue("@FaturaAdi", CBoxFaturaAdi.Text);
                komut.Parameters.AddWithValue("@FaturaTutari", TxtFaturaTutar.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Fatura kaydı yapıldı.");
            }
            else
            if (comboBox1.SelectedIndex == 5)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into  PersonelMaas values(@AdSoyad,@Tutar)", baglanti);
                komut.Parameters.AddWithValue("@AdSoyad", TxtPersonelAdSoyad.Text);
                komut.Parameters.AddWithValue("@Tutar", TxtPersonelMaas.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Maaş kaydı yapıldı.");
            }

        }


    }
}
