namespace BilgiYarışması
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
            richTextBox1 = new RichTextBox();
            btnA = new Button();
            btnC = new Button();
            btnB = new Button();
            btnD = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblSoruno = new Label();
            lblDoğru = new Label();
            lblYanlış = new Label();
            btnSonraki = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(-2, 0);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(459, 238);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // btnA
            // 
            btnA.Location = new Point(-2, 252);
            btnA.Name = "btnA";
            btnA.Size = new Size(205, 47);
            btnA.TabIndex = 1;
            btnA.Text = "A";
            btnA.UseVisualStyleBackColor = true;
            btnA.Click += btnA_Click;
            // 
            // btnC
            // 
            btnC.Location = new Point(-2, 323);
            btnC.Name = "btnC";
            btnC.Size = new Size(205, 47);
            btnC.TabIndex = 2;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = true;
            btnC.Click += btnC_Click;
            // 
            // btnB
            // 
            btnB.Location = new Point(209, 252);
            btnB.Name = "btnB";
            btnB.Size = new Size(211, 47);
            btnB.TabIndex = 3;
            btnB.Text = "B";
            btnB.UseVisualStyleBackColor = true;
            btnB.Click += btnB_Click;
            // 
            // btnD
            // 
            btnD.Location = new Point(209, 323);
            btnD.Name = "btnD";
            btnD.Size = new Size(211, 47);
            btnD.TabIndex = 4;
            btnD.Text = "D";
            btnD.UseVisualStyleBackColor = true;
            btnD.Click += btnD_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(479, 45);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 5;
            label1.Text = "Soru No:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(489, 76);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 6;
            label2.Text = "Doğru:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(495, 114);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 7;
            label3.Text = "Yanlış";
            // 
            // lblSoruno
            // 
            lblSoruno.AutoSize = true;
            lblSoruno.Location = new Point(538, 45);
            lblSoruno.Name = "lblSoruno";
            lblSoruno.Size = new Size(13, 15);
            lblSoruno.TabIndex = 8;
            lblSoruno.Text = "0";
            // 
            // lblDoğru
            // 
            lblDoğru.AutoSize = true;
            lblDoğru.Location = new Point(538, 76);
            lblDoğru.Name = "lblDoğru";
            lblDoğru.Size = new Size(13, 15);
            lblDoğru.TabIndex = 9;
            lblDoğru.Text = "0";
            // 
            // lblYanlış
            // 
            lblYanlış.AutoSize = true;
            lblYanlış.Location = new Point(538, 114);
            lblYanlış.Name = "lblYanlış";
            lblYanlış.Size = new Size(13, 15);
            lblYanlış.TabIndex = 10;
            lblYanlış.Text = "0";
            // 
            // btnSonraki
            // 
            btnSonraki.Location = new Point(488, 177);
            btnSonraki.Name = "btnSonraki";
            btnSonraki.Size = new Size(228, 61);
            btnSonraki.TabIndex = 11;
            btnSonraki.Text = "Sonraki";
            btnSonraki.UseVisualStyleBackColor = true;
            btnSonraki.Click += btnSonraki_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(462, 252);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(129, 118);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(597, 251);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(119, 119);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(135, 408);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 14;
            label4.Text = "label4";
            label4.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(209, 408);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 15;
            label5.Text = "label5";
            label5.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(748, 397);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnSonraki);
            Controls.Add(lblYanlış);
            Controls.Add(lblDoğru);
            Controls.Add(lblSoruno);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnD);
            Controls.Add(btnB);
            Controls.Add(btnC);
            Controls.Add(btnA);
            Controls.Add(richTextBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button btnA;
        private Button btnC;
        private Button btnB;
        private Button btnD;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblSoruno;
        private Label lblDoğru;
        private Label lblYanlış;
        private Button btnSonraki;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label4;
        private Label label5;
    }
}
