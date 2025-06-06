namespace Work5
{
    partial class FrmDataGridViewSampleMain
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ContextMenuStripForGrid = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuItemRemoveBook = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEditBook = new System.Windows.Forms.ToolStripMenuItem();
            this.DataGridViewBooks = new System.Windows.Forms.DataGridView();
            this.TextBoxBooks = new System.Windows.Forms.TextBox();
            this.LabelSearch = new System.Windows.Forms.Label();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.GroupBoxAddNewBook = new System.Windows.Forms.GroupBox();
            this.ButtonAddBook = new System.Windows.Forms.Button();
            this.DateTimePickerDatePublished = new System.Windows.Forms.DateTimePicker();
            this.LabelDatePublished = new System.Windows.Forms.Label();
            this.TextBoxAuthor = new System.Windows.Forms.TextBox();
            this.LabelAuthor = new System.Windows.Forms.Label();
            this.TextBoxTitle = new System.Windows.Forms.TextBox();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.ContextMenuStripForGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewBooks)).BeginInit();
            this.GroupBoxAddNewBook.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContextMenuStripForGrid
            // 
            this.ContextMenuStripForGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemRemoveBook,
            this.MenuItemEditBook});
            this.ContextMenuStripForGrid.Name = "ContextMenuStripForGrid";
            this.ContextMenuStripForGrid.Size = new System.Drawing.Size(257, 48);
            // 
            // MenuItemRemoveBook
            // 
            this.MenuItemRemoveBook.Name = "MenuItemRemoveBook";
            this.MenuItemRemoveBook.Size = new System.Drawing.Size(256, 22);
            this.MenuItemRemoveBook.Text = "&Удалить выбранную книгу";
            // 
            // MenuItemEditBook
            // 
            this.MenuItemEditBook.Name = "MenuItemEditBook";
            this.MenuItemEditBook.Size = new System.Drawing.Size(256, 22);
            this.MenuItemEditBook.Text = "&Редактировать выбранную книгу";
            // 
            // DataGridViewBooks
            // 
            this.DataGridViewBooks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewBooks.ContextMenuStrip = this.ContextMenuStripForGrid;
            this.DataGridViewBooks.Location = new System.Drawing.Point(12, 41);
            this.DataGridViewBooks.Name = "DataGridViewBooks";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.PapayaWhip;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewBooks.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewBooks.Size = new System.Drawing.Size(587, 388);
            this.DataGridViewBooks.TabIndex = 1;
            // 
            // TextBoxBooks
            // 
            this.TextBoxBooks.Location = new System.Drawing.Point(605, 12);
            this.TextBoxBooks.Multiline = true;
            this.TextBoxBooks.Name = "TextBoxBooks";
            this.TextBoxBooks.ReadOnly = true;
            this.TextBoxBooks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBoxBooks.Size = new System.Drawing.Size(391, 417);
            this.TextBoxBooks.TabIndex = 2;
            // 
            // LabelSearch
            // 
            this.LabelSearch.AutoSize = true;
            this.LabelSearch.Location = new System.Drawing.Point(12, 15);
            this.LabelSearch.Name = "LabelSearch";
            this.LabelSearch.Size = new System.Drawing.Size(42, 13);
            this.LabelSearch.TabIndex = 3;
            this.LabelSearch.Text = "Поиск:";
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Location = new System.Drawing.Point(53, 12);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(546, 20);
            this.TextBoxSearch.TabIndex = 4;
            // 
            // GroupBoxAddNewBook
            // 
            this.GroupBoxAddNewBook.Controls.Add(this.ButtonAddBook);
            this.GroupBoxAddNewBook.Controls.Add(this.DateTimePickerDatePublished);
            this.GroupBoxAddNewBook.Controls.Add(this.LabelDatePublished);
            this.GroupBoxAddNewBook.Controls.Add(this.TextBoxAuthor);
            this.GroupBoxAddNewBook.Controls.Add(this.LabelAuthor);
            this.GroupBoxAddNewBook.Controls.Add(this.TextBoxTitle);
            this.GroupBoxAddNewBook.Controls.Add(this.LabelTitle);
            this.GroupBoxAddNewBook.Location = new System.Drawing.Point(12, 435);
            this.GroupBoxAddNewBook.Name = "GroupBoxAddNewBook";
            this.GroupBoxAddNewBook.Size = new System.Drawing.Size(984, 59);
            this.GroupBoxAddNewBook.TabIndex = 5;
            this.GroupBoxAddNewBook.TabStop = false;
            this.GroupBoxAddNewBook.Text = "Добавить новую книгу в коллекцию:";
            // 
            // ButtonAddBook
            // 
            this.ButtonAddBook.Location = new System.Drawing.Point(823, 20);
            this.ButtonAddBook.Name = "ButtonAddBook";
            this.ButtonAddBook.Size = new System.Drawing.Size(147, 23);
            this.ButtonAddBook.TabIndex = 6;
            this.ButtonAddBook.Text = "&Добавить книгу";
            this.ButtonAddBook.UseVisualStyleBackColor = true;
            // 
            // DateTimePickerDatePublished
            // 
            this.DateTimePickerDatePublished.CustomFormat = "yyyy";
            this.DateTimePickerDatePublished.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePickerDatePublished.Location = new System.Drawing.Point(717, 22);
            this.DateTimePickerDatePublished.Name = "DateTimePickerDatePublished";
            this.DateTimePickerDatePublished.Size = new System.Drawing.Size(66, 20);
            this.DateTimePickerDatePublished.TabIndex = 5;
            // 
            // LabelDatePublished
            // 
            this.LabelDatePublished.AutoSize = true;
            this.LabelDatePublished.Location = new System.Drawing.Point(630, 25);
            this.LabelDatePublished.Name = "LabelDatePublished";
            this.LabelDatePublished.Size = new System.Drawing.Size(73, 13);
            this.LabelDatePublished.TabIndex = 4;
            this.LabelDatePublished.Text = "Год издания:";
            // 
            // TextBoxAuthor
            // 
            this.TextBoxAuthor.Location = new System.Drawing.Point(439, 22);
            this.TextBoxAuthor.Name = "TextBoxAuthor";
            this.TextBoxAuthor.Size = new System.Drawing.Size(175, 20);
            this.TextBoxAuthor.TabIndex = 3;
            // 
            // LabelAuthor
            // 
            this.LabelAuthor.AutoSize = true;
            this.LabelAuthor.Location = new System.Drawing.Point(393, 25);
            this.LabelAuthor.Name = "LabelAuthor";
            this.LabelAuthor.Size = new System.Drawing.Size(40, 13);
            this.LabelAuthor.TabIndex = 2;
            this.LabelAuthor.Text = "Автор:";
            // 
            // TextBoxTitle
            // 
            this.TextBoxTitle.Location = new System.Drawing.Point(82, 22);
            this.TextBoxTitle.Name = "TextBoxTitle";
            this.TextBoxTitle.Size = new System.Drawing.Size(294, 20);
            this.TextBoxTitle.TabIndex = 1;
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Location = new System.Drawing.Point(16, 25);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(60, 13);
            this.LabelTitle.TabIndex = 0;
            this.LabelTitle.Text = "Название:";
            // 
            // FrmDataGridViewSampleMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 529);
            this.Controls.Add(this.GroupBoxAddNewBook);
            this.Controls.Add(this.TextBoxSearch);
            this.Controls.Add(this.LabelSearch);
            this.Controls.Add(this.TextBoxBooks);
            this.Controls.Add(this.DataGridViewBooks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDataGridViewSampleMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[Allineed.Ru] Пример работы с элементом DataGridView";
            this.Load += new System.EventHandler(this.FrmDataGridViewSampleMain_Load);
            this.ContextMenuStripForGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewBooks)).EndInit();
            this.GroupBoxAddNewBook.ResumeLayout(false);
            this.GroupBoxAddNewBook.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip ContextMenuStripForGrid;
        private System.Windows.Forms.ToolStripMenuItem MenuItemRemoveBook;
        private System.Windows.Forms.ToolStripMenuItem MenuItemEditBook;
        private System.Windows.Forms.DataGridView DataGridViewBooks;
        private System.Windows.Forms.TextBox TextBoxBooks;
        private System.Windows.Forms.Label LabelSearch;
        private System.Windows.Forms.TextBox TextBoxSearch;
        private System.Windows.Forms.GroupBox GroupBoxAddNewBook;
        private System.Windows.Forms.Label LabelDatePublished;
        private System.Windows.Forms.TextBox TextBoxAuthor;
        private System.Windows.Forms.Label LabelAuthor;
        private System.Windows.Forms.TextBox TextBoxTitle;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Button ButtonAddBook;
        private System.Windows.Forms.DateTimePicker DateTimePickerDatePublished;
    }
}

