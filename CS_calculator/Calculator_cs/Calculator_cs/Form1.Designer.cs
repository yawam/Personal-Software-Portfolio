namespace Calculator_cs
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnPlusMinus = new System.Windows.Forms.Button();
            this.btnPoint = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnBckspace = new System.Windows.Forms.Button();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnDivision);
            this.panel1.Controls.Add(this.btnMultiply);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnSubtract);
            this.panel1.Controls.Add(this.btnPlusMinus);
            this.panel1.Controls.Add(this.btnPoint);
            this.panel1.Controls.Add(this.btn2);
            this.panel1.Controls.Add(this.btn8);
            this.panel1.Controls.Add(this.btn5);
            this.panel1.Controls.Add(this.btnCE);
            this.panel1.Controls.Add(this.btnEquals);
            this.panel1.Controls.Add(this.btn3);
            this.panel1.Controls.Add(this.btn9);
            this.panel1.Controls.Add(this.btn6);
            this.panel1.Controls.Add(this.btnC);
            this.panel1.Controls.Add(this.btn0);
            this.panel1.Controls.Add(this.btn1);
            this.panel1.Controls.Add(this.btn4);
            this.panel1.Controls.Add(this.btnSeven);
            this.panel1.Controls.Add(this.btnBckspace);
            this.panel1.Controls.Add(this.txtDisplay);
            this.panel1.Location = new System.Drawing.Point(7, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 497);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnDivision
            // 
            this.btnDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivision.Location = new System.Drawing.Point(254, 414);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(77, 76);
            this.btnDivision.TabIndex = 1;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.btnDivide_click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiply.Location = new System.Drawing.Point(254, 334);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(77, 76);
            this.btnMultiply.TabIndex = 1;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(254, 170);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(77, 76);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtract.Location = new System.Drawing.Point(254, 252);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(77, 76);
            this.btnSubtract.TabIndex = 1;
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_click);
            // 
            // btnPlusMinus
            // 
            this.btnPlusMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlusMinus.Location = new System.Drawing.Point(254, 88);
            this.btnPlusMinus.Name = "btnPlusMinus";
            this.btnPlusMinus.Size = new System.Drawing.Size(77, 76);
            this.btnPlusMinus.TabIndex = 1;
            this.btnPlusMinus.Text = "±";
            this.btnPlusMinus.UseVisualStyleBackColor = true;
            this.btnPlusMinus.Click += new System.EventHandler(this.btnPlusMinus_click);
            // 
            // btnPoint
            // 
            this.btnPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoint.Location = new System.Drawing.Point(88, 414);
            this.btnPoint.Name = "btnPoint";
            this.btnPoint.Size = new System.Drawing.Size(77, 76);
            this.btnPoint.TabIndex = 1;
            this.btnPoint.Text = ".";
            this.btnPoint.UseVisualStyleBackColor = true;
            this.btnPoint.Click += new System.EventHandler(this.btnDecimal_click);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(88, 334);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(77, 76);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_click);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(88, 170);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(77, 76);
            this.btn8.TabIndex = 1;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8Click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(88, 252);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(77, 76);
            this.btn5.TabIndex = 1;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_click);
            // 
            // btnCE
            // 
            this.btnCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCE.Location = new System.Drawing.Point(88, 88);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(77, 76);
            this.btnCE.TabIndex = 1;
            this.btnCE.Text = "CE";
            this.btnCE.UseVisualStyleBackColor = true;
            this.btnCE.Click += new System.EventHandler(this.btnCE_click);
            // 
            // btnEquals
            // 
            this.btnEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquals.Location = new System.Drawing.Point(171, 414);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(77, 76);
            this.btnEquals.TabIndex = 1;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = true;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(171, 334);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(77, 76);
            this.btn3.TabIndex = 1;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_click);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(171, 170);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(77, 76);
            this.btn9.TabIndex = 1;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_click);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(171, 252);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(77, 76);
            this.btn6.TabIndex = 1;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_click);
            // 
            // btnC
            // 
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.Location = new System.Drawing.Point(171, 88);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(77, 76);
            this.btnC.TabIndex = 1;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_click);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(5, 414);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(77, 76);
            this.btn0.TabIndex = 1;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_click);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(5, 334);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(77, 76);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(5, 252);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(77, 76);
            this.btn4.TabIndex = 1;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_click);
            // 
            // btnSeven
            // 
            this.btnSeven.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeven.Location = new System.Drawing.Point(5, 170);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(77, 76);
            this.btnSeven.TabIndex = 1;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = true;
            this.btnSeven.Click += new System.EventHandler(this.btn7_click);
            // 
            // btnBckspace
            // 
            this.btnBckspace.Font = new System.Drawing.Font("Wingdings", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnBckspace.Location = new System.Drawing.Point(5, 88);
            this.btnBckspace.Name = "btnBckspace";
            this.btnBckspace.Size = new System.Drawing.Size(77, 76);
            this.btnBckspace.TabIndex = 1;
            this.btnBckspace.Text = "";
            this.btnBckspace.UseVisualStyleBackColor = true;
            this.btnBckspace.Click += new System.EventHandler(this.btnBckspace_click);
            // 
            // txtDisplay
            // 
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.Location = new System.Drawing.Point(5, 12);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(326, 70);
            this.txtDisplay.TabIndex = 0;
            this.txtDisplay.Text = "0";
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDisplay.TextChanged += new System.EventHandler(this.txtDisplay_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 505);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBckspace;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnPlusMinus;
        private System.Windows.Forms.Button btnPoint;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btnSeven;
    }
}

