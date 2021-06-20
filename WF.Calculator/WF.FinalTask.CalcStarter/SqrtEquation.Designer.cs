namespace SimpleCalculator
{
    partial class SqrtEquation
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
            this.TextBoxA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ResultOut = new System.Windows.Forms.RichTextBox();
            this.ButtonEqualSqrt = new System.Windows.Forms.Button();
            this.ButtonCloseSqrt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBoxA
            // 
            this.TextBoxA.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxA.Location = new System.Drawing.Point(12, 18);
            this.TextBoxA.Name = "TextBoxA";
            this.TextBoxA.Size = new System.Drawing.Size(75, 24);
            this.TextBoxA.TabIndex = 0;
            this.TextBoxA.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(93, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "x^2 + ";
            // 
            // TextBoxB
            // 
            this.TextBoxB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxB.Location = new System.Drawing.Point(146, 18);
            this.TextBoxB.Name = "TextBoxB";
            this.TextBoxB.Size = new System.Drawing.Size(75, 24);
            this.TextBoxB.TabIndex = 2;
            this.TextBoxB.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(227, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "x + ";
            // 
            // TextBoxC
            // 
            this.TextBoxC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxC.Location = new System.Drawing.Point(265, 18);
            this.TextBoxC.Name = "TextBoxC";
            this.TextBoxC.Size = new System.Drawing.Size(75, 24);
            this.TextBoxC.TabIndex = 4;
            this.TextBoxC.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(346, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "= 0";
            // 
            // ResultOut
            // 
            this.ResultOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ResultOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultOut.Location = new System.Drawing.Point(12, 49);
            this.ResultOut.Name = "ResultOut";
            this.ResultOut.ReadOnly = true;
            this.ResultOut.Size = new System.Drawing.Size(247, 96);
            this.ResultOut.TabIndex = 6;
            this.ResultOut.Text = "";
            // 
            // ButtonEqualSqrt
            // 
            this.ButtonEqualSqrt.Location = new System.Drawing.Point(265, 49);
            this.ButtonEqualSqrt.Name = "ButtonEqualSqrt";
            this.ButtonEqualSqrt.Size = new System.Drawing.Size(110, 47);
            this.ButtonEqualSqrt.TabIndex = 7;
            this.ButtonEqualSqrt.Text = "Решить";
            this.ButtonEqualSqrt.UseVisualStyleBackColor = true;
            this.ButtonEqualSqrt.Click += new System.EventHandler(this.ButtonEqualSqrt_Click);
            // 
            // ButtonCloseSqrt
            // 
            this.ButtonCloseSqrt.Location = new System.Drawing.Point(265, 102);
            this.ButtonCloseSqrt.Name = "ButtonCloseSqrt";
            this.ButtonCloseSqrt.Size = new System.Drawing.Size(110, 37);
            this.ButtonCloseSqrt.TabIndex = 8;
            this.ButtonCloseSqrt.Text = "Закрыть";
            this.ButtonCloseSqrt.UseVisualStyleBackColor = true;
            this.ButtonCloseSqrt.Click += new System.EventHandler(this.ButtonCloseSqrt_Click);
            // 
            // SqrtEquation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(390, 151);
            this.Controls.Add(this.ButtonCloseSqrt);
            this.Controls.Add(this.ButtonEqualSqrt);
            this.Controls.Add(this.ResultOut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBoxC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBoxB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "SqrtEquation";
            this.Text = "SqrtEquation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox ResultOut;
        private System.Windows.Forms.Button ButtonEqualSqrt;
        private System.Windows.Forms.Button ButtonCloseSqrt;
    }
}