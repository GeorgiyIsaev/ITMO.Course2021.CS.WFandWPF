namespace WF.Lab03.Ex03.ExtendedControl
{
    partial class WinButNum
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.clickButton1 = new WF.Lab03.Ex03.ExtendedControl.ClickButton();
            this.SuspendLayout();
            // 
            // clickButton1
            // 
            this.clickButton1.Location = new System.Drawing.Point(28, 24);
            this.clickButton1.Name = "clickButton1";
            this.clickButton1.Size = new System.Drawing.Size(145, 23);
            this.clickButton1.TabIndex = 0;
            this.clickButton1.Text = "clickButton1";
            this.clickButton1.UseVisualStyleBackColor = true;
            // 
            // WinButNum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clickButton1);
            this.Name = "WinButNum";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ClickButton clickButton1;
    }
}

