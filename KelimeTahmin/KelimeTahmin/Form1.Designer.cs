namespace KelimeTahmin
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
            this.textBoxDene = new System.Windows.Forms.TextBox();
            this.labelKelime = new System.Windows.Forms.Label();
            this.checkBoxIngilizce = new System.Windows.Forms.CheckBox();
            this.buttonKelime = new System.Windows.Forms.Button();
            this.buttonTahmin = new System.Windows.Forms.Button();
            this.textBoxTahmin = new System.Windows.Forms.TextBox();
            this.buttonDene = new System.Windows.Forms.Button();
            this.buttonKapat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelPuan = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxDene
            // 
            this.textBoxDene.Font = new System.Drawing.Font("Segoe UI", 24F);
            this.textBoxDene.Location = new System.Drawing.Point(33, 210);
            this.textBoxDene.Name = "textBoxDene";
            this.textBoxDene.Size = new System.Drawing.Size(67, 61);
            this.textBoxDene.TabIndex = 0;
            this.textBoxDene.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelKelime
            // 
            this.labelKelime.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.labelKelime.Location = new System.Drawing.Point(4, -3);
            this.labelKelime.Name = "labelKelime";
            this.labelKelime.Size = new System.Drawing.Size(709, 63);
            this.labelKelime.TabIndex = 1;
            this.labelKelime.Text = "Boş";
            this.labelKelime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBoxIngilizce
            // 
            this.checkBoxIngilizce.AutoSize = true;
            this.checkBoxIngilizce.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.checkBoxIngilizce.Location = new System.Drawing.Point(38, 88);
            this.checkBoxIngilizce.Name = "checkBoxIngilizce";
            this.checkBoxIngilizce.Size = new System.Drawing.Size(105, 32);
            this.checkBoxIngilizce.TabIndex = 2;
            this.checkBoxIngilizce.Text = "İngilizce";
            this.checkBoxIngilizce.UseVisualStyleBackColor = true;
            // 
            // buttonKelime
            // 
            this.buttonKelime.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonKelime.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonKelime.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.buttonKelime.Location = new System.Drawing.Point(33, 122);
            this.buttonKelime.Name = "buttonKelime";
            this.buttonKelime.Size = new System.Drawing.Size(209, 49);
            this.buttonKelime.TabIndex = 3;
            this.buttonKelime.Text = "Kelime Getir";
            this.buttonKelime.UseVisualStyleBackColor = false;
            this.buttonKelime.Click += new System.EventHandler(this.buttonKelime_Click);
            // 
            // buttonTahmin
            // 
            this.buttonTahmin.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonTahmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonTahmin.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonTahmin.Location = new System.Drawing.Point(460, 189);
            this.buttonTahmin.Name = "buttonTahmin";
            this.buttonTahmin.Size = new System.Drawing.Size(240, 61);
            this.buttonTahmin.TabIndex = 4;
            this.buttonTahmin.Text = "Tahmin Et";
            this.buttonTahmin.UseVisualStyleBackColor = false;
            this.buttonTahmin.Click += new System.EventHandler(this.buttonTahmin_Click);
            // 
            // textBoxTahmin
            // 
            this.textBoxTahmin.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.textBoxTahmin.Location = new System.Drawing.Point(460, 131);
            this.textBoxTahmin.Name = "textBoxTahmin";
            this.textBoxTahmin.Size = new System.Drawing.Size(237, 52);
            this.textBoxTahmin.TabIndex = 5;
            // 
            // buttonDene
            // 
            this.buttonDene.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonDene.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDene.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonDene.Location = new System.Drawing.Point(106, 210);
            this.buttonDene.Name = "buttonDene";
            this.buttonDene.Size = new System.Drawing.Size(229, 61);
            this.buttonDene.TabIndex = 6;
            this.buttonDene.Text = "Harf Dene";
            this.buttonDene.UseVisualStyleBackColor = false;
            this.buttonDene.Click += new System.EventHandler(this.buttonDene_Click);
            // 
            // buttonKapat
            // 
            this.buttonKapat.BackColor = System.Drawing.Color.Firebrick;
            this.buttonKapat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonKapat.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKapat.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonKapat.Location = new System.Drawing.Point(612, 410);
            this.buttonKapat.Name = "buttonKapat";
            this.buttonKapat.Size = new System.Drawing.Size(154, 56);
            this.buttonKapat.TabIndex = 7;
            this.buttonKapat.Text = "Kapat";
            this.buttonKapat.UseVisualStyleBackColor = false;
            this.buttonKapat.Click += new System.EventHandler(this.buttonKapat_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 77);
            this.label1.TabIndex = 8;
            this.label1.Text = "Kelime Tahmin";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.buttonKelime);
            this.panel1.Controls.Add(this.textBoxDene);
            this.panel1.Controls.Add(this.buttonDene);
            this.panel1.Controls.Add(this.checkBoxIngilizce);
            this.panel1.Controls.Add(this.textBoxTahmin);
            this.panel1.Controls.Add(this.buttonTahmin);
            this.panel1.Location = new System.Drawing.Point(27, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(739, 310);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.labelKelime);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.panel2.Location = new System.Drawing.Point(11, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(717, 63);
            this.panel2.TabIndex = 7;
            // 
            // labelPuan
            // 
            this.labelPuan.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.labelPuan.Location = new System.Drawing.Point(22, 403);
            this.labelPuan.Name = "labelPuan";
            this.labelPuan.Size = new System.Drawing.Size(417, 63);
            this.labelPuan.TabIndex = 2;
            this.labelPuan.Text = "Puan: 0";
            this.labelPuan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(800, 504);
            this.ControlBox = false;
            this.Controls.Add(this.labelPuan);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonKapat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kelime Tahmin Uygulamasi";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDene;
        private System.Windows.Forms.Label labelKelime;
        private System.Windows.Forms.CheckBox checkBoxIngilizce;
        private System.Windows.Forms.Button buttonKelime;
        private System.Windows.Forms.Button buttonTahmin;
        private System.Windows.Forms.TextBox textBoxTahmin;
        private System.Windows.Forms.Button buttonDene;
        private System.Windows.Forms.Button buttonKapat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelPuan;
    }
}

