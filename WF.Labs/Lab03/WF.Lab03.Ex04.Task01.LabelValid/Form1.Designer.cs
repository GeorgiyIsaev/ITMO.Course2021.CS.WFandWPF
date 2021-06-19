namespace WF.Lab03.Ex04.Task01.LabelValid
{
    partial class Form1
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
            this.TBValidForm = new WF.Lab03.Ex04.Task01.LabelValid.TextBoxValid();
            this.ListBox_NameAndAge = new System.Windows.Forms.ListBox();
            this.Button_Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TBValidForm
            // 
            this.TBValidForm.Location = new System.Drawing.Point(13, 13);
            this.TBValidForm.Name = "TBValidForm";
            this.TBValidForm.Size = new System.Drawing.Size(189, 88);
            this.TBValidForm.TabIndex = 0;
            this.TBValidForm.TextA = "";
            this.TBValidForm.TextB = "";
            // 
            // ListBox_NameAndAge
            // 
            this.ListBox_NameAndAge.FormattingEnabled = true;
            this.ListBox_NameAndAge.Location = new System.Drawing.Point(217, 19);
            this.ListBox_NameAndAge.Name = "ListBox_NameAndAge";
            this.ListBox_NameAndAge.Size = new System.Drawing.Size(172, 108);
            this.ListBox_NameAndAge.TabIndex = 1;
            // 
            // Button_Add
            // 
            this.Button_Add.Location = new System.Drawing.Point(13, 107);
            this.Button_Add.Name = "Button_Add";
            this.Button_Add.Size = new System.Drawing.Size(189, 23);
            this.Button_Add.TabIndex = 2;
            this.Button_Add.Text = "Добавить";
            this.Button_Add.UseVisualStyleBackColor = true;
            this.Button_Add.Click += new System.EventHandler(this.Button_Add_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 146);
            this.Controls.Add(this.Button_Add);
            this.Controls.Add(this.ListBox_NameAndAge);
            this.Controls.Add(this.TBValidForm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private TextBoxValid TBValidForm;
        private System.Windows.Forms.ListBox ListBox_NameAndAge;
        private System.Windows.Forms.Button Button_Add;
    }
}

