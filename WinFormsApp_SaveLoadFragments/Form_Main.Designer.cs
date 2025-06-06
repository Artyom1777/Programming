namespace WinFormsApp_SaveLoadFragments
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.RadioButton_SaveAs = new System.Windows.Forms.RadioButton();
            this.radioButton_Load = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.MinimumSize = new System.Drawing.Size(480, 280);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(480, 280);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // RadioButton_SaveAs
            // 
            this.RadioButton_SaveAs.AutoSize = true;
            this.RadioButton_SaveAs.Location = new System.Drawing.Point(21, 303);
            this.RadioButton_SaveAs.Name = "RadioButton_SaveAs";
            this.RadioButton_SaveAs.Size = new System.Drawing.Size(151, 17);
            this.RadioButton_SaveAs.TabIndex = 1;
            this.RadioButton_SaveAs.TabStop = true;
            this.RadioButton_SaveAs.Text = "Загрузить фрагмент как";
            this.RadioButton_SaveAs.UseVisualStyleBackColor = true;
            // 
            // radioButton_Load
            // 
            this.radioButton_Load.AutoSize = true;
            this.radioButton_Load.Location = new System.Drawing.Point(300, 303);
            this.radioButton_Load.Name = "radioButton_Load";
            this.radioButton_Load.Size = new System.Drawing.Size(130, 17);
            this.radioButton_Load.TabIndex = 2;
            this.radioButton_Load.TabStop = true;
            this.radioButton_Load.Text = "Загрузить фрагмент";
            this.radioButton_Load.UseVisualStyleBackColor = true;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 332);
            this.Controls.Add(this.radioButton_Load);
            this.Controls.Add(this.RadioButton_SaveAs);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form_Main";
            this.Text = "Сохранения и загрузка фрагментов изображений";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.RadioButton RadioButton_SaveAs;
        private System.Windows.Forms.RadioButton radioButton_Load;
    }
}

