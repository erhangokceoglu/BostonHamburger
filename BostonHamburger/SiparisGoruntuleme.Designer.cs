namespace BostonHamburger
{
    partial class SiparisGoruntuleme
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
            this.lstSiparis = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCiro = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSiparisAdet = new System.Windows.Forms.Label();
            this.lblEkstraMalzemeFiyat = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSatilanUrun = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstSiparis
            // 
            this.lstSiparis.FormattingEnabled = true;
            this.lstSiparis.ItemHeight = 20;
            this.lstSiparis.Location = new System.Drawing.Point(30, 38);
            this.lstSiparis.Name = "lstSiparis";
            this.lstSiparis.Size = new System.Drawing.Size(495, 364);
            this.lstSiparis.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(546, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "CİRO:";
            // 
            // lblCiro
            // 
            this.lblCiro.AutoSize = true;
            this.lblCiro.Location = new System.Drawing.Point(546, 86);
            this.lblCiro.Name = "lblCiro";
            this.lblCiro.Size = new System.Drawing.Size(55, 20);
            this.lblCiro.TabIndex = 2;
            this.lblCiro.Text = "0.00 TL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(542, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Toplam Sipariş:";
            // 
            // lblSiparisAdet
            // 
            this.lblSiparisAdet.AutoSize = true;
            this.lblSiparisAdet.Location = new System.Drawing.Point(546, 181);
            this.lblSiparisAdet.Name = "lblSiparisAdet";
            this.lblSiparisAdet.Size = new System.Drawing.Size(51, 20);
            this.lblSiparisAdet.TabIndex = 4;
            this.lblSiparisAdet.Text = "0 adet";
            // 
            // lblEkstraMalzemeFiyat
            // 
            this.lblEkstraMalzemeFiyat.AutoSize = true;
            this.lblEkstraMalzemeFiyat.Location = new System.Drawing.Point(546, 278);
            this.lblEkstraMalzemeFiyat.Name = "lblEkstraMalzemeFiyat";
            this.lblEkstraMalzemeFiyat.Size = new System.Drawing.Size(55, 20);
            this.lblEkstraMalzemeFiyat.TabIndex = 6;
            this.lblEkstraMalzemeFiyat.Text = "0.00 TL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(542, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ekstra Malzeme Fiyatı:";
            // 
            // lblSatilanUrun
            // 
            this.lblSatilanUrun.AutoSize = true;
            this.lblSatilanUrun.Location = new System.Drawing.Point(546, 371);
            this.lblSatilanUrun.Name = "lblSatilanUrun";
            this.lblSatilanUrun.Size = new System.Drawing.Size(51, 20);
            this.lblSatilanUrun.TabIndex = 8;
            this.lblSatilanUrun.Text = "0 adet";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(542, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Satilan Ürün Adedi:";
            // 
            // SiparisGoruntuleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSatilanUrun);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblEkstraMalzemeFiyat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblSiparisAdet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCiro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstSiparis);
            this.Name = "SiparisGoruntuleme";
            this.Text = "SiparisGoruntuleme";
            this.Load += new System.EventHandler(this.SiparisGoruntuleme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lstSiparis;
        private Label label1;
        private Label lblCiro;
        private Label label2;
        private Label lblSiparisAdet;
        private Label lblEkstraMalzemeFiyat;
        private Label label4;
        private Label lblSatilanUrun;
        private Label label5;
    }
}