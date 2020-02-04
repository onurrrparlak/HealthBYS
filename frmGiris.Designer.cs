namespace HealthBYS
{
    partial class frmGiris
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.kAdi = new System.Windows.Forms.Label();
            this.Sifre = new System.Windows.Forms.Label();
            this.sifreText = new System.Windows.Forms.TextBox();
            this.girisButon = new System.Windows.Forms.Button();
            this.cbKullanici = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kAdi
            // 
            this.kAdi.AutoSize = true;
            this.kAdi.Location = new System.Drawing.Point(105, 59);
            this.kAdi.Name = "kAdi";
            this.kAdi.Size = new System.Drawing.Size(67, 13);
            this.kAdi.TabIndex = 0;
            this.kAdi.Text = "Kullanıcı Adı:";
            // 
            // Sifre
            // 
            this.Sifre.AutoSize = true;
            this.Sifre.Location = new System.Drawing.Point(141, 86);
            this.Sifre.Name = "Sifre";
            this.Sifre.Size = new System.Drawing.Size(31, 13);
            this.Sifre.TabIndex = 1;
            this.Sifre.Text = "Şifre:";
            // 
            // sifreText
            // 
            this.sifreText.Location = new System.Drawing.Point(197, 86);
            this.sifreText.Name = "sifreText";
            this.sifreText.Size = new System.Drawing.Size(201, 20);
            this.sifreText.TabIndex = 3;
            // 
            // girisButon
            // 
            this.girisButon.Location = new System.Drawing.Point(197, 112);
            this.girisButon.Name = "girisButon";
            this.girisButon.Size = new System.Drawing.Size(201, 33);
            this.girisButon.TabIndex = 4;
            this.girisButon.Text = "Giriş";
            this.girisButon.UseVisualStyleBackColor = true;
            this.girisButon.Click += new System.EventHandler(this.girisButon_Click);
            // 
            // cbKullanici
            // 
            this.cbKullanici.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKullanici.FormattingEnabled = true;
            this.cbKullanici.Location = new System.Drawing.Point(197, 56);
            this.cbKullanici.Name = "cbKullanici";
            this.cbKullanici.Size = new System.Drawing.Size(201, 21);
            this.cbKullanici.TabIndex = 5;
            this.cbKullanici.SelectedIndexChanged += new System.EventHandler(this.cbKullanici_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(433, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Çıkış";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 224);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbKullanici);
            this.Controls.Add(this.girisButon);
            this.Controls.Add(this.sifreText);
            this.Controls.Add(this.Sifre);
            this.Controls.Add(this.kAdi);
            this.Name = "frmGiris";
            this.Text = "HealthBYS";
            this.Load += new System.EventHandler(this.frmGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label kAdi;
        private System.Windows.Forms.Label Sifre;
        private System.Windows.Forms.TextBox sifreText;
        private System.Windows.Forms.Button girisButon;
        private System.Windows.Forms.ComboBox cbKullanici;
        private System.Windows.Forms.Button button1;
    }
}

