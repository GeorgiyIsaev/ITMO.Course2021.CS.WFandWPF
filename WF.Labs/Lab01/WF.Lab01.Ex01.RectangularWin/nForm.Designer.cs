namespace WF.Lab01.Ex01.RectangularWin
{
    partial class nForm
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
            this.CheckBox_Exit = new System.Windows.Forms.CheckBox();
            this.Button_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CheckBox_Exit
            // 
            this.CheckBox_Exit.AutoSize = true;
            this.CheckBox_Exit.Location = new System.Drawing.Point(13, 13);
            this.CheckBox_Exit.Name = "CheckBox_Exit";
            this.CheckBox_Exit.Size = new System.Drawing.Size(157, 17);
            this.CheckBox_Exit.TabIndex = 0;
            this.CheckBox_Exit.Text = "Действительно закрыть?";
            this.CheckBox_Exit.UseVisualStyleBackColor = true;
            // 
            // Button_Exit
            // 
            this.Button_Exit.Location = new System.Drawing.Point(193, 13);
            this.Button_Exit.Name = "Button_Exit";
            this.Button_Exit.Size = new System.Drawing.Size(137, 23);
            this.Button_Exit.TabIndex = 1;
            this.Button_Exit.Text = "Закрыть совсем!";
            this.Button_Exit.UseVisualStyleBackColor = true;
            this.Button_Exit.Click += new System.EventHandler(this.Button_Exit_Click);
            // 
            // nForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Button_Exit);
            this.Controls.Add(this.CheckBox_Exit);
            this.Name = "nForm";
            this.Text = "nForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.nForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CheckBox_Exit;
        private System.Windows.Forms.Button Button_Exit;
    }
}