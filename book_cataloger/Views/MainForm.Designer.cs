namespace book_cataloger
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.informationTable = new System.Windows.Forms.Panel();
            this.fieldYearPublication = new System.Windows.Forms.MaskedTextBox();
            this.buttonChoose = new System.Windows.Forms.Button();
            this.label_choosePicture = new System.Windows.Forms.Label();
            this.publishingField = new System.Windows.Forms.TextBox();
            this.label_publishingHouse = new System.Windows.Forms.Label();
            this.subcategoryField = new System.Windows.Forms.ComboBox();
            this.label_subcategory = new System.Windows.Forms.Label();
            this.label_category = new System.Windows.Forms.Label();
            this.fieldCategory = new System.Windows.Forms.ComboBox();
            this.buttonChange = new System.Windows.Forms.Button();
            this.nameField = new System.Windows.Forms.TextBox();
            this.authorField = new System.Windows.Forms.TextBox();
            this.label_yearPublish = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.label_autor = new System.Windows.Forms.Label();
            this.button_addBook = new System.Windows.Forms.Button();
            this.mainTable = new System.Windows.Forms.FlowLayoutPanel();
            this.button_deleteBook = new System.Windows.Forms.Button();
            this.button_editBook = new System.Windows.Forms.Button();
            this.button_SearchBook = new System.Windows.Forms.Button();
            this.button_backToView = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationTable.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // informationTable
            // 
            this.informationTable.AutoSize = true;
            this.informationTable.BackColor = System.Drawing.Color.Gainsboro;
            this.informationTable.Controls.Add(this.fieldYearPublication);
            this.informationTable.Controls.Add(this.buttonChoose);
            this.informationTable.Controls.Add(this.label_choosePicture);
            this.informationTable.Controls.Add(this.publishingField);
            this.informationTable.Controls.Add(this.label_publishingHouse);
            this.informationTable.Controls.Add(this.subcategoryField);
            this.informationTable.Controls.Add(this.label_subcategory);
            this.informationTable.Controls.Add(this.label_category);
            this.informationTable.Controls.Add(this.fieldCategory);
            this.informationTable.Controls.Add(this.buttonChange);
            this.informationTable.Controls.Add(this.nameField);
            this.informationTable.Controls.Add(this.authorField);
            this.informationTable.Controls.Add(this.label_yearPublish);
            this.informationTable.Controls.Add(this.label_name);
            this.informationTable.Controls.Add(this.label_autor);
            this.informationTable.Location = new System.Drawing.Point(557, 52);
            this.informationTable.Name = "informationTable";
            this.informationTable.Size = new System.Drawing.Size(337, 353);
            this.informationTable.TabIndex = 2;
            // 
            // fieldYearPublication
            // 
            this.fieldYearPublication.Enabled = false;
            this.fieldYearPublication.Location = new System.Drawing.Point(151, 68);
            this.fieldYearPublication.Mask = "0000";
            this.fieldYearPublication.Name = "fieldYearPublication";
            this.fieldYearPublication.Size = new System.Drawing.Size(167, 20);
            this.fieldYearPublication.TabIndex = 21;
            // 
            // buttonChoose
            // 
            this.buttonChoose.BackColor = System.Drawing.Color.White;
            this.buttonChoose.Location = new System.Drawing.Point(243, 236);
            this.buttonChoose.Name = "buttonChoose";
            this.buttonChoose.Size = new System.Drawing.Size(75, 23);
            this.buttonChoose.TabIndex = 20;
            this.buttonChoose.Text = "Выбрать";
            this.buttonChoose.UseVisualStyleBackColor = false;
            this.buttonChoose.Visible = false;
            this.buttonChoose.Click += new System.EventHandler(this.buttonChoose_Click);
            // 
            // label_choosePicture
            // 
            this.label_choosePicture.AutoSize = true;
            this.label_choosePicture.BackColor = System.Drawing.Color.Transparent;
            this.label_choosePicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_choosePicture.ForeColor = System.Drawing.Color.Black;
            this.label_choosePicture.Location = new System.Drawing.Point(13, 236);
            this.label_choosePicture.Name = "label_choosePicture";
            this.label_choosePicture.Size = new System.Drawing.Size(210, 18);
            this.label_choosePicture.TabIndex = 19;
            this.label_choosePicture.Text = "Выбрать другую картинку";
            this.label_choosePicture.Visible = false;
            // 
            // publishingField
            // 
            this.publishingField.Enabled = false;
            this.publishingField.Location = new System.Drawing.Point(151, 94);
            this.publishingField.Name = "publishingField";
            this.publishingField.Size = new System.Drawing.Size(167, 20);
            this.publishingField.TabIndex = 17;
            // 
            // label_publishingHouse
            // 
            this.label_publishingHouse.AutoSize = true;
            this.label_publishingHouse.BackColor = System.Drawing.Color.Transparent;
            this.label_publishingHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_publishingHouse.ForeColor = System.Drawing.Color.Black;
            this.label_publishingHouse.Location = new System.Drawing.Point(13, 96);
            this.label_publishingHouse.Name = "label_publishingHouse";
            this.label_publishingHouse.Size = new System.Drawing.Size(120, 18);
            this.label_publishingHouse.TabIndex = 16;
            this.label_publishingHouse.Text = "Издательство";
            // 
            // subcategoryField
            // 
            this.subcategoryField.Enabled = false;
            this.subcategoryField.FormattingEnabled = true;
            this.subcategoryField.Items.AddRange(new object[] {
            "Детективы",
            "Фантастика",
            "Комиксы и манга",
            "Любовные романы",
            "Поэзия",
            "Приключения",
            "Проза",
            "Триллеры",
            "Ужасы"});
            this.subcategoryField.Location = new System.Drawing.Point(151, 147);
            this.subcategoryField.Name = "subcategoryField";
            this.subcategoryField.Size = new System.Drawing.Size(167, 21);
            this.subcategoryField.TabIndex = 15;
            // 
            // label_subcategory
            // 
            this.label_subcategory.AutoSize = true;
            this.label_subcategory.BackColor = System.Drawing.Color.Transparent;
            this.label_subcategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_subcategory.ForeColor = System.Drawing.Color.Black;
            this.label_subcategory.Location = new System.Drawing.Point(13, 150);
            this.label_subcategory.Name = "label_subcategory";
            this.label_subcategory.Size = new System.Drawing.Size(119, 18);
            this.label_subcategory.TabIndex = 14;
            this.label_subcategory.Text = "Подкатегория";
            // 
            // label_category
            // 
            this.label_category.AutoSize = true;
            this.label_category.BackColor = System.Drawing.Color.Transparent;
            this.label_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_category.ForeColor = System.Drawing.Color.Black;
            this.label_category.Location = new System.Drawing.Point(13, 123);
            this.label_category.Name = "label_category";
            this.label_category.Size = new System.Drawing.Size(89, 18);
            this.label_category.TabIndex = 13;
            this.label_category.Text = "Категория";
            // 
            // fieldCategory
            // 
            this.fieldCategory.Enabled = false;
            this.fieldCategory.FormattingEnabled = true;
            this.fieldCategory.Items.AddRange(new object[] {
            "Детская литература",
            "Публицистика и периодика",
            "Художественная литература",
            "Научная литература",
            "Учебная литература"});
            this.fieldCategory.Location = new System.Drawing.Point(151, 120);
            this.fieldCategory.Name = "fieldCategory";
            this.fieldCategory.Size = new System.Drawing.Size(167, 21);
            this.fieldCategory.TabIndex = 12;
            // 
            // buttonChange
            // 
            this.buttonChange.BackColor = System.Drawing.Color.White;
            this.buttonChange.Location = new System.Drawing.Point(86, 316);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(75, 23);
            this.buttonChange.TabIndex = 10;
            this.buttonChange.Text = "Изменить";
            this.buttonChange.UseVisualStyleBackColor = false;
            this.buttonChange.Visible = false;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // nameField
            // 
            this.nameField.Enabled = false;
            this.nameField.Location = new System.Drawing.Point(151, 42);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(167, 20);
            this.nameField.TabIndex = 8;
            // 
            // authorField
            // 
            this.authorField.Enabled = false;
            this.authorField.Location = new System.Drawing.Point(151, 17);
            this.authorField.Name = "authorField";
            this.authorField.Size = new System.Drawing.Size(167, 20);
            this.authorField.TabIndex = 7;
            // 
            // label_yearPublish
            // 
            this.label_yearPublish.AutoSize = true;
            this.label_yearPublish.BackColor = System.Drawing.Color.Transparent;
            this.label_yearPublish.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_yearPublish.ForeColor = System.Drawing.Color.Black;
            this.label_yearPublish.Location = new System.Drawing.Point(13, 71);
            this.label_yearPublish.Name = "label_yearPublish";
            this.label_yearPublish.Size = new System.Drawing.Size(107, 18);
            this.label_yearPublish.TabIndex = 2;
            this.label_yearPublish.Text = "Год издания";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.BackColor = System.Drawing.Color.Transparent;
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_name.ForeColor = System.Drawing.Color.Black;
            this.label_name.Location = new System.Drawing.Point(13, 44);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(83, 18);
            this.label_name.TabIndex = 1;
            this.label_name.Text = "Название";
            // 
            // label_autor
            // 
            this.label_autor.AutoSize = true;
            this.label_autor.BackColor = System.Drawing.Color.Transparent;
            this.label_autor.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_autor.ForeColor = System.Drawing.Color.Black;
            this.label_autor.Location = new System.Drawing.Point(12, 18);
            this.label_autor.Name = "label_autor";
            this.label_autor.Size = new System.Drawing.Size(56, 19);
            this.label_autor.TabIndex = 0;
            this.label_autor.Text = "Автор";
            // 
            // button_addBook
            // 
            this.button_addBook.Location = new System.Drawing.Point(16, 50);
            this.button_addBook.Name = "button_addBook";
            this.button_addBook.Size = new System.Drawing.Size(206, 55);
            this.button_addBook.TabIndex = 3;
            this.button_addBook.Text = "Добавить книгу";
            this.button_addBook.UseVisualStyleBackColor = true;
            this.button_addBook.Click += new System.EventHandler(this.button_addBook_Click);
            // 
            // mainTable
            // 
            this.mainTable.AutoScroll = true;
            this.mainTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.mainTable.BackgroundImage = global::book_cataloger.Properties.Resources.Без_названия__1_;
            this.mainTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainTable.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mainTable.Location = new System.Drawing.Point(228, 52);
            this.mainTable.Name = "mainTable";
            this.mainTable.Size = new System.Drawing.Size(323, 353);
            this.mainTable.TabIndex = 5;
            // 
            // button_deleteBook
            // 
            this.button_deleteBook.Location = new System.Drawing.Point(16, 123);
            this.button_deleteBook.Name = "button_deleteBook";
            this.button_deleteBook.Size = new System.Drawing.Size(206, 55);
            this.button_deleteBook.TabIndex = 6;
            this.button_deleteBook.Text = "Удалить книгу";
            this.button_deleteBook.UseVisualStyleBackColor = true;
            this.button_deleteBook.Click += new System.EventHandler(this.button_deleteBook_Click);
            // 
            // button_editBook
            // 
            this.button_editBook.Location = new System.Drawing.Point(16, 199);
            this.button_editBook.Name = "button_editBook";
            this.button_editBook.Size = new System.Drawing.Size(206, 55);
            this.button_editBook.TabIndex = 7;
            this.button_editBook.Text = "Редактировать книгу";
            this.button_editBook.UseVisualStyleBackColor = true;
            this.button_editBook.Click += new System.EventHandler(this.button_editBook_Click);
            // 
            // button_SearchBook
            // 
            this.button_SearchBook.Location = new System.Drawing.Point(16, 271);
            this.button_SearchBook.Name = "button_SearchBook";
            this.button_SearchBook.Size = new System.Drawing.Size(206, 55);
            this.button_SearchBook.TabIndex = 8;
            this.button_SearchBook.Text = "Поиск";
            this.button_SearchBook.UseVisualStyleBackColor = true;
            this.button_SearchBook.Click += new System.EventHandler(this.button_SearchBook_Click);
            // 
            // button_backToView
            // 
            this.button_backToView.BackColor = System.Drawing.Color.White;
            this.button_backToView.Location = new System.Drawing.Point(408, 453);
            this.button_backToView.Name = "button_backToView";
            this.button_backToView.Size = new System.Drawing.Size(260, 53);
            this.button_backToView.TabIndex = 9;
            this.button_backToView.Text = "Вернуться к просмотру всех книг\r\n";
            this.button_backToView.UseVisualStyleBackColor = false;
            this.button_backToView.Visible = false;
            this.button_backToView.Click += new System.EventHandler(this.button_backToView_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(923, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItem
            // 
            this.ToolStripMenuItem.Name = "ToolStripMenuItem";
            this.ToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.ToolStripMenuItem.Text = "Язык";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::book_cataloger.Properties.Resources.covermainform3;
            this.ClientSize = new System.Drawing.Size(923, 537);
            this.Controls.Add(this.button_backToView);
            this.Controls.Add(this.button_SearchBook);
            this.Controls.Add(this.button_editBook);
            this.Controls.Add(this.button_deleteBook);
            this.Controls.Add(this.mainTable);
            this.Controls.Add(this.button_addBook);
            this.Controls.Add(this.informationTable);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(939, 576);
            this.Name = "MainForm";
            this.Text = "My Library";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.informationTable.ResumeLayout(false);
            this.informationTable.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel informationTable;
        private System.Windows.Forms.Label label_yearPublish;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_autor;
        private System.Windows.Forms.Button button_addBook;
        private System.Windows.Forms.FlowLayoutPanel mainTable;
        private System.Windows.Forms.Button button_deleteBook;
        private System.Windows.Forms.TextBox authorField;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.Button button_editBook;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.ComboBox fieldCategory;
        private System.Windows.Forms.ComboBox subcategoryField;
        private System.Windows.Forms.Label label_subcategory;
        private System.Windows.Forms.Label label_category;
        private System.Windows.Forms.TextBox publishingField;
        private System.Windows.Forms.Label label_publishingHouse;
        private System.Windows.Forms.Button buttonChoose;
        private System.Windows.Forms.Label label_choosePicture;
        private System.Windows.Forms.Button button_SearchBook;
        private System.Windows.Forms.Button button_backToView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem;
        private System.Windows.Forms.MaskedTextBox fieldYearPublication;
    }
}

