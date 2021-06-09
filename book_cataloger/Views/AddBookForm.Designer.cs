namespace book_cataloger
{
    partial class AddBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBookForm));
            this.label_enterAuthor = new System.Windows.Forms.Label();
            this.label_enterName = new System.Windows.Forms.Label();
            this.label_enterYearPublishing = new System.Windows.Forms.Label();
            this.label_addCoverImage = new System.Windows.Forms.Label();
            this.authorField = new System.Windows.Forms.TextBox();
            this.nameField = new System.Windows.Forms.TextBox();
            this.button_addPicture = new System.Windows.Forms.Button();
            this.button_addBook = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.label_enterPublishingHouse = new System.Windows.Forms.Label();
            this.fieldYearPublication = new System.Windows.Forms.MaskedTextBox();
            this.publishingField = new System.Windows.Forms.TextBox();
            this.fieldCategory = new System.Windows.Forms.ComboBox();
            this.label_enterCategory = new System.Windows.Forms.Label();
            this.label_enterSubcategory = new System.Windows.Forms.Label();
            this.subcategoryField = new System.Windows.Forms.ComboBox();
            this.label_note = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_enterAuthor
            // 
            this.label_enterAuthor.AutoSize = true;
            this.label_enterAuthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label_enterAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_enterAuthor.ForeColor = System.Drawing.Color.Red;
            this.label_enterAuthor.Location = new System.Drawing.Point(67, 27);
            this.label_enterAuthor.Name = "label_enterAuthor";
            this.label_enterAuthor.Size = new System.Drawing.Size(153, 20);
            this.label_enterAuthor.TabIndex = 0;
            this.label_enterAuthor.Text = "Введите автора:";
            // 
            // label_enterName
            // 
            this.label_enterName.AutoSize = true;
            this.label_enterName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label_enterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_enterName.ForeColor = System.Drawing.Color.Red;
            this.label_enterName.Location = new System.Drawing.Point(67, 65);
            this.label_enterName.Name = "label_enterName";
            this.label_enterName.Size = new System.Drawing.Size(224, 20);
            this.label_enterName.TabIndex = 1;
            this.label_enterName.Text = "Введите название книги:";
            // 
            // label_enterYearPublishing
            // 
            this.label_enterYearPublishing.AutoSize = true;
            this.label_enterYearPublishing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label_enterYearPublishing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_enterYearPublishing.ForeColor = System.Drawing.Color.Red;
            this.label_enterYearPublishing.Location = new System.Drawing.Point(67, 104);
            this.label_enterYearPublishing.Name = "label_enterYearPublishing";
            this.label_enterYearPublishing.Size = new System.Drawing.Size(199, 20);
            this.label_enterYearPublishing.TabIndex = 2;
            this.label_enterYearPublishing.Text = "Введите год издания:";
            // 
            // label_addCoverImage
            // 
            this.label_addCoverImage.AutoSize = true;
            this.label_addCoverImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label_addCoverImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_addCoverImage.ForeColor = System.Drawing.Color.Red;
            this.label_addCoverImage.Location = new System.Drawing.Point(67, 270);
            this.label_addCoverImage.Name = "label_addCoverImage";
            this.label_addCoverImage.Size = new System.Drawing.Size(224, 20);
            this.label_addCoverImage.TabIndex = 3;
            this.label_addCoverImage.Text = "Добавить обложку книги:";
            // 
            // authorField
            // 
            this.authorField.Location = new System.Drawing.Point(336, 27);
            this.authorField.Name = "authorField";
            this.authorField.Size = new System.Drawing.Size(180, 20);
            this.authorField.TabIndex = 4;
            // 
            // nameField
            // 
            this.nameField.Location = new System.Drawing.Point(336, 65);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(180, 20);
            this.nameField.TabIndex = 5;
            // 
            // button_addPicture
            // 
            this.button_addPicture.Location = new System.Drawing.Point(336, 270);
            this.button_addPicture.Name = "button_addPicture";
            this.button_addPicture.Size = new System.Drawing.Size(74, 20);
            this.button_addPicture.TabIndex = 7;
            this.button_addPicture.Text = "Добавить";
            this.button_addPicture.UseVisualStyleBackColor = true;
            this.button_addPicture.Click += new System.EventHandler(this.button_addPicture_Click);
            // 
            // button_addBook
            // 
            this.button_addBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button_addBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_addBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_addBook.Location = new System.Drawing.Point(244, 317);
            this.button_addBook.Name = "button_addBook";
            this.button_addBook.Size = new System.Drawing.Size(208, 63);
            this.button_addBook.TabIndex = 8;
            this.button_addBook.Text = "Добавить книгу";
            this.button_addBook.UseVisualStyleBackColor = false;
            this.button_addBook.Click += new System.EventHandler(this.button_addBook_Click);
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(559, 334);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(94, 20);
            this.button_back.TabIndex = 9;
            this.button_back.Text = "Отмена";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // label_enterPublishingHouse
            // 
            this.label_enterPublishingHouse.AutoSize = true;
            this.label_enterPublishingHouse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label_enterPublishingHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_enterPublishingHouse.ForeColor = System.Drawing.Color.Red;
            this.label_enterPublishingHouse.Location = new System.Drawing.Point(67, 142);
            this.label_enterPublishingHouse.Name = "label_enterPublishingHouse";
            this.label_enterPublishingHouse.Size = new System.Drawing.Size(209, 20);
            this.label_enterPublishingHouse.TabIndex = 10;
            this.label_enterPublishingHouse.Text = "Введите издательство";
            // 
            // fieldYearPublication
            // 
            this.fieldYearPublication.Location = new System.Drawing.Point(336, 104);
            this.fieldYearPublication.Mask = "0000";
            this.fieldYearPublication.Name = "fieldYearPublication";
            this.fieldYearPublication.Size = new System.Drawing.Size(180, 20);
            this.fieldYearPublication.TabIndex = 11;
            // 
            // publishingField
            // 
            this.publishingField.Location = new System.Drawing.Point(336, 142);
            this.publishingField.Name = "publishingField";
            this.publishingField.Size = new System.Drawing.Size(180, 20);
            this.publishingField.TabIndex = 12;
            // 
            // fieldCategory
            // 
            this.fieldCategory.FormattingEnabled = true;
            this.fieldCategory.Items.AddRange(new object[] {
            "Детская литература",
            "Публицистика и периодика",
            "Художественная литература",
            "Научная литература",
            "Учебная литература"});
            this.fieldCategory.Location = new System.Drawing.Point(336, 180);
            this.fieldCategory.Name = "fieldCategory";
            this.fieldCategory.Size = new System.Drawing.Size(180, 21);
            this.fieldCategory.TabIndex = 13;
            // 
            // label_enterCategory
            // 
            this.label_enterCategory.AutoSize = true;
            this.label_enterCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label_enterCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_enterCategory.ForeColor = System.Drawing.Color.Red;
            this.label_enterCategory.Location = new System.Drawing.Point(67, 181);
            this.label_enterCategory.Name = "label_enterCategory";
            this.label_enterCategory.Size = new System.Drawing.Size(188, 20);
            this.label_enterCategory.TabIndex = 14;
            this.label_enterCategory.Text = "Выберите категорию";
            // 
            // label_enterSubcategory
            // 
            this.label_enterSubcategory.AutoSize = true;
            this.label_enterSubcategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label_enterSubcategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_enterSubcategory.ForeColor = System.Drawing.Color.Red;
            this.label_enterSubcategory.Location = new System.Drawing.Point(67, 220);
            this.label_enterSubcategory.Name = "label_enterSubcategory";
            this.label_enterSubcategory.Size = new System.Drawing.Size(220, 20);
            this.label_enterSubcategory.TabIndex = 15;
            this.label_enterSubcategory.Text = "Выберите подкатегорию";
            // 
            // subcategoryField
            // 
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
            this.subcategoryField.Location = new System.Drawing.Point(336, 219);
            this.subcategoryField.Name = "subcategoryField";
            this.subcategoryField.Size = new System.Drawing.Size(180, 21);
            this.subcategoryField.TabIndex = 16;
            // 
            // label_note
            // 
            this.label_note.BackColor = System.Drawing.Color.Transparent;
            this.label_note.ForeColor = System.Drawing.Color.Black;
            this.label_note.Location = new System.Drawing.Point(170, 293);
            this.label_note.Name = "label_note";
            this.label_note.Size = new System.Drawing.Size(346, 21);
            this.label_note.TabIndex = 17;
            this.label_note.Text = "(если картинка не выбрана, ставиться картинка по умолчанию)\r\n\r\n\r\n\r\n";
            // 
            // AddBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::book_cataloger.Properties.Resources.coverAddBook;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(676, 389);
            this.Controls.Add(this.label_note);
            this.Controls.Add(this.subcategoryField);
            this.Controls.Add(this.label_enterSubcategory);
            this.Controls.Add(this.label_enterCategory);
            this.Controls.Add(this.fieldCategory);
            this.Controls.Add(this.publishingField);
            this.Controls.Add(this.fieldYearPublication);
            this.Controls.Add(this.label_enterPublishingHouse);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_addBook);
            this.Controls.Add(this.button_addPicture);
            this.Controls.Add(this.nameField);
            this.Controls.Add(this.authorField);
            this.Controls.Add(this.label_addCoverImage);
            this.Controls.Add(this.label_enterYearPublishing);
            this.Controls.Add(this.label_enterName);
            this.Controls.Add(this.label_enterAuthor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(692, 428);
            this.Name = "AddBookForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_enterAuthor;
        private System.Windows.Forms.Label label_enterName;
        private System.Windows.Forms.Label label_enterYearPublishing;
        private System.Windows.Forms.Label label_addCoverImage;
        private System.Windows.Forms.TextBox authorField;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.Button button_addPicture;
        private System.Windows.Forms.Button button_addBook;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Label label_enterPublishingHouse;
        private System.Windows.Forms.MaskedTextBox fieldYearPublication;
        private System.Windows.Forms.TextBox publishingField;
        private System.Windows.Forms.ComboBox fieldCategory;
        private System.Windows.Forms.Label label_enterCategory;
        private System.Windows.Forms.Label label_enterSubcategory;
        private System.Windows.Forms.ComboBox subcategoryField;
        private System.Windows.Forms.Label label_note;
    }
}