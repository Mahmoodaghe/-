namespace المحاضرة_الثالثة_عملي
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
            this.fristN = new System.Windows.Forms.TextBox();
            this.secondN = new System.Windows.Forms.TextBox();
            this.opertion2 = new System.Windows.Forms.TextBox();
            this.opertion1 = new System.Windows.Forms.TextBox();
            this.thirdN = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fristN
            // 
            this.fristN.Location = new System.Drawing.Point(53, 24);
            this.fristN.Name = "fristN";
            this.fristN.Size = new System.Drawing.Size(100, 20);
            this.fristN.TabIndex = 0;
            this.fristN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fristN_KeyPress);
            // 
            // secondN
            // 
            this.secondN.Location = new System.Drawing.Point(53, 97);
            this.secondN.Name = "secondN";
            this.secondN.Size = new System.Drawing.Size(100, 20);
            this.secondN.TabIndex = 1;
            // 
            // opertion2
            // 
            this.opertion2.Location = new System.Drawing.Point(53, 138);
            this.opertion2.Name = "opertion2";
            this.opertion2.Size = new System.Drawing.Size(100, 20);
            this.opertion2.TabIndex = 2;
            // 
            // opertion1
            // 
            this.opertion1.Location = new System.Drawing.Point(53, 60);
            this.opertion1.Name = "opertion1";
            this.opertion1.Size = new System.Drawing.Size(100, 20);
            this.opertion1.TabIndex = 3;
            this.opertion1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.opertion1_KeyPress);
            // 
            // thirdN
            // 
            this.thirdN.Location = new System.Drawing.Point(53, 184);
            this.thirdN.Name = "thirdN";
            this.thirdN.Size = new System.Drawing.Size(100, 20);
            this.thirdN.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(187, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "حساب";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(31, 258);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "اغلاق";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "العدد الاول";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "العملية";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "العدد الثاني";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(171, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "العملية";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(171, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "العدد الثالث";
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(53, 228);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(100, 20);
            this.result.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(171, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "الناتج";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 309);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.thirdN);
            this.Controls.Add(this.opertion1);
            this.Controls.Add(this.opertion2);
            this.Controls.Add(this.secondN);
            this.Controls.Add(this.fristN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fristN;
        private System.Windows.Forms.TextBox secondN;
        private System.Windows.Forms.TextBox opertion2;
        private System.Windows.Forms.TextBox opertion1;
        private System.Windows.Forms.TextBox thirdN;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Label label6;
    }
}

