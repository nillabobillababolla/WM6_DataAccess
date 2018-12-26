namespace EF_TemelCrudIslemleri
{
    partial class Form1
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
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.txtKategoriAdi = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.RichTextBox();
            this.btnKatKaydet = new System.Windows.Forms.Button();
            this.ep1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lstUrunler = new System.Windows.Forms.ListBox();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.nuFiyat = new System.Windows.Forms.NumericUpDown();
            this.cmbUrunKategori = new System.Windows.Forms.ComboBox();
            this.btnUrunGuncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ep1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuFiyat)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbKategori
            // 
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(12, 12);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(121, 21);
            this.cmbKategori.TabIndex = 0;
            this.cmbKategori.SelectedIndexChanged += new System.EventHandler(this.cmbKategori_SelectedIndexChanged);
            // 
            // txtKategoriAdi
            // 
            this.txtKategoriAdi.Location = new System.Drawing.Point(12, 39);
            this.txtKategoriAdi.Name = "txtKategoriAdi";
            this.txtKategoriAdi.Size = new System.Drawing.Size(121, 20);
            this.txtKategoriAdi.TabIndex = 1;
            this.txtKategoriAdi.MouseHover += new System.EventHandler(this.txtKategoriAdi_MouseHover);
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(12, 65);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(121, 96);
            this.txtAciklama.TabIndex = 2;
            this.txtAciklama.Text = "";
            // 
            // btnKatKaydet
            // 
            this.btnKatKaydet.Location = new System.Drawing.Point(12, 167);
            this.btnKatKaydet.Name = "btnKatKaydet";
            this.btnKatKaydet.Size = new System.Drawing.Size(121, 23);
            this.btnKatKaydet.TabIndex = 3;
            this.btnKatKaydet.Text = "Kategori Kaydet";
            this.btnKatKaydet.UseVisualStyleBackColor = true;
            this.btnKatKaydet.Click += new System.EventHandler(this.btnKatKaydet_Click);
            // 
            // ep1
            // 
            this.ep1.BlinkRate = 1;
            this.ep1.ContainerControl = this;
            // 
            // lstUrunler
            // 
            this.lstUrunler.FormattingEnabled = true;
            this.lstUrunler.Location = new System.Drawing.Point(139, 12);
            this.lstUrunler.Name = "lstUrunler";
            this.lstUrunler.Size = new System.Drawing.Size(448, 147);
            this.lstUrunler.TabIndex = 4;
            this.lstUrunler.SelectedIndexChanged += new System.EventHandler(this.lstUrunler_SelectedIndexChanged);
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(604, 12);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(120, 20);
            this.txtUrunAdi.TabIndex = 5;
            // 
            // nuFiyat
            // 
            this.nuFiyat.DecimalPlaces = 2;
            this.nuFiyat.Location = new System.Drawing.Point(604, 38);
            this.nuFiyat.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nuFiyat.Name = "nuFiyat";
            this.nuFiyat.Size = new System.Drawing.Size(120, 20);
            this.nuFiyat.TabIndex = 6;
            // 
            // cmbUrunKategori
            // 
            this.cmbUrunKategori.FormattingEnabled = true;
            this.cmbUrunKategori.Location = new System.Drawing.Point(604, 65);
            this.cmbUrunKategori.Name = "cmbUrunKategori";
            this.cmbUrunKategori.Size = new System.Drawing.Size(120, 21);
            this.cmbUrunKategori.TabIndex = 7;
            // 
            // btnUrunGuncelle
            // 
            this.btnUrunGuncelle.Location = new System.Drawing.Point(604, 124);
            this.btnUrunGuncelle.Name = "btnUrunGuncelle";
            this.btnUrunGuncelle.Size = new System.Drawing.Size(120, 35);
            this.btnUrunGuncelle.TabIndex = 8;
            this.btnUrunGuncelle.Text = "Ürün Güncelle";
            this.btnUrunGuncelle.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUrunGuncelle);
            this.Controls.Add(this.cmbUrunKategori);
            this.Controls.Add(this.nuFiyat);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.lstUrunler);
            this.Controls.Add(this.btnKatKaydet);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtKategoriAdi);
            this.Controls.Add(this.cmbKategori);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ep1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuFiyat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.TextBox txtKategoriAdi;
        private System.Windows.Forms.RichTextBox txtAciklama;
        private System.Windows.Forms.Button btnKatKaydet;
        private System.Windows.Forms.ErrorProvider ep1;
        private System.Windows.Forms.ListBox lstUrunler;
        private System.Windows.Forms.Button btnUrunGuncelle;
        private System.Windows.Forms.ComboBox cmbUrunKategori;
        private System.Windows.Forms.NumericUpDown nuFiyat;
        private System.Windows.Forms.TextBox txtUrunAdi;
    }
}

