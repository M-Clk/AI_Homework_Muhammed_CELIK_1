namespace EigthPuzzleWithAStarAlgorithm
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnCoz = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tmrAnimation = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 27);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(607, 252);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(0, 0);
            this.btn0.Margin = new System.Windows.Forms.Padding(0);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(35, 35);
            this.btn0.TabIndex = 3;
            this.btn0.Tag = "0";
            this.btn0.Text = "1";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(35, 0);
            this.btn1.Margin = new System.Windows.Forms.Padding(0);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(35, 35);
            this.btn1.TabIndex = 4;
            this.btn1.Tag = "1";
            this.btn1.Text = "2";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(70, 0);
            this.btn2.Margin = new System.Windows.Forms.Padding(0);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(35, 35);
            this.btn2.TabIndex = 5;
            this.btn2.Tag = "2";
            this.btn2.Text = "3";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(0, 35);
            this.btn3.Margin = new System.Windows.Forms.Padding(0);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(35, 35);
            this.btn3.TabIndex = 6;
            this.btn3.Tag = "3";
            this.btn3.Text = "4";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(35, 70);
            this.btn7.Margin = new System.Windows.Forms.Padding(0);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(35, 35);
            this.btn7.TabIndex = 7;
            this.btn7.Tag = "7";
            this.btn7.Text = "8";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnCoz
            // 
            this.btnCoz.Location = new System.Drawing.Point(251, 354);
            this.btnCoz.Name = "btnCoz";
            this.btnCoz.Size = new System.Drawing.Size(117, 63);
            this.btnCoz.TabIndex = 9;
            this.btnCoz.Text = "Coz";
            this.btnCoz.UseVisualStyleBackColor = true;
            this.btnCoz.Click += new System.EventHandler(this.btnCoz_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(0, 70);
            this.btn6.Margin = new System.Windows.Forms.Padding(0);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(35, 35);
            this.btn6.TabIndex = 10;
            this.btn6.Tag = "6";
            this.btn6.Text = "7";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(70, 70);
            this.btn5.Margin = new System.Windows.Forms.Padding(0);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(35, 35);
            this.btn5.TabIndex = 11;
            this.btn5.Tag = "5";
            this.btn5.Text = "6";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(35, 35);
            this.btn4.Margin = new System.Windows.Forms.Padding(0);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(35, 35);
            this.btn4.TabIndex = 12;
            this.btn4.Tag = "4";
            this.btn4.Text = "5";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn0_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn0);
            this.panel1.Controls.Add(this.btn4);
            this.panel1.Controls.Add(this.btn1);
            this.panel1.Controls.Add(this.btn5);
            this.panel1.Controls.Add(this.btn2);
            this.panel1.Controls.Add(this.btn6);
            this.panel1.Controls.Add(this.btn3);
            this.panel1.Controls.Add(this.btn7);
            this.panel1.Location = new System.Drawing.Point(12, 319);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(117, 109);
            this.panel1.TabIndex = 13;
            // 
            // tmrAnimation
            // 
            this.tmrAnimation.Interval = 10;
            this.tmrAnimation.Tick += new System.EventHandler(this.tmrAnimation_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Adimlar";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button0);
            this.panel2.Location = new System.Drawing.Point(511, 319);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(108, 109);
            this.panel2.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 35);
            this.button1.TabIndex = 3;
            this.button1.Tag = "0";
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn0_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(35, 35);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 35);
            this.button2.TabIndex = 12;
            this.button2.Tag = "4";
            this.button2.Text = "5";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btn0_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(35, 0);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(35, 35);
            this.button3.TabIndex = 4;
            this.button3.Tag = "1";
            this.button3.Text = "2";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btn0_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(70, 35);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(35, 35);
            this.button4.TabIndex = 11;
            this.button4.Tag = "5";
            this.button4.Text = "6";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btn0_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(70, 0);
            this.button5.Margin = new System.Windows.Forms.Padding(0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(35, 35);
            this.button5.TabIndex = 5;
            this.button5.Tag = "2";
            this.button5.Text = "3";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.btn0_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(0, 70);
            this.button6.Margin = new System.Windows.Forms.Padding(0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(35, 35);
            this.button6.TabIndex = 10;
            this.button6.Tag = "6";
            this.button6.Text = "7";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.btn0_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(0, 35);
            this.button7.Margin = new System.Windows.Forms.Padding(0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(35, 35);
            this.button7.TabIndex = 6;
            this.button7.Tag = "3";
            this.button7.Text = "4";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.btn0_Click);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(35, 70);
            this.button0.Margin = new System.Windows.Forms.Padding(0);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(35, 35);
            this.button0.TabIndex = 7;
            this.button0.Tag = "7";
            this.button0.Text = "8";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(511, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Hedef Durum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Baslangic Durumu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(631, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCoz);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnCoz;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer tmrAnimation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

