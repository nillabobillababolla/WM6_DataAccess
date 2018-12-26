namespace CrudOdev
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
            this.txtArama = new System.Windows.Forms.TextBox();
            this.lstUrunler = new System.Windows.Forms.ListBox();
            this.btnSepeteEkle = new System.Windows.Forms.Button();
            this.cbMusteri = new System.Windows.Forms.ComboBox();
            this.cbNakliye = new System.Windows.Forms.ComboBox();
            this.cbCalisan = new System.Windows.Forms.ComboBox();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.txtNakliyeUcreti = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.lstSepet = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cikartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSepetToplam = new System.Windows.Forms.TextBox();
            this.btnSiparisVer = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.gbUrunDetay = new System.Windows.Forms.GroupBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.gbUrunDetay.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtArama
            // 
            this.txtArama.Location = new System.Drawing.Point(12, 12);
            this.txtArama.Name = "txtArama";
            this.txtArama.Size = new System.Drawing.Size(200, 20);
            this.txtArama.TabIndex = 0;
            this.txtArama.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtArama_KeyUp);
            // 
            // lstUrunler
            // 
            this.lstUrunler.FormattingEnabled = true;
            this.lstUrunler.Location = new System.Drawing.Point(12, 38);
            this.lstUrunler.Name = "lstUrunler";
            this.lstUrunler.Size = new System.Drawing.Size(200, 277);
            this.lstUrunler.TabIndex = 1;
            // 
            // btnSepeteEkle
            // 
            this.btnSepeteEkle.Location = new System.Drawing.Point(218, 38);
            this.btnSepeteEkle.Name = "btnSepeteEkle";
            this.btnSepeteEkle.Size = new System.Drawing.Size(121, 23);
            this.btnSepeteEkle.TabIndex = 2;
            this.btnSepeteEkle.Text = "Sepete Ekle";
            this.btnSepeteEkle.UseVisualStyleBackColor = true;
            this.btnSepeteEkle.Click += new System.EventHandler(this.btnSepeteEkle_Click);
            // 
            // cbMusteri
            // 
            this.cbMusteri.FormattingEnabled = true;
            this.cbMusteri.Location = new System.Drawing.Point(218, 67);
            this.cbMusteri.Name = "cbMusteri";
            this.cbMusteri.Size = new System.Drawing.Size(203, 21);
            this.cbMusteri.TabIndex = 3;
            // 
            // cbNakliye
            // 
            this.cbNakliye.FormattingEnabled = true;
            this.cbNakliye.Location = new System.Drawing.Point(218, 94);
            this.cbNakliye.Name = "cbNakliye";
            this.cbNakliye.Size = new System.Drawing.Size(203, 21);
            this.cbNakliye.TabIndex = 3;
            // 
            // cbCalisan
            // 
            this.cbCalisan.FormattingEnabled = true;
            this.cbCalisan.Location = new System.Drawing.Point(218, 121);
            this.cbCalisan.Name = "cbCalisan";
            this.cbCalisan.Size = new System.Drawing.Size(203, 21);
            this.cbCalisan.TabIndex = 3;
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(218, 148);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(203, 20);
            this.dtpTarih.TabIndex = 4;
            // 
            // txtNakliyeUcreti
            // 
            this.txtNakliyeUcreti.Location = new System.Drawing.Point(218, 174);
            this.txtNakliyeUcreti.Name = "txtNakliyeUcreti";
            this.txtNakliyeUcreti.Size = new System.Drawing.Size(203, 20);
            this.txtNakliyeUcreti.TabIndex = 5;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(218, 200);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(203, 115);
            this.txtAdres.TabIndex = 5;
            // 
            // lstSepet
            // 
            this.lstSepet.ContextMenuStrip = this.contextMenuStrip1;
            this.lstSepet.FormattingEnabled = true;
            this.lstSepet.Location = new System.Drawing.Point(437, 38);
            this.lstSepet.Name = "lstSepet";
            this.lstSepet.Size = new System.Drawing.Size(156, 277);
            this.lstSepet.TabIndex = 6;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cikartToolStripMenuItem,
            this.guncelleToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(121, 48);
            // 
            // cikartToolStripMenuItem
            // 
            this.cikartToolStripMenuItem.Name = "cikartToolStripMenuItem";
            this.cikartToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.cikartToolStripMenuItem.Text = "Cikart";
            // 
            // guncelleToolStripMenuItem
            // 
            this.guncelleToolStripMenuItem.Name = "guncelleToolStripMenuItem";
            this.guncelleToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.guncelleToolStripMenuItem.Text = "Guncelle";
            // 
            // txtSepetToplam
            // 
            this.txtSepetToplam.Location = new System.Drawing.Point(437, 321);
            this.txtSepetToplam.Name = "txtSepetToplam";
            this.txtSepetToplam.Size = new System.Drawing.Size(156, 20);
            this.txtSepetToplam.TabIndex = 8;
            // 
            // btnSiparisVer
            // 
            this.btnSiparisVer.Location = new System.Drawing.Point(437, 347);
            this.btnSiparisVer.Name = "btnSiparisVer";
            this.btnSiparisVer.Size = new System.Drawing.Size(156, 23);
            this.btnSiparisVer.TabIndex = 9;
            this.btnSiparisVer.Text = "Sipariş Ver";
            this.btnSiparisVer.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(41, 30);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 10;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(41, 56);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown2.TabIndex = 11;
            // 
            // gbUrunDetay
            // 
            this.gbUrunDetay.Controls.Add(this.btnGuncelle);
            this.gbUrunDetay.Controls.Add(this.numericUpDown1);
            this.gbUrunDetay.Controls.Add(this.numericUpDown2);
            this.gbUrunDetay.Location = new System.Drawing.Point(610, 38);
            this.gbUrunDetay.Name = "gbUrunDetay";
            this.gbUrunDetay.Size = new System.Drawing.Size(200, 130);
            this.gbUrunDetay.TabIndex = 12;
            this.gbUrunDetay.TabStop = false;
            this.gbUrunDetay.Text = "Sepet Ürün Detayı";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(86, 83);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 12;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 450);
            this.Controls.Add(this.gbUrunDetay);
            this.Controls.Add(this.btnSiparisVer);
            this.Controls.Add(this.txtSepetToplam);
            this.Controls.Add(this.lstSepet);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtNakliyeUcreti);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.cbCalisan);
            this.Controls.Add(this.cbNakliye);
            this.Controls.Add(this.cbMusteri);
            this.Controls.Add(this.btnSepeteEkle);
            this.Controls.Add(this.lstUrunler);
            this.Controls.Add(this.txtArama);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sipariş";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.gbUrunDetay.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.ListBox lstUrunler;
        private System.Windows.Forms.Button btnSepeteEkle;
        private System.Windows.Forms.ComboBox cbMusteri;
        private System.Windows.Forms.ComboBox cbNakliye;
        private System.Windows.Forms.ComboBox cbCalisan;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.TextBox txtNakliyeUcreti;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.ListBox lstSepet;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cikartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guncelleToolStripMenuItem;
        private System.Windows.Forms.TextBox txtSepetToplam;
        private System.Windows.Forms.Button btnSiparisVer;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.GroupBox gbUrunDetay;
        private System.Windows.Forms.Button btnGuncelle;
    }
}

