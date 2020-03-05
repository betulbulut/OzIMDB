namespace OzIMDB
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
            this.btnYeniFilm = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFilmId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gboPuan = new System.Windows.Forms.GroupBox();
            this.rb0 = new System.Windows.Forms.RadioButton();
            this.rbPuan3 = new System.Windows.Forms.RadioButton();
            this.rbPuan5 = new System.Windows.Forms.RadioButton();
            this.rbPuan1 = new System.Windows.Forms.RadioButton();
            this.rbPuan4 = new System.Windows.Forms.RadioButton();
            this.rbPuan2 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFilmAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pboFoto = new System.Windows.Forms.PictureBox();
            this.lstFilmler = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.gboPuan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnYeniFilm
            // 
            this.btnYeniFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniFilm.Location = new System.Drawing.Point(12, 22);
            this.btnYeniFilm.Name = "btnYeniFilm";
            this.btnYeniFilm.Size = new System.Drawing.Size(128, 37);
            this.btnYeniFilm.TabIndex = 0;
            this.btnYeniFilm.Text = "Yeni Film Ekle";
            this.btnYeniFilm.UseVisualStyleBackColor = true;
            this.btnYeniFilm.Click += new System.EventHandler(this.btnYeniFilm_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFilmId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.gboPuan);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtFilmAd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pboFoto);
            this.groupBox1.Location = new System.Drawing.Point(12, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 335);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Film Detayları";
            // 
            // txtFilmId
            // 
            this.txtFilmId.Location = new System.Drawing.Point(9, 35);
            this.txtFilmId.Name = "txtFilmId";
            this.txtFilmId.ReadOnly = true;
            this.txtFilmId.Size = new System.Drawing.Size(99, 20);
            this.txtFilmId.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Film No";
            // 
            // gboPuan
            // 
            this.gboPuan.Controls.Add(this.rb0);
            this.gboPuan.Controls.Add(this.rbPuan3);
            this.gboPuan.Controls.Add(this.rbPuan5);
            this.gboPuan.Controls.Add(this.rbPuan1);
            this.gboPuan.Controls.Add(this.rbPuan4);
            this.gboPuan.Controls.Add(this.rbPuan2);
            this.gboPuan.Location = new System.Drawing.Point(9, 126);
            this.gboPuan.Name = "gboPuan";
            this.gboPuan.Size = new System.Drawing.Size(137, 171);
            this.gboPuan.TabIndex = 3;
            this.gboPuan.TabStop = false;
            this.gboPuan.Text = "Puan";
            // 
            // rb0
            // 
            this.rb0.AutoSize = true;
            this.rb0.Checked = true;
            this.rb0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rb0.Location = new System.Drawing.Point(6, 19);
            this.rb0.Name = "rb0";
            this.rb0.Size = new System.Drawing.Size(123, 19);
            this.rb0.TabIndex = 9;
            this.rb0.TabStop = true;
            this.rb0.Text = "0- Puan Verilmedi";
            this.rb0.UseVisualStyleBackColor = true;
            this.rb0.CheckedChanged += new System.EventHandler(this.rb0_CheckedChanged);
            // 
            // rbPuan3
            // 
            this.rbPuan3.AutoSize = true;
            this.rbPuan3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbPuan3.Location = new System.Drawing.Point(5, 92);
            this.rbPuan3.Name = "rbPuan3";
            this.rbPuan3.Size = new System.Drawing.Size(62, 19);
            this.rbPuan3.TabIndex = 6;
            this.rbPuan3.Tag = "3";
            this.rbPuan3.Text = "3- Orta";
            this.rbPuan3.UseVisualStyleBackColor = true;
            this.rbPuan3.CheckedChanged += new System.EventHandler(this.rb0_CheckedChanged);
            // 
            // rbPuan5
            // 
            this.rbPuan5.AutoSize = true;
            this.rbPuan5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbPuan5.Location = new System.Drawing.Point(6, 142);
            this.rbPuan5.Name = "rbPuan5";
            this.rbPuan5.Size = new System.Drawing.Size(74, 19);
            this.rbPuan5.TabIndex = 8;
            this.rbPuan5.Tag = "5";
            this.rbPuan5.Text = "5- Çok İyi";
            this.rbPuan5.UseVisualStyleBackColor = true;
            this.rbPuan5.CheckedChanged += new System.EventHandler(this.rb0_CheckedChanged);
            // 
            // rbPuan1
            // 
            this.rbPuan1.AutoSize = true;
            this.rbPuan1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbPuan1.Location = new System.Drawing.Point(5, 42);
            this.rbPuan1.Name = "rbPuan1";
            this.rbPuan1.Size = new System.Drawing.Size(86, 19);
            this.rbPuan1.TabIndex = 4;
            this.rbPuan1.Tag = "1";
            this.rbPuan1.Text = "1- Çok kötü";
            this.rbPuan1.UseVisualStyleBackColor = true;
            this.rbPuan1.CheckedChanged += new System.EventHandler(this.rb0_CheckedChanged);
            // 
            // rbPuan4
            // 
            this.rbPuan4.AutoSize = true;
            this.rbPuan4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbPuan4.Location = new System.Drawing.Point(6, 117);
            this.rbPuan4.Name = "rbPuan4";
            this.rbPuan4.Size = new System.Drawing.Size(50, 19);
            this.rbPuan4.TabIndex = 7;
            this.rbPuan4.Tag = "4";
            this.rbPuan4.Text = "4- İyi";
            this.rbPuan4.UseVisualStyleBackColor = true;
            this.rbPuan4.CheckedChanged += new System.EventHandler(this.rb0_CheckedChanged);
            // 
            // rbPuan2
            // 
            this.rbPuan2.AutoSize = true;
            this.rbPuan2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbPuan2.Location = new System.Drawing.Point(5, 67);
            this.rbPuan2.Name = "rbPuan2";
            this.rbPuan2.Size = new System.Drawing.Size(64, 19);
            this.rbPuan2.TabIndex = 5;
            this.rbPuan2.Tag = "2";
            this.rbPuan2.Text = "2- Kötü";
            this.rbPuan2.UseVisualStyleBackColor = true;
            this.rbPuan2.CheckedChanged += new System.EventHandler(this.rb0_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "(Değiştirmek için  resme tıklayınız.)";
            // 
            // txtFilmAd
            // 
            this.txtFilmAd.Location = new System.Drawing.Point(9, 87);
            this.txtFilmAd.Name = "txtFilmAd";
            this.txtFilmAd.Size = new System.Drawing.Size(316, 20);
            this.txtFilmAd.TabIndex = 2;
            this.txtFilmAd.TextChanged += new System.EventHandler(this.txtFilmAd_TextChanged);
            this.txtFilmAd.Leave += new System.EventHandler(this.txtFilmAd_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Film Adı";
            // 
            // pboFoto
            // 
            this.pboFoto.BackColor = System.Drawing.Color.Silver;
            this.pboFoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pboFoto.Location = new System.Drawing.Point(152, 126);
            this.pboFoto.Name = "pboFoto";
            this.pboFoto.Size = new System.Drawing.Size(173, 171);
            this.pboFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboFoto.TabIndex = 0;
            this.pboFoto.TabStop = false;
            this.pboFoto.Click += new System.EventHandler(this.pboFoto_Click);
            // 
            // lstFilmler
            // 
            this.lstFilmler.DisplayMember = "filmad";
            this.lstFilmler.FormattingEnabled = true;
            this.lstFilmler.Location = new System.Drawing.Point(364, 22);
            this.lstFilmler.Name = "lstFilmler";
            this.lstFilmler.Size = new System.Drawing.Size(306, 381);
            this.lstFilmler.TabIndex = 2;
            this.lstFilmler.ValueMember = "ID";
            this.lstFilmler.SelectedIndexChanged += new System.EventHandler(this.lstFilmler_SelectedIndexChanged);
            this.lstFilmler.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstFilmler_KeyDown);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Resim Dosyası(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 424);
            this.Controls.Add(this.lstFilmler);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnYeniFilm);
            this.Name = "Form1";
            this.Text = "Öz IMDB";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gboPuan.ResumeLayout(false);
            this.gboPuan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnYeniFilm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbPuan5;
        private System.Windows.Forms.RadioButton rbPuan4;
        private System.Windows.Forms.RadioButton rbPuan3;
        private System.Windows.Forms.RadioButton rbPuan2;
        private System.Windows.Forms.RadioButton rbPuan1;
        private System.Windows.Forms.TextBox txtFilmAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pboFoto;
        private System.Windows.Forms.ListBox lstFilmler;
        private System.Windows.Forms.GroupBox gboPuan;
        private System.Windows.Forms.TextBox txtFilmId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rb0;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

