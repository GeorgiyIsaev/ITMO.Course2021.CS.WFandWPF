namespace WinFormsMVP_
{
    partial class ClientsForm
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
            this.clientsListBox = new System.Windows.Forms.ListBox();
            this.clientNameTextBox = new System.Windows.Forms.TextBox();
            this.clientEmailTextBox = new System.Windows.Forms.TextBox();
            this.clientGenderTextBox = new System.Windows.Forms.TextBox();
            this.clientAgeTextBox = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clientsListBox
            // 
            this.clientsListBox.FormattingEnabled = true;
            this.clientsListBox.Location = new System.Drawing.Point(341, 12);
            this.clientsListBox.Name = "clientsListBox";
            this.clientsListBox.Size = new System.Drawing.Size(211, 225);
            this.clientsListBox.TabIndex = 0;
            // 
            // clientNameTextBox
            // 
            this.clientNameTextBox.Location = new System.Drawing.Point(219, 12);
            this.clientNameTextBox.Name = "clientNameTextBox";
            this.clientNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.clientNameTextBox.TabIndex = 1;
            // 
            // clientEmailTextBox
            // 
            this.clientEmailTextBox.Location = new System.Drawing.Point(219, 58);
            this.clientEmailTextBox.Name = "clientEmailTextBox";
            this.clientEmailTextBox.Size = new System.Drawing.Size(100, 20);
            this.clientEmailTextBox.TabIndex = 2;
            // 
            // clientGenderTextBox
            // 
            this.clientGenderTextBox.Location = new System.Drawing.Point(219, 104);
            this.clientGenderTextBox.Name = "clientGenderTextBox";
            this.clientGenderTextBox.Size = new System.Drawing.Size(100, 20);
            this.clientGenderTextBox.TabIndex = 3;
            // 
            // clientAgeTextBox
            // 
            this.clientAgeTextBox.Location = new System.Drawing.Point(219, 147);
            this.clientAgeTextBox.Name = "clientAgeTextBox";
            this.clientAgeTextBox.Size = new System.Drawing.Size(100, 20);
            this.clientAgeTextBox.TabIndex = 4;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(219, 213);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(100, 23);
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "close";
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // ClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 262);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.clientAgeTextBox);
            this.Controls.Add(this.clientGenderTextBox);
            this.Controls.Add(this.clientEmailTextBox);
            this.Controls.Add(this.clientNameTextBox);
            this.Controls.Add(this.clientsListBox);
            this.Name = "ClientsForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox clientsListBox;
        private System.Windows.Forms.TextBox clientNameTextBox;
        private System.Windows.Forms.TextBox clientEmailTextBox;
        private System.Windows.Forms.TextBox clientGenderTextBox;
        private System.Windows.Forms.TextBox clientAgeTextBox;
        private System.Windows.Forms.Button closeButton;
    }
}

