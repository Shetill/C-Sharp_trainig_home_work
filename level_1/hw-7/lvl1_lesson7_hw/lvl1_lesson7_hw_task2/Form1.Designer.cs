namespace lvl1_lesson7_hw_task2
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
            this.UsrTextBox = new System.Windows.Forms.TextBox();
            this.lblInputUsrTextBox = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UsrTextBox
            // 
            this.UsrTextBox.Location = new System.Drawing.Point(261, 18);
            this.UsrTextBox.Name = "UsrTextBox";
            this.UsrTextBox.Size = new System.Drawing.Size(71, 22);
            this.UsrTextBox.TabIndex = 0;
            // 
            // lblInputUsrTextBox
            // 
            this.lblInputUsrTextBox.AutoSize = true;
            this.lblInputUsrTextBox.Location = new System.Drawing.Point(31, 18);
            this.lblInputUsrTextBox.Name = "lblInputUsrTextBox";
            this.lblInputUsrTextBox.Size = new System.Drawing.Size(224, 17);
            this.lblInputUsrTextBox.TabIndex = 1;
            this.lblInputUsrTextBox.Text = "Введите предпологаемое число:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "Проверить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 99);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblInputUsrTextBox);
            this.Controls.Add(this.UsrTextBox);
            this.Name = "Form1";
            this.Text = "Игра: Угадай число";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UsrTextBox;
        private System.Windows.Forms.Label lblInputUsrTextBox;
        private System.Windows.Forms.Button button1;
    }
}

