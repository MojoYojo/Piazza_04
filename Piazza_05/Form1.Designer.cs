namespace Piazza_05
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
            this.display = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.subtract = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.Dot = new System.Windows.Forms.Button();
            this.MS = new System.Windows.Forms.Button();
            this.MR = new System.Windows.Forms.Button();
            this.Backspace = new System.Windows.Forms.Button();
            this.MC = new System.Windows.Forms.Button();
            this.MP = new System.Windows.Forms.Button();
            this.MM = new System.Windows.Forms.Button();
            this.Square = new System.Windows.Forms.Button();
            this.Cube = new System.Windows.Forms.Button();
            this.Power = new System.Windows.Forms.Button();
            this.Sqrt = new System.Windows.Forms.Button();
            this.Factorial = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.Memory = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // display
            // 
            this.display.Cursor = System.Windows.Forms.Cursors.No;
            this.display.Location = new System.Drawing.Point(12, 24);
            this.display.Name = "display";
            this.display.ReadOnly = true;
            this.display.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.display.Size = new System.Drawing.Size(212, 20);
            this.display.TabIndex = 0;
            this.display.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.display.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "7";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.num_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(58, 130);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 30);
            this.button2.TabIndex = 2;
            this.button2.Text = "8";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.num_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(104, 130);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(30, 30);
            this.button3.TabIndex = 3;
            this.button3.Text = "9";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.num_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(104, 168);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(30, 30);
            this.button4.TabIndex = 6;
            this.button4.Text = "6";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.num_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(58, 168);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(30, 30);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.num_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(13, 168);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(30, 30);
            this.button6.TabIndex = 4;
            this.button6.Text = "4";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.num_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(104, 206);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(30, 30);
            this.button7.TabIndex = 9;
            this.button7.Text = "3";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.num_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(58, 206);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(30, 30);
            this.button8.TabIndex = 8;
            this.button8.Text = "2";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.num_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(13, 206);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(30, 30);
            this.button9.TabIndex = 7;
            this.button9.Text = "1";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.num_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(143, 241);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(37, 30);
            this.add.TabIndex = 10;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.operation_click);
            // 
            // subtract
            // 
            this.subtract.Location = new System.Drawing.Point(143, 206);
            this.subtract.Name = "subtract";
            this.subtract.Size = new System.Drawing.Size(37, 30);
            this.subtract.TabIndex = 11;
            this.subtract.Text = "-";
            this.subtract.UseVisualStyleBackColor = true;
            this.subtract.Click += new System.EventHandler(this.operation_click);
            // 
            // multiply
            // 
            this.multiply.Location = new System.Drawing.Point(143, 168);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(37, 30);
            this.multiply.TabIndex = 12;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.operation_click);
            // 
            // division
            // 
            this.division.Location = new System.Drawing.Point(144, 130);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(36, 30);
            this.division.TabIndex = 13;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.operation_click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(188, 206);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(36, 65);
            this.button14.TabIndex = 14;
            this.button14.Text = "=";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.result_click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(13, 241);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(30, 30);
            this.button15.TabIndex = 15;
            this.button15.Text = "0";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.num_Click);
            // 
            // Dot
            // 
            this.Dot.Location = new System.Drawing.Point(58, 241);
            this.Dot.Name = "Dot";
            this.Dot.Size = new System.Drawing.Size(30, 30);
            this.Dot.TabIndex = 16;
            this.Dot.Text = ",";
            this.Dot.UseVisualStyleBackColor = true;
            this.Dot.Click += new System.EventHandler(this.num_Click);
            // 
            // MS
            // 
            this.MS.Location = new System.Drawing.Point(98, 54);
            this.MS.Name = "MS";
            this.MS.Size = new System.Drawing.Size(38, 30);
            this.MS.TabIndex = 19;
            this.MS.Text = "MS";
            this.MS.UseVisualStyleBackColor = true;
            this.MS.Click += new System.EventHandler(this.memory_Click);
            // 
            // MR
            // 
            this.MR.Location = new System.Drawing.Point(55, 54);
            this.MR.Name = "MR";
            this.MR.Size = new System.Drawing.Size(38, 30);
            this.MR.TabIndex = 20;
            this.MR.Text = "MR";
            this.MR.UseVisualStyleBackColor = true;
            this.MR.Click += new System.EventHandler(this.memory_Click);
            // 
            // Backspace
            // 
            this.Backspace.Location = new System.Drawing.Point(186, 130);
            this.Backspace.Name = "Backspace";
            this.Backspace.Size = new System.Drawing.Size(38, 30);
            this.Backspace.TabIndex = 21;
            this.Backspace.Text = "<---";
            this.Backspace.UseVisualStyleBackColor = true;
            this.Backspace.Click += new System.EventHandler(this.clear_Click);
            // 
            // MC
            // 
            this.MC.Location = new System.Drawing.Point(12, 54);
            this.MC.Name = "MC";
            this.MC.Size = new System.Drawing.Size(38, 30);
            this.MC.TabIndex = 22;
            this.MC.Text = "MC";
            this.MC.UseVisualStyleBackColor = true;
            this.MC.Click += new System.EventHandler(this.memory_Click);
            // 
            // MP
            // 
            this.MP.Location = new System.Drawing.Point(142, 54);
            this.MP.Name = "MP";
            this.MP.Size = new System.Drawing.Size(38, 30);
            this.MP.TabIndex = 23;
            this.MP.Text = "M+";
            this.MP.UseVisualStyleBackColor = true;
            this.MP.Click += new System.EventHandler(this.memory_Click);
            // 
            // MM
            // 
            this.MM.Location = new System.Drawing.Point(186, 54);
            this.MM.Name = "MM";
            this.MM.Size = new System.Drawing.Size(38, 30);
            this.MM.TabIndex = 24;
            this.MM.Text = "M-";
            this.MM.UseVisualStyleBackColor = true;
            this.MM.Click += new System.EventHandler(this.memory_Click);
            // 
            // Square
            // 
            this.Square.Location = new System.Drawing.Point(12, 90);
            this.Square.Name = "Square";
            this.Square.Size = new System.Drawing.Size(38, 30);
            this.Square.TabIndex = 25;
            this.Square.Text = "x^2";
            this.Square.UseVisualStyleBackColor = true;
            this.Square.Click += new System.EventHandler(this.degree_Click);
            // 
            // Cube
            // 
            this.Cube.Location = new System.Drawing.Point(55, 90);
            this.Cube.Name = "Cube";
            this.Cube.Size = new System.Drawing.Size(38, 30);
            this.Cube.TabIndex = 26;
            this.Cube.Text = "x^3";
            this.Cube.UseVisualStyleBackColor = true;
            this.Cube.Click += new System.EventHandler(this.degree_Click);
            // 
            // Power
            // 
            this.Power.Location = new System.Drawing.Point(98, 90);
            this.Power.Name = "Power";
            this.Power.Size = new System.Drawing.Size(38, 30);
            this.Power.TabIndex = 27;
            this.Power.Text = "x^y";
            this.Power.UseVisualStyleBackColor = true;
            this.Power.Click += new System.EventHandler(this.operation_click);
            // 
            // Sqrt
            // 
            this.Sqrt.Location = new System.Drawing.Point(142, 90);
            this.Sqrt.Name = "Sqrt";
            this.Sqrt.Size = new System.Drawing.Size(38, 30);
            this.Sqrt.TabIndex = 28;
            this.Sqrt.Text = "Sqrt";
            this.Sqrt.UseVisualStyleBackColor = true;
            this.Sqrt.Click += new System.EventHandler(this.degree_Click);
            // 
            // Factorial
            // 
            this.Factorial.Location = new System.Drawing.Point(186, 90);
            this.Factorial.Name = "Factorial";
            this.Factorial.Size = new System.Drawing.Size(38, 30);
            this.Factorial.TabIndex = 29;
            this.Factorial.Text = "x!";
            this.Factorial.UseVisualStyleBackColor = true;
            this.Factorial.Click += new System.EventHandler(this.degree_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(186, 168);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(38, 30);
            this.Clear.TabIndex = 30;
            this.Clear.Text = "C";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(104, 242);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(30, 29);
            this.button25.TabIndex = 31;
            this.button25.Text = "CE";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.surprise_Click);
            // 
            // Memory
            // 
            this.Memory.AutoSize = true;
            this.Memory.Location = new System.Drawing.Point(12, 5);
            this.Memory.Name = "Memory";
            this.Memory.Size = new System.Drawing.Size(35, 13);
            this.Memory.TabIndex = 32;
            this.Memory.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 281);
            this.Controls.Add(this.Memory);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Factorial);
            this.Controls.Add(this.Sqrt);
            this.Controls.Add(this.Power);
            this.Controls.Add(this.Cube);
            this.Controls.Add(this.Square);
            this.Controls.Add(this.MM);
            this.Controls.Add(this.MP);
            this.Controls.Add(this.MC);
            this.Controls.Add(this.Backspace);
            this.Controls.Add(this.MR);
            this.Controls.Add(this.MS);
            this.Controls.Add(this.Dot);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.division);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.subtract);
            this.Controls.Add(this.add);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.display);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox display;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button subtract;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button Dot;
        private System.Windows.Forms.Button MS;
        private System.Windows.Forms.Button MR;
        private System.Windows.Forms.Button Backspace;
        private System.Windows.Forms.Button MC;
        private System.Windows.Forms.Button MP;
        private System.Windows.Forms.Button MM;
        private System.Windows.Forms.Button Square;
        private System.Windows.Forms.Button Cube;
        private System.Windows.Forms.Button Power;
        private System.Windows.Forms.Button Sqrt;
        private System.Windows.Forms.Button Factorial;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Label Memory;
    }
}

