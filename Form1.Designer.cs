namespace HtmlViewerApp
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
            this.loadButton = new System.Windows.Forms.Button();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.htmlTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(717, 14);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(128, 70);
            this.loadButton.TabIndex = 0;
            this.loadButton.Text = "Загрузить";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click); 
            // 
            // urlTextBox
            // 
            this.urlTextBox.Location = new System.Drawing.Point(12, 26);
            this.urlTextBox.Multiline = true;
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(687, 44);
            this.urlTextBox.TabIndex = 1;
            this.urlTextBox.Text = "enter url";
            // 
            // htmlTextBox
            // 
            this.htmlTextBox.Location = new System.Drawing.Point(12, 90);
            this.htmlTextBox.Multiline = true;
            this.htmlTextBox.Name = "htmlTextBox";
            this.htmlTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.htmlTextBox.Size = new System.Drawing.Size(875, 430);
            this.htmlTextBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 551);
            this.Controls.Add(this.htmlTextBox);
            this.Controls.Add(this.urlTextBox);
            this.Controls.Add(this.loadButton);
            this.Name = "Form1";
            this.Text = "Read Html";
            this.ResumeLayout(false);
            this.PerformLayout();
        }


        #endregion

        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.TextBox htmlTextBox;
    }
}

