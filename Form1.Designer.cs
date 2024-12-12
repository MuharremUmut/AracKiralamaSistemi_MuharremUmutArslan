namespace AracKiralama
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtAracBilgisi = new System.Windows.Forms.TextBox();
            this.btnAracEkle = new System.Windows.Forms.Button();
            this.lstAraclar = new System.Windows.Forms.ListBox();
            this.txtMusteriBilgisi = new System.Windows.Forms.TextBox();
            this.btnMusteriEkle = new System.Windows.Forms.Button();
            this.lstMusteriler = new System.Windows.Forms.ListBox();
            this.btnKirala = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAracBilgisi
            // 
            this.txtAracBilgisi.Location = new System.Drawing.Point(20, 20);
            this.txtAracBilgisi.Name = "txtAracBilgisi";
            this.txtAracBilgisi.Size = new System.Drawing.Size(200, 23);
            this.txtAracBilgisi.TabIndex = 0;
            // 
            // btnAracEkle
            // 
            this.btnAracEkle.Location = new System.Drawing.Point(230, 20);
            this.btnAracEkle.Name = "btnAracEkle";
            this.btnAracEkle.Size = new System.Drawing.Size(75, 23);
            this.btnAracEkle.TabIndex = 1;
            this.btnAracEkle.Text = "Araç Ekle";
            this.btnAracEkle.UseVisualStyleBackColor = true;
            this.btnAracEkle.Click += new System.EventHandler(this.btnAracEkle_Click);
            // 
            // lstAraclar
            // 
            this.lstAraclar.FormattingEnabled = true;
            this.lstAraclar.ItemHeight = 15;
            this.lstAraclar.Location = new System.Drawing.Point(20, 60);
            this.lstAraclar.Name = "lstAraclar";
            this.lstAraclar.Size = new System.Drawing.Size(285, 94);
            this.lstAraclar.TabIndex = 2;
            // 
            // txtMusteriBilgisi
            // 
            this.txtMusteriBilgisi.Location = new System.Drawing.Point(20, 180);
            this.txtMusteriBilgisi.Name = "txtMusteriBilgisi";
            this.txtMusteriBilgisi.Size = new System.Drawing.Size(200, 23);
            this.txtMusteriBilgisi.TabIndex = 3;
            // 
            // btnMusteriEkle
            // 
            this.btnMusteriEkle.Location = new System.Drawing.Point(230, 180);
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.Size = new System.Drawing.Size(75, 23);
            this.btnMusteriEkle.TabIndex = 4;
            this.btnMusteriEkle.Text = "Müşteri Ekle";
            this.btnMusteriEkle.UseVisualStyleBackColor = true;
            this.btnMusteriEkle.Click += new System.EventHandler(this.btnMusteriEkle_Click);
            // 
            // lstMusteriler
            // 
            this.lstMusteriler.FormattingEnabled = true;
            this.lstMusteriler.ItemHeight = 15;
            this.lstMusteriler.Location = new System.Drawing.Point(20, 220);
            this.lstMusteriler.Name = "lstMusteriler";
            this.lstMusteriler.Size = new System.Drawing.Size(285, 94);
            this.lstMusteriler.TabIndex = 5;
            // 
            // btnKirala
            // 
            this.btnKirala.Location = new System.Drawing.Point(120, 330);
            this.btnKirala.Name = "btnKirala";
            this.btnKirala.Size = new System.Drawing.Size(75, 23);
            this.btnKirala.TabIndex = 6;
            this.btnKirala.Text = "Kirala";
            this.btnKirala.UseVisualStyleBackColor = true;
            this.btnKirala.Click += new System.EventHandler(this.btnKirala_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 380);
            this.Controls.Add(this.btnKirala);
            this.Controls.Add(this.lstMusteriler);
            this.Controls.Add(this.btnMusteriEkle);
            this.Controls.Add(this.txtMusteriBilgisi);
            this.Controls.Add(this.lstAraclar);
            this.Controls.Add(this.btnAracEkle);
            this.Controls.Add(this.txtAracBilgisi);
            this.Name = "Form1";
            this.Text = "Araç Kiralama Sistemi";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtAracBilgisi;
        private System.Windows.Forms.Button btnAracEkle;
        private System.Windows.Forms.ListBox lstAraclar;
        private System.Windows.Forms.TextBox txtMusteriBilgisi;
        private System.Windows.Forms.Button btnMusteriEkle;
        private System.Windows.Forms.ListBox lstMusteriler;
        private System.Windows.Forms.Button btnKirala;
    }
}
