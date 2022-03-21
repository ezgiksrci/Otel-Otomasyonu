namespace Kiraz_Cicegi_Otel
{
    partial class FrmGiderler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtYiyTopTutar = new System.Windows.Forms.TextBox();
            this.TxtYiyUrunAdi = new System.Windows.Forms.TextBox();
            this.TxtYiyMiktar = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.TxtIcTopTutar = new System.Windows.Forms.TextBox();
            this.TxtIcUrunAdi = new System.Windows.Forms.TextBox();
            this.TxtIcMiktar = new System.Windows.Forms.TextBox();
            this.TxtTemizTopTutar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtTemizUrunAdi = new System.Windows.Forms.TextBox();
            this.TxtTemizMiktar = new System.Windows.Forms.TextBox();
            this.TxtDigerTopTutar = new System.Windows.Forms.TextBox();
            this.TxtDigerUrunAdi = new System.Windows.Forms.TextBox();
            this.TxtDigerMiktar = new System.Windows.Forms.TextBox();
            this.GrpBoxDigerUrun = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.GrpBoxTemizlikUrun = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.GrpBoxIcecek = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.GrBoxYiyecek = new System.Windows.Forms.GroupBox();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.GrpBoxFaturalar = new System.Windows.Forms.GroupBox();
            this.CBoxFaturaAdi = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtFaturaTutar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.GrpBoxPersonelMaas = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.TxtPersonelMaas = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.TxtPersonelAdSoyad = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GrpBoxDigerUrun.SuspendLayout();
            this.GrpBoxTemizlikUrun.SuspendLayout();
            this.GrpBoxIcecek.SuspendLayout();
            this.GrBoxYiyecek.SuspendLayout();
            this.GrpBoxFaturalar.SuspendLayout();
            this.GrpBoxPersonelMaas.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtYiyTopTutar
            // 
            this.TxtYiyTopTutar.BackColor = System.Drawing.Color.Ivory;
            this.TxtYiyTopTutar.Location = new System.Drawing.Point(124, 108);
            this.TxtYiyTopTutar.Name = "TxtYiyTopTutar";
            this.TxtYiyTopTutar.Size = new System.Drawing.Size(170, 27);
            this.TxtYiyTopTutar.TabIndex = 3;
            // 
            // TxtYiyUrunAdi
            // 
            this.TxtYiyUrunAdi.BackColor = System.Drawing.Color.Ivory;
            this.TxtYiyUrunAdi.Location = new System.Drawing.Point(124, 43);
            this.TxtYiyUrunAdi.Name = "TxtYiyUrunAdi";
            this.TxtYiyUrunAdi.Size = new System.Drawing.Size(170, 27);
            this.TxtYiyUrunAdi.TabIndex = 1;
            // 
            // TxtYiyMiktar
            // 
            this.TxtYiyMiktar.BackColor = System.Drawing.Color.Ivory;
            this.TxtYiyMiktar.Location = new System.Drawing.Point(124, 75);
            this.TxtYiyMiktar.Name = "TxtYiyMiktar";
            this.TxtYiyMiktar.Size = new System.Drawing.Size(170, 27);
            this.TxtYiyMiktar.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Ivory;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Yiyecekler",
            "İçecekler",
            "Temizlik Ürünleri",
            "Diğer Ürünler",
            "Faturalar",
            "Personel Maaşları"});
            this.comboBox1.Location = new System.Drawing.Point(31, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(333, 27);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Text = "Gider Kategorisi Seçiniz...";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // TxtIcTopTutar
            // 
            this.TxtIcTopTutar.BackColor = System.Drawing.Color.Ivory;
            this.TxtIcTopTutar.Location = new System.Drawing.Point(142, 112);
            this.TxtIcTopTutar.Name = "TxtIcTopTutar";
            this.TxtIcTopTutar.Size = new System.Drawing.Size(170, 27);
            this.TxtIcTopTutar.TabIndex = 3;
            // 
            // TxtIcUrunAdi
            // 
            this.TxtIcUrunAdi.BackColor = System.Drawing.Color.Ivory;
            this.TxtIcUrunAdi.Location = new System.Drawing.Point(142, 47);
            this.TxtIcUrunAdi.Name = "TxtIcUrunAdi";
            this.TxtIcUrunAdi.Size = new System.Drawing.Size(170, 27);
            this.TxtIcUrunAdi.TabIndex = 1;
            // 
            // TxtIcMiktar
            // 
            this.TxtIcMiktar.BackColor = System.Drawing.Color.Ivory;
            this.TxtIcMiktar.Location = new System.Drawing.Point(142, 79);
            this.TxtIcMiktar.Name = "TxtIcMiktar";
            this.TxtIcMiktar.Size = new System.Drawing.Size(170, 27);
            this.TxtIcMiktar.TabIndex = 2;
            // 
            // TxtTemizTopTutar
            // 
            this.TxtTemizTopTutar.BackColor = System.Drawing.Color.Ivory;
            this.TxtTemizTopTutar.Location = new System.Drawing.Point(124, 114);
            this.TxtTemizTopTutar.Name = "TxtTemizTopTutar";
            this.TxtTemizTopTutar.Size = new System.Drawing.Size(170, 27);
            this.TxtTemizTopTutar.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Miktarı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Toplam Tutar:";
            // 
            // TxtTemizUrunAdi
            // 
            this.TxtTemizUrunAdi.BackColor = System.Drawing.Color.Ivory;
            this.TxtTemizUrunAdi.Location = new System.Drawing.Point(124, 45);
            this.TxtTemizUrunAdi.Name = "TxtTemizUrunAdi";
            this.TxtTemizUrunAdi.Size = new System.Drawing.Size(170, 27);
            this.TxtTemizUrunAdi.TabIndex = 1;
            // 
            // TxtTemizMiktar
            // 
            this.TxtTemizMiktar.BackColor = System.Drawing.Color.Ivory;
            this.TxtTemizMiktar.Location = new System.Drawing.Point(124, 80);
            this.TxtTemizMiktar.Name = "TxtTemizMiktar";
            this.TxtTemizMiktar.Size = new System.Drawing.Size(170, 27);
            this.TxtTemizMiktar.TabIndex = 2;
            // 
            // TxtDigerTopTutar
            // 
            this.TxtDigerTopTutar.BackColor = System.Drawing.Color.Ivory;
            this.TxtDigerTopTutar.Location = new System.Drawing.Point(142, 117);
            this.TxtDigerTopTutar.Name = "TxtDigerTopTutar";
            this.TxtDigerTopTutar.Size = new System.Drawing.Size(170, 27);
            this.TxtDigerTopTutar.TabIndex = 3;
            // 
            // TxtDigerUrunAdi
            // 
            this.TxtDigerUrunAdi.BackColor = System.Drawing.Color.Ivory;
            this.TxtDigerUrunAdi.Location = new System.Drawing.Point(142, 48);
            this.TxtDigerUrunAdi.Name = "TxtDigerUrunAdi";
            this.TxtDigerUrunAdi.Size = new System.Drawing.Size(170, 27);
            this.TxtDigerUrunAdi.TabIndex = 1;
            // 
            // TxtDigerMiktar
            // 
            this.TxtDigerMiktar.BackColor = System.Drawing.Color.Ivory;
            this.TxtDigerMiktar.Location = new System.Drawing.Point(142, 83);
            this.TxtDigerMiktar.Name = "TxtDigerMiktar";
            this.TxtDigerMiktar.Size = new System.Drawing.Size(170, 27);
            this.TxtDigerMiktar.TabIndex = 2;
            // 
            // GrpBoxDigerUrun
            // 
            this.GrpBoxDigerUrun.Controls.Add(this.TxtDigerTopTutar);
            this.GrpBoxDigerUrun.Controls.Add(this.label13);
            this.GrpBoxDigerUrun.Controls.Add(this.label14);
            this.GrpBoxDigerUrun.Controls.Add(this.label15);
            this.GrpBoxDigerUrun.Controls.Add(this.TxtDigerUrunAdi);
            this.GrpBoxDigerUrun.Controls.Add(this.TxtDigerMiktar);
            this.GrpBoxDigerUrun.Enabled = false;
            this.GrpBoxDigerUrun.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.GrpBoxDigerUrun.Location = new System.Drawing.Point(372, 254);
            this.GrpBoxDigerUrun.Name = "GrpBoxDigerUrun";
            this.GrpBoxDigerUrun.Size = new System.Drawing.Size(334, 172);
            this.GrpBoxDigerUrun.TabIndex = 9;
            this.GrpBoxDigerUrun.TabStop = false;
            this.GrpBoxDigerUrun.Text = "Diğer Ürünler";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(33, 51);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "Ürün Adı:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(33, 85);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 20);
            this.label14.TabIndex = 0;
            this.label14.Text = "Miktarı:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(33, 120);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(103, 20);
            this.label15.TabIndex = 0;
            this.label15.Text = "Toplam Tutar:";
            // 
            // GrpBoxTemizlikUrun
            // 
            this.GrpBoxTemizlikUrun.Controls.Add(this.TxtTemizTopTutar);
            this.GrpBoxTemizlikUrun.Controls.Add(this.label1);
            this.GrpBoxTemizlikUrun.Controls.Add(this.label2);
            this.GrpBoxTemizlikUrun.Controls.Add(this.label3);
            this.GrpBoxTemizlikUrun.Controls.Add(this.TxtTemizUrunAdi);
            this.GrpBoxTemizlikUrun.Controls.Add(this.TxtTemizMiktar);
            this.GrpBoxTemizlikUrun.Enabled = false;
            this.GrpBoxTemizlikUrun.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.GrpBoxTemizlikUrun.Location = new System.Drawing.Point(31, 254);
            this.GrpBoxTemizlikUrun.Name = "GrpBoxTemizlikUrun";
            this.GrpBoxTemizlikUrun.Size = new System.Drawing.Size(334, 172);
            this.GrpBoxTemizlikUrun.TabIndex = 5;
            this.GrpBoxTemizlikUrun.TabStop = false;
            this.GrpBoxTemizlikUrun.Text = "Temizlik Ürünü";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Toplam Tutar:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Miktarı:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ürün Adı:";
            // 
            // GrpBoxIcecek
            // 
            this.GrpBoxIcecek.Controls.Add(this.TxtIcTopTutar);
            this.GrpBoxIcecek.Controls.Add(this.label7);
            this.GrpBoxIcecek.Controls.Add(this.label8);
            this.GrpBoxIcecek.Controls.Add(this.label9);
            this.GrpBoxIcecek.Controls.Add(this.TxtIcUrunAdi);
            this.GrpBoxIcecek.Controls.Add(this.TxtIcMiktar);
            this.GrpBoxIcecek.Enabled = false;
            this.GrpBoxIcecek.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.GrpBoxIcecek.Location = new System.Drawing.Point(372, 75);
            this.GrpBoxIcecek.Name = "GrpBoxIcecek";
            this.GrpBoxIcecek.Size = new System.Drawing.Size(334, 172);
            this.GrpBoxIcecek.TabIndex = 7;
            this.GrpBoxIcecek.TabStop = false;
            this.GrpBoxIcecek.Text = "İçecek";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 115);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Toplam Tutar:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Miktarı:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Ürün Adı:";
            // 
            // GrBoxYiyecek
            // 
            this.GrBoxYiyecek.Controls.Add(this.TxtYiyTopTutar);
            this.GrBoxYiyecek.Controls.Add(this.label10);
            this.GrBoxYiyecek.Controls.Add(this.label11);
            this.GrBoxYiyecek.Controls.Add(this.label12);
            this.GrBoxYiyecek.Controls.Add(this.TxtYiyUrunAdi);
            this.GrBoxYiyecek.Controls.Add(this.TxtYiyMiktar);
            this.GrBoxYiyecek.Enabled = false;
            this.GrBoxYiyecek.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.GrBoxYiyecek.Location = new System.Drawing.Point(31, 73);
            this.GrBoxYiyecek.Name = "GrBoxYiyecek";
            this.GrBoxYiyecek.Size = new System.Drawing.Size(334, 172);
            this.GrBoxYiyecek.TabIndex = 5;
            this.GrBoxYiyecek.TabStop = false;
            this.GrBoxYiyecek.Text = "Yiyecek";
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.BackColor = System.Drawing.Color.LightSlateGray;
            this.BtnKaydet.Enabled = false;
            this.BtnKaydet.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKaydet.ForeColor = System.Drawing.Color.Black;
            this.BtnKaydet.Location = new System.Drawing.Point(818, 471);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(164, 67);
            this.BtnKaydet.TabIndex = 10;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = false;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // GrpBoxFaturalar
            // 
            this.GrpBoxFaturalar.Controls.Add(this.CBoxFaturaAdi);
            this.GrpBoxFaturalar.Controls.Add(this.label5);
            this.GrpBoxFaturalar.Controls.Add(this.TxtFaturaTutar);
            this.GrpBoxFaturalar.Controls.Add(this.label4);
            this.GrpBoxFaturalar.Enabled = false;
            this.GrpBoxFaturalar.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.GrpBoxFaturalar.Location = new System.Drawing.Point(713, 75);
            this.GrpBoxFaturalar.Name = "GrpBoxFaturalar";
            this.GrpBoxFaturalar.Size = new System.Drawing.Size(334, 170);
            this.GrpBoxFaturalar.TabIndex = 11;
            this.GrpBoxFaturalar.TabStop = false;
            this.GrpBoxFaturalar.Text = "Faturalar";
            // 
            // CBoxFaturaAdi
            // 
            this.CBoxFaturaAdi.BackColor = System.Drawing.Color.Ivory;
            this.CBoxFaturaAdi.FormattingEnabled = true;
            this.CBoxFaturaAdi.Items.AddRange(new object[] {
            "Elektrik",
            "Su",
            "Doğalgaz",
            "İnternet"});
            this.CBoxFaturaAdi.Location = new System.Drawing.Point(128, 63);
            this.CBoxFaturaAdi.Name = "CBoxFaturaAdi";
            this.CBoxFaturaAdi.Size = new System.Drawing.Size(170, 27);
            this.CBoxFaturaAdi.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Fatura Tutarı:";
            // 
            // TxtFaturaTutar
            // 
            this.TxtFaturaTutar.BackColor = System.Drawing.Color.Ivory;
            this.TxtFaturaTutar.Location = new System.Drawing.Point(128, 96);
            this.TxtFaturaTutar.Name = "TxtFaturaTutar";
            this.TxtFaturaTutar.Size = new System.Drawing.Size(170, 27);
            this.TxtFaturaTutar.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Fatura Adı:";
            // 
            // GrpBoxPersonelMaas
            // 
            this.GrpBoxPersonelMaas.Controls.Add(this.label18);
            this.GrpBoxPersonelMaas.Controls.Add(this.TxtPersonelMaas);
            this.GrpBoxPersonelMaas.Controls.Add(this.label17);
            this.GrpBoxPersonelMaas.Controls.Add(this.TxtPersonelAdSoyad);
            this.GrpBoxPersonelMaas.Enabled = false;
            this.GrpBoxPersonelMaas.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.GrpBoxPersonelMaas.Location = new System.Drawing.Point(717, 254);
            this.GrpBoxPersonelMaas.Name = "GrpBoxPersonelMaas";
            this.GrpBoxPersonelMaas.Size = new System.Drawing.Size(334, 172);
            this.GrpBoxPersonelMaas.TabIndex = 11;
            this.GrpBoxPersonelMaas.TabStop = false;
            this.GrpBoxPersonelMaas.Text = "Personel Maaş";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(23, 90);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(49, 20);
            this.label18.TabIndex = 0;
            this.label18.Text = "Tutar:";
            // 
            // TxtPersonelMaas
            // 
            this.TxtPersonelMaas.BackColor = System.Drawing.Color.Ivory;
            this.TxtPersonelMaas.Location = new System.Drawing.Point(124, 85);
            this.TxtPersonelMaas.Name = "TxtPersonelMaas";
            this.TxtPersonelMaas.Size = new System.Drawing.Size(170, 27);
            this.TxtPersonelMaas.TabIndex = 1;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(23, 56);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(86, 20);
            this.label17.TabIndex = 0;
            this.label17.Text = "Adı Soyadı:";
            // 
            // TxtPersonelAdSoyad
            // 
            this.TxtPersonelAdSoyad.BackColor = System.Drawing.Color.Ivory;
            this.TxtPersonelAdSoyad.Location = new System.Drawing.Point(124, 52);
            this.TxtPersonelAdSoyad.Name = "TxtPersonelAdSoyad";
            this.TxtPersonelAdSoyad.Size = new System.Drawing.Size(170, 27);
            this.TxtPersonelAdSoyad.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.Ivory;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(31, 444);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(746, 125);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Gider Adı";
            this.columnHeader1.Width = 500;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Gider Tutarı";
            this.columnHeader2.Width = 100;
            // 
            // FrmGiderler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1065, 584);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.GrpBoxPersonelMaas);
            this.Controls.Add(this.GrpBoxFaturalar);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.GrpBoxDigerUrun);
            this.Controls.Add(this.GrpBoxIcecek);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.GrpBoxTemizlikUrun);
            this.Controls.Add(this.GrBoxYiyecek);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGiderler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGiderler";
            this.GrpBoxDigerUrun.ResumeLayout(false);
            this.GrpBoxDigerUrun.PerformLayout();
            this.GrpBoxTemizlikUrun.ResumeLayout(false);
            this.GrpBoxTemizlikUrun.PerformLayout();
            this.GrpBoxIcecek.ResumeLayout(false);
            this.GrpBoxIcecek.PerformLayout();
            this.GrBoxYiyecek.ResumeLayout(false);
            this.GrBoxYiyecek.PerformLayout();
            this.GrpBoxFaturalar.ResumeLayout(false);
            this.GrpBoxFaturalar.PerformLayout();
            this.GrpBoxPersonelMaas.ResumeLayout(false);
            this.GrpBoxPersonelMaas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox TxtYiyTopTutar;
        private System.Windows.Forms.TextBox TxtYiyUrunAdi;
        private System.Windows.Forms.TextBox TxtYiyMiktar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox TxtIcTopTutar;
        private System.Windows.Forms.TextBox TxtIcUrunAdi;
        private System.Windows.Forms.TextBox TxtIcMiktar;
        private System.Windows.Forms.TextBox TxtTemizTopTutar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtTemizUrunAdi;
        private System.Windows.Forms.TextBox TxtTemizMiktar;
        private System.Windows.Forms.TextBox TxtDigerTopTutar;
        private System.Windows.Forms.TextBox TxtDigerUrunAdi;
        private System.Windows.Forms.TextBox TxtDigerMiktar;
        private System.Windows.Forms.GroupBox GrpBoxDigerUrun;
        private System.Windows.Forms.GroupBox GrpBoxTemizlikUrun;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox GrpBoxIcecek;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox GrBoxYiyecek;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.GroupBox GrpBoxFaturalar;
        private System.Windows.Forms.GroupBox GrpBoxPersonelMaas;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox TxtPersonelMaas;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox TxtPersonelAdSoyad;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtFaturaTutar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CBoxFaturaAdi;
    }
}