namespace book_cataloger.Views
{
    partial class FindBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindBookForm));
            this.label_search = new System.Windows.Forms.Label();
            this.label_autor = new System.Windows.Forms.Label();
            this.authorField = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.nameField = new System.Windows.Forms.TextBox();
            this.label_yearPublish = new System.Windows.Forms.Label();
            this.fieldYearPublication = new System.Windows.Forms.MaskedTextBox();
            this.label_publishingHouse = new System.Windows.Forms.Label();
            this.publishingField = new System.Windows.Forms.TextBox();
            this.label_category = new System.Windows.Forms.Label();
            this.fieldCategory = new System.Windows.Forms.ComboBox();
            this.label_subcategory = new System.Windows.Forms.Label();
            this.subcategoryField = new System.Windows.Forms.ComboBox();
            this.button_search = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_search
            // 
            this.label_search.AutoSize = true;
            this.label_search.BackColor = System.Drawing.Color.Transparent;
            this.label_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_search.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label_search.Location = new System.Drawing.Point(68, 9);
            this.label_search.Name = "label_search";
            this.label_search.Size = new System.Drawing.Size(725, 58);
            this.label_search.TabIndex = 0;
            this.label_search.Text = "Впишите данные по которым хотите осуществить поиск:\r\n\r\n";
            // 
            // label_autor
            // 
            this.label_autor.AutoSize = true;
            this.label_autor.BackColor = System.Drawing.Color.Transparent;
            this.label_autor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_autor.ForeColor = System.Drawing.Color.White;
            this.label_autor.Location = new System.Drawing.Point(165, 55);
            this.label_autor.Name = "label_autor";
            this.label_autor.Size = new System.Drawing.Size(81, 25);
            this.label_autor.TabIndex = 1;
            this.label_autor.Text = "автор:";
            // 
            // authorField
            // 
            this.authorField.Location = new System.Drawing.Point(389, 59);
            this.authorField.Name = "authorField";
            this.authorField.Size = new System.Drawing.Size(169, 20);
            this.authorField.TabIndex = 8;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.BackColor = System.Drawing.Color.Transparent;
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_name.ForeColor = System.Drawing.Color.White;
            this.label_name.Location = new System.Drawing.Point(165, 111);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(121, 25);
            this.label_name.TabIndex = 9;
            this.label_name.Text = "название:";
            // 
            // nameField
            // 
            this.nameField.Location = new System.Drawing.Point(389, 115);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(169, 20);
            this.nameField.TabIndex = 10;
            // 
            // label_yearPublish
            // 
            this.label_yearPublish.AutoSize = true;
            this.label_yearPublish.BackColor = System.Drawing.Color.Transparent;
            this.label_yearPublish.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_yearPublish.ForeColor = System.Drawing.Color.White;
            this.label_yearPublish.Location = new System.Drawing.Point(165, 163);
            this.label_yearPublish.Name = "label_yearPublish";
            this.label_yearPublish.Size = new System.Drawing.Size(150, 25);
            this.label_yearPublish.TabIndex = 11;
            this.label_yearPublish.Text = "год издания:";
            // 
            // fieldYearPublication
            // 
            this.fieldYearPublication.Location = new System.Drawing.Point(389, 167);
            this.fieldYearPublication.Mask = "0000";
            this.fieldYearPublication.Name = "fieldYearPublication";
            this.fieldYearPublication.Size = new System.Drawing.Size(169, 20);
            this.fieldYearPublication.TabIndex = 12;
            // 
            // label_publishingHouse
            // 
            this.label_publishingHouse.AutoSize = true;
            this.label_publishingHouse.BackColor = System.Drawing.Color.Transparent;
            this.label_publishingHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_publishingHouse.ForeColor = System.Drawing.Color.White;
            this.label_publishingHouse.Location = new System.Drawing.Point(165, 228);
            this.label_publishingHouse.Name = "label_publishingHouse";
            this.label_publishingHouse.Size = new System.Drawing.Size(170, 25);
            this.label_publishingHouse.TabIndex = 17;
            this.label_publishingHouse.Text = "Издательство:";
            // 
            // publishingField
            // 
            this.publishingField.Location = new System.Drawing.Point(389, 228);
            this.publishingField.Name = "publishingField";
            this.publishingField.Size = new System.Drawing.Size(169, 20);
            this.publishingField.TabIndex = 18;
            // 
            // label_category
            // 
            this.label_category.AutoSize = true;
            this.label_category.BackColor = System.Drawing.Color.Transparent;
            this.label_category.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_category.ForeColor = System.Drawing.Color.White;
            this.label_category.Location = new System.Drawing.Point(165, 287);
            this.label_category.Name = "label_category";
            this.label_category.Size = new System.Drawing.Size(131, 25);
            this.label_category.TabIndex = 19;
            this.label_category.Text = "Категория:";
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
            this.fieldCategory.Location = new System.Drawing.Point(389, 290);
            this.fieldCategory.Name = "fieldCategory";
            this.fieldCategory.Size = new System.Drawing.Size(169, 21);
            this.fieldCategory.TabIndex = 20;
            // 
            // label_subcategory
            // 
            this.label_subcategory.AutoSize = true;
            this.label_subcategory.BackColor = System.Drawing.Color.Transparent;
            this.label_subcategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_subcategory.ForeColor = System.Drawing.Color.White;
            this.label_subcategory.Location = new System.Drawing.Point(165, 346);
            this.label_subcategory.Name = "label_subcategory";
            this.label_subcategory.Size = new System.Drawing.Size(167, 25);
            this.label_subcategory.TabIndex = 21;
            this.label_subcategory.Text = "подкатегория:";
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
            this.subcategoryField.Location = new System.Drawing.Point(389, 349);
            this.subcategoryField.Name = "subcategoryField";
            this.subcategoryField.Size = new System.Drawing.Size(169, 21);
            this.subcategoryField.TabIndex = 22;
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(648, 167);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(145, 79);
            this.button_search.TabIndex = 23;
            this.button_search.Text = "Поиск";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(718, 346);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(75, 23);
            this.button_back.TabIndex = 24;
            this.button_back.Text = "назад";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // FindBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::book_cataloger.Properties.Resources.depositphotos_4784329_stock_photo_nice_room;
            this.ClientSize = new System.Drawing.Size(823, 413);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.subcategoryField);
            this.Controls.Add(this.label_subcategory);
            this.Controls.Add(this.fieldCategory);
            this.Controls.Add(this.label_category);
            this.Controls.Add(this.publishingField);
            this.Controls.Add(this.label_publishingHouse);
            this.Controls.Add(this.fieldYearPublication);
            this.Controls.Add(this.label_yearPublish);
            this.Controls.Add(this.nameField);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.authorField);
            this.Controls.Add(this.label_autor);
            this.Controls.Add(this.label_search);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(839, 496);
            this.Name = "FindBookForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_search;
        private System.Windows.Forms.Label label_autor;
        private System.Windows.Forms.TextBox authorField;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.Label label_yearPublish;
        private System.Windows.Forms.MaskedTextBox fieldYearPublication;
        private System.Windows.Forms.Label label_publishingHouse;
        private System.Windows.Forms.TextBox publishingField;
        private System.Windows.Forms.Label label_category;
        private System.Windows.Forms.ComboBox fieldCategory;
        private System.Windows.Forms.Label label_subcategory;
        private System.Windows.Forms.ComboBox subcategoryField;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Button button_back;
    }
}