namespace BostonHamburger
{
    partial class EkstraMalzemeYonetimi
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEkstra = new System.Windows.Forms.TextBox();
            this.nudEkstaFiyat = new System.Windows.Forms.NumericUpDown();
            this.btnEkstraMalzeme = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudEkstaFiyat)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(232, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ekstra Malzeme Bilgileri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(226, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ekstra Malzeme Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(226, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fiyatı:";
            // 
            // txtEkstra
            // 
            this.txtEkstra.Location = new System.Drawing.Point(412, 141);
            this.txtEkstra.Name = "txtEkstra";
            this.txtEkstra.Size = new System.Drawing.Size(150, 27);
            this.txtEkstra.TabIndex = 3;
            // 
            // nudEkstaFiyat
            // 
            this.nudEkstaFiyat.Location = new System.Drawing.Point(412, 191);
            this.nudEkstaFiyat.Name = "nudEkstaFiyat";
            this.nudEkstaFiyat.Size = new System.Drawing.Size(150, 27);
            this.nudEkstaFiyat.TabIndex = 4;
            // 
            // btnEkstraMalzeme
            // 
            this.btnEkstraMalzeme.Location = new System.Drawing.Point(412, 242);
            this.btnEkstraMalzeme.Name = "btnEkstraMalzeme";
            this.btnEkstraMalzeme.Size = new System.Drawing.Size(153, 34);
            this.btnEkstraMalzeme.TabIndex = 5;
            this.btnEkstraMalzeme.Text = "Ekstra Malzeme Ekle";
            this.btnEkstraMalzeme.UseVisualStyleBackColor = true;
            this.btnEkstraMalzeme.Click += new System.EventHandler(this.btnEkstraMalzeme_Click);
            // 
            // EkstraMalzemeYonetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEkstraMalzeme);
            this.Controls.Add(this.nudEkstaFiyat);
            this.Controls.Add(this.txtEkstra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EkstraMalzemeYonetimi";
            this.Text = "EkstraMalzemeYonetimi";
            ((System.ComponentModel.ISupportInitialize)(this.nudEkstaFiyat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtEkstra;
        private NumericUpDown nudEkstaFiyat;
        private Button btnEkstraMalzeme;
    }
}