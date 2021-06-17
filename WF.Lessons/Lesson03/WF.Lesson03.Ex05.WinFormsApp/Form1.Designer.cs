namespace WinFormsApp
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.beepButtonExclamation1 = new ButtonLibrary.BeepButtonExclamation();
            this.beepButtonExclamation2 = new ButtonLibrary.BeepButtonExclamation();
            this.SuspendLayout();
            // 
            // beepButtonExclamation1
            // 
            this.beepButtonExclamation1.Location = new System.Drawing.Point(61, 109);
            this.beepButtonExclamation1.Name = "beepButtonExclamation1";
            this.beepButtonExclamation1.Size = new System.Drawing.Size(159, 32);
            this.beepButtonExclamation1.TabIndex = 0;
            this.beepButtonExclamation1.Text = "beepButtonExclamation1";
            this.beepButtonExclamation1.UseVisualStyleBackColor = true;
            this.beepButtonExclamation1.Click += new System.EventHandler(this.beepButtonExclamation1_Click);
            // 
            // beepButtonExclamation2
            // 
            this.beepButtonExclamation2.Location = new System.Drawing.Point(61, 189);
            this.beepButtonExclamation2.Name = "beepButtonExclamation2";
            this.beepButtonExclamation2.Size = new System.Drawing.Size(159, 23);
            this.beepButtonExclamation2.TabIndex = 1;
            this.beepButtonExclamation2.Text = "beepButtonExclamation2";
            this.beepButtonExclamation2.UseVisualStyleBackColor = true;
            this.beepButtonExclamation2.Click += new System.EventHandler(this.beepButtonExclamation2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.beepButtonExclamation2);
            this.Controls.Add(this.beepButtonExclamation1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ButtonLibrary.BeepButtonExclamation beepButtonExclamation1;
        private ButtonLibrary.BeepButtonExclamation beepButtonExclamation2;
    }
}

