namespace TextBoxClearTest
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.userControlTextClear1 = new TextBoxClear.UserControlTextClear();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(369, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 56);
            this.button1.TabIndex = 1;
            this.button1.Text = "but";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(42, 153);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(218, 20);
            this.textBox1.TabIndex = 3;
            // 
            // userControlTextClear1
            // 
            this.userControlTextClear1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.userControlTextClear1.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.userControlTextClear1.Location = new System.Drawing.Point(42, 12);
            this.userControlTextClear1.Name = "userControlTextClear1";
            this.userControlTextClear1.Size = new System.Drawing.Size(247, 112);
            this.userControlTextClear1.TabIndex = 2;
            this.userControlTextClear1.TextB = 0;
            this.userControlTextClear1.TextM = "";
            this.userControlTextClear1.ButText += new TextBoxClear.UserControlTextClear.MyEvent(this.userControlTextClear1_ButText);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 217);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.userControlTextClear1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private TextBoxClear.UserControlTextClear userControlTextClear1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

