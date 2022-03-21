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
    public partial class FrmAdminBilgiGuncelle : Form
    {
        public FrmAdminBilgiGuncelle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-T55S7FP\SQLEXPRESS;Initial Catalog=KirazCicegiOtel;Integrated Security=True");

        private void FrmAdminBilgiGuncelle_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select Kullanici From AdminGiris", baglanti);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                TxtYeniKullaniciAdi.Text = oku["Kullanici"].ToString();
            }
            baglanti.Close();

            // Form açıldığında güncel kullanıcı adı textbox'da yazılı olarak gelir.
        }

        private void TxtGuncelle_Click(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder connectionStringBuilder = new SqlConnectionStringBuilder();
            connectionStringBuilder.DataSource = ".";
            connectionStringBuilder.InitialCatalog = "temp";
            connectionStringBuilder.IntegratedSecurity = true;

            SqlConnection connection = new SqlConnection(connectionStringBuilder.ToString());
            SqlCommand command = new SqlCommand("select Parola from AdminGiris", baglanti);
            baglanti.Open();
            string value = command.ExecuteScalar() as string;
            baglanti.Close();

            if (TxtParola.Text.Equals(value) && TxtYParola.Text == TxtYParolaTekrar.Text)
            {
                if (String.IsNullOrEmpty(TxtYeniKullaniciAdi.Text) || String.IsNullOrEmpty(TxtParola.Text) || String.IsNullOrEmpty(TxtYParola.Text) || String.IsNullOrEmpty(TxtYParolaTekrar.Text))
                {
                    MessageBox.Show("Hata! Lütfen girdiğiniz bilgileri kontrol ederek tekrar deneyiniz...");
                }
                else
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("update AdminGiris Set kullanici=@Kullanici, parola=@Parola", baglanti);
                    komut.Parameters.AddWithValue("@Kullanici", TxtYeniKullaniciAdi.Text);
                    komut.Parameters.AddWithValue("@Parola", TxtYParola.Text);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("İşlem Başarılı!");
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Hata! Lütfen girdiğiniz bilgileri kontrol ederek tekrar deneyiniz...");
            }
        }
    }
}
