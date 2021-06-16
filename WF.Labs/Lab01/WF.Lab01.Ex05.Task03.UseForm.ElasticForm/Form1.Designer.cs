namespace WF.Lab01.Ex05.Task03.UseForm.ElasticForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.TextBox_Item = new System.Windows.Forms.TextBox();
            this.Button_AddItem = new System.Windows.Forms.Button();
            this.ListBox_Collection = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(9, 7, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите данные:";
            // 
            // TextBox_Item
            // 
            this.TextBox_Item.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_Item.Location = new System.Drawing.Point(133, 13);
            this.TextBox_Item.Name = "TextBox_Item";
            this.TextBox_Item.Size = new System.Drawing.Size(136, 20);
            this.TextBox_Item.TabIndex = 1;
            // 
            // Button_AddItem
            // 
            this.Button_AddItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_AddItem.Location = new System.Drawing.Point(175, 39);
            this.Button_AddItem.Name = "Button_AddItem";
            this.Button_AddItem.Size = new System.Drawing.Size(94, 23);
            this.Button_AddItem.TabIndex = 2;
            this.Button_AddItem.Text = "Добавить";
            this.Button_AddItem.UseVisualStyleBackColor = true;
            this.Button_AddItem.Click += new System.EventHandler(this.Button_AddItem_Click);
            // 
            // ListBox_Collection
            // 
            this.ListBox_Collection.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListBox_Collection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ListBox_Collection.FormattingEnabled = true;
            this.ListBox_Collection.Location = new System.Drawing.Point(12, 39);
            this.ListBox_Collection.Name = "ListBox_Collection";
            this.ListBox_Collection.ScrollAlwaysVisible = true;
            this.ListBox_Collection.Size = new System.Drawing.Size(149, 82);
            this.ListBox_Collection.TabIndex = 3;
            this.ListBox_Collection.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 142);
            this.Controls.Add(this.ListBox_Collection);
            this.Controls.Add(this.Button_AddItem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBox_Item);
            this.MinimumSize = new System.Drawing.Size(300, 180);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button_AddItem;
        private System.Windows.Forms.TextBox TextBox_Item;
        private System.Windows.Forms.ListBox ListBox_Collection;
    }
}

