namespace Calculator2
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
            this.title = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.add1 = new System.Windows.Forms.Button();
            this.add2 = new System.Windows.Forms.Button();
            this.add3 = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.add4 = new System.Windows.Forms.Button();
            this.add5 = new System.Windows.Forms.Button();
            this.add6 = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.add7 = new System.Windows.Forms.Button();
            this.add8 = new System.Windows.Forms.Button();
            this.add9 = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.add0 = new System.Windows.Forms.Button();
            this.twice = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.title.Location = new System.Drawing.Point(98, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(173, 31);
            this.title.TabIndex = 0;
            this.title.Text = "C# calculator";
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.result.Location = new System.Drawing.Point(13, 69);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 46);
            this.result.TabIndex = 1;
            this.result.Click += new System.EventHandler(this.label2_Click);
            // 
            // add1
            // 
            this.add1.Location = new System.Drawing.Point(21, 179);
            this.add1.Name = "add1";
            this.add1.Size = new System.Drawing.Size(57, 56);
            this.add1.TabIndex = 2;
            this.add1.Text = "1";
            this.add1.UseVisualStyleBackColor = true;
            this.add1.Click += new System.EventHandler(this.button1_Click);
            // 
            // add2
            // 
            this.add2.Location = new System.Drawing.Point(104, 179);
            this.add2.Name = "add2";
            this.add2.Size = new System.Drawing.Size(57, 56);
            this.add2.TabIndex = 3;
            this.add2.Text = "2";
            this.add2.UseVisualStyleBackColor = true;
            // 
            // add3
            // 
            this.add3.Location = new System.Drawing.Point(185, 179);
            this.add3.Name = "add3";
            this.add3.Size = new System.Drawing.Size(57, 56);
            this.add3.TabIndex = 4;
            this.add3.Text = "3";
            this.add3.UseVisualStyleBackColor = true;
            // 
            // plus
            // 
            this.plus.Location = new System.Drawing.Point(311, 179);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(24, 56);
            this.plus.TabIndex = 5;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            // 
            // add4
            // 
            this.add4.Location = new System.Drawing.Point(21, 257);
            this.add4.Name = "add4";
            this.add4.Size = new System.Drawing.Size(57, 56);
            this.add4.TabIndex = 6;
            this.add4.Text = "4";
            this.add4.UseVisualStyleBackColor = true;
            // 
            // add5
            // 
            this.add5.Location = new System.Drawing.Point(104, 257);
            this.add5.Name = "add5";
            this.add5.Size = new System.Drawing.Size(57, 56);
            this.add5.TabIndex = 7;
            this.add5.Text = "5";
            this.add5.UseVisualStyleBackColor = true;
            // 
            // add6
            // 
            this.add6.Location = new System.Drawing.Point(185, 257);
            this.add6.Name = "add6";
            this.add6.Size = new System.Drawing.Size(57, 56);
            this.add6.TabIndex = 8;
            this.add6.Text = "6";
            this.add6.UseVisualStyleBackColor = true;
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(278, 179);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(27, 56);
            this.minus.TabIndex = 9;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            // 
            // add7
            // 
            this.add7.Location = new System.Drawing.Point(21, 333);
            this.add7.Name = "add7";
            this.add7.Size = new System.Drawing.Size(57, 56);
            this.add7.TabIndex = 10;
            this.add7.Text = "7";
            this.add7.UseVisualStyleBackColor = true;
            // 
            // add8
            // 
            this.add8.Location = new System.Drawing.Point(104, 333);
            this.add8.Name = "add8";
            this.add8.Size = new System.Drawing.Size(57, 56);
            this.add8.TabIndex = 11;
            this.add8.Text = "8";
            this.add8.UseVisualStyleBackColor = true;
            // 
            // add9
            // 
            this.add9.Location = new System.Drawing.Point(185, 333);
            this.add9.Name = "add9";
            this.add9.Size = new System.Drawing.Size(57, 56);
            this.add9.TabIndex = 12;
            this.add9.Text = "9";
            this.add9.UseVisualStyleBackColor = true;
            // 
            // equal
            // 
            this.equal.Location = new System.Drawing.Point(278, 333);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(57, 56);
            this.equal.TabIndex = 13;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            // 
            // add0
            // 
            this.add0.Location = new System.Drawing.Point(21, 395);
            this.add0.Name = "add0";
            this.add0.Size = new System.Drawing.Size(57, 56);
            this.add0.TabIndex = 14;
            this.add0.Text = "0";
            this.add0.UseVisualStyleBackColor = true;
            // 
            // twice
            // 
            this.twice.Location = new System.Drawing.Point(278, 257);
            this.twice.Name = "twice";
            this.twice.Size = new System.Drawing.Size(27, 56);
            this.twice.TabIndex = 17;
            this.twice.Text = "x";
            this.twice.UseVisualStyleBackColor = true;
            // 
            // divide
            // 
            this.divide.Location = new System.Drawing.Point(308, 257);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(27, 56);
            this.divide.TabIndex = 18;
            this.divide.Text = "/";
            this.divide.UseVisualStyleBackColor = true;
            this.divide.Click += new System.EventHandler(this.button17_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(185, 395);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(150, 46);
            this.clear.TabIndex = 19;
            this.clear.Text = "clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 453);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.twice);
            this.Controls.Add(this.add0);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.add9);
            this.Controls.Add(this.add8);
            this.Controls.Add(this.add7);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.add6);
            this.Controls.Add(this.add5);
            this.Controls.Add(this.add4);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.add3);
            this.Controls.Add(this.add2);
            this.Controls.Add(this.add1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.title);
            this.Name = "Form1";
            this.Text = "Sample c# calculator by BlueMaT";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Button add1;
        private System.Windows.Forms.Button add2;
        private System.Windows.Forms.Button add3;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button add4;
        private System.Windows.Forms.Button add5;
        private System.Windows.Forms.Button add6;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button add7;
        private System.Windows.Forms.Button add8;
        private System.Windows.Forms.Button add9;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button add0;
        private System.Windows.Forms.Button twice;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button clear;
    }
}

