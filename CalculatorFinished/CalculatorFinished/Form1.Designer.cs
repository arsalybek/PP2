﻿namespace CalculatorFinished
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.sqrt = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sin = new System.Windows.Forms.Button();
            this.e = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.pi = new System.Windows.Forms.Button();
            this.tan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(4, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.Size = new System.Drawing.Size(254, 35);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "1/x";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.operation2_click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(212, 139);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 37);
            this.button2.TabIndex = 2;
            this.button2.Text = "/";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.operation_click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(108, 96);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(46, 37);
            this.button3.TabIndex = 3;
            this.button3.Text = "C";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.clear_clicked);
            // 
            // sqrt
            // 
            this.sqrt.Location = new System.Drawing.Point(56, 96);
            this.sqrt.Name = "sqrt";
            this.sqrt.Size = new System.Drawing.Size(46, 37);
            this.sqrt.TabIndex = 4;
            this.sqrt.Text = "sqrt";
            this.sqrt.UseVisualStyleBackColor = true;
            this.sqrt.Click += new System.EventHandler(this.operation2_click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(56, 182);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(46, 37);
            this.button7.TabIndex = 9;
            this.button7.Text = "5";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.numbers_click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(108, 182);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(46, 37);
            this.button8.TabIndex = 8;
            this.button8.Text = "6";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.numbers_click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(160, 182);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(46, 37);
            this.button9.TabIndex = 7;
            this.button9.Text = "-";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.operation_click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(4, 182);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(46, 37);
            this.button10.TabIndex = 6;
            this.button10.Text = "4";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.numbers_click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(56, 225);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(46, 37);
            this.button12.TabIndex = 14;
            this.button12.Text = "2";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.numbers_click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(108, 225);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(46, 37);
            this.button13.TabIndex = 13;
            this.button13.Text = "3";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.numbers_click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(160, 225);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(46, 39);
            this.button14.TabIndex = 12;
            this.button14.Text = "+";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.operation_click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(4, 225);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(46, 37);
            this.button15.TabIndex = 11;
            this.button15.Text = "1";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.numbers_click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(56, 268);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(46, 37);
            this.button17.TabIndex = 19;
            this.button17.Text = "0";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.numbers_click);
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(108, 268);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(46, 37);
            this.button18.TabIndex = 18;
            this.button18.Text = ",";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.numbers_click);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(160, 268);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(46, 37);
            this.button19.TabIndex = 17;
            this.button19.Text = "=";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.equal_click);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(4, 268);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(46, 37);
            this.button20.TabIndex = 16;
            this.button20.Text = "+/-";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.operation2_click);
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(56, 139);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(46, 37);
            this.button22.TabIndex = 24;
            this.button22.Text = "8";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.numbers_click);
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(108, 139);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(46, 37);
            this.button23.TabIndex = 23;
            this.button23.Text = "9";
            this.button23.UseVisualStyleBackColor = true;
            this.button23.Click += new System.EventHandler(this.numbers_click);
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(160, 139);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(46, 37);
            this.button24.TabIndex = 22;
            this.button24.Text = "X";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.operation_click);
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(4, 139);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(46, 37);
            this.button25.TabIndex = 21;
            this.button25.Text = "7";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.numbers_click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(56, 53);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(46, 37);
            this.button5.TabIndex = 28;
            this.button5.Text = "x^y";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.operation_click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(108, 53);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(46, 37);
            this.button6.TabIndex = 27;
            this.button6.Text = "x!";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.operation2_click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(160, 53);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(46, 37);
            this.button11.TabIndex = 26;
            this.button11.Text = "x^2";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.operation2_click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(4, 53);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(46, 37);
            this.button16.TabIndex = 25;
            this.button16.Text = "log";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.operation2_click);
            // 
            // sin
            // 
            this.sin.Location = new System.Drawing.Point(212, 53);
            this.sin.Name = "sin";
            this.sin.Size = new System.Drawing.Size(46, 37);
            this.sin.TabIndex = 34;
            this.sin.Text = "sin";
            this.sin.UseVisualStyleBackColor = true;
            this.sin.Click += new System.EventHandler(this.operation2_click);
            // 
            // e
            // 
            this.e.Location = new System.Drawing.Point(212, 182);
            this.e.Name = "e";
            this.e.Size = new System.Drawing.Size(46, 37);
            this.e.TabIndex = 33;
            this.e.Text = "e";
            this.e.UseVisualStyleBackColor = true;
            this.e.Click += new System.EventHandler(this.showNumber_click);
            // 
            // button26
            // 
            this.button26.Location = new System.Drawing.Point(160, 96);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(46, 37);
            this.button26.TabIndex = 32;
            this.button26.Text = "<--";
            this.button26.UseVisualStyleBackColor = true;
            this.button26.Click += new System.EventHandler(this.clearLast_click);
            // 
            // button27
            // 
            this.button27.Location = new System.Drawing.Point(212, 268);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(46, 39);
            this.button27.TabIndex = 31;
            this.button27.Text = "10^x";
            this.button27.UseVisualStyleBackColor = true;
            this.button27.Click += new System.EventHandler(this.operation2_click);
            // 
            // pi
            // 
            this.pi.Location = new System.Drawing.Point(212, 227);
            this.pi.Name = "pi";
            this.pi.Size = new System.Drawing.Size(46, 37);
            this.pi.TabIndex = 30;
            this.pi.Text = "pi";
            this.pi.UseVisualStyleBackColor = true;
            this.pi.Click += new System.EventHandler(this.showNumber_click);
            // 
            // tan
            // 
            this.tan.Location = new System.Drawing.Point(212, 96);
            this.tan.Name = "tan";
            this.tan.Size = new System.Drawing.Size(46, 37);
            this.tan.TabIndex = 29;
            this.tan.Text = "tan";
            this.tan.UseVisualStyleBackColor = true;
            this.tan.Click += new System.EventHandler(this.operation2_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 327);
            this.Controls.Add(this.sin);
            this.Controls.Add(this.e);
            this.Controls.Add(this.button26);
            this.Controls.Add(this.button27);
            this.Controls.Add(this.pi);
            this.Controls.Add(this.tan);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.sqrt);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button sqrt;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button sin;
        private System.Windows.Forms.Button e;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button pi;
        private System.Windows.Forms.Button tan;
        public System.Windows.Forms.TextBox textBox1;
    }
}

