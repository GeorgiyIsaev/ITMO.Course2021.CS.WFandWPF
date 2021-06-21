namespace WF.Lab04.Ex05.ControlTask.FunctionCalculation
{
    partial class FormRange
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
            this.TextBox_Begin = new System.Windows.Forms.TextBox();
            this.TextBox_End = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Button_Start = new System.Windows.Forms.Button();
            this.Button_Censel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBox_Begin
            // 
            this.TextBox_Begin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox_Begin.Location = new System.Drawing.Point(27, 58);
            this.TextBox_Begin.Name = "TextBox_Begin";
            this.TextBox_Begin.Size = new System.Drawing.Size(131, 24);
            this.TextBox_Begin.TabIndex = 0;
            // 
            // TextBox_End
            // 
            this.TextBox_End.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox_End.Location = new System.Drawing.Point(164, 58);
            this.TextBox_End.Name = "TextBox_End";
            this.TextBox_End.Size = new System.Drawing.Size(131, 24);
            this.TextBox_End.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Границы интервала";
            // 
            // Button_Start
            // 
            this.Button_Start.Location = new System.Drawing.Point(27, 88);
            this.Button_Start.Name = "Button_Start";
            this.Button_Start.Size = new System.Drawing.Size(131, 23);
            this.Button_Start.TabIndex = 3;
            this.Button_Start.Text = "Передать данные";
            this.Button_Start.UseVisualStyleBackColor = true;
            // 
            // Button_Censel
            // 
            this.Button_Censel.Location = new System.Drawing.Point(164, 88);
            this.Button_Censel.Name = "Button_Censel";
            this.Button_Censel.Size = new System.Drawing.Size(131, 23);
            this.Button_Censel.TabIndex = 4;
            this.Button_Censel.Text = "Отменить передачу";
            this.Button_Censel.UseVisualStyleBackColor = true;
            // 
            // FormRange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 135);
            this.Controls.Add(this.Button_Censel);
            this.Controls.Add(this.Button_Start);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBox_End);
            this.Controls.Add(this.TextBox_Begin);
            this.Name = "FormRange";
            this.Text = "FormRange";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox_Begin;
        private System.Windows.Forms.TextBox TextBox_End;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button_Start;
        private System.Windows.Forms.Button Button_Censel;
    }
}