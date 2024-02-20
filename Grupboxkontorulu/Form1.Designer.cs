namespace Grupboxkontorulu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbcbulR3 = new System.Windows.Forms.RadioButton();
            this.rbcbulR5 = new System.Windows.Forms.RadioButton();
            this.rbcbul3 = new System.Windows.Forms.RadioButton();
            this.rblcbul5 = new System.Windows.Forms.RadioButton();
            this.rblcbul7 = new System.Windows.Forms.RadioButton();
            this.r = new System.Windows.Forms.GroupBox();
            this.radioButton30 = new System.Windows.Forms.RadioButton();
            this.radioButton29 = new System.Windows.Forms.RadioButton();
            this.radioButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdhmm320 = new System.Windows.Forms.RadioButton();
            this.rdhmm500 = new System.Windows.Forms.RadioButton();
            this.rdhmm1000 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbwifi = new System.Windows.Forms.CheckBox();
            this.cbwebcam = new System.Windows.Forms.CheckBox();
            this.cbDVD = new System.Windows.Forms.CheckBox();
            this.btnhesapla = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.r.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbcbulR3);
            this.groupBox1.Controls.Add(this.rbcbulR5);
            this.groupBox1.Controls.Add(this.rbcbul3);
            this.groupBox1.Controls.Add(this.rblcbul5);
            this.groupBox1.Controls.Add(this.rblcbul7);
            this.groupBox1.Location = new System.Drawing.Point(84, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(114, 162);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "islemciler";
            // 
            // rbcbulR3
            // 
            this.rbcbulR3.AutoSize = true;
            this.rbcbulR3.Location = new System.Drawing.Point(16, 128);
            this.rbcbulR3.Name = "rbcbulR3";
            this.rbcbulR3.Size = new System.Drawing.Size(70, 17);
            this.rbcbulR3.TabIndex = 4;
            this.rbcbulR3.TabStop = true;
            this.rbcbulR3.Text = "nterkore3";
            this.rbcbulR3.UseVisualStyleBackColor = true;
            this.rbcbulR3.CheckedChanged += new System.EventHandler(this.rbcbulR3_CheckedChanged);
            // 
            // rbcbulR5
            // 
            this.rbcbulR5.AutoSize = true;
            this.rbcbulR5.Location = new System.Drawing.Point(16, 104);
            this.rbcbulR5.Name = "rbcbulR5";
            this.rbcbulR5.Size = new System.Drawing.Size(70, 17);
            this.rbcbulR5.TabIndex = 3;
            this.rbcbulR5.TabStop = true;
            this.rbcbulR5.Text = "nterkore5";
            this.rbcbulR5.UseVisualStyleBackColor = true;
            this.rbcbulR5.CheckedChanged += new System.EventHandler(this.rbcbulR5_CheckedChanged);
            // 
            // rbcbul3
            // 
            this.rbcbul3.AutoSize = true;
            this.rbcbul3.Location = new System.Drawing.Point(16, 80);
            this.rbcbul3.Name = "rbcbul3";
            this.rbcbul3.Size = new System.Drawing.Size(70, 17);
            this.rbcbul3.TabIndex = 2;
            this.rbcbul3.TabStop = true;
            this.rbcbul3.Text = "nterkore3";
            this.rbcbul3.UseVisualStyleBackColor = true;
            // 
            // rblcbul5
            // 
            this.rblcbul5.AutoSize = true;
            this.rblcbul5.Location = new System.Drawing.Point(16, 56);
            this.rblcbul5.Name = "rblcbul5";
            this.rblcbul5.Size = new System.Drawing.Size(70, 17);
            this.rblcbul5.TabIndex = 1;
            this.rblcbul5.TabStop = true;
            this.rblcbul5.Text = "ntercore5";
            this.rblcbul5.UseVisualStyleBackColor = true;
            // 
            // rblcbul7
            // 
            this.rblcbul7.AutoSize = true;
            this.rblcbul7.Location = new System.Drawing.Point(16, 32);
            this.rblcbul7.Name = "rblcbul7";
            this.rblcbul7.Size = new System.Drawing.Size(71, 17);
            this.rblcbul7.TabIndex = 0;
            this.rblcbul7.TabStop = true;
            this.rblcbul7.Text = "intelcore7";
            this.rblcbul7.UseVisualStyleBackColor = true;
            // 
            // r
            // 
            this.r.Controls.Add(this.radioButton30);
            this.r.Controls.Add(this.radioButton29);
            this.r.Controls.Add(this.radioButton);
            this.r.Location = new System.Drawing.Point(231, 71);
            this.r.Name = "r";
            this.r.Size = new System.Drawing.Size(111, 121);
            this.r.TabIndex = 1;
            this.r.TabStop = false;
            this.r.Text = "rambbelek";
            // 
            // radioButton30
            // 
            this.radioButton30.AutoSize = true;
            this.radioButton30.Location = new System.Drawing.Point(7, 80);
            this.radioButton30.Name = "radioButton30";
            this.radioButton30.Size = new System.Drawing.Size(46, 17);
            this.radioButton30.TabIndex = 2;
            this.radioButton30.TabStop = true;
            this.radioButton30.Text = "4GB";
            this.radioButton30.UseVisualStyleBackColor = true;
            // 
            // radioButton29
            // 
            this.radioButton29.AutoSize = true;
            this.radioButton29.Location = new System.Drawing.Point(7, 56);
            this.radioButton29.Name = "radioButton29";
            this.radioButton29.Size = new System.Drawing.Size(49, 17);
            this.radioButton29.TabIndex = 1;
            this.radioButton29.TabStop = true;
            this.radioButton29.Text = "8 GB";
            this.radioButton29.UseVisualStyleBackColor = true;
            // 
            // radioButton
            // 
            this.radioButton.AutoSize = true;
            this.radioButton.Location = new System.Drawing.Point(7, 33);
            this.radioButton.Name = "radioButton";
            this.radioButton.Size = new System.Drawing.Size(52, 17);
            this.radioButton.TabIndex = 0;
            this.radioButton.TabStop = true;
            this.radioButton.Text = "16GB";
            this.radioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdhmm320);
            this.groupBox2.Controls.Add(this.rdhmm500);
            this.groupBox2.Controls.Add(this.rdhmm1000);
            this.groupBox2.Location = new System.Drawing.Point(370, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(103, 121);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sabit disk";
            // 
            // rdhmm320
            // 
            this.rdhmm320.AutoSize = true;
            this.rdhmm320.Location = new System.Drawing.Point(12, 80);
            this.rdhmm320.Name = "rdhmm320";
            this.rdhmm320.Size = new System.Drawing.Size(58, 17);
            this.rdhmm320.TabIndex = 2;
            this.rdhmm320.TabStop = true;
            this.rdhmm320.Text = "320GB";
            this.rdhmm320.UseVisualStyleBackColor = true;
            // 
            // rdhmm500
            // 
            this.rdhmm500.AutoSize = true;
            this.rdhmm500.Location = new System.Drawing.Point(6, 56);
            this.rdhmm500.Name = "rdhmm500";
            this.rdhmm500.Size = new System.Drawing.Size(61, 17);
            this.rdhmm500.TabIndex = 1;
            this.rdhmm500.TabStop = true;
            this.rdhmm500.Text = "500GB,";
            this.rdhmm500.UseVisualStyleBackColor = true;
            // 
            // rdhmm1000
            // 
            this.rdhmm1000.AutoSize = true;
            this.rdhmm1000.Location = new System.Drawing.Point(12, 32);
            this.rdhmm1000.Name = "rdhmm1000";
            this.rdhmm1000.Size = new System.Drawing.Size(45, 17);
            this.rdhmm1000.TabIndex = 0;
            this.rdhmm1000.TabStop = true;
            this.rdhmm1000.Text = "1TB";
            this.rdhmm1000.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbwifi);
            this.groupBox3.Controls.Add(this.cbwebcam);
            this.groupBox3.Controls.Add(this.cbDVD);
            this.groupBox3.Location = new System.Drawing.Point(84, 255);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(114, 147);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ek donanım";
            // 
            // cbwifi
            // 
            this.cbwifi.AutoSize = true;
            this.cbwifi.Location = new System.Drawing.Point(16, 82);
            this.cbwifi.Name = "cbwifi";
            this.cbwifi.Size = new System.Drawing.Size(79, 17);
            this.cbwifi.TabIndex = 2;
            this.cbwifi.Text = "wireles kart";
            this.cbwifi.UseVisualStyleBackColor = true;
            // 
            // cbwebcam
            // 
            this.cbwebcam.AutoSize = true;
            this.cbwebcam.Location = new System.Drawing.Point(16, 58);
            this.cbwebcam.Name = "cbwebcam";
            this.cbwebcam.Size = new System.Drawing.Size(72, 17);
            this.cbwebcam.TabIndex = 1;
            this.cbwebcam.Text = "Web cam";
            this.cbwebcam.UseVisualStyleBackColor = true;
            // 
            // cbDVD
            // 
            this.cbDVD.AutoSize = true;
            this.cbDVD.Location = new System.Drawing.Point(16, 34);
            this.cbDVD.Name = "cbDVD";
            this.cbDVD.Size = new System.Drawing.Size(71, 17);
            this.cbDVD.TabIndex = 0;
            this.cbDVD.Text = "DVD RW";
            this.cbDVD.UseVisualStyleBackColor = true;
            // 
            // btnhesapla
            // 
            this.btnhesapla.Location = new System.Drawing.Point(257, 289);
            this.btnhesapla.Name = "btnhesapla";
            this.btnhesapla.Size = new System.Drawing.Size(216, 77);
            this.btnhesapla.TabIndex = 4;
            this.btnhesapla.Text = "hesapla";
            this.btnhesapla.UseVisualStyleBackColor = true;
            this.btnhesapla.Click += new System.EventHandler(this.btnhesapla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnhesapla);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.r);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.r.ResumeLayout(false);
            this.r.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbcbulR3;
        private System.Windows.Forms.RadioButton rbcbulR5;
        private System.Windows.Forms.RadioButton rbcbul3;
        private System.Windows.Forms.RadioButton rblcbul5;
        private System.Windows.Forms.RadioButton rblcbul7;
        private System.Windows.Forms.GroupBox r;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton30;
        private System.Windows.Forms.RadioButton radioButton29;
        private System.Windows.Forms.RadioButton radioButton;
        private System.Windows.Forms.RadioButton rdhmm320;
        private System.Windows.Forms.RadioButton rdhmm500;
        private System.Windows.Forms.RadioButton rdhmm1000;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cbwifi;
        private System.Windows.Forms.CheckBox cbwebcam;
        private System.Windows.Forms.CheckBox cbDVD;
        private System.Windows.Forms.Button btnhesapla;
    }
}

