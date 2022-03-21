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
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-T55S7FP\SQLEXPRESS;Initial Catalog=KirazCicegiOtel;Integrated Security=True");
        private void BtnYeniMusteri_Click(object sender, EventArgs e)
        {
            FrmYeniMusteri fr = new FrmYeniMusteri();
            fr.Show();

        }
        private void BtnOdaDurum_Click(object sender, EventArgs e)
        {
            FrmOdalar fr = new FrmOdalar();
            fr.Show();
        }

        private void BtnMusteriler_Click(object sender, EventArgs e)
        {
            FrmMusteriler fr = new FrmMusteriler();
            fr.Show();
        }

        private void FrmAnaForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update MusteriEkle set OdaNo='" + "---" + "' where  CikisTarihi < CURRENT_TIMESTAMP", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LblTarih.Text = DateTime.Now.ToLongDateString();
            LblSaat.Text = DateTime.Now.ToLongTimeString();
        }

        private void BtnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnGelirGider_Click(object sender, EventArgs e)
        {
            FrmGelir_Gider fr = new FrmGelir_Gider();
            fr.Show();
        }

        private void BtnGiderEkle_Click(object sender, EventArgs e)
        {
            FrmGiderler fr = new FrmGiderler();
            fr.Show();
        }

        private void BtnRadyo_Click(object sender, EventArgs e)
        {
            FrmRadyo fr = new FrmRadyo();
            fr.Show();
        }

        private void BtnGazete_Click(object sender, EventArgs e)
        {
            FrmGazete fr = new FrmGazete();
            fr.Show();
        }

        private void BtnMusteriMesaj_Click(object sender, EventArgs e)
        {
            FrmMusteriMesajlari fr = new FrmMusteriMesajlari();
            fr.Show();
        }

        private void BtnAdminGuncelle_Click(object sender, EventArgs e)
        {
            FrmAdminBilgiGuncelle fr = new FrmAdminBilgiGuncelle();
            fr.Show();
        }
    }
}
