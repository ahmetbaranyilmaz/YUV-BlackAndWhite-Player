namespace yazlab3
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.genislikTxt = new System.Windows.Forms.TextBox();
            this.yukseklikTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.formatTipi = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dosyaSec = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.oynat = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.durdur = new System.Windows.Forms.Button();
            this.kaydet = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.sonsuzOynat = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // genislikTxt
            // 
            this.genislikTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.genislikTxt.Location = new System.Drawing.Point(113, 32);
            this.genislikTxt.Name = "genislikTxt";
            this.genislikTxt.Size = new System.Drawing.Size(100, 21);
            this.genislikTxt.TabIndex = 0;
            this.genislikTxt.TextChanged += new System.EventHandler(this.genislikTxt_TextChanged);
            // 
            // yukseklikTxt
            // 
            this.yukseklikTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.yukseklikTxt.Location = new System.Drawing.Point(113, 72);
            this.yukseklikTxt.Name = "yukseklikTxt";
            this.yukseklikTxt.Size = new System.Drawing.Size(100, 21);
            this.yukseklikTxt.TabIndex = 1;
            this.yukseklikTxt.TextChanged += new System.EventHandler(this.yukseklikTxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Genislik:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label2.Location = new System.Drawing.Point(13, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Yukseklik:";
            // 
            // formatTipi
            // 
            this.formatTipi.FormattingEnabled = true;
            this.formatTipi.Items.AddRange(new object[] {
            "4:4:4",
            "4:2:2",
            "4:2:0"});
            this.formatTipi.Location = new System.Drawing.Point(113, 114);
            this.formatTipi.Name = "formatTipi";
            this.formatTipi.Size = new System.Drawing.Size(100, 21);
            this.formatTipi.TabIndex = 4;
            this.formatTipi.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label3.Location = new System.Drawing.Point(13, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Format:";
            // 
            // dosyaSec
            // 
            this.dosyaSec.Enabled = false;
            this.dosyaSec.Location = new System.Drawing.Point(113, 154);
            this.dosyaSec.Name = "dosyaSec";
            this.dosyaSec.Size = new System.Drawing.Size(100, 31);
            this.dosyaSec.TabIndex = 6;
            this.dosyaSec.Text = ".yuv Dosyasi Sec";
            this.dosyaSec.UseVisualStyleBackColor = true;
            this.dosyaSec.Click += new System.EventHandler(this.dosyaSec_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(250, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 20);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // oynat
            // 
            this.oynat.Enabled = false;
            this.oynat.Location = new System.Drawing.Point(113, 191);
            this.oynat.Name = "oynat";
            this.oynat.Size = new System.Drawing.Size(100, 31);
            this.oynat.TabIndex = 8;
            this.oynat.Text = "Video Oynat";
            this.oynat.UseVisualStyleBackColor = true;
            this.oynat.Click += new System.EventHandler(this.oynat_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 344);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cerceve";
            this.label4.Visible = false;
            // 
            // durdur
            // 
            this.durdur.Enabled = false;
            this.durdur.Location = new System.Drawing.Point(113, 228);
            this.durdur.Name = "durdur";
            this.durdur.Size = new System.Drawing.Size(100, 31);
            this.durdur.TabIndex = 10;
            this.durdur.Text = "Video Durdur";
            this.durdur.UseVisualStyleBackColor = true;
            this.durdur.Click += new System.EventHandler(this.durdur_Click);
            // 
            // kaydet
            // 
            this.kaydet.Enabled = false;
            this.kaydet.Location = new System.Drawing.Point(113, 265);
            this.kaydet.Name = "kaydet";
            this.kaydet.Size = new System.Drawing.Size(100, 31);
            this.kaydet.TabIndex = 11;
            this.kaydet.Text = ".bmp Kaydet";
            this.kaydet.UseVisualStyleBackColor = true;
            this.kaydet.Click += new System.EventHandler(this.kaydet_Click);
            // 
            // sonsuzOynat
            // 
            this.sonsuzOynat.Enabled = false;
            this.sonsuzOynat.Location = new System.Drawing.Point(7, 185);
            this.sonsuzOynat.Name = "sonsuzOynat";
            this.sonsuzOynat.Size = new System.Drawing.Size(100, 42);
            this.sonsuzOynat.TabIndex = 12;
            this.sonsuzOynat.Text = "Video Oynat (Sonsuz)";
            this.sonsuzOynat.UseVisualStyleBackColor = true;
            this.sonsuzOynat.Click += new System.EventHandler(this.sonsuzOynat_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Toplam Cerceve";
            this.label5.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 621);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sonsuzOynat);
            this.Controls.Add(this.kaydet);
            this.Controls.Add(this.durdur);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.oynat);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dosyaSec);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.formatTipi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yukseklikTxt);
            this.Controls.Add(this.genislikTxt);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Siyah-Beyaz TV";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox genislikTxt;
        private System.Windows.Forms.TextBox yukseklikTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox formatTipi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button dosyaSec;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button oynat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button durdur;
        private System.Windows.Forms.Button kaydet;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button sonsuzOynat;
        private System.Windows.Forms.Label label5;
    }
}

