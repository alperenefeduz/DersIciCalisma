namespace KlasorIslemleri
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
            this.BTN_KlasorOlustur = new System.Windows.Forms.Button();
            this.LBL_Mesaj = new System.Windows.Forms.Label();
            this.BTN_KlasorSil = new System.Windows.Forms.Button();
            this.BTN_KlaroTasi = new System.Windows.Forms.Button();
            this.BTN_KlasorleriGetir = new System.Windows.Forms.Button();
            this.BTN_DosyalariGetir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BTN_DIKlasorOlustur = new System.Windows.Forms.Button();
            this.BTN_DIKlasorSil = new System.Windows.Forms.Button();
            this.BTN_DIKlasorTasi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTN_KlasorOlustur
            // 
            this.BTN_KlasorOlustur.Location = new System.Drawing.Point(6, 19);
            this.BTN_KlasorOlustur.Name = "BTN_KlasorOlustur";
            this.BTN_KlasorOlustur.Size = new System.Drawing.Size(128, 23);
            this.BTN_KlasorOlustur.TabIndex = 0;
            this.BTN_KlasorOlustur.Text = "Klasör Oluştur";
            this.BTN_KlasorOlustur.UseVisualStyleBackColor = true;
            this.BTN_KlasorOlustur.Click += new System.EventHandler(this.BTN_KlasorOlustur_Click);
            // 
            // LBL_Mesaj
            // 
            this.LBL_Mesaj.AutoSize = true;
            this.LBL_Mesaj.Location = new System.Drawing.Point(12, 127);
            this.LBL_Mesaj.Name = "LBL_Mesaj";
            this.LBL_Mesaj.Size = new System.Drawing.Size(35, 13);
            this.LBL_Mesaj.TabIndex = 1;
            this.LBL_Mesaj.Text = "Mesaj";
            // 
            // BTN_KlasorSil
            // 
            this.BTN_KlasorSil.Location = new System.Drawing.Point(140, 19);
            this.BTN_KlasorSil.Name = "BTN_KlasorSil";
            this.BTN_KlasorSil.Size = new System.Drawing.Size(128, 23);
            this.BTN_KlasorSil.TabIndex = 2;
            this.BTN_KlasorSil.Text = "Klasör Sil";
            this.BTN_KlasorSil.UseVisualStyleBackColor = true;
            this.BTN_KlasorSil.Click += new System.EventHandler(this.BTN_KlasorSil_Click);
            // 
            // BTN_KlaroTasi
            // 
            this.BTN_KlaroTasi.Location = new System.Drawing.Point(274, 19);
            this.BTN_KlaroTasi.Name = "BTN_KlaroTasi";
            this.BTN_KlaroTasi.Size = new System.Drawing.Size(128, 23);
            this.BTN_KlaroTasi.TabIndex = 3;
            this.BTN_KlaroTasi.Text = "Klasör Taşı";
            this.BTN_KlaroTasi.UseVisualStyleBackColor = true;
            this.BTN_KlaroTasi.Click += new System.EventHandler(this.BTN_KlaroTasi_Click);
            // 
            // BTN_KlasorleriGetir
            // 
            this.BTN_KlasorleriGetir.Location = new System.Drawing.Point(408, 19);
            this.BTN_KlasorleriGetir.Name = "BTN_KlasorleriGetir";
            this.BTN_KlasorleriGetir.Size = new System.Drawing.Size(128, 23);
            this.BTN_KlasorleriGetir.TabIndex = 4;
            this.BTN_KlasorleriGetir.Text = "Klasörleri Getir";
            this.BTN_KlasorleriGetir.UseVisualStyleBackColor = true;
            this.BTN_KlasorleriGetir.Click += new System.EventHandler(this.BTN_KlasorleriGetir_Click);
            // 
            // BTN_DosyalariGetir
            // 
            this.BTN_DosyalariGetir.Location = new System.Drawing.Point(542, 19);
            this.BTN_DosyalariGetir.Name = "BTN_DosyalariGetir";
            this.BTN_DosyalariGetir.Size = new System.Drawing.Size(128, 23);
            this.BTN_DosyalariGetir.TabIndex = 5;
            this.BTN_DosyalariGetir.Text = "Dosyaları Getir";
            this.BTN_DosyalariGetir.UseVisualStyleBackColor = true;
            this.BTN_DosyalariGetir.Click += new System.EventHandler(this.BTN_DosyalariGetir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BTN_KlasorOlustur);
            this.groupBox1.Controls.Add(this.BTN_DosyalariGetir);
            this.groupBox1.Controls.Add(this.BTN_KlasorSil);
            this.groupBox1.Controls.Add(this.BTN_KlasorleriGetir);
            this.groupBox1.Controls.Add(this.BTN_KlaroTasi);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 53);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Directory İle Klasör İşlemleri";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BTN_DIKlasorTasi);
            this.groupBox2.Controls.Add(this.BTN_DIKlasorSil);
            this.groupBox2.Controls.Add(this.BTN_DIKlasorOlustur);
            this.groupBox2.Location = new System.Drawing.Point(12, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 53);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DirectoryInfo İle Klasör İşlemleri";
            // 
            // BTN_DIKlasorOlustur
            // 
            this.BTN_DIKlasorOlustur.Location = new System.Drawing.Point(6, 19);
            this.BTN_DIKlasorOlustur.Name = "BTN_DIKlasorOlustur";
            this.BTN_DIKlasorOlustur.Size = new System.Drawing.Size(128, 23);
            this.BTN_DIKlasorOlustur.TabIndex = 0;
            this.BTN_DIKlasorOlustur.Text = "Klasör Oluştur";
            this.BTN_DIKlasorOlustur.UseVisualStyleBackColor = true;
            this.BTN_DIKlasorOlustur.Click += new System.EventHandler(this.BTN_DIKlasorOlustur_Click);
            // 
            // BTN_DIKlasorSil
            // 
            this.BTN_DIKlasorSil.Location = new System.Drawing.Point(140, 19);
            this.BTN_DIKlasorSil.Name = "BTN_DIKlasorSil";
            this.BTN_DIKlasorSil.Size = new System.Drawing.Size(128, 23);
            this.BTN_DIKlasorSil.TabIndex = 8;
            this.BTN_DIKlasorSil.Text = "Klasör Sil";
            this.BTN_DIKlasorSil.UseVisualStyleBackColor = true;
            this.BTN_DIKlasorSil.Click += new System.EventHandler(this.BTN_DIKlasorSil_Click);
            // 
            // BTN_DIKlasorTasi
            // 
            this.BTN_DIKlasorTasi.Location = new System.Drawing.Point(274, 19);
            this.BTN_DIKlasorTasi.Name = "BTN_DIKlasorTasi";
            this.BTN_DIKlasorTasi.Size = new System.Drawing.Size(128, 23);
            this.BTN_DIKlasorTasi.TabIndex = 8;
            this.BTN_DIKlasorTasi.Text = "Klasör Taşı";
            this.BTN_DIKlasorTasi.UseVisualStyleBackColor = true;
            this.BTN_DIKlasorTasi.Click += new System.EventHandler(this.BTN_DIKlasorTasi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LBL_Mesaj);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_KlasorOlustur;
        private System.Windows.Forms.Label LBL_Mesaj;
        private System.Windows.Forms.Button BTN_KlasorSil;
        private System.Windows.Forms.Button BTN_KlaroTasi;
        private System.Windows.Forms.Button BTN_KlasorleriGetir;
        private System.Windows.Forms.Button BTN_DosyalariGetir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BTN_DIKlasorOlustur;
        private System.Windows.Forms.Button BTN_DIKlasorSil;
        private System.Windows.Forms.Button BTN_DIKlasorTasi;
    }
}

