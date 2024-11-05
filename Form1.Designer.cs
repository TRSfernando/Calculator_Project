namespace CalculatorProject
{
    partial class Calculator
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
            this.displayScreen = new System.Windows.Forms.TextBox();
            this.reciprocal = new System.Windows.Forms.Button();
            this.power = new System.Windows.Forms.Button();
            this.squareRoot = new System.Windows.Forms.Button();
            this.divide = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.percentage = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.answerScreen = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // displayScreen
            // 
            this.displayScreen.BackColor = System.Drawing.Color.Gray;
            this.displayScreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.displayScreen.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.displayScreen.Location = new System.Drawing.Point(43, 40);
            this.displayScreen.Name = "displayScreen";
            this.displayScreen.Size = new System.Drawing.Size(686, 68);
            this.displayScreen.TabIndex = 0;
            // 
            // reciprocal
            // 
            this.reciprocal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(55)))));
            this.reciprocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.reciprocal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(140)))), ((int)(((byte)(153)))));
            this.reciprocal.Location = new System.Drawing.Point(43, 275);
            this.reciprocal.Name = "reciprocal";
            this.reciprocal.Size = new System.Drawing.Size(167, 92);
            this.reciprocal.TabIndex = 1;
            this.reciprocal.Text = "1/𝒳";
            this.reciprocal.UseVisualStyleBackColor = false;
            this.reciprocal.Click += new System.EventHandler(this.reciprocal_Click);
            // 
            // power
            // 
            this.power.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(55)))));
            this.power.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.power.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(140)))), ((int)(((byte)(153)))));
            this.power.Location = new System.Drawing.Point(216, 275);
            this.power.Name = "power";
            this.power.Size = new System.Drawing.Size(167, 92);
            this.power.TabIndex = 2;
            this.power.Text = "𝒳²";
            this.power.UseVisualStyleBackColor = false;
            this.power.Click += new System.EventHandler(this.power_Click);
            // 
            // squareRoot
            // 
            this.squareRoot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(55)))));
            this.squareRoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.squareRoot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(140)))), ((int)(((byte)(153)))));
            this.squareRoot.Location = new System.Drawing.Point(389, 275);
            this.squareRoot.Name = "squareRoot";
            this.squareRoot.Size = new System.Drawing.Size(167, 92);
            this.squareRoot.TabIndex = 3;
            this.squareRoot.Text = "2√𝒳";
            this.squareRoot.UseVisualStyleBackColor = false;
            this.squareRoot.Click += new System.EventHandler(this.squareRoot_Click);
            // 
            // divide
            // 
            this.divide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(55)))));
            this.divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.divide.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(140)))), ((int)(((byte)(153)))));
            this.divide.Location = new System.Drawing.Point(562, 275);
            this.divide.Name = "divide";
            this.divide.Size = new System.Drawing.Size(167, 92);
            this.divide.TabIndex = 4;
            this.divide.Text = "÷";
            this.divide.UseVisualStyleBackColor = false;
            this.divide.Click += new System.EventHandler(this.divide_Click);
            // 
            // multiply
            // 
            this.multiply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(55)))));
            this.multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.multiply.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(140)))), ((int)(((byte)(153)))));
            this.multiply.Location = new System.Drawing.Point(562, 373);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(167, 92);
            this.multiply.TabIndex = 8;
            this.multiply.Text = "x";
            this.multiply.UseVisualStyleBackColor = false;
            this.multiply.Click += new System.EventHandler(this.multiply_Click);
            // 
            // nine
            // 
            this.nine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.nine.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.nine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(140)))), ((int)(((byte)(153)))));
            this.nine.Location = new System.Drawing.Point(389, 373);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(167, 92);
            this.nine.TabIndex = 7;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = false;
            this.nine.Click += new System.EventHandler(this.nine_Click);
            // 
            // eight
            // 
            this.eight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.eight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.eight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(140)))), ((int)(((byte)(153)))));
            this.eight.Location = new System.Drawing.Point(216, 373);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(167, 92);
            this.eight.TabIndex = 6;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = false;
            this.eight.Click += new System.EventHandler(this.eight_Click);
            // 
            // seven
            // 
            this.seven.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.seven.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.seven.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(140)))), ((int)(((byte)(153)))));
            this.seven.Location = new System.Drawing.Point(43, 373);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(167, 92);
            this.seven.TabIndex = 5;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = false;
            this.seven.Click += new System.EventHandler(this.seven_Click);
            // 
            // minus
            // 
            this.minus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(55)))));
            this.minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.minus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(140)))), ((int)(((byte)(153)))));
            this.minus.Location = new System.Drawing.Point(562, 471);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(167, 92);
            this.minus.TabIndex = 12;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = false;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // six
            // 
            this.six.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.six.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.six.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(140)))), ((int)(((byte)(153)))));
            this.six.Location = new System.Drawing.Point(389, 471);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(167, 92);
            this.six.TabIndex = 11;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = false;
            this.six.Click += new System.EventHandler(this.six_Click);
            // 
            // five
            // 
            this.five.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.five.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.five.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(140)))), ((int)(((byte)(153)))));
            this.five.Location = new System.Drawing.Point(216, 471);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(167, 92);
            this.five.TabIndex = 10;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = false;
            this.five.Click += new System.EventHandler(this.button10_Click);
            // 
            // four
            // 
            this.four.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.four.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.four.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(140)))), ((int)(((byte)(153)))));
            this.four.Location = new System.Drawing.Point(43, 471);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(167, 92);
            this.four.TabIndex = 9;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = false;
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // plus
            // 
            this.plus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(55)))));
            this.plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.plus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(140)))), ((int)(((byte)(153)))));
            this.plus.Location = new System.Drawing.Point(562, 569);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(167, 92);
            this.plus.TabIndex = 16;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = false;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // three
            // 
            this.three.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.three.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.three.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(140)))), ((int)(((byte)(153)))));
            this.three.Location = new System.Drawing.Point(389, 569);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(167, 92);
            this.three.TabIndex = 15;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = false;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // two
            // 
            this.two.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.two.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.two.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(140)))), ((int)(((byte)(153)))));
            this.two.Location = new System.Drawing.Point(216, 569);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(167, 92);
            this.two.TabIndex = 14;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = false;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // one
            // 
            this.one.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.one.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.one.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(140)))), ((int)(((byte)(153)))));
            this.one.Location = new System.Drawing.Point(43, 569);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(167, 92);
            this.one.TabIndex = 13;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = false;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // equal
            // 
            this.equal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(55)))));
            this.equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.equal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(223)))), ((int)(((byte)(204)))));
            this.equal.Location = new System.Drawing.Point(562, 667);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(167, 92);
            this.equal.TabIndex = 20;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = false;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // percentage
            // 
            this.percentage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(61)))), ((int)(((byte)(55)))));
            this.percentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.percentage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(140)))), ((int)(((byte)(153)))));
            this.percentage.Location = new System.Drawing.Point(389, 667);
            this.percentage.Name = "percentage";
            this.percentage.Size = new System.Drawing.Size(167, 92);
            this.percentage.TabIndex = 19;
            this.percentage.Text = "%";
            this.percentage.UseVisualStyleBackColor = false;
            this.percentage.Click += new System.EventHandler(this.percentage_Click);
            // 
            // zero
            // 
            this.zero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.zero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(140)))), ((int)(((byte)(153)))));
            this.zero.Location = new System.Drawing.Point(216, 667);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(167, 92);
            this.zero.TabIndex = 18;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = false;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(188)))), ((int)(((byte)(218)))));
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.clear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(140)))), ((int)(((byte)(153)))));
            this.clear.Location = new System.Drawing.Point(43, 667);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(167, 92);
            this.clear.TabIndex = 17;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // answerScreen
            // 
            this.answerScreen.BackColor = System.Drawing.SystemColors.GrayText;
            this.answerScreen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.answerScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F);
            this.answerScreen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.answerScreen.Location = new System.Drawing.Point(43, 114);
            this.answerScreen.Name = "answerScreen";
            this.answerScreen.Size = new System.Drawing.Size(686, 106);
            this.answerScreen.TabIndex = 21;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(765, 806);
            this.Controls.Add(this.answerScreen);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.percentage);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.divide);
            this.Controls.Add(this.squareRoot);
            this.Controls.Add(this.power);
            this.Controls.Add(this.reciprocal);
            this.Controls.Add(this.displayScreen);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox displayScreen;
        private System.Windows.Forms.Button reciprocal;
        private System.Windows.Forms.Button power;
        private System.Windows.Forms.Button squareRoot;
        private System.Windows.Forms.Button divide;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button percentage;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.TextBox answerScreen;
    }
}

