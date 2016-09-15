namespace oop_otopark_otomasyonu
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstAracTip = new System.Windows.Forms.ListBox();
            this.chkKontak = new System.Windows.Forms.CheckBox();
            this.chkAbone = new System.Windows.Forms.CheckBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstAraclar = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPlaka = new System.Windows.Forms.Label();
            this.lblSure = new System.Windows.Forms.Label();
            this.lblUcret = new System.Windows.Forms.Label();
            this.btnSatisRaporu = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.çıkışYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.chkAbone);
            this.groupBox1.Controls.Add(this.chkKontak);
            this.groupBox1.Controls.Add(this.lstAracTip);
            this.groupBox1.Controls.Add(this.txtPlaka);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(51, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 260);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giriş";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plaka";
            // 
            // txtPlaka
            // 
            this.txtPlaka.Location = new System.Drawing.Point(72, 20);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(157, 20);
            this.txtPlaka.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Araç Tipi";
            // 
            // lstAracTip
            // 
            this.lstAracTip.FormattingEnabled = true;
            this.lstAracTip.Location = new System.Drawing.Point(72, 61);
            this.lstAracTip.Name = "lstAracTip";
            this.lstAracTip.Size = new System.Drawing.Size(157, 95);
            this.lstAracTip.TabIndex = 1;
            // 
            // chkKontak
            // 
            this.chkKontak.AutoSize = true;
            this.chkKontak.Location = new System.Drawing.Point(72, 163);
            this.chkKontak.Name = "chkKontak";
            this.chkKontak.Size = new System.Drawing.Size(79, 17);
            this.chkKontak.TabIndex = 2;
            this.chkKontak.Text = "Kontak Var";
            this.chkKontak.UseVisualStyleBackColor = true;
            // 
            // chkAbone
            // 
            this.chkAbone.AutoSize = true;
            this.chkAbone.Location = new System.Drawing.Point(157, 163);
            this.chkAbone.Name = "chkAbone";
            this.chkAbone.Size = new System.Drawing.Size(57, 17);
            this.chkAbone.TabIndex = 3;
            this.chkAbone.Text = "Abone";
            this.chkAbone.UseVisualStyleBackColor = true;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(72, 195);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstAraclar);
            this.groupBox2.Location = new System.Drawing.Point(331, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(365, 420);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Otoparktaki Araçlar";
            // 
            // lstAraclar
            // 
            this.lstAraclar.ContextMenuStrip = this.contextMenuStrip1;
            this.lstAraclar.FormattingEnabled = true;
            this.lstAraclar.Location = new System.Drawing.Point(7, 20);
            this.lstAraclar.Name = "lstAraclar";
            this.lstAraclar.Size = new System.Drawing.Size(352, 394);
            this.lstAraclar.TabIndex = 0;
            this.lstAraclar.SelectedIndexChanged += new System.EventHandler(this.lstAraclar_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSatisRaporu);
            this.groupBox3.Controls.Add(this.lblUcret);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.lblSure);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.lblPlaka);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(51, 302);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(249, 165);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Durum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(6, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Plaka";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Süre";
            this.label4.Click += new System.EventHandler(this.label3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(6, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ücret";
            this.label5.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblPlaka
            // 
            this.lblPlaka.AutoSize = true;
            this.lblPlaka.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPlaka.Location = new System.Drawing.Point(69, 32);
            this.lblPlaka.Name = "lblPlaka";
            this.lblPlaka.Size = new System.Drawing.Size(108, 25);
            this.lblPlaka.TabIndex = 0;
            this.lblPlaka.Text = "00 xx 0000";
            this.lblPlaka.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblSure
            // 
            this.lblSure.AutoSize = true;
            this.lblSure.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSure.Location = new System.Drawing.Point(69, 60);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(65, 25);
            this.lblSure.TabIndex = 0;
            this.lblSure.Text = "0 saat";
            this.lblSure.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblUcret
            // 
            this.lblUcret.AutoSize = true;
            this.lblUcret.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUcret.Location = new System.Drawing.Point(69, 88);
            this.lblUcret.Name = "lblUcret";
            this.lblUcret.Size = new System.Drawing.Size(52, 25);
            this.lblUcret.TabIndex = 0;
            this.lblUcret.Text = "0 TL";
            this.lblUcret.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnSatisRaporu
            // 
            this.btnSatisRaporu.Location = new System.Drawing.Point(11, 136);
            this.btnSatisRaporu.Name = "btnSatisRaporu";
            this.btnSatisRaporu.Size = new System.Drawing.Size(218, 23);
            this.btnSatisRaporu.TabIndex = 1;
            this.btnSatisRaporu.Text = "Günlük Satış Raporu";
            this.btnSatisRaporu.UseVisualStyleBackColor = true;
            this.btnSatisRaporu.Click += new System.EventHandler(this.btnSatisRaporu_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çıkışYapToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(123, 26);
            // 
            // çıkışYapToolStripMenuItem
            // 
            this.çıkışYapToolStripMenuItem.Name = "çıkışYapToolStripMenuItem";
            this.çıkışYapToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.çıkışYapToolStripMenuItem.Text = "Çıkış Yap";
            this.çıkışYapToolStripMenuItem.Click += new System.EventHandler(this.çıkışYapToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 508);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.CheckBox chkAbone;
        private System.Windows.Forms.CheckBox chkKontak;
        private System.Windows.Forms.ListBox lstAracTip;
        private System.Windows.Forms.TextBox txtPlaka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstAraclar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblUcret;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPlaka;
        private System.Windows.Forms.Button btnSatisRaporu;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem çıkışYapToolStripMenuItem;
    }
}

