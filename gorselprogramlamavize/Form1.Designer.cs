namespace gorselprogramlamavize
{
    partial class uye_ekleme
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
            uyeeklemebutonu = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label4 = new Label();
            uyesilmebutonu = new Button();
            uyeguncellemebutonu = new Button();
            SuspendLayout();
            // 
            // uyeeklemebutonu
            // 
            uyeeklemebutonu.Location = new Point(12, 230);
            uyeeklemebutonu.Name = "uyeeklemebutonu";
            uyeeklemebutonu.Size = new Size(75, 23);
            uyeeklemebutonu.TabIndex = 0;
            uyeeklemebutonu.Text = "ekle";
            uyeeklemebutonu.UseVisualStyleBackColor = true;
            uyeeklemebutonu.Click += uyeeklemebutonu_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 40);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 1;
            label1.Text = "İsim";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(65, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 94);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Soy İsim";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(65, 86);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 134);
            label3.Name = "label3";
            label3.Size = new Size(20, 15);
            label3.TabIndex = 1;
            label3.Text = "TC";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(65, 126);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(65, 172);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 180);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 3;
            label4.Text = "E posta";
            // 
            // uyesilmebutonu
            // 
            uyesilmebutonu.Location = new Point(93, 230);
            uyesilmebutonu.Name = "uyesilmebutonu";
            uyesilmebutonu.Size = new Size(75, 23);
            uyesilmebutonu.TabIndex = 5;
            uyesilmebutonu.Text = "sil";
            uyesilmebutonu.UseVisualStyleBackColor = true;
            // 
            // uyeguncellemebutonu
            // 
            uyeguncellemebutonu.Location = new Point(174, 230);
            uyeguncellemebutonu.Name = "uyeguncellemebutonu";
            uyeguncellemebutonu.Size = new Size(75, 23);
            uyeguncellemebutonu.TabIndex = 6;
            uyeguncellemebutonu.Text = "güncelle";
            uyeguncellemebutonu.UseVisualStyleBackColor = true;
            // 
            // uye_ekleme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(uyeguncellemebutonu);
            Controls.Add(uyesilmebutonu);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(uyeeklemebutonu);
            Name = "uye_ekleme";
            Text = "üye ekleme";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button uyeeklemebutonu;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label4;
        private Button uyesilmebutonu;
        private Button uyeguncellemebutonu;
    }
}
