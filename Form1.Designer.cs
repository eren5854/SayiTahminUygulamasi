namespace SayiTahminUygulaması
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox1 = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            label8 = new Label();
            button2 = new Button();
            label7 = new Label();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(95, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 25);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(10, 20);
            label1.Name = "label1";
            label1.Size = new Size(41, 28);
            label1.TabIndex = 1;
            label1.Text = "Ad:";
            // 
            // panel1
            // 
            panel1.Controls.Add(label8);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(225, 496);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(13, 267);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 14;
            label8.Text = "label8";
            label8.Visible = false;
            // 
            // button2
            // 
            button2.Location = new Point(71, 260);
            button2.Name = "button2";
            button2.Size = new Size(89, 23);
            button2.TabIndex = 13;
            button2.Text = "Gönder";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(65, 327);
            label7.Name = "label7";
            label7.Size = new Size(10, 15);
            label7.TabIndex = 12;
            label7.Text = " ";
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 346);
            panel2.Name = "panel2";
            panel2.Size = new Size(225, 150);
            panel2.TabIndex = 11;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            pictureBox2.Dock = DockStyle.Top;
            pictureBox2.Location = new Point(0, 82);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(225, 82);
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(225, 82);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(108, 296);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 296);
            label5.Name = "label5";
            label5.Size = new Size(92, 15);
            label5.TabIndex = 8;
            label5.Text = "Deneme Sayısı : ";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(46, 209);
            label4.Name = "label4";
            label4.Size = new Size(149, 19);
            label4.TabIndex = 7;
            label4.Text = "Tahmini Giriniz 1-10:";
            label4.Click += label4_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(71, 231);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(89, 23);
            textBox3.TabIndex = 6;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(85, 115);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "OYNA";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(10, 141);
            label3.Name = "label3";
            label3.Size = new Size(65, 28);
            label3.TabIndex = 4;
            label3.Text = "label3";
            label3.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(10, 56);
            label2.Name = "label2";
            label2.Size = new Size(79, 28);
            label2.TabIndex = 3;
            label2.Text = "Soy Ad:";
            label2.Click += label2_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(95, 62);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 25);
            textBox2.TabIndex = 2;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(234, 496);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Sayı Tahmin";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Panel panel1;
        private Label label2;
        private TextBox textBox2;
        private Button button1;
        private Label label3;
        private Label label7;
        private Panel panel2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox textBox3;
        private Button button2;
        private Label label8;
    }
}