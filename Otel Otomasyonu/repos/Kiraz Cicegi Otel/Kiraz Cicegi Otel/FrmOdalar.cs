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
    public partial class FrmOdalar : Form
    {
        public FrmOdalar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-T55S7FP\SQLEXPRESS;Initial Catalog=KirazCicegiOtel;Integrated Security=True");

        private void FrmOdalar_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from MusteriEkle", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                if (oku["OdaNo"].ToString() == "101")
                {
                    BtnOda101.Text = oku["Adi"].ToString() + " " + oku["Soyadi"].ToString();
                    BtnOda101.BackColor = Color.Red;
                }

                if (oku["OdaNo"].ToString() == "102")
                {
                    BtnOda102.Text = oku["Adi"].ToString() + " " + oku["Soyadi"].ToString();
                    BtnOda102.BackColor = Color.Red;
                }

                if (oku["OdaNo"].ToString() == "103")
                {
                    BtnOda103.Text = oku["Adi"].ToString() + " " + oku["Soyadi"].ToString();
                    BtnOda103.BackColor = Color.Red;
                }

                if (oku["OdaNo"].ToString() == "104")
                {
                    BtnOda104.Text = oku["Adi"].ToString() + " " + oku["Soyadi"].ToString();
                    BtnOda104.BackColor = Color.Red;
                }

                if (oku["OdaNo"].ToString() == "105")
                {
                    BtnOda105.Text = oku["Adi"].ToString() + " " + oku["Soyadi"].ToString();
                    BtnOda105.BackColor = Color.Red;
                }

                if (oku["OdaNo"].ToString() == "106")
                {
                    BtnOda106.Text = oku["Adi"].ToString() + " " + oku["Soyadi"].ToString();
                    BtnOda106.BackColor = Color.Red;
                }

                if (oku["OdaNo"].ToString() == "107")
                {
                    BtnOda107.Text = oku["Adi"].ToString() + " " + oku["Soyadi"].ToString();
                    BtnOda107.BackColor = Color.Red;
                }

                if (oku["OdaNo"].ToString() == "108")
                {
                    BtnOda108.Text = oku["Adi"].ToString() + " " + oku["Soyadi"].ToString();
                    BtnOda108.BackColor = Color.Red;
                }

                if (oku["OdaNo"].ToString() == "109")
                {
                    BtnOda109.Text = oku["Adi"].ToString() + " " + oku["Soyadi"].ToString();
                    BtnOda109.BackColor = Color.Red;
                }





            }
            baglanti.Close();
        }
    }
}
