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
            this.label1 = new System.Windows.Forms.Label();
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
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(467, 252);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 382);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "goalState";
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(0, 0);
            this.btn0.Margin = new System.Windows.Forms.Padding(0);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(35, 35);
            this.btn0.TabIndex = 3;
            this.btn0.Text = "1";
            this.btn0.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(35, 0);
            this.btn1.Margin = new System.Windows.Forms.Padding(0);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(35, 35);
            this.btn1.TabIndex = 4;
            this.btn1.Text = "2";
            this.btn1.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(70, 0);
            this.btn2.Margin = new System.Windows.Forms.Padding(0);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(35, 35);
            this.btn2.TabIndex = 5;
            this.btn2.Text = "3";
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(0, 35);
            this.btn3.Margin = new System.Windows.Forms.Padding(0);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(35, 35);
            this.btn3.TabIndex = 6;
            this.btn3.Text = "4";
            this.btn3.UseVisualStyleBackColor = true;
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(35, 70);
            this.btn7.Margin = new System.Windows.Forms.Padding(0);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(35, 35);
            this.btn7.TabIndex = 7;
            this.btn7.Text = "8";
            this.btn7.UseVisualStyleBackColor = true;
            // 
            // btnCoz
            // 
            this.btnCoz.Location = new System.Drawing.Point(427, 408);
            this.btnCoz.Name = "btnCoz";
            this.btnCoz.Size = new System.Drawing.Size(117, 28);
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
            this.btn6.Text = "7";
            this.btn6.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(70, 35);
            this.btn5.Margin = new System.Windows.Forms.Padding(0);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(35, 35);
            this.btn5.TabIndex = 11;
            this.btn5.Text = "6";
            this.btn5.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(35, 35);
            this.btn4.Margin = new System.Windows.Forms.Padding(0);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(35, 35);
            this.btn4.TabIndex = 12;
            this.btn4.Text = "5";
            this.btn4.UseVisualStyleBackColor = true;
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
            this.panel1.Location = new System.Drawing.Point(424, 270);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 132);
            this.panel1.TabIndex = 13;
            // 
            // tmrAnimation
            // 
            this.tmrAnimation.Tick += new System.EventHandler(this.tmrAnimation_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCoz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
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
    }
}

