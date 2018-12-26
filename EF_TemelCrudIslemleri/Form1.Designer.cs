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
            ((System.ComponentModel.ISupportInitialize)(this.ep1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbKategori
            // 
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(12, 12);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(121, 21);
            this.cmbKategori.TabIndex = 0;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

