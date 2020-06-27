namespace complex_numbers
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
            this.boxRe = new System.Windows.Forms.TextBox();
            this.boxIm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelIm = new System.Windows.Forms.Label();
            this.labelRe = new System.Windows.Forms.Label();
            this.boxIm2 = new System.Windows.Forms.TextBox();
            this.boxRe2 = new System.Windows.Forms.TextBox();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelOut = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // boxRe
            // 
            this.boxRe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.boxRe.Location = new System.Drawing.Point(45, 13);
            this.boxRe.Name = "boxRe";
            this.boxRe.Size = new System.Drawing.Size(59, 24);
            this.boxRe.TabIndex = 0;
            // 
            // boxIm
            // 
            this.boxIm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.boxIm.Location = new System.Drawing.Point(143, 13);
            this.boxIm.Name = "boxIm";
            this.boxIm.Size = new System.Drawing.Size(59, 24);
            this.boxIm.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Re";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(110, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Im";
            // 
            // labelIm
            // 
            this.labelIm.AutoSize = true;
            this.labelIm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIm.Location = new System.Drawing.Point(110, 76);
            this.labelIm.Name = "labelIm";
            this.labelIm.Size = new System.Drawing.Size(27, 20);
            this.labelIm.TabIndex = 7;
            this.labelIm.Text = "Im";
            // 
            // labelRe
            // 
            this.labelRe.AutoSize = true;
            this.labelRe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRe.Location = new System.Drawing.Point(9, 75);
            this.labelRe.Name = "labelRe";
            this.labelRe.Size = new System.Drawing.Size(30, 20);
            this.labelRe.TabIndex = 6;
            this.labelRe.Text = "Re";
            // 
            // boxIm2
            // 
            this.boxIm2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.boxIm2.Location = new System.Drawing.Point(143, 75);
            this.boxIm2.Name = "boxIm2";
            this.boxIm2.Size = new System.Drawing.Size(59, 24);
            this.boxIm2.TabIndex = 5;
            // 
            // boxRe2
            // 
            this.boxRe2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.boxRe2.Location = new System.Drawing.Point(45, 75);
            this.boxRe2.Name = "boxRe2";
            this.boxRe2.Size = new System.Drawing.Size(59, 24);
            this.boxRe2.TabIndex = 4;
            // 
            // comboBox
            // 
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "abs",
            "arg"});
            this.comboBox.Location = new System.Drawing.Point(91, 43);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(65, 23);
            this.comboBox.TabIndex = 8;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart.Location = new System.Drawing.Point(76, 76);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(92, 26);
            this.buttonStart.TabIndex = 9;
            this.buttonStart.Text = "Посчитать";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelOut
            // 
            this.labelOut.AutoEllipsis = true;
            this.labelOut.AutoSize = true;
            this.labelOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOut.Location = new System.Drawing.Point(228, 46);
            this.labelOut.Name = "labelOut";
            this.labelOut.Size = new System.Drawing.Size(0, 20);
            this.labelOut.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(344, 137);
            this.Controls.Add(this.labelOut);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.labelIm);
            this.Controls.Add(this.labelRe);
            this.Controls.Add(this.boxIm2);
            this.Controls.Add(this.boxRe2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxIm);
            this.Controls.Add(this.boxRe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox boxRe;
        private System.Windows.Forms.TextBox boxIm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelIm;
        private System.Windows.Forms.Label labelRe;
        private System.Windows.Forms.TextBox boxIm2;
        private System.Windows.Forms.TextBox boxRe2;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelOut;
    }
}

