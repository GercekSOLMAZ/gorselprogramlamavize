namespace gorselprogramlamavize
{
    partial class ana_menu
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
            uyeeklemeislemi = new Button();
            emanetislemleributonu = new Button();
            kitapeklemeislemleri = new Button();
            SuspendLayout();
            // 
            // uyeeklemeislemi
            // 
            uyeeklemeislemi.Location = new Point(21, 36);
            uyeeklemeislemi.Name = "uyeeklemeislemi";
            uyeeklemeislemi.Size = new Size(75, 23);
            uyeeklemeislemi.TabIndex = 0;
            uyeeklemeislemi.Text = "üye_ekle";
            uyeeklemeislemi.UseVisualStyleBackColor = true;
            uyeeklemeislemi.Click += uyeeklemeislemi_Click;
            // 
            // emanetislemleributonu
            // 
            emanetislemleributonu.Location = new Point(160, 36);
            emanetislemleributonu.Name = "emanetislemleributonu";
            emanetislemleributonu.Size = new Size(75, 23);
            emanetislemleributonu.TabIndex = 1;
            emanetislemleributonu.Text = "emanet_işlemleri";
            emanetislemleributonu.UseVisualStyleBackColor = true;
            emanetislemleributonu.Click += emanetislemleributonu_Click;
            // 
            // kitapeklemeislemleri
            // 
            kitapeklemeislemleri.Location = new Point(307, 36);
            kitapeklemeislemleri.Name = "kitapeklemeislemleri";
            kitapeklemeislemleri.Size = new Size(75, 23);
            kitapeklemeislemleri.TabIndex = 2;
            kitapeklemeislemleri.Text = "kitap_ekle";
            kitapeklemeislemleri.UseVisualStyleBackColor = true;
            kitapeklemeislemleri.Click += kitapeklemeislemleri_Click;
            // 
            // ana_menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(kitapeklemeislemleri);
            Controls.Add(emanetislemleributonu);
            Controls.Add(uyeeklemeislemi);
            Name = "ana_menu";
            Text = "ana_menu";
            ResumeLayout(false);
        }

        #endregion

        private Button uyeeklemeislemi;
        private Button emanetislemleributonu;
        private Button kitapeklemeislemleri;
    }
}