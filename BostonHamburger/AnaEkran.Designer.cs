namespace BostonHamburger
{
    partial class AnaEkran
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiSiparisYonetimi = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSiparisOlustur = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSiparisBilgileri = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUrunYonetimi = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMenuEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEkstraMalzemeEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSiparisYonetimi,
            this.tsmiUrunYonetimi});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1247, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiSiparisYonetimi
            // 
            this.tsmiSiparisYonetimi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSiparisOlustur,
            this.tsmiSiparisBilgileri});
            this.tsmiSiparisYonetimi.Name = "tsmiSiparisYonetimi";
            this.tsmiSiparisYonetimi.Size = new System.Drawing.Size(129, 24);
            this.tsmiSiparisYonetimi.Text = "Sipariş Yönetimi";
            // 
            // tsmiSiparisOlustur
            // 
            this.tsmiSiparisOlustur.Name = "tsmiSiparisOlustur";
            this.tsmiSiparisOlustur.Size = new System.Drawing.Size(191, 26);
            this.tsmiSiparisOlustur.Text = "Sipariş Oluştur";
            this.tsmiSiparisOlustur.Click += new System.EventHandler(this.tsmiSiparisOlustur_Click);
            // 
            // tsmiSiparisBilgileri
            // 
            this.tsmiSiparisBilgileri.Name = "tsmiSiparisBilgileri";
            this.tsmiSiparisBilgileri.Size = new System.Drawing.Size(191, 26);
            this.tsmiSiparisBilgileri.Text = "Sipariş Bilgileri";
            this.tsmiSiparisBilgileri.Click += new System.EventHandler(this.tsmiSiparisBilgileri_Click);
            // 
            // tsmiUrunYonetimi
            // 
            this.tsmiUrunYonetimi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMenuEkle,
            this.tsmiEkstraMalzemeEkle});
            this.tsmiUrunYonetimi.Name = "tsmiUrunYonetimi";
            this.tsmiUrunYonetimi.Size = new System.Drawing.Size(116, 24);
            this.tsmiUrunYonetimi.Text = "Ürün Yönetimi";
            // 
            // tsmiMenuEkle
            // 
            this.tsmiMenuEkle.Name = "tsmiMenuEkle";
            this.tsmiMenuEkle.Size = new System.Drawing.Size(227, 26);
            this.tsmiMenuEkle.Text = "Menü Ekle";
            this.tsmiMenuEkle.Click += new System.EventHandler(this.tsmiMenuEkle_Click);
            // 
            // tsmiEkstraMalzemeEkle
            // 
            this.tsmiEkstraMalzemeEkle.Name = "tsmiEkstraMalzemeEkle";
            this.tsmiEkstraMalzemeEkle.Size = new System.Drawing.Size(227, 26);
            this.tsmiEkstraMalzemeEkle.Text = "Ekstra Malzeme Ekle";
            this.tsmiEkstraMalzemeEkle.Click += new System.EventHandler(this.tsmiEkstraMalzemeEkle_Click);
            // 
            // AnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 839);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AnaEkran";
            this.Text = "Ana Ekran";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tsmiSiparisYonetimi;
        private ToolStripMenuItem tsmiSiparisOlustur;
        private ToolStripMenuItem tsmiSiparisBilgileri;
        private ToolStripMenuItem tsmiUrunYonetimi;
        private ToolStripMenuItem tsmiMenuEkle;
        private ToolStripMenuItem tsmiEkstraMalzemeEkle;
    }
}