namespace Work5
{
    partial class FrmEditBook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.TextBoxTitle = new System.Windows.Forms.TextBox();
            this.LabelAuthor = new System.Windows.Forms.Label();
            this.TextBoxAuthor = new System.Windows.Forms.TextBox();
            this.LabelDatePublished = new System.Windows.Forms.Label();
            this.DateTimePickerDatePublished = new System.Windows.Forms.DateTimePicker();
            this.ButtonOK = new System.Windows.Forms.Button();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Location = new System.Drawing.Point(23, 20);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(92, 13);
            this.LabelTitle.TabIndex = 0;
            this.LabelTitle.Text = "Название книги:";
            // 
            // TextBoxTitle
            // 
            this.TextBoxTitle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "Title", true));
            this.TextBoxTitle.Location = new System.Drawing.Point(26, 36);
            this.TextBoxTitle.Name = "TextBoxTitle";
            this.TextBoxTitle.Size = new System.Drawing.Size(476, 20);
            this.TextBoxTitle.TabIndex = 1;
            // 
            // LabelAuthor
            // 
            this.LabelAuthor.AutoSize = true;
            this.LabelAuthor.Location = new System.Drawing.Point(23, 81);
            this.LabelAuthor.Name = "LabelAuthor";
            this.LabelAuthor.Size = new System.Drawing.Size(72, 13);
            this.LabelAuthor.TabIndex = 2;
            this.LabelAuthor.Text = "Автор книги:";
            // 
            // TextBoxAuthor
            // 
            this.TextBoxAuthor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookBindingSource, "Author", true));
            this.TextBoxAuthor.Location = new System.Drawing.Point(26, 97);
            this.TextBoxAuthor.Name = "TextBoxAuthor";
            this.TextBoxAuthor.Size = new System.Drawing.Size(476, 20);
            this.TextBoxAuthor.TabIndex = 3;
            // 
            // LabelDatePublished
            // 
            this.LabelDatePublished.AutoSize = true;
            this.LabelDatePublished.Location = new System.Drawing.Point(23, 144);
            this.LabelDatePublished.Name = "LabelDatePublished";
            this.LabelDatePublished.Size = new System.Drawing.Size(73, 13);
            this.LabelDatePublished.TabIndex = 4;
            this.LabelDatePublished.Text = "Год издания:";
            // 
            // DateTimePickerDatePublished
            // 
            this.DateTimePickerDatePublished.CustomFormat = "yyyy";
            this.DateTimePickerDatePublished.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bookBindingSource, "DatePublished", true));
            this.DateTimePickerDatePublished.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePickerDatePublished.Location = new System.Drawing.Point(26, 160);
            this.DateTimePickerDatePublished.Name = "DateTimePickerDatePublished";
            this.DateTimePickerDatePublished.Size = new System.Drawing.Size(89, 20);
            this.DateTimePickerDatePublished.TabIndex = 5;
            // 
            // ButtonOK
            // 
            this.ButtonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButtonOK.Location = new System.Drawing.Point(346, 236);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(75, 23);
            this.ButtonOK.TabIndex = 6;
            this.ButtonOK.Text = "&OK";
            this.ButtonOK.UseVisualStyleBackColor = true;
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.Location = new System.Drawing.Point(427, 236);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.ButtonCancel.TabIndex = 7;
            this.ButtonCancel.Text = "&Отмена";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataSource = typeof(Work5.Book);
            // 
            // FrmEditBook
            // 
            this.AcceptButton = this.ButtonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ButtonCancel;
            this.ClientSize = new System.Drawing.Size(532, 303);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonOK);
            this.Controls.Add(this.DateTimePickerDatePublished);
            this.Controls.Add(this.LabelDatePublished);
            this.Controls.Add(this.TextBoxAuthor);
            this.Controls.Add(this.LabelAuthor);
            this.Controls.Add(this.TextBoxTitle);
            this.Controls.Add(this.LabelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEditBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактировать книгу";
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.TextBox TextBoxTitle;
        private System.Windows.Forms.Label LabelAuthor;
        private System.Windows.Forms.TextBox TextBoxAuthor;
        private System.Windows.Forms.Label LabelDatePublished;
        private System.Windows.Forms.DateTimePicker DateTimePickerDatePublished;
        private System.Windows.Forms.Button ButtonOK;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.BindingSource bookBindingSource;
    }
}