namespace 電卓
{
    partial class 電卓
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.mark = new System.Windows.Forms.Label();
            this.Num_Label = new System.Windows.Forms.Label();
            this.percent = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.sign = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.divided = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.all_clear = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.multiplied = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mark
            // 
            this.mark.AutoSize = true;
            this.mark.Font = new System.Drawing.Font("MS UI Gothic", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.mark.Location = new System.Drawing.Point(28, 11);
            this.mark.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.mark.Name = "mark";
            this.mark.Size = new System.Drawing.Size(111, 120);
            this.mark.TabIndex = 0;
            this.mark.Text = "=";
            this.mark.Click += new System.EventHandler(this.mark_Click);
            // 
            // Num_Label
            // 
            this.Num_Label.AutoSize = true;
            this.Num_Label.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Num_Label.Location = new System.Drawing.Point(199, 34);
            this.Num_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Num_Label.Name = "Num_Label";
            this.Num_Label.Size = new System.Drawing.Size(75, 80);
            this.Num_Label.TabIndex = 1;
            this.Num_Label.Text = "0";
            this.Num_Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Num_Label.Click += new System.EventHandler(this.label1_Click);
            // 
            // percent
            // 
            this.percent.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.percent.Location = new System.Drawing.Point(347, 130);
            this.percent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.percent.Name = "percent";
            this.percent.Size = new System.Drawing.Size(120, 105);
            this.percent.TabIndex = 2;
            this.percent.Text = "％";
            this.percent.UseVisualStyleBackColor = true;
            this.percent.Click += new System.EventHandler(this.percent_Click);
            // 
            // three
            // 
            this.three.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.three.Location = new System.Drawing.Point(345, 516);
            this.three.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(121, 110);
            this.three.TabIndex = 3;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // seven
            // 
            this.seven.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.seven.Location = new System.Drawing.Point(28, 256);
            this.seven.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(121, 110);
            this.seven.TabIndex = 4;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.button3_Click);
            // 
            // six
            // 
            this.six.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.six.Location = new System.Drawing.Point(347, 385);
            this.six.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(120, 110);
            this.six.TabIndex = 5;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.six_Click);
            // 
            // eight
            // 
            this.eight.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.eight.Location = new System.Drawing.Point(188, 256);
            this.eight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(124, 110);
            this.eight.TabIndex = 6;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.eight_Click);
            // 
            // four
            // 
            this.four.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.four.Location = new System.Drawing.Point(28, 385);
            this.four.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(121, 110);
            this.four.TabIndex = 7;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // sign
            // 
            this.sign.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.sign.Location = new System.Drawing.Point(188, 130);
            this.sign.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sign.Name = "sign";
            this.sign.Size = new System.Drawing.Size(121, 105);
            this.sign.TabIndex = 8;
            this.sign.Text = "＋/ー";
            this.sign.UseVisualStyleBackColor = true;
            this.sign.Click += new System.EventHandler(this.sign_Click);
            // 
            // one
            // 
            this.one.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.one.Location = new System.Drawing.Point(28, 516);
            this.one.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(121, 110);
            this.one.TabIndex = 9;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // divided
            // 
            this.divided.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.divided.Location = new System.Drawing.Point(497, 130);
            this.divided.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.divided.Name = "divided";
            this.divided.Size = new System.Drawing.Size(120, 105);
            this.divided.TabIndex = 10;
            this.divided.Text = "÷";
            this.divided.UseVisualStyleBackColor = true;
            this.divided.Click += new System.EventHandler(this.divided_Click);
            // 
            // five
            // 
            this.five.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.five.Location = new System.Drawing.Point(188, 385);
            this.five.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(124, 110);
            this.five.TabIndex = 11;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.five_Click);
            // 
            // zero
            // 
            this.zero.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.zero.Location = new System.Drawing.Point(31, 649);
            this.zero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(281, 109);
            this.zero.TabIndex = 12;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // nine
            // 
            this.nine.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nine.Location = new System.Drawing.Point(345, 256);
            this.nine.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(121, 110);
            this.nine.TabIndex = 13;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.nine_Click);
            // 
            // all_clear
            // 
            this.all_clear.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.all_clear.Location = new System.Drawing.Point(28, 130);
            this.all_clear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.all_clear.Name = "all_clear";
            this.all_clear.Size = new System.Drawing.Size(121, 105);
            this.all_clear.TabIndex = 14;
            this.all_clear.Text = "AC";
            this.all_clear.UseVisualStyleBackColor = true;
            this.all_clear.Click += new System.EventHandler(this.all_clear_Click);
            // 
            // minus
            // 
            this.minus.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.minus.Location = new System.Drawing.Point(499, 385);
            this.minus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(119, 110);
            this.minus.TabIndex = 15;
            this.minus.Text = "－";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // two
            // 
            this.two.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.two.Location = new System.Drawing.Point(191, 516);
            this.two.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(121, 110);
            this.two.TabIndex = 16;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // multiplied
            // 
            this.multiplied.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.multiplied.Location = new System.Drawing.Point(496, 256);
            this.multiplied.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.multiplied.Name = "multiplied";
            this.multiplied.Size = new System.Drawing.Size(121, 110);
            this.multiplied.TabIndex = 17;
            this.multiplied.Text = "×";
            this.multiplied.UseVisualStyleBackColor = true;
            this.multiplied.Click += new System.EventHandler(this.multiplied_Click);
            // 
            // plus
            // 
            this.plus.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.plus.Location = new System.Drawing.Point(499, 516);
            this.plus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(119, 110);
            this.plus.TabIndex = 18;
            this.plus.Text = "+";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // equal
            // 
            this.equal.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.equal.Location = new System.Drawing.Point(499, 649);
            this.equal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(119, 109);
            this.equal.TabIndex = 19;
            this.equal.Text = "＝";
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.equal_Click_1);
            // 
            // dot
            // 
            this.dot.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.dot.Location = new System.Drawing.Point(347, 649);
            this.dot.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(120, 109);
            this.dot.TabIndex = 20;
            this.dot.Text = ".";
            this.dot.UseVisualStyleBackColor = true;
            this.dot.Click += new System.EventHandler(this.dot_Click);
            // 
            // 電卓
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 772);
            this.Controls.Add(this.dot);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.multiplied);
            this.Controls.Add(this.two);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.all_clear);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.five);
            this.Controls.Add(this.divided);
            this.Controls.Add(this.one);
            this.Controls.Add(this.sign);
            this.Controls.Add(this.four);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.six);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.three);
            this.Controls.Add(this.percent);
            this.Controls.Add(this.Num_Label);
            this.Controls.Add(this.mark);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "電卓";
            this.Text = "電卓";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mark;
        private System.Windows.Forms.Label Num_Label;
        private System.Windows.Forms.Button percent;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button sign;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button divided;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button all_clear;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button multiplied;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button dot;
    }
}

