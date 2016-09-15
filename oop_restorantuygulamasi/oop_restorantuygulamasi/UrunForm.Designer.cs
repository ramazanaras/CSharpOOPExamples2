namespace oop_restorantuygulamasi
{
    partial class UrunForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.txtFiyat = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.lstUrun = new System.Windows.Forms.ListView();
            this.btnEkle = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.txtFiyat)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı";
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(12, 46);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(100, 20);
            this.txtAdi.TabIndex = 1;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(120, 46);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(120, 20);
            this.txtFiyat.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fiyatı";
            // 
            // lstUrun
            // 
            this.lstUrun.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstUrun.FullRowSelect = true;
            this.lstUrun.GridLines = true;
            this.lstUrun.Location = new System.Drawing.Point(15, 72);
            this.lstUrun.Name = "lstUrun";
            this.lstUrun.Size = new System.Drawing.Size(306, 328);
            this.lstUrun.TabIndex = 3;
            this.lstUrun.UseCompatibleStateImageBehavior = false;
            this.lstUrun.View = System.Windows.Forms.View.Details;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(246, 44);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Adı";
            this.columnHeader1.Width = 138;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Fiyat";
            this.columnHeader2.Width = 145;
            // 
            // UrunForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 432);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lstUrun);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UrunForm";
            this.Text = "UrunForm";
            ((System.ComponentModel.ISupportInitialize)(this.txtFiyat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.NumericUpDown txtFiyat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lstUrun;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnEkle;
    }
}