namespace lvl1_lesson7_hw
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
            this.btnPlusOne = new System.Windows.Forms.Button();
            this.btnMultiTwo = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPlusOne
            // 
            this.btnPlusOne.Location = new System.Drawing.Point(137, 12);
            this.btnPlusOne.Name = "btnPlusOne";
            this.btnPlusOne.Size = new System.Drawing.Size(146, 50);
            this.btnPlusOne.TabIndex = 1;
            this.btnPlusOne.Text = "+1";
            this.btnPlusOne.UseVisualStyleBackColor = true;
            this.btnPlusOne.Click += new System.EventHandler(this.btnPlusOne_Click);
            // 
            // btnMultiTwo
            // 
            this.btnMultiTwo.Location = new System.Drawing.Point(137, 68);
            this.btnMultiTwo.Name = "btnMultiTwo";
            this.btnMultiTwo.Size = new System.Drawing.Size(146, 50);
            this.btnMultiTwo.TabIndex = 1;
            this.btnMultiTwo.Text = "x2";
            this.btnMultiTwo.UseVisualStyleBackColor = true;
            this.btnMultiTwo.Click += new System.EventHandler(this.btnMultiTwo_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(137, 124);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(146, 50);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Сброс";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblResult.Location = new System.Drawing.Point(57, 12);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(23, 25);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 181);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnMultiTwo);
            this.Controls.Add(this.btnPlusOne);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPlusOne;
        private System.Windows.Forms.Button btnMultiTwo;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblResult;
    }
}

