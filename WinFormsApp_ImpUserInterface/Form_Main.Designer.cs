namespace WinFormsApp_ImpUserInterface
{
    partial class Form_Main
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
            this.panel_Output = new System.Windows.Forms.Panel();
            this.pictureBox_Formula = new System.Windows.Forms.PictureBox();
            this.label_InputValue = new System.Windows.Forms.Label();
            this.textBox_InputValue = new System.Windows.Forms.TextBox();
            this.vScrollBar_InputValue = new System.Windows.Forms.VScrollBar();
            this.label_Output = new System.Windows.Forms.Label();
            this.label_InputTaskNum = new System.Windows.Forms.Label();
            this.comboBox_TaskNum = new System.Windows.Forms.ComboBox();
            this.button_EvaluateVariant = new System.Windows.Forms.Button();
            this.button_EvaluateAllDefault = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_Output.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Formula)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Output
            // 
            this.panel_Output.Controls.Add(this.pictureBox1);
            this.panel_Output.Controls.Add(this.vScrollBar_InputValue);
            this.panel_Output.Controls.Add(this.label_Output);
            this.panel_Output.Controls.Add(this.textBox_InputValue);
            this.panel_Output.Controls.Add(this.label_InputValue);
            this.panel_Output.Controls.Add(this.pictureBox_Formula);
            this.panel_Output.Location = new System.Drawing.Point(263, 12);
            this.panel_Output.Name = "panel_Output";
            this.panel_Output.Size = new System.Drawing.Size(496, 386);
            this.panel_Output.TabIndex = 0;
            // 
            // pictureBox_Formula
            // 
            this.pictureBox_Formula.Location = new System.Drawing.Point(13, 16);
            this.pictureBox_Formula.Name = "pictureBox_Formula";
            this.pictureBox_Formula.Size = new System.Drawing.Size(468, 182);
            this.pictureBox_Formula.TabIndex = 0;
            this.pictureBox_Formula.TabStop = false;
            // 
            // label_InputValue
            // 
            this.label_InputValue.AutoSize = true;
            this.label_InputValue.Location = new System.Drawing.Point(38, 246);
            this.label_InputValue.Name = "label_InputValue";
            this.label_InputValue.Size = new System.Drawing.Size(85, 16);
            this.label_InputValue.TabIndex = 1;
            this.label_InputValue.Text = "Значение n:";
            // 
            // textBox_InputValue
            // 
            this.textBox_InputValue.Location = new System.Drawing.Point(129, 246);
            this.textBox_InputValue.Name = "textBox_InputValue";
            this.textBox_InputValue.ReadOnly = true;
            this.textBox_InputValue.Size = new System.Drawing.Size(100, 22);
            this.textBox_InputValue.TabIndex = 2;
            this.textBox_InputValue.TextChanged += new System.EventHandler(this.textBox_InputValue_TextChanged);
            // 
            // vScrollBar_InputValue
            // 
            this.vScrollBar_InputValue.Location = new System.Drawing.Point(232, 246);
            this.vScrollBar_InputValue.Name = "vScrollBar_InputValue";
            this.vScrollBar_InputValue.Size = new System.Drawing.Size(23, 23);
            this.vScrollBar_InputValue.TabIndex = 3;
            // 
            // label_Output
            // 
            this.label_Output.Location = new System.Drawing.Point(48, 201);
            this.label_Output.Name = "label_Output";
            this.label_Output.Size = new System.Drawing.Size(191, 23);
            this.label_Output.TabIndex = 4;
            this.label_Output.Text = "Расчет по формуле при n:\r\n";
            this.label_Output.Click += new System.EventHandler(this.label_Output_Click);
            // 
            // label_InputTaskNum
            // 
            this.label_InputTaskNum.AutoSize = true;
            this.label_InputTaskNum.Location = new System.Drawing.Point(24, 67);
            this.label_InputTaskNum.Name = "label_InputTaskNum";
            this.label_InputTaskNum.Size = new System.Drawing.Size(174, 16);
            this.label_InputTaskNum.TabIndex = 5;
            this.label_InputTaskNum.Text = "Выберите номер задания";
            // 
            // comboBox_TaskNum
            // 
            this.comboBox_TaskNum.FormattingEnabled = true;
            this.comboBox_TaskNum.Items.AddRange(new object[] {
            "Задание 1, Задания 2, Задания 3"});
            this.comboBox_TaskNum.Location = new System.Drawing.Point(26, 103);
            this.comboBox_TaskNum.Name = "comboBox_TaskNum";
            this.comboBox_TaskNum.Size = new System.Drawing.Size(172, 24);
            this.comboBox_TaskNum.TabIndex = 6;
            // 
            // button_EvaluateVariant
            // 
            this.button_EvaluateVariant.Location = new System.Drawing.Point(12, 172);
            this.button_EvaluateVariant.Name = "button_EvaluateVariant";
            this.button_EvaluateVariant.Size = new System.Drawing.Size(225, 54);
            this.button_EvaluateVariant.TabIndex = 7;
            this.button_EvaluateVariant.Text = "Выполнить расчет";
            this.button_EvaluateVariant.UseVisualStyleBackColor = true;
            // 
            // button_EvaluateAllDefault
            // 
            this.button_EvaluateAllDefault.Location = new System.Drawing.Point(12, 254);
            this.button_EvaluateAllDefault.Name = "button_EvaluateAllDefault";
            this.button_EvaluateAllDefault.Size = new System.Drawing.Size(225, 51);
            this.button_EvaluateAllDefault.TabIndex = 8;
            this.button_EvaluateAllDefault.Text = "Все расчеты со значениями по умолчанию";
            this.button_EvaluateAllDefault.UseVisualStyleBackColor = true;
            // 
            // button_Close
            // 
            this.button_Close.Location = new System.Drawing.Point(12, 331);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(225, 57);
            this.button_Close.TabIndex = 9;
            this.button_Close.Text = "Закрыть";
            this.button_Close.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 299);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(469, 77);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 410);
            this.Controls.Add(this.label_InputTaskNum);
            this.Controls.Add(this.comboBox_TaskNum);
            this.Controls.Add(this.button_EvaluateVariant);
            this.Controls.Add(this.button_EvaluateAllDefault);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.panel_Output);
            this.Name = "Form_Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.panel_Output.ResumeLayout(false);
            this.panel_Output.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Formula)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_Output;
        private System.Windows.Forms.ComboBox comboBox_TaskNum;
        private System.Windows.Forms.Label label_InputTaskNum;
        private System.Windows.Forms.Label label_Output;
        private System.Windows.Forms.VScrollBar vScrollBar_InputValue;
        private System.Windows.Forms.TextBox textBox_InputValue;
        private System.Windows.Forms.Label label_InputValue;
        private System.Windows.Forms.PictureBox pictureBox_Formula;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Button button_EvaluateAllDefault;
        private System.Windows.Forms.Button button_EvaluateVariant;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

