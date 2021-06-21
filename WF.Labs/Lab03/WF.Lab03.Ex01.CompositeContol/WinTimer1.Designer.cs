namespace WF.Lab03.Ex01.CompositeContol
{
    partial class WinTimer1
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.userControlTimer1 = new WF.Lab03.Ex01.CompositeContolDLL.UserControlTimer();
            this.userControlTimer2 = new WF.Lab03.Ex01.CompositeContolDLL.UserControlTimer();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(13, 54);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(92, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Остановить?";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // userControlTimer1
            // 
            this.userControlTimer1.Location = new System.Drawing.Point(13, 13);
            this.userControlTimer1.Name = "userControlTimer1";
            this.userControlTimer1.Size = new System.Drawing.Size(104, 23);
            this.userControlTimer1.TabIndex = 2;
            this.userControlTimer1.TimeEnabled = true;
            // 
            // userControlTimer2
            // 
            this.userControlTimer2.Location = new System.Drawing.Point(134, 12);
            this.userControlTimer2.Name = "userControlTimer2";
            this.userControlTimer2.Size = new System.Drawing.Size(104, 23);
            this.userControlTimer2.TabIndex = 3;
            this.userControlTimer2.TimeEnabled = false;
            // 
            // WinTimer1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userControlTimer2);
            this.Controls.Add(this.userControlTimer1);
            this.Controls.Add(this.checkBox1);
            this.Name = "WinTimer1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBox1;
        private CompositeContolDLL.UserControlTimer userControlTimer1;
        private CompositeContolDLL.UserControlTimer userControlTimer2;
    }
}

