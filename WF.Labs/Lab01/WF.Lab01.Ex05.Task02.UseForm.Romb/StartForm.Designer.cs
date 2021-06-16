namespace WF.Lab01.Ex05.Task02.UseForm
{
    partial class StartForm
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
            this.Button_BaseForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button_BaseForm
            // 
            this.Button_BaseForm.Location = new System.Drawing.Point(45, 33);
            this.Button_BaseForm.Name = "Button_BaseForm";
            this.Button_BaseForm.Size = new System.Drawing.Size(179, 23);
            this.Button_BaseForm.TabIndex = 0;
            this.Button_BaseForm.Text = "Первое окно";
            this.Button_BaseForm.UseVisualStyleBackColor = true;
            this.Button_BaseForm.Click += new System.EventHandler(this.Button_BaseForm_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Button_BaseForm);
            this.Name = "StartForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.StartForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button_BaseForm;
    }
}