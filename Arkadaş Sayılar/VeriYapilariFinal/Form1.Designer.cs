namespace VeriYapilariFinal
{
    partial class frmArkadasSayilar
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
            this.btnSayilariGoster = new System.Windows.Forms.Button();
            this.btnSayilarinYeriniDegistir = new System.Windows.Forms.Button();
            this.txtSayiGir = new System.Windows.Forms.TextBox();
            this.btnSayiGir = new System.Windows.Forms.Button();
            this.grpSayiKaydi = new System.Windows.Forms.GroupBox();
            this.grpArkadasSayiIslemleri = new System.Windows.Forms.GroupBox();
            this.btnListeyiTemizle = new System.Windows.Forms.Button();
            this.grpSayiKaydi.SuspendLayout();
            this.grpArkadasSayiIslemleri.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSayilariGoster
            // 
            this.btnSayilariGoster.Location = new System.Drawing.Point(58, 81);
            this.btnSayilariGoster.Name = "btnSayilariGoster";
            this.btnSayilariGoster.Size = new System.Drawing.Size(279, 45);
            this.btnSayilariGoster.TabIndex = 0;
            this.btnSayilariGoster.Text = "Sayıları Listele";
            this.btnSayilariGoster.UseVisualStyleBackColor = true;
            this.btnSayilariGoster.Click += new System.EventHandler(this.btnSayilariGoster_Click);
            // 
            // btnSayilarinYeriniDegistir
            // 
            this.btnSayilarinYeriniDegistir.Location = new System.Drawing.Point(58, 129);
            this.btnSayilarinYeriniDegistir.Name = "btnSayilarinYeriniDegistir";
            this.btnSayilarinYeriniDegistir.Size = new System.Drawing.Size(279, 45);
            this.btnSayilarinYeriniDegistir.TabIndex = 1;
            this.btnSayilarinYeriniDegistir.Text = "Arkadaş Sayıların Yerini Değiştir";
            this.btnSayilarinYeriniDegistir.UseVisualStyleBackColor = true;
            this.btnSayilarinYeriniDegistir.Click += new System.EventHandler(this.btnSayilarinYeriniDegistir_Click);
            // 
            // txtSayiGir
            // 
            this.txtSayiGir.Location = new System.Drawing.Point(18, 81);
            this.txtSayiGir.Name = "txtSayiGir";
            this.txtSayiGir.Size = new System.Drawing.Size(279, 22);
            this.txtSayiGir.TabIndex = 2;
            // 
            // btnSayiGir
            // 
            this.btnSayiGir.Location = new System.Drawing.Point(18, 129);
            this.btnSayiGir.Name = "btnSayiGir";
            this.btnSayiGir.Size = new System.Drawing.Size(279, 45);
            this.btnSayiGir.TabIndex = 3;
            this.btnSayiGir.Text = "Sayıyı Gir";
            this.btnSayiGir.UseVisualStyleBackColor = true;
            this.btnSayiGir.Click += new System.EventHandler(this.btnSayiGir_Click);
            // 
            // grpSayiKaydi
            // 
            this.grpSayiKaydi.Controls.Add(this.txtSayiGir);
            this.grpSayiKaydi.Controls.Add(this.btnSayiGir);
            this.grpSayiKaydi.Location = new System.Drawing.Point(32, 52);
            this.grpSayiKaydi.Name = "grpSayiKaydi";
            this.grpSayiKaydi.Size = new System.Drawing.Size(314, 285);
            this.grpSayiKaydi.TabIndex = 4;
            this.grpSayiKaydi.TabStop = false;
            this.grpSayiKaydi.Text = "Sayı Kaydı";
            // 
            // grpArkadasSayiIslemleri
            // 
            this.grpArkadasSayiIslemleri.Controls.Add(this.btnListeyiTemizle);
            this.grpArkadasSayiIslemleri.Controls.Add(this.btnSayilarinYeriniDegistir);
            this.grpArkadasSayiIslemleri.Controls.Add(this.btnSayilariGoster);
            this.grpArkadasSayiIslemleri.Location = new System.Drawing.Point(401, 52);
            this.grpArkadasSayiIslemleri.Name = "grpArkadasSayiIslemleri";
            this.grpArkadasSayiIslemleri.Size = new System.Drawing.Size(387, 272);
            this.grpArkadasSayiIslemleri.TabIndex = 5;
            this.grpArkadasSayiIslemleri.TabStop = false;
            this.grpArkadasSayiIslemleri.Text = "Arkadaş Sayı İşlemleri";
            // 
            // btnListeyiTemizle
            // 
            this.btnListeyiTemizle.Location = new System.Drawing.Point(58, 180);
            this.btnListeyiTemizle.Name = "btnListeyiTemizle";
            this.btnListeyiTemizle.Size = new System.Drawing.Size(279, 45);
            this.btnListeyiTemizle.TabIndex = 2;
            this.btnListeyiTemizle.Text = "Listeyi Temizle";
            this.btnListeyiTemizle.UseVisualStyleBackColor = true;
            this.btnListeyiTemizle.Click += new System.EventHandler(this.btnListeyiTemizle_Click);
            // 
            // frmArkadasSayilar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpArkadasSayiIslemleri);
            this.Controls.Add(this.grpSayiKaydi);
            this.Name = "frmArkadasSayilar";
            this.Text = "Arkadaş Sayılar";
            this.grpSayiKaydi.ResumeLayout(false);
            this.grpSayiKaydi.PerformLayout();
            this.grpArkadasSayiIslemleri.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSayilariGoster;
        private System.Windows.Forms.Button btnSayilarinYeriniDegistir;
        private System.Windows.Forms.TextBox txtSayiGir;
        private System.Windows.Forms.Button btnSayiGir;
        private System.Windows.Forms.GroupBox grpSayiKaydi;
        private System.Windows.Forms.GroupBox grpArkadasSayiIslemleri;
        private System.Windows.Forms.Button btnListeyiTemizle;
    }
}

