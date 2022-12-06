namespace classOrnek
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textYuksek = new System.Windows.Forms.TextBox();
            this.textTaban = new System.Windows.Forms.TextBox();
            this.button_hesap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yükseklik";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Taban";
            // 
            // textYuksek
            // 
            this.textYuksek.Location = new System.Drawing.Point(142, 40);
            this.textYuksek.Name = "textYuksek";
            this.textYuksek.Size = new System.Drawing.Size(100, 20);
            this.textYuksek.TabIndex = 2;
            // 
            // textTaban
            // 
            this.textTaban.Location = new System.Drawing.Point(142, 86);
            this.textTaban.Name = "textTaban";
            this.textTaban.Size = new System.Drawing.Size(100, 20);
            this.textTaban.TabIndex = 3;
            // 
            // button_hesap
            // 
            this.button_hesap.Location = new System.Drawing.Point(248, 62);
            this.button_hesap.Name = "button_hesap";
            this.button_hesap.Size = new System.Drawing.Size(75, 23);
            this.button_hesap.TabIndex = 4;
            this.button_hesap.Text = "Hesapla\r\n";
            this.button_hesap.UseVisualStyleBackColor = true;
            this.button_hesap.Click += new System.EventHandler(this.button_hesap_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_hesap);
            this.Controls.Add(this.textTaban);
            this.Controls.Add(this.textYuksek);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textYuksek;
        private System.Windows.Forms.TextBox textTaban;
        private System.Windows.Forms.Button button_hesap;
    }
}

