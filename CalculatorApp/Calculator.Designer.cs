namespace CalculatorApp
{
    partial class Calculator
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Clear = new System.Windows.Forms.Button();
            this.OpenBracket = new System.Windows.Forms.Button();
            this.CloseBracket = new System.Windows.Forms.Button();
            this.Seven = new System.Windows.Forms.Button();
            this.Eight = new System.Windows.Forms.Button();
            this.Nine = new System.Windows.Forms.Button();
            this.Four = new System.Windows.Forms.Button();
            this.Five = new System.Windows.Forms.Button();
            this.Six = new System.Windows.Forms.Button();
            this.Expression = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.Subtract = new System.Windows.Forms.Button();
            this.Multiply = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.Three = new System.Windows.Forms.Button();
            this.Two = new System.Windows.Forms.Button();
            this.One = new System.Windows.Forms.Button();
            this.Equal = new System.Windows.Forms.Button();
            this.Decimal = new System.Windows.Forms.Button();
            this.Zero = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Clear.Location = new System.Drawing.Point(12, 141);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(88, 68);
            this.Clear.TabIndex = 0;
            this.Clear.Text = "AC";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // OpenBracket
            // 
            this.OpenBracket.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.OpenBracket.Location = new System.Drawing.Point(106, 141);
            this.OpenBracket.Name = "OpenBracket";
            this.OpenBracket.Size = new System.Drawing.Size(88, 68);
            this.OpenBracket.TabIndex = 1;
            this.OpenBracket.Text = "(";
            this.OpenBracket.UseVisualStyleBackColor = true;
            this.OpenBracket.Click += new System.EventHandler(this.OpenBracket_Click);
            // 
            // CloseBracket
            // 
            this.CloseBracket.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.CloseBracket.Location = new System.Drawing.Point(200, 141);
            this.CloseBracket.Name = "CloseBracket";
            this.CloseBracket.Size = new System.Drawing.Size(88, 68);
            this.CloseBracket.TabIndex = 2;
            this.CloseBracket.Text = ")";
            this.CloseBracket.UseVisualStyleBackColor = true;
            this.CloseBracket.Click += new System.EventHandler(this.CloseBracket_Click);
            // 
            // Seven
            // 
            this.Seven.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Seven.Location = new System.Drawing.Point(12, 215);
            this.Seven.Name = "Seven";
            this.Seven.Size = new System.Drawing.Size(88, 68);
            this.Seven.TabIndex = 3;
            this.Seven.Text = "7";
            this.Seven.UseVisualStyleBackColor = true;
            this.Seven.Click += new System.EventHandler(this.Seven_Click);
            // 
            // Eight
            // 
            this.Eight.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Eight.Location = new System.Drawing.Point(106, 215);
            this.Eight.Name = "Eight";
            this.Eight.Size = new System.Drawing.Size(88, 68);
            this.Eight.TabIndex = 4;
            this.Eight.Text = "8";
            this.Eight.UseVisualStyleBackColor = true;
            this.Eight.Click += new System.EventHandler(this.Eight_Click);
            // 
            // Nine
            // 
            this.Nine.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Nine.Location = new System.Drawing.Point(200, 215);
            this.Nine.Name = "Nine";
            this.Nine.Size = new System.Drawing.Size(88, 68);
            this.Nine.TabIndex = 5;
            this.Nine.Text = "9";
            this.Nine.UseVisualStyleBackColor = true;
            this.Nine.Click += new System.EventHandler(this.Nine_Click);
            // 
            // Four
            // 
            this.Four.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Four.Location = new System.Drawing.Point(12, 289);
            this.Four.Name = "Four";
            this.Four.Size = new System.Drawing.Size(88, 68);
            this.Four.TabIndex = 6;
            this.Four.Text = "4";
            this.Four.UseVisualStyleBackColor = true;
            this.Four.Click += new System.EventHandler(this.Four_Click);
            // 
            // Five
            // 
            this.Five.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Five.Location = new System.Drawing.Point(106, 289);
            this.Five.Name = "Five";
            this.Five.Size = new System.Drawing.Size(88, 68);
            this.Five.TabIndex = 7;
            this.Five.Text = "5";
            this.Five.UseVisualStyleBackColor = true;
            this.Five.Click += new System.EventHandler(this.Five_Click);
            // 
            // Six
            // 
            this.Six.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Six.Location = new System.Drawing.Point(200, 289);
            this.Six.Name = "Six";
            this.Six.Size = new System.Drawing.Size(88, 68);
            this.Six.TabIndex = 8;
            this.Six.Text = "6";
            this.Six.UseVisualStyleBackColor = true;
            this.Six.Click += new System.EventHandler(this.Six_Click);
            // 
            // Expression
            // 
            this.Expression.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Expression.Location = new System.Drawing.Point(12, 9);
            this.Expression.Name = "Expression";
            this.Expression.Size = new System.Drawing.Size(370, 115);
            this.Expression.TabIndex = 9;
            this.Expression.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Expression.Click += new System.EventHandler(this.Expression_Click);
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Add.Location = new System.Drawing.Point(294, 141);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(88, 68);
            this.Add.TabIndex = 10;
            this.Add.Text = "+";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Subtract
            // 
            this.Subtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Subtract.Location = new System.Drawing.Point(294, 215);
            this.Subtract.Name = "Subtract";
            this.Subtract.Size = new System.Drawing.Size(88, 68);
            this.Subtract.TabIndex = 11;
            this.Subtract.Text = "-";
            this.Subtract.UseVisualStyleBackColor = true;
            this.Subtract.Click += new System.EventHandler(this.Subtract_Click);
            // 
            // Multiply
            // 
            this.Multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Multiply.Location = new System.Drawing.Point(294, 289);
            this.Multiply.Name = "Multiply";
            this.Multiply.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Multiply.Size = new System.Drawing.Size(88, 68);
            this.Multiply.TabIndex = 12;
            this.Multiply.Text = "x";
            this.Multiply.UseVisualStyleBackColor = true;
            this.Multiply.Click += new System.EventHandler(this.Multiply_Click);
            // 
            // Divide
            // 
            this.Divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Divide.Location = new System.Drawing.Point(294, 363);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(88, 68);
            this.Divide.TabIndex = 13;
            this.Divide.Text = "÷";
            this.Divide.UseVisualStyleBackColor = true;
            this.Divide.Click += new System.EventHandler(this.Divide_Click);
            // 
            // Three
            // 
            this.Three.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Three.Location = new System.Drawing.Point(200, 363);
            this.Three.Name = "Three";
            this.Three.Size = new System.Drawing.Size(88, 68);
            this.Three.TabIndex = 14;
            this.Three.Text = "3";
            this.Three.UseVisualStyleBackColor = true;
            this.Three.Click += new System.EventHandler(this.Three_Click);
            // 
            // Two
            // 
            this.Two.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Two.Location = new System.Drawing.Point(106, 363);
            this.Two.Name = "Two";
            this.Two.Size = new System.Drawing.Size(88, 68);
            this.Two.TabIndex = 15;
            this.Two.Text = "2";
            this.Two.UseVisualStyleBackColor = true;
            this.Two.Click += new System.EventHandler(this.Two_Click);
            // 
            // One
            // 
            this.One.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.One.Location = new System.Drawing.Point(12, 363);
            this.One.Name = "One";
            this.One.Size = new System.Drawing.Size(88, 68);
            this.One.TabIndex = 16;
            this.One.Text = "1";
            this.One.UseVisualStyleBackColor = true;
            this.One.Click += new System.EventHandler(this.One_Click);
            // 
            // Equal
            // 
            this.Equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Equal.Location = new System.Drawing.Point(200, 437);
            this.Equal.Name = "Equal";
            this.Equal.Size = new System.Drawing.Size(182, 68);
            this.Equal.TabIndex = 17;
            this.Equal.Text = "=";
            this.Equal.UseVisualStyleBackColor = true;
            this.Equal.Click += new System.EventHandler(this.Equal_Click);
            // 
            // Decimal
            // 
            this.Decimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Decimal.Location = new System.Drawing.Point(106, 437);
            this.Decimal.Name = "Decimal";
            this.Decimal.Size = new System.Drawing.Size(88, 68);
            this.Decimal.TabIndex = 18;
            this.Decimal.Text = ".";
            this.Decimal.UseVisualStyleBackColor = true;
            this.Decimal.Click += new System.EventHandler(this.Decimal_Click);
            // 
            // Zero
            // 
            this.Zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Zero.Location = new System.Drawing.Point(12, 437);
            this.Zero.Name = "Zero";
            this.Zero.Size = new System.Drawing.Size(88, 68);
            this.Zero.TabIndex = 19;
            this.Zero.Text = "0";
            this.Zero.UseVisualStyleBackColor = true;
            this.Zero.Click += new System.EventHandler(this.Zero_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 521);
            this.Controls.Add(this.Zero);
            this.Controls.Add(this.Decimal);
            this.Controls.Add(this.Equal);
            this.Controls.Add(this.One);
            this.Controls.Add(this.Two);
            this.Controls.Add(this.Three);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.Multiply);
            this.Controls.Add(this.Subtract);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Expression);
            this.Controls.Add(this.Six);
            this.Controls.Add(this.Five);
            this.Controls.Add(this.Four);
            this.Controls.Add(this.Nine);
            this.Controls.Add(this.Eight);
            this.Controls.Add(this.Seven);
            this.Controls.Add(this.CloseBracket);
            this.Controls.Add(this.OpenBracket);
            this.Controls.Add(this.Clear);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button Zero;

        private System.Windows.Forms.Button Decimal;

        private System.Windows.Forms.Button Eight;
        private System.Windows.Forms.Label Expression;
        private System.Windows.Forms.Button Five;
        private System.Windows.Forms.Button Four;
        private System.Windows.Forms.Button Nine;
        private System.Windows.Forms.Button One;
        private System.Windows.Forms.Button Seven;
        private System.Windows.Forms.Button Six;
        private System.Windows.Forms.Button Three;
        private System.Windows.Forms.Button Two;

        private System.Windows.Forms.Button Divide;

        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button CloseBracket;
        private System.Windows.Forms.Button Equal;
        private System.Windows.Forms.Button Multiply;
        private System.Windows.Forms.Button OpenBracket;
        private System.Windows.Forms.Button Subtract;

        private System.Windows.Forms.Button Clear;

        #endregion
    }
}