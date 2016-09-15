namespace oop_restorantuygulamasi
{
    partial class MasaListeForm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblSalonAdi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(25, 38);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(524, 361);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // lblSalonAdi
            // 
            this.lblSalonAdi.AutoSize = true;
            this.lblSalonAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSalonAdi.Location = new System.Drawing.Point(20, 6);
            this.lblSalonAdi.Name = "lblSalonAdi";
            this.lblSalonAdi.Size = new System.Drawing.Size(116, 29);
            this.lblSalonAdi.TabIndex = 2;
            this.lblSalonAdi.Text = "Salon Adı";
            // 
            // MasaListeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 433);
            this.Controls.Add(this.lblSalonAdi);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "MasaListeForm";
            this.Text = "MasaListeForm";
            this.Load += new System.EventHandler(this.MasaListeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblSalonAdi;
    }
}