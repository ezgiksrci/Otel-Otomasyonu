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
    public partial class FrmAdminGiris : System.Windows.Forms.Form
    {
        public FrmAdminGiris()
        {
            InitializeComponent();
            
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-T55S7FP\SQLEXPRESS;Initial Catalog=KirazCicegiOtel;Integrated Security=True");


        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                string sql = "Select * from AdminGiris where Kullanici=@KullaniciAdi AND Parola=@AdminParola";
                SqlParameter KullaniciParam = new SqlParameter("KullaniciAdi",txtKullaniciAdi.Text.Trim());
                SqlParameter ParolaParam = new SqlParameter("AdminParola",txtParola.Text.Trim());
                SqlCommand komut = new SqlCommand(sql,baglanti);
                komut.Parameters.Add(KullaniciParam);
                komut.Parameters.Add(ParolaParam);


                DataTable table = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(komut);
                dataAdapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    FrmAnaForm fr = new FrmAnaForm();
                    fr.Show();
                    this.Hide();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Kullanıcı adı veya Parola hatalı. Bilgilerinizi kontrol ediniz.");
            }
        }
    }
}
