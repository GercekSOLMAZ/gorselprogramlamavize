namespace gorselprogramlamavize
{
    partial class kitap_ekle
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
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox5 = new TextBox();
            kitapeklemebutonu = new Button();
            kitapsilmebutonu = new Button();
            kitapguncellemebutonu = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 29);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 0;
            label1.Text = "kitap ismi";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(111, 19);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(114, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(111, 76);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(114, 27);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 87);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 2;
            label2.Text = "kitap türü";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 143);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 2;
            label3.Text = "yazar adı";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(111, 132);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(114, 27);
            textBox3.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 265);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 2;
            label4.Text = "baskı sayısı";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(111, 255);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(114, 27);
            textBox4.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 204);
            label5.Name = "label5";
            label5.Size = new Size(76, 20);
            label5.TabIndex = 2;
            label5.Text = "basım yılı ";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(111, 193);
            textBox5.Margin = new Padding(3, 4, 3, 4);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(114, 27);
            textBox5.TabIndex = 3;
            // 
            // kitapeklemebutonu
            // 
            kitapeklemebutonu.Location = new Point(2, 339);
            kitapeklemebutonu.Margin = new Padding(3, 4, 3, 4);
            kitapeklemebutonu.Name = "kitapeklemebutonu";
            kitapeklemebutonu.Size = new Size(86, 31);
            kitapeklemebutonu.TabIndex = 4;
            kitapeklemebutonu.Text = "ekle";
            kitapeklemebutonu.UseVisualStyleBackColor = true;
            kitapeklemebutonu.Click += kitapeklemebutonu_Click;
            // 
            // kitapsilmebutonu
            // 
            kitapsilmebutonu.Location = new Point(95, 339);
            kitapsilmebutonu.Margin = new Padding(3, 4, 3, 4);
            kitapsilmebutonu.Name = "kitapsilmebutonu";
            kitapsilmebutonu.Size = new Size(86, 31);
            kitapsilmebutonu.TabIndex = 5;
            kitapsilmebutonu.Text = "silme";
            kitapsilmebutonu.UseVisualStyleBackColor = true;
            kitapsilmebutonu.Click += kitapsilmebutonu_Click;
            // 
            // kitapguncellemebutonu
            // 
            kitapguncellemebutonu.Location = new Point(187, 339);
            kitapguncellemebutonu.Margin = new Padding(3, 4, 3, 4);
            kitapguncellemebutonu.Name = "kitapguncellemebutonu";
            kitapguncellemebutonu.Size = new Size(86, 31);
            kitapguncellemebutonu.TabIndex = 6;
            kitapguncellemebutonu.Text = "güncelle";
            kitapguncellemebutonu.UseVisualStyleBackColor = true;
            kitapguncellemebutonu.Click += kitapguncellemebutonu_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(402, 29);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(474, 537);
            dataGridView1.TabIndex = 7;
            // 
            // kitap_ekle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(dataGridView1);
            Controls.Add(kitapguncellemebutonu);
            Controls.Add(kitapsilmebutonu);
            Controls.Add(kitapeklemebutonu);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox5);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "kitap_ekle";
            Text = "kitap_ekle";
            Load += kitap_ekle_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox5;
        private Button kitapeklemebutonu;
        private Button kitapsilmebutonu;
        private Button kitapguncellemebutonu;
        private DataGridView dataGridView1;
    }
}