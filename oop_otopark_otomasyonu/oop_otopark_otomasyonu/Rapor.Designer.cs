namespace oop_otopark_otomasyonu
{
    partial class Rapor
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblToplamUcret = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblToplamArac = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(23, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(527, 414);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Plaka";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tip";
            this.columnHeader2.Width = 121;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Abone";
            this.columnHeader3.Width = 124;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Süre";
            this.columnHeader4.Width = 112;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ücret";
            this.columnHeader5.Width = 126;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblToplamUcret);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblToplamArac);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(556, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 160);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Toplam Bilgiler";
            // 
            // lblToplamUcret
            // 
            this.lblToplamUcret.AutoSize = true;
            this.lblToplamUcret.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamUcret.Location = new System.Drawing.Point(48, 112);
            this.lblToplamUcret.Name = "lblToplamUcret";
            this.lblToplamUcret.Size = new System.Drawing.Size(52, 25);
            this.lblToplamUcret.TabIndex = 1;
            this.lblToplamUcret.Text = "0 TL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(15, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Toplam Ücret";
            // 
            // lblToplamArac
            // 
            this.lblToplamArac.AutoSize = true;
            this.lblToplamArac.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamArac.Location = new System.Drawing.Point(15, 52);
            this.lblToplamArac.Name = "lblToplamArac";
            this.lblToplamArac.Size = new System.Drawing.Size(23, 25);
            this.lblToplamArac.TabIndex = 5;
            this.lblToplamArac.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(15, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Toplam Arac";
            // 
            // Rapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 438);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView1);
            this.Name = "Rapor";
            this.Text = "Rapor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        public System.Windows.Forms.ListView listView1;
        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label lblToplamUcret;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label lblToplamArac;
        public System.Windows.Forms.Label label3;
    }
}