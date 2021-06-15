namespace Lab01.Ex01.RectangularWin
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
            this.Button_BorderStyle = new System.Windows.Forms.Button();
            this.Button_Resize = new System.Windows.Forms.Button();
            this.Button_Opacity = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button_BorderStyle
            // 
            this.Button_BorderStyle.Location = new System.Drawing.Point(8, 12);
            this.Button_BorderStyle.Name = "Button_BorderStyle";
            this.Button_BorderStyle.Size = new System.Drawing.Size(81, 41);
            this.Button_BorderStyle.TabIndex = 0;
            this.Button_BorderStyle.Text = "Border Style";
            this.Button_BorderStyle.UseVisualStyleBackColor = true;
            this.Button_BorderStyle.Click += new System.EventHandler(this.Button_BorderStyle_Click);
            // 
            // Button_Resize
            // 
            this.Button_Resize.Location = new System.Drawing.Point(95, 12);
            this.Button_Resize.Name = "Button_Resize";
            this.Button_Resize.Size = new System.Drawing.Size(74, 41);
            this.Button_Resize.TabIndex = 1;
            this.Button_Resize.Text = "Resize";
            this.Button_Resize.UseVisualStyleBackColor = true;
            this.Button_Resize.Click += new System.EventHandler(this.Button_Resize_Click);
            // 
            // Button_Opacity
            // 
            this.Button_Opacity.Location = new System.Drawing.Point(175, 12);
            this.Button_Opacity.Name = "Button_Opacity";
            this.Button_Opacity.Size = new System.Drawing.Size(75, 41);
            this.Button_Opacity.TabIndex = 2;
            this.Button_Opacity.Text = "Opacity.";
            this.Button_Opacity.UseVisualStyleBackColor = true;
            this.Button_Opacity.Click += new System.EventHandler(this.Button_Opacity_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Button_Opacity);
            this.Controls.Add(this.Button_Resize);
            this.Controls.Add(this.Button_BorderStyle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Location = new System.Drawing.Point(100, 200);
            this.Name = "Form1";
            this.Opacity = 0.75D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Trey Research";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button_BorderStyle;
        private System.Windows.Forms.Button Button_Resize;
        private System.Windows.Forms.Button Button_Opacity;
    }
}

