namespace AnythingForm
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
            this.checkBox_Add = new System.Windows.Forms.CheckBox();
            this.checkBox_Remve = new System.Windows.Forms.CheckBox();
            this.checkBox_Multiple = new System.Windows.Forms.CheckBox();
            this.checkBox_Divide = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox_Add
            // 
            this.checkBox_Add.AutoSize = true;
            this.checkBox_Add.Location = new System.Drawing.Point(12, 12);
            this.checkBox_Add.Name = "checkBox_Add";
            this.checkBox_Add.Size = new System.Drawing.Size(45, 17);
            this.checkBox_Add.TabIndex = 1;
            this.checkBox_Add.Text = "Add";
            this.checkBox_Add.UseVisualStyleBackColor = true;
            // 
            // checkBox_Remve
            // 
            this.checkBox_Remve.AutoSize = true;
            this.checkBox_Remve.Location = new System.Drawing.Point(12, 35);
            this.checkBox_Remve.Name = "checkBox_Remve";
            this.checkBox_Remve.Size = new System.Drawing.Size(60, 17);
            this.checkBox_Remve.TabIndex = 2;
            this.checkBox_Remve.Text = "Remve";
            this.checkBox_Remve.UseVisualStyleBackColor = true;
            // 
            // checkBox_Multiple
            // 
            this.checkBox_Multiple.AutoSize = true;
            this.checkBox_Multiple.Location = new System.Drawing.Point(12, 58);
            this.checkBox_Multiple.Name = "checkBox_Multiple";
            this.checkBox_Multiple.Size = new System.Drawing.Size(62, 17);
            this.checkBox_Multiple.TabIndex = 3;
            this.checkBox_Multiple.Text = "Multiple";
            this.checkBox_Multiple.UseVisualStyleBackColor = true;
            // 
            // checkBox_Divide
            // 
            this.checkBox_Divide.AutoSize = true;
            this.checkBox_Divide.Location = new System.Drawing.Point(12, 81);
            this.checkBox_Divide.Name = "checkBox_Divide";
            this.checkBox_Divide.Size = new System.Drawing.Size(56, 17);
            this.checkBox_Divide.TabIndex = 4;
            this.checkBox_Divide.Text = "Divide";
            this.checkBox_Divide.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(12, 117);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(80, 20);
            this.numericUpDown1.TabIndex = 5;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(98, 117);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(80, 20);
            this.numericUpDown2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 20);
            this.label1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 20);
            this.label2.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 20);
            this.label3.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 20);
            this.label4.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 27);
            this.button1.TabIndex = 11;
            this.button1.Text = "Do it";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(189, 280);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.checkBox_Divide);
            this.Controls.Add(this.checkBox_Multiple);
            this.Controls.Add(this.checkBox_Remve);
            this.Controls.Add(this.checkBox_Add);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_Add;
        private System.Windows.Forms.CheckBox checkBox_Remve;
        private System.Windows.Forms.CheckBox checkBox_Multiple;
        private System.Windows.Forms.CheckBox checkBox_Divide;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}

