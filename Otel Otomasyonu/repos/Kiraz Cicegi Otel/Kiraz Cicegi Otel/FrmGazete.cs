using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;


namespace Kiraz_Cicegi_Otel
{
    public partial class FrmGazete : Form
    {
        public FrmGazete()
        {
            InitializeComponent();

        }


        private void BtnAA_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            XmlTextReader xmlOku = new XmlTextReader("https://www.aa.com.tr/tr/rss/default?cat=guncel");

            while (xmlOku.Read())
            {
                if (xmlOku.Name == "title")
                {
                    listBox1.Items.Add("■ " + xmlOku.ReadString());
                    //listBox1.Items.Add("");
                }
                if (xmlOku.Name=="description")
                {
                    listBox1.Items.Add(xmlOku.ReadString());
                    listBox1.Items.Add(" ");
                }

            }
        }

        private void BtnHaberTurk_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            XmlTextReader xmlOku = new XmlTextReader("http://www.haberturk.com/rss");

            while (xmlOku.Read())
            {
                if (xmlOku.Name == "title")
                {
                    listBox1.Items.Add("■ " + xmlOku.ReadString());
                    listBox1.Items.Add("");
                }
            }
        }

        private void BtnSabah_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            XmlTextReader xmlOku = new XmlTextReader("https://www.sabah.com.tr/rss/anasayfa.xml");

            while (xmlOku.Read())
            {
                if (xmlOku.Name == "title")
                {
                    listBox1.Items.Add("■ " + xmlOku.ReadString());
                    listBox1.Items.Add("");
                }
            }
        }


        private void BtnAnayurtGzt_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            XmlTextReader xmlOku = new XmlTextReader("http://www.anayurtgazetesi.com/sondakika.xml");

            while (xmlOku.Read())
            {
                if (xmlOku.Name == "title")
                {
                    listBox1.Items.Add("■ " + xmlOku.ReadString());
                    listBox1.Items.Add("");
                }
            }
        }

        private void BtnBirgun_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            XmlTextReader xmlOku = new XmlTextReader("https://www.birgun.net/feed");

            while (xmlOku.Read())
            {
                if (xmlOku.Name == "title")
                {
                    listBox1.Items.Add("■ " + xmlOku.ReadString());
                    listBox1.Items.Add("");
                }
            }
        }

        private void BtnCumhuriyet_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            XmlTextReader xmlOku = new XmlTextReader("http://www.cumhuriyet.com.tr/rss/son_dakika.xml");

            while (xmlOku.Read())
            {
                if (xmlOku.Name == "title")
                {
                    listBox1.Items.Add("■ " + xmlOku.ReadString());
                    listBox1.Items.Add("");
                }
            }
        }

        private void BtnDunya_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            XmlTextReader xmlOku = new XmlTextReader("https://www.dunya.com/rss");

            while (xmlOku.Read())
            {
                if (xmlOku.Name == "title")
                {
                    listBox1.Items.Add("■ " + xmlOku.ReadString());
                    listBox1.Items.Add("");
                }
            }
        }

        private void BtnHurriyet_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            XmlTextReader xmlOku = new XmlTextReader("http://www.hurriyet.com.tr/rss/anasayfa");

            while (xmlOku.Read())
            {
                if (xmlOku.Name == "title")
                {
                    listBox1.Items.Add("■ " + xmlOku.ReadString());
                }
            }
        }

        private void BtnMilliyet_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            XmlTextReader xmlOku = new XmlTextReader("http://www.milliyet.com.tr/rss/rssNew/gundemRss.xml");

            while (xmlOku.Read())
            {
                if (xmlOku.Name == "title")
                {
                    listBox1.Items.Add("■ " + xmlOku.ReadString());
                    listBox1.Items.Add("");
                }
            }
        }

        private void BtnTakvim_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            XmlTextReader xmlOku = new XmlTextReader("https://www.takvim.com.tr/rss/anasayfa.xml");

            while (xmlOku.Read())
            {
                if (xmlOku.Name == "title")
                {
                    listBox1.Items.Add("■ " + xmlOku.ReadString());
                    listBox1.Items.Add("");
                }
            }
        }

        private void BtnTurkiye_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            XmlTextReader xmlOku = new XmlTextReader("http://www.turkiyegazetesi.com.tr/rss/rss.xml");

            while (xmlOku.Read())
            {
                if (xmlOku.Name == "title")
                {
                    listBox1.Items.Add("■ " + xmlOku.ReadString());
                    listBox1.Items.Add("");
                }
            }
        }

        private void BtnTRTHaber_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            XmlTextReader xmlOku = new XmlTextReader("http://www.trt.net.tr/rss/gundem.rss");

            while (xmlOku.Read())
            {
                if (xmlOku.Name == "title")
                {
                    listBox1.Items.Add("■ " + xmlOku.ReadString());
                    listBox1.Items.Add("");
                }
            }
        }
    }
}
