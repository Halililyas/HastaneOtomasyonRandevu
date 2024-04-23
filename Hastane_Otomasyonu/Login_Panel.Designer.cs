namespace Hastane_Otomasyonu
{
    partial class Login_Panel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Panel));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGiris = new System.Windows.Forms.PictureBox();
            this.Kilit_Kapali = new System.Windows.Forms.PictureBox();
            this.Kilit_Acik = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGiris)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kilit_Kapali)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kilit_Acik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hastane_Otomasyonu.Properties.Resources.Hastane_Foto;
            this.pictureBox1.Location = new System.Drawing.Point(-23, 342);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1100, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(443, 158);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(199, 22);
            this.textBox1.TabIndex = 1;
            
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(443, 214);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '●';
            this.textBox2.Size = new System.Drawing.Size(199, 22);
            this.textBox2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(292, 158);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(371, 212);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şifre:";
            // 
            // btnGiris
            // 
            this.btnGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGiris.Image = ((System.Drawing.Image)(resources.GetObject("btnGiris.Image")));
            this.btnGiris.Location = new System.Drawing.Point(455, 284);
            this.btnGiris.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(156, 49);
            this.btnGiris.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnGiris.TabIndex = 5;
            this.btnGiris.TabStop = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // Kilit_Kapali
            // 
            this.Kilit_Kapali.Image = ((System.Drawing.Image)(resources.GetObject("Kilit_Kapali.Image")));
            this.Kilit_Kapali.Location = new System.Drawing.Point(651, 191);
            this.Kilit_Kapali.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Kilit_Kapali.Name = "Kilit_Kapali";
            this.Kilit_Kapali.Size = new System.Drawing.Size(51, 64);
            this.Kilit_Kapali.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Kilit_Kapali.TabIndex = 7;
            this.Kilit_Kapali.TabStop = false;
            // 
            // Kilit_Acik
            // 
            this.Kilit_Acik.Image = ((System.Drawing.Image)(resources.GetObject("Kilit_Acik.Image")));
            this.Kilit_Acik.Location = new System.Drawing.Point(651, 191);
            this.Kilit_Acik.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Kilit_Acik.Name = "Kilit_Acik";
            this.Kilit_Acik.Size = new System.Drawing.Size(51, 64);
            this.Kilit_Acik.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Kilit_Acik.TabIndex = 8;
            this.Kilit_Acik.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(455, 30);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(156, 121);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // Login_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 565);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Kilit_Acik);
            this.Controls.Add(this.Kilit_Kapali);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Login_Panel";
            this.Text = "UCUNCUBİNYIL HOSPITAL";
            this.Load += new System.EventHandler(this.Login_Panel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGiris)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kilit_Kapali)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Kilit_Acik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btnGiris;
        private System.Windows.Forms.PictureBox Kilit_Kapali;
        private System.Windows.Forms.PictureBox Kilit_Acik;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}