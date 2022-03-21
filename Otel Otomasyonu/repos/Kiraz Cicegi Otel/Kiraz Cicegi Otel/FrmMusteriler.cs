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
    public partial class FrmMusteriler : Form
    {
        public FrmMusteriler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-T55S7FP\SQLEXPRESS;Initial Catalog=KirazCicegiOtel;Integrated Security=True");

        private void verilerigoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from MusteriEkle",baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read()) {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["MusteriID"].ToString();
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            verilerigoster();
        }
        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            MskTxtKimlikNo.Text = listView1.SelectedItems[0].SubItems[1].Text;
            TxtAdi.Text = listView1.SelectedItems[0].SubItems[2].Text;
            TxtSoyadi.Text = listView1.SelectedItems[0].SubItems[3].Text;
            CBoxCinsiyet.Text = listView1.SelectedItems[0].SubItems[4].Text;
            MskTxtTelefon.Text = listView1.SelectedItems[0].SubItems[5].Text;
            TxtMail.Text = listView1.SelectedItems[0].SubItems[6].Text;
            TxtOdaNo.Text = listView1.SelectedItems[0].SubItems[7].Text;
            TxtUcret.Text = listView1.SelectedItems[0].SubItems[8].Text;
            DTPGirisTarihi.Text = listView1.SelectedItems[0].SubItems[9].Text;
            DTPCikisTarihi.Text = listView1.SelectedItems[0].SubItems[10].Text;

        }

        private void BtnMusteriSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from MusteriEkle where MusteriID=("+id+ ")",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigoster();
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            MskTxtKimlikNo.Clear();
            TxtAdi.Clear();
            TxtSoyadi.Clear();
            CBoxCinsiyet.Text = "";
            MskTxtTelefon.Clear();
            TxtMail.Clear();
            TxtOdaNo.Clear();
            TxtUcret.Clear();
            DTPGirisTarihi.Text = "";
            DTPCikisTarihi.Text = "";

        }

        private void BtnMusteriGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update MusteriEkle set TC='" + MskTxtKimlikNo.Text + "',Adi='" + TxtAdi.Text + "',Soyadi='" + TxtSoyadi.Text + "',Cinsiyet='"+CBoxCinsiyet.Text+"',Telefon='"+MskTxtTelefon.Text+"',Mail='"+TxtMail.Text+"',OdaNo='"+TxtOdaNo.Text+"',Ucret='"+TxtUcret.Text+"',GirisTarihi='"+DTPGirisTarihi.Value.ToString("yyyy-MM-dd")+"',CikisTarihi='"+DTPCikisTarihi.Value.ToString("yyyy-MM-dd") + "'  where MusteriID="+id + "", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verilerigoster();
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from MusteriEkle where TC like '%" + textBox1.Text + "%' OR Adi like '%" + textBox1.Text+ "%' OR Soyadi like '%" + textBox1.Text + "%' OR Cinsiyet like '%" + textBox1.Text + "%' OR Telefon like '%" + textBox1.Text + "%' OR OdaNo like '%" + textBox1.Text + "%' ", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem
                {
                    Text = oku["MusteriID"].ToString()
                };
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();


        }
    }
}

//Data Source=DESKTOP-T55S7FP\SQLEXPRESS;Initial Catalog=KirazCicegiOtel;Integrated Security=True