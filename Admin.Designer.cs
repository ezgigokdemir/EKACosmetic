namespace EKAKozmetik
{
    partial class Admin
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
            this.components = new System.ComponentModel.Container();
            this.bkargoguncelle = new System.Windows.Forms.Button();
            this.burunler = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bkargoguncel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ckargodurumu = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.kategoriBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eKADatabaseDataSet1 = new EKAKozmetik.EKADatabaseDataSet1();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.markaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eKADatabaseDataSet = new EKAKozmetik.EKADatabaseDataSet();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtresim = new System.Windows.Forms.TextBox();
            this.bsil = new System.Windows.Forms.Button();
            this.burunguncelle = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.tbarkotno = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tadet = new System.Windows.Forms.TextBox();
            this.tfiyat = new System.Windows.Forms.TextBox();
            this.tisim = new System.Windows.Forms.TextBox();
            this.burunekle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.markaTableAdapter = new EKAKozmetik.EKADatabaseDataSetTableAdapters.MarkaTableAdapter();
            this.kategoriTableAdapter = new EKAKozmetik.EKADatabaseDataSet1TableAdapters.KategoriTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kategoriBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eKADatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.markaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eKADatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bkargoguncelle
            // 
            this.bkargoguncelle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.bkargoguncelle.Location = new System.Drawing.Point(808, 55);
            this.bkargoguncelle.Name = "bkargoguncelle";
            this.bkargoguncelle.Size = new System.Drawing.Size(84, 37);
            this.bkargoguncelle.TabIndex = 0;
            this.bkargoguncelle.Text = "Müşteriler";
            this.bkargoguncelle.UseVisualStyleBackColor = true;
            this.bkargoguncelle.Click += new System.EventHandler(this.bkargoguncelle_Click);
            // 
            // burunler
            // 
            this.burunler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.burunler.Location = new System.Drawing.Point(808, 12);
            this.burunler.Name = "burunler";
            this.burunler.Size = new System.Drawing.Size(84, 37);
            this.burunler.TabIndex = 3;
            this.burunler.Text = "Ürünler";
            this.burunler.UseVisualStyleBackColor = true;
            this.burunler.Click += new System.EventHandler(this.burunler_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bkargoguncel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ckargodurumu);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(436, 236);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 118);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kargo Durum Güncelle";
            // 
            // bkargoguncel
            // 
            this.bkargoguncel.Location = new System.Drawing.Point(258, 28);
            this.bkargoguncel.Name = "bkargoguncel";
            this.bkargoguncel.Size = new System.Drawing.Size(100, 36);
            this.bkargoguncel.TabIndex = 7;
            this.bkargoguncel.Text = "Güncelle";
            this.bkargoguncel.UseVisualStyleBackColor = true;
            this.bkargoguncel.Click += new System.EventHandler(this.bkargoguncel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 4;
            // 
            // ckargodurumu
            // 
            this.ckargodurumu.FormattingEnabled = true;
            this.ckargodurumu.Items.AddRange(new object[] {
            "Hazırlanıyor",
            "Kargoya verildi",
            "Teslim edildi"});
            this.ckargodurumu.Location = new System.Drawing.Point(103, 43);
            this.ckargodurumu.Name = "ckargodurumu";
            this.ckargodurumu.Size = new System.Drawing.Size(121, 21);
            this.ckargodurumu.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kargo Durumu:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(13, 12);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(781, 218);
            this.dataGridView2.TabIndex = 7;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.SelectionChanged += new System.EventHandler(this.dataGridView2_SelectionChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBox2);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtresim);
            this.groupBox3.Controls.Add(this.bsil);
            this.groupBox3.Controls.Add(this.burunguncelle);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.tbarkotno);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.tadet);
            this.groupBox3.Controls.Add(this.tfiyat);
            this.groupBox3.Controls.Add(this.tisim);
            this.groupBox3.Controls.Add(this.burunekle);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(13, 236);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(417, 245);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Yeni Ürün Ekle ";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.kategoriBindingSource;
            this.comboBox2.DisplayMember = "Isim";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(93, 105);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 26;
            this.comboBox2.ValueMember = "KategoriID";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // kategoriBindingSource
            // 
            this.kategoriBindingSource.DataMember = "Kategori";
            this.kategoriBindingSource.DataSource = this.eKADatabaseDataSet1;
            // 
            // eKADatabaseDataSet1
            // 
            this.eKADatabaseDataSet1.DataSetName = "EKADatabaseDataSet1";
            this.eKADatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.markaBindingSource;
            this.comboBox1.DisplayMember = "Isim";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(93, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 25;
            this.comboBox1.ValueMember = "MarkaID";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // markaBindingSource
            // 
            this.markaBindingSource.DataMember = "Marka";
            this.markaBindingSource.DataSource = this.eKADatabaseDataSet;
            // 
            // eKADatabaseDataSet
            // 
            this.eKADatabaseDataSet.DataSetName = "EKADatabaseDataSet";
            this.eKADatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(246, 153);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 23;
            this.button1.Text = "Dosya Ekle ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Resim :";
            // 
            // txtresim
            // 
            this.txtresim.Location = new System.Drawing.Point(93, 180);
            this.txtresim.Name = "txtresim";
            this.txtresim.Size = new System.Drawing.Size(121, 20);
            this.txtresim.TabIndex = 21;
            // 
            // bsil
            // 
            this.bsil.Location = new System.Drawing.Point(311, 102);
            this.bsil.Name = "bsil";
            this.bsil.Size = new System.Drawing.Size(100, 36);
            this.bsil.TabIndex = 20;
            this.bsil.Text = "Sil";
            this.bsil.UseVisualStyleBackColor = true;
            this.bsil.Click += new System.EventHandler(this.bsil_Click);
            // 
            // burunguncelle
            // 
            this.burunguncelle.Location = new System.Drawing.Point(311, 60);
            this.burunguncelle.Name = "burunguncelle";
            this.burunguncelle.Size = new System.Drawing.Size(100, 36);
            this.burunguncelle.TabIndex = 19;
            this.burunguncelle.Text = "Güncelle";
            this.burunguncelle.UseVisualStyleBackColor = true;
            this.burunguncelle.Click += new System.EventHandler(this.burunguncelle_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(27, 128);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Barkot No :";
            // 
            // tbarkotno
            // 
            this.tbarkotno.Location = new System.Drawing.Point(93, 128);
            this.tbarkotno.Name = "tbarkotno";
            this.tbarkotno.Size = new System.Drawing.Size(121, 20);
            this.tbarkotno.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Marka :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 105);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Kategori :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 157);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Adet :";
            // 
            // tadet
            // 
            this.tadet.Location = new System.Drawing.Point(93, 154);
            this.tadet.Name = "tadet";
            this.tadet.Size = new System.Drawing.Size(121, 20);
            this.tadet.TabIndex = 11;
            this.tadet.TextChanged += new System.EventHandler(this.tadet_TextChanged);
            this.tadet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tadet_KeyPress);
            this.tadet.Leave += new System.EventHandler(this.tadet_Leave);
            // 
            // tfiyat
            // 
            this.tfiyat.Location = new System.Drawing.Point(93, 74);
            this.tfiyat.Name = "tfiyat";
            this.tfiyat.Size = new System.Drawing.Size(121, 20);
            this.tfiyat.TabIndex = 10;
            this.tfiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tfiyat_KeyPress);
            this.tfiyat.Leave += new System.EventHandler(this.tfiyat_Leave);
            // 
            // tisim
            // 
            this.tisim.Location = new System.Drawing.Point(93, 22);
            this.tisim.Name = "tisim";
            this.tisim.Size = new System.Drawing.Size(121, 20);
            this.tisim.TabIndex = 9;
            // 
            // burunekle
            // 
            this.burunekle.Location = new System.Drawing.Point(311, 20);
            this.burunekle.Name = "burunekle";
            this.burunekle.Size = new System.Drawing.Size(100, 36);
            this.burunekle.TabIndex = 7;
            this.burunekle.Text = "Ürün Ekle";
            this.burunekle.UseVisualStyleBackColor = true;
            this.burunekle.Click += new System.EventHandler(this.burunekle_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "İsim :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(73, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Fiyat :";
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(808, 98);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 37);
            this.button2.TabIndex = 11;
            this.button2.Text = "Kargo Durum Güncelle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(436, 365);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(217, 130);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Arama Motoru";
            this.groupBox2.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(103, 51);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 32);
            this.button3.TabIndex = 11;
            this.button3.Text = "Kategori Arama";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(54, 24);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 20);
            this.textBox2.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ara :";
            // 
            // markaTableAdapter
            // 
            this.markaTableAdapter.ClearBeforeFill = true;
            // 
            // kategoriTableAdapter
            // 
            this.kategoriTableAdapter.ClearBeforeFill = true;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 493);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.burunler);
            this.Controls.Add(this.bkargoguncelle);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kategoriBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eKADatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.markaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eKADatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bkargoguncelle;
        private System.Windows.Forms.Button burunler;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox ckargodurumu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bkargoguncel;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bsil;
        private System.Windows.Forms.Button burunguncelle;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbarkotno;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tadet;
        private System.Windows.Forms.TextBox tfiyat;
        private System.Windows.Forms.Button burunekle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtresim;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private EKADatabaseDataSet eKADatabaseDataSet;
        private System.Windows.Forms.BindingSource markaBindingSource;
        private EKADatabaseDataSetTableAdapters.MarkaTableAdapter markaTableAdapter;
        private EKADatabaseDataSet1 eKADatabaseDataSet1;
        private System.Windows.Forms.BindingSource kategoriBindingSource;
        private EKADatabaseDataSet1TableAdapters.KategoriTableAdapter kategoriTableAdapter;
        private System.Windows.Forms.TextBox tisim;
    }
}