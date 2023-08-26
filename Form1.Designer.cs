namespace WeatherApp
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
            richTextBox1 = new RichTextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(18, 19);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(770, 131);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(panel1);
            groupBox1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(18, 156);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(770, 282);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Погода";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(16, 126);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(202, 154);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ветер";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 128);
            label7.Name = "label7";
            label7.Size = new Size(55, 23);
            label7.TabIndex = 1;
            label7.Text = "label7";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 26);
            label6.Name = "label6";
            label6.Size = new Size(55, 23);
            label6.TabIndex = 0;
            label6.Text = "label6";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(458, 97);
            label5.Name = "label5";
            label5.Size = new Size(55, 23);
            label5.TabIndex = 5;
            label5.Text = "label5";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(458, 64);
            label4.Name = "label4";
            label4.Size = new Size(55, 23);
            label4.TabIndex = 4;
            label4.Text = "label4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(109, 97);
            label3.Name = "label3";
            label3.Size = new Size(55, 23);
            label3.TabIndex = 3;
            label3.Text = "label3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(109, 64);
            label2.Name = "label2";
            label2.Size = new Size(55, 23);
            label2.TabIndex = 2;
            label2.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(109, 30);
            label1.Name = "label1";
            label1.Size = new Size(55, 23);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // panel1
            // 
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Location = new Point(13, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(90, 90);
            panel1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(richTextBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox1;
        private GroupBox groupBox1;
        private Panel panel1;
        private GroupBox groupBox2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}