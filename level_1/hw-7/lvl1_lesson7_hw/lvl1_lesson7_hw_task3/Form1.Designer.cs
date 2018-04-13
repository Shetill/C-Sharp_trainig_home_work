namespace lvl1_lesson7_hw_task3
{
    partial class FormZRS
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
            this.lblWho = new System.Windows.Forms.Label();
            this.txtWho = new System.Windows.Forms.TextBox();
            this.lblFrom = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.lblZRS = new System.Windows.Forms.Label();
            this.txtSituation = new System.Windows.Forms.TextBox();
            this.lblSituation = new System.Windows.Forms.Label();
            this.lblInform = new System.Windows.Forms.Label();
            this.txtInform = new System.Windows.Forms.TextBox();
            this.lblSolve = new System.Windows.Forms.Label();
            this.txtSolve = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.btnPrint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWho
            // 
            this.lblWho.AutoSize = true;
            this.lblWho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWho.Location = new System.Drawing.Point(9, 9);
            this.lblWho.Name = "lblWho";
            this.lblWho.Size = new System.Drawing.Size(60, 20);
            this.lblWho.TabIndex = 0;
            this.lblWho.Text = "Кому:";
            // 
            // txtWho
            // 
            this.txtWho.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtWho.Location = new System.Drawing.Point(12, 37);
            this.txtWho.Name = "txtWho";
            this.txtWho.Size = new System.Drawing.Size(172, 22);
            this.txtWho.TabIndex = 1;
            this.txtWho.Text = "Пинягину Сергею";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFrom.Location = new System.Drawing.Point(12, 73);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(70, 17);
            this.lblFrom.TabIndex = 2;
            this.lblFrom.Text = "От кого:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(12, 101);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Петухова Романа";
            // 
            // txtDate
            // 
            this.txtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDate.Location = new System.Drawing.Point(412, 29);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(150, 24);
            this.txtDate.TabIndex = 4;
            // 
            // lblZRS
            // 
            this.lblZRS.AutoSize = true;
            this.lblZRS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblZRS.Location = new System.Drawing.Point(242, 189);
            this.lblZRS.Name = "lblZRS";
            this.lblZRS.Size = new System.Drawing.Size(53, 25);
            this.lblZRS.TabIndex = 5;
            this.lblZRS.Text = "ЗРС";
            this.lblZRS.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtSituation
            // 
            this.txtSituation.Location = new System.Drawing.Point(12, 259);
            this.txtSituation.Multiline = true;
            this.txtSituation.Name = "txtSituation";
            this.txtSituation.Size = new System.Drawing.Size(553, 62);
            this.txtSituation.TabIndex = 6;
            // 
            // lblSituation
            // 
            this.lblSituation.AutoSize = true;
            this.lblSituation.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSituation.Location = new System.Drawing.Point(9, 225);
            this.lblSituation.Name = "lblSituation";
            this.lblSituation.Size = new System.Drawing.Size(84, 17);
            this.lblSituation.TabIndex = 7;
            this.lblSituation.Text = "Ситуация:";
            // 
            // lblInform
            // 
            this.lblInform.AutoSize = true;
            this.lblInform.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInform.Location = new System.Drawing.Point(9, 347);
            this.lblInform.Name = "lblInform";
            this.lblInform.Size = new System.Drawing.Size(109, 17);
            this.lblInform.TabIndex = 8;
            this.lblInform.Text = "Информация:";
            // 
            // txtInform
            // 
            this.txtInform.Location = new System.Drawing.Point(12, 381);
            this.txtInform.Multiline = true;
            this.txtInform.Name = "txtInform";
            this.txtInform.Size = new System.Drawing.Size(553, 62);
            this.txtInform.TabIndex = 6;
            // 
            // lblSolve
            // 
            this.lblSolve.AutoSize = true;
            this.lblSolve.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSolve.Location = new System.Drawing.Point(9, 468);
            this.lblSolve.Name = "lblSolve";
            this.lblSolve.Size = new System.Drawing.Size(80, 17);
            this.lblSolve.TabIndex = 8;
            this.lblSolve.Text = "Решения:";
            // 
            // txtSolve
            // 
            this.txtSolve.Location = new System.Drawing.Point(12, 503);
            this.txtSolve.Multiline = true;
            this.txtSolve.Name = "txtSolve";
            this.txtSolve.Size = new System.Drawing.Size(553, 62);
            this.txtSolve.TabIndex = 6;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(12, 608);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(129, 42);
            this.btnPrint.TabIndex = 9;
            this.btnPrint.Text = "Печать";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // FormZRS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 687);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.lblSolve);
            this.Controls.Add(this.lblInform);
            this.Controls.Add(this.lblSituation);
            this.Controls.Add(this.txtSolve);
            this.Controls.Add(this.txtInform);
            this.Controls.Add(this.txtSituation);
            this.Controls.Add(this.lblZRS);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.txtWho);
            this.Controls.Add(this.lblWho);
            this.Name = "FormZRS";
            this.Text = "ЗРС сотрудника";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWho;
        private System.Windows.Forms.TextBox txtWho;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label lblZRS;
        private System.Windows.Forms.TextBox txtSituation;
        private System.Windows.Forms.Label lblSituation;
        private System.Windows.Forms.Label lblInform;
        private System.Windows.Forms.TextBox txtInform;
        private System.Windows.Forms.Label lblSolve;
        private System.Windows.Forms.TextBox txtSolve;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button btnPrint;
    }
}

