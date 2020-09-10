namespace CSC260_Calculator
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
            this.bSqrt = new System.Windows.Forms.Button();
            this.bSquare = new System.Windows.Forms.Button();
            this.bExponent = new System.Windows.Forms.Button();
            this.bInverse = new System.Windows.Forms.Button();
            this.bCearEntry = new System.Windows.Forms.Button();
            this.bClearAll = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.bDivide = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.bMultiply = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.bSubtract = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.bFlip = new System.Windows.Forms.Button();
            this.b0 = new System.Windows.Forms.Button();
            this.bDecimal = new System.Windows.Forms.Button();
            this.bEquals = new System.Windows.Forms.Button();
            this.bDisplayBox = new System.Windows.Forms.TextBox();
            this.bHistoryBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.entryHistory = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bSqrt
            // 
            this.bSqrt.Location = new System.Drawing.Point(14, 99);
            this.bSqrt.Name = "bSqrt";
            this.bSqrt.Size = new System.Drawing.Size(64, 32);
            this.bSqrt.TabIndex = 0;
            this.bSqrt.Text = "Sqrt";
            this.bSqrt.UseVisualStyleBackColor = true;
            this.bSqrt.Click += new System.EventHandler(this.BSqrt_click);
            // 
            // bSquare
            // 
            this.bSquare.Location = new System.Drawing.Point(84, 99);
            this.bSquare.Name = "bSquare";
            this.bSquare.Size = new System.Drawing.Size(64, 32);
            this.bSquare.TabIndex = 1;
            this.bSquare.Text = "x^2";
            this.bSquare.UseVisualStyleBackColor = true;
            this.bSquare.Click += new System.EventHandler(this.BSquare_click);
            // 
            // bExponent
            // 
            this.bExponent.Location = new System.Drawing.Point(154, 99);
            this.bExponent.Name = "bExponent";
            this.bExponent.Size = new System.Drawing.Size(64, 32);
            this.bExponent.TabIndex = 2;
            this.bExponent.Text = "x^y";
            this.bExponent.UseVisualStyleBackColor = true;
            this.bExponent.Click += new System.EventHandler(this.BExponent_click);
            // 
            // bInverse
            // 
            this.bInverse.Location = new System.Drawing.Point(224, 99);
            this.bInverse.Name = "bInverse";
            this.bInverse.Size = new System.Drawing.Size(64, 32);
            this.bInverse.TabIndex = 3;
            this.bInverse.Text = "1/x";
            this.bInverse.UseVisualStyleBackColor = true;
            this.bInverse.Click += new System.EventHandler(this.BInverse_click);
            // 
            // bCearEntry
            // 
            this.bCearEntry.Location = new System.Drawing.Point(14, 137);
            this.bCearEntry.Name = "bCearEntry";
            this.bCearEntry.Size = new System.Drawing.Size(64, 32);
            this.bCearEntry.TabIndex = 4;
            this.bCearEntry.Text = "CE";
            this.bCearEntry.UseVisualStyleBackColor = true;
            this.bCearEntry.Click += new System.EventHandler(this.BClearEntry_click);
            // 
            // bClearAll
            // 
            this.bClearAll.Location = new System.Drawing.Point(84, 137);
            this.bClearAll.Name = "bClearAll";
            this.bClearAll.Size = new System.Drawing.Size(64, 32);
            this.bClearAll.TabIndex = 5;
            this.bClearAll.Text = "C";
            this.bClearAll.UseVisualStyleBackColor = true;
            this.bClearAll.Click += new System.EventHandler(this.BClear_click);
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(154, 137);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(64, 32);
            this.bDelete.TabIndex = 6;
            this.bDelete.Text = "Del.";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.BDelete_click);
            // 
            // bDivide
            // 
            this.bDivide.Location = new System.Drawing.Point(224, 137);
            this.bDivide.Name = "bDivide";
            this.bDivide.Size = new System.Drawing.Size(64, 32);
            this.bDivide.TabIndex = 7;
            this.bDivide.Text = "/";
            this.bDivide.UseVisualStyleBackColor = true;
            this.bDivide.Click += new System.EventHandler(this.BDivide_click);
            // 
            // b7
            // 
            this.b7.Location = new System.Drawing.Point(14, 175);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(64, 32);
            this.b7.TabIndex = 8;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.B7_click);
            // 
            // b8
            // 
            this.b8.Location = new System.Drawing.Point(84, 175);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(64, 32);
            this.b8.TabIndex = 9;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.B8_click);
            // 
            // b9
            // 
            this.b9.Location = new System.Drawing.Point(154, 175);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(64, 32);
            this.b9.TabIndex = 10;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.B9_click);
            // 
            // bMultiply
            // 
            this.bMultiply.Location = new System.Drawing.Point(224, 175);
            this.bMultiply.Name = "bMultiply";
            this.bMultiply.Size = new System.Drawing.Size(64, 32);
            this.bMultiply.TabIndex = 11;
            this.bMultiply.Text = "X";
            this.bMultiply.UseVisualStyleBackColor = true;
            this.bMultiply.Click += new System.EventHandler(this.BMultiply_click);
            // 
            // b4
            // 
            this.b4.Location = new System.Drawing.Point(14, 213);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(64, 32);
            this.b4.TabIndex = 12;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.B4_click);
            // 
            // b5
            // 
            this.b5.Location = new System.Drawing.Point(84, 213);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(64, 32);
            this.b5.TabIndex = 13;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.B5_click);
            // 
            // b6
            // 
            this.b6.Location = new System.Drawing.Point(154, 213);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(64, 32);
            this.b6.TabIndex = 14;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.B6_click);
            // 
            // bSubtract
            // 
            this.bSubtract.Location = new System.Drawing.Point(224, 213);
            this.bSubtract.Name = "bSubtract";
            this.bSubtract.Size = new System.Drawing.Size(64, 32);
            this.bSubtract.TabIndex = 15;
            this.bSubtract.Text = "-";
            this.bSubtract.UseVisualStyleBackColor = true;
            this.bSubtract.Click += new System.EventHandler(this.BSubtract_click);
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(14, 251);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(64, 32);
            this.b1.TabIndex = 16;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.B1_click);
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(84, 251);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(64, 32);
            this.b2.TabIndex = 17;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.B2_click);
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(154, 251);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(64, 32);
            this.b3.TabIndex = 18;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.B3_click);
            // 
            // bAdd
            // 
            this.bAdd.Location = new System.Drawing.Point(224, 251);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(64, 32);
            this.bAdd.TabIndex = 19;
            this.bAdd.Text = "+";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.BAdd_click);
            // 
            // bFlip
            // 
            this.bFlip.Location = new System.Drawing.Point(14, 289);
            this.bFlip.Name = "bFlip";
            this.bFlip.Size = new System.Drawing.Size(64, 32);
            this.bFlip.TabIndex = 20;
            this.bFlip.Text = "+/-";
            this.bFlip.UseVisualStyleBackColor = true;
            this.bFlip.Click += new System.EventHandler(this.BFlip_click);
            // 
            // b0
            // 
            this.b0.Location = new System.Drawing.Point(84, 289);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(64, 32);
            this.b0.TabIndex = 21;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = true;
            this.b0.Click += new System.EventHandler(this.B0_click);
            // 
            // bDecimal
            // 
            this.bDecimal.Location = new System.Drawing.Point(154, 289);
            this.bDecimal.Name = "bDecimal";
            this.bDecimal.Size = new System.Drawing.Size(64, 32);
            this.bDecimal.TabIndex = 22;
            this.bDecimal.Text = ".";
            this.bDecimal.UseVisualStyleBackColor = true;
            this.bDecimal.Click += new System.EventHandler(this.BDecimal_click);
            // 
            // bEquals
            // 
            this.bEquals.Location = new System.Drawing.Point(224, 289);
            this.bEquals.Name = "bEquals";
            this.bEquals.Size = new System.Drawing.Size(64, 32);
            this.bEquals.TabIndex = 23;
            this.bEquals.Text = "=";
            this.bEquals.UseVisualStyleBackColor = true;
            this.bEquals.Click += new System.EventHandler(this.BEquals_click);
            // 
            // bDisplayBox
            // 
            this.bDisplayBox.AcceptsReturn = true;
            this.bDisplayBox.Location = new System.Drawing.Point(14, 71);
            this.bDisplayBox.Name = "bDisplayBox";
            this.bDisplayBox.Size = new System.Drawing.Size(274, 22);
            this.bDisplayBox.TabIndex = 24;
            this.bDisplayBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

            // 
            // bHistoryBox
            // 
            this.bHistoryBox.Location = new System.Drawing.Point(14, 12);
            this.bHistoryBox.Multiline = true;
            this.bHistoryBox.Name = "bHistoryBox";
            this.bHistoryBox.Size = new System.Drawing.Size(274, 53);
            this.bHistoryBox.TabIndex = 25;
           
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Font = new System.Drawing.Font("Constantia", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(294, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 53);
            this.label1.TabIndex = 27;
            this.label1.Text = "History";
            
            // 
            // entryHistory
            // 
            this.entryHistory.Location = new System.Drawing.Point(294, 71);
            this.entryHistory.Multiline = true;
            this.entryHistory.Name = "entryHistory";
            this.entryHistory.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.entryHistory.Size = new System.Drawing.Size(308, 250);
            this.entryHistory.TabIndex = 28;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(614, 340);
            this.Controls.Add(this.entryHistory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bHistoryBox);
            this.Controls.Add(this.bDisplayBox);
            this.Controls.Add(this.bEquals);
            this.Controls.Add(this.bDecimal);
            this.Controls.Add(this.b0);
            this.Controls.Add(this.bFlip);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.bSubtract);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.bMultiply);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.bDivide);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.bClearAll);
            this.Controls.Add(this.bCearEntry);
            this.Controls.Add(this.bInverse);
            this.Controls.Add(this.bExponent);
            this.Controls.Add(this.bSquare);
            this.Controls.Add(this.bSqrt);
            this.KeyPreview = true;
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bSqrt;
        private System.Windows.Forms.Button bSquare;
        private System.Windows.Forms.Button bExponent;
        private System.Windows.Forms.Button bInverse;
        private System.Windows.Forms.Button bCearEntry;
        private System.Windows.Forms.Button bClearAll;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bDivide;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button bMultiply;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button bSubtract;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bFlip;
        private System.Windows.Forms.Button b0;
        private System.Windows.Forms.Button bDecimal;
        private System.Windows.Forms.Button bEquals;
        private System.Windows.Forms.TextBox bDisplayBox;
        private System.Windows.Forms.TextBox bHistoryBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox entryHistory;
    }
}

