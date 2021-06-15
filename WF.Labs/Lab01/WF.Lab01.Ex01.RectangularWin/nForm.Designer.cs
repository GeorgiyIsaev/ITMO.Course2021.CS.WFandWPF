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
            // nForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CheckBox_Exit);
            this.Name = "nForm";
            this.Text = "nForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.nForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox CheckBox_Exit;
    }
}