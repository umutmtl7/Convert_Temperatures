namespace Convert_Temperatures
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCel = new System.Windows.Forms.TextBox();
            this.textBoxFah = new System.Windows.Forms.TextBox();
            this.textBoxKel = new System.Windows.Forms.TextBox();
            this.lbl_warning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "CELSIUS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "FAHRENHEIT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "KELVIN";
            // 
            // textBoxCel
            // 
            this.textBoxCel.Location = new System.Drawing.Point(318, 46);
            this.textBoxCel.Name = "textBoxCel";
            this.textBoxCel.Size = new System.Drawing.Size(128, 22);
            this.textBoxCel.TabIndex = 3;
            this.textBoxCel.Click += new System.EventHandler(this.txt_Cel_Click);
            this.textBoxCel.TextChanged += new System.EventHandler(this.txt_Cel_Changed);
            // 
            // textBoxFah
            // 
            this.textBoxFah.Location = new System.Drawing.Point(318, 158);
            this.textBoxFah.Name = "textBoxFah";
            this.textBoxFah.Size = new System.Drawing.Size(128, 22);
            this.textBoxFah.TabIndex = 4;
            this.textBoxFah.Click += new System.EventHandler(this.txt_Fah_Click);
            this.textBoxFah.TextChanged += new System.EventHandler(this.txt_Fah_Changed);
            // 
            // textBoxKel
            // 
            this.textBoxKel.Location = new System.Drawing.Point(318, 270);
            this.textBoxKel.Name = "textBoxKel";
            this.textBoxKel.Size = new System.Drawing.Size(128, 22);
            this.textBoxKel.TabIndex = 5;
            this.textBoxKel.Click += new System.EventHandler(this.txt_Kel_Click);
            this.textBoxKel.TextChanged += new System.EventHandler(this.txt_Kel_Changed);
            // 
            // lbl_warning
            // 
            this.lbl_warning.AutoSize = true;
            this.lbl_warning.Location = new System.Drawing.Point(318, 347);
            this.lbl_warning.Name = "lbl_warning";
            this.lbl_warning.Size = new System.Drawing.Size(0, 17);
            this.lbl_warning.TabIndex = 6;
            this.lbl_warning.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_warning);
            this.Controls.Add(this.textBoxKel);
            this.Controls.Add(this.textBoxFah);
            this.Controls.Add(this.textBoxCel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Temperature Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCel;
        private System.Windows.Forms.TextBox textBoxFah;
        private System.Windows.Forms.TextBox textBoxKel;
        private System.Windows.Forms.Label lbl_warning;
    }
}

