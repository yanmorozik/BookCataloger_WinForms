using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using book_cataloger.Interfaces;

namespace book_cataloger
{
    public partial class MainForm : Form, IMainView
    {
        public string CurrentLanguage { get; set; }

        public event Action Add;
        public event Action Delete;
        public event Action EditingTextBoxes;
        public event Action EditingChooseBook;
        public event Action ChangePicture;
        public event Action Find;
        public event Action Back;
        public event Action LanguageChange;

        public MainForm()
        {
            InitializeComponent();
        }

        public new void Show()
        {
            Application.Run(this);
        }
        public string GetPath()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";
            dialog.InitialDirectory = @"D:\крутые обои\";
            dialog.Title = "Please select an image file.";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                return dialog.FileName;
            }
            return null;
        }
        public void ClearForm()
        {
            mainTable.Controls.Clear();
        }
        public void ClearTextBox()
        {
            authorField.Text = "";
            nameField.Text = "";
            fieldYearPublication.Text = "";
            publishingField.Text = "";
            fieldCategory.Text = "";
            subcategoryField.Text = "";
        }
        public void SetLanguage()
        {
            ToolStripMenuItem.Text = Properties.Resources.Language;
            label_autor.Text = Properties.Resources.Label_Autor;
            label_name.Text = Properties.Resources.Label_Name;
            label_yearPublish.Text = Properties.Resources.Label_YearPublication;
            label_publishingHouse.Text = Properties.Resources.Label_PublishinghHouse;
            label_category.Text = Properties.Resources.Label_Category;
            label_subcategory.Text = Properties.Resources.Label_Subcategory;
            label_choosePicture.Text = Properties.Resources.Label_ChoosePicture;
            buttonChoose.Text = Properties.Resources.Button_Choose;
            buttonChange.Text = Properties.Resources.Button_Change;
            button_backToView.Text = Properties.Resources.Button_BackToView;
            button_addBook.Text = Properties.Resources.Button_AddBook;
            button_deleteBook.Text = Properties.Resources.Button_DeleteBook;
            button_editBook.Text = Properties.Resources.Button_EditBook;
            button_SearchBook.Text = Properties.Resources.Button_SearchBook;
            fieldCategory.Items[0] = Properties.Resources.TextBoxItem_ChildrenLiterature;
            fieldCategory.Items[1] = Properties.Resources.TextBoxItem_Journalism_Periodicals;
            fieldCategory.Items[2] = Properties.Resources.TextBoxItem_Fiction;
            fieldCategory.Items[3] = Properties.Resources.TextBoxItem_ScientificLiterature;
            fieldCategory.Items[4] = Properties.Resources.TextBoxItem_EducationalLiterature;
            subcategoryField.Items[0] = Properties.Resources.TextBox_2Item_Detectives;
            subcategoryField.Items[1] = Properties.Resources.TextBox_2Item_Fantasy;
            subcategoryField.Items[2] = Properties.Resources.TextBox_2Item_Comics_Manga;
            subcategoryField.Items[3] = Properties.Resources.TextBox_2Item_RomanceNovels;
            subcategoryField.Items[4] = Properties.Resources.TextBox_2Item_Poetry;
            subcategoryField.Items[5] = Properties.Resources.TextBox_2Item_Adventure;
            subcategoryField.Items[6] = Properties.Resources.TextBox_2Item_Prose;
            subcategoryField.Items[7] = Properties.Resources.TextBox_2Item_Thrillers;
            subcategoryField.Items[8] = Properties.Resources.TextBox_2Item_Horror;
        }
        public bool DataChecking()
        {
            if (authorField.Text == "" || nameField.Text == "" || publishingField.Text == "" || fieldCategory.Text == "" || subcategoryField.Text == "" || fieldYearPublication.Text == "")
            {
                return true;
            }
            return false;
        }
        public void OpenInterface()
        {
            mainTable.Enabled = true;
            button_addBook.Enabled = true;
            button_deleteBook.Enabled = true;
            button_editBook.Enabled = true;
            button_SearchBook.Enabled = true;
        }
        public void OpenMainTable()
        {
            mainTable.Enabled = true;
        }
        public void CloseInterface()
        {
            mainTable.Enabled = false;
            button_addBook.Enabled = false;
            button_deleteBook.Enabled = false;
            button_editBook.Enabled = false;
            button_SearchBook.Enabled = false;
        }
        public bool BookIsSelected()
        {
            if (nameField.Text == "")
            {
                return false;
            }
            return true;
        }
        public void OpenItemsForEdit()
        {
            authorField.Enabled = true;
            nameField.Enabled = true;
            fieldYearPublication.Enabled = true;
            publishingField.Enabled = true;
            fieldCategory.Enabled = true;
            subcategoryField.Enabled = true;
            buttonChange.Visible = true;
            buttonChoose.Visible = true;
            label_choosePicture.Visible = true;
        }
        public void СloseItemsForEdit()
        {
            authorField.Enabled = false;
            nameField.Enabled = false;
            fieldYearPublication.Enabled = false;
            publishingField.Enabled = false;
            fieldCategory.Enabled = false;
            subcategoryField.Enabled = false;
            buttonChange.Visible = false;
            label_choosePicture.Visible = false;
            buttonChoose.Visible = false;
        }
        public void AddButton_BackToView()
        {
            button_backToView.Visible = true;
        }
        public void HideButton_BackToView()
        {
            button_backToView.Visible = false;
        }
        public string GetUnnecessaryBook()
        {
            string name = nameField.Text;
            return name;
        }
        public void AddBookToForm(Book book)
        {
            var pictuteBox = new PictureBox
            {
                Image = Image.FromFile(book.PathPicture),
                Size = new Size(70, 65),
                SizeMode = PictureBoxSizeMode.StretchImage
            };
            pictuteBox.Click += (sender, e) => SetBookInfo(book, pictuteBox);
            mainTable.Controls.Add(pictuteBox);
        }
        public List<string> GetUnchangedData()
        {
            var myList = new List<string>();
            myList.Add(authorField.Text);
            myList.Add(nameField.Text);
            myList.Add(fieldYearPublication.Text);
            myList.Add(publishingField.Text);
            myList.Add(fieldCategory.Text);
            myList.Add(subcategoryField.Text);
            return myList;
        }
        public void ShowMessageBox(string message)
        {
            MessageBox.Show(message);
        }
        public void SetLanguages(List<string> languages)
        {
            foreach (var item in languages)
            {
                var toolStripMenuItem = new ToolStripMenuItem
                {
                    Name = item + "ToolStripMenuItem",
                    Size = new Size(180, 22),
                    Text = item
                };
                toolStripMenuItem.Click += new EventHandler(LanguageChanged_Click);

                this.ToolStripMenuItem.DropDownItems.Add(toolStripMenuItem);
            }
            CurrentLanguage = languages[0];
        }
        public void SetBookInfo(Book book,PictureBox pictureBox)
        {
            foreach (var item in mainTable.Controls)
            {
                if (((PictureBox)item).BorderStyle == BorderStyle.Fixed3D)
                {
                    ((PictureBox)item).BorderStyle = BorderStyle.None;
                }
            }
            pictureBox.BorderStyle = BorderStyle.Fixed3D;
            authorField.Text = book.Author;
            nameField.Text = book.Name;
            fieldYearPublication.Text = book.YearPublish.ToString();
            publishingField.Text = book.PublishingHouse;
            fieldCategory.Text = book.Category;
            subcategoryField.Text = book.SubCategory;  
        }
        public List<string> GetDataForEditingBook(Book unchangingBook, List<Book> books, string path)
        {
            var myList = new List<string>();
            foreach (var book in books)
            {
                if (unchangingBook.Name == book.Name)
                {
                    myList.Add(authorField.Text);
                    myList.Add(nameField.Text);
                    myList.Add(fieldYearPublication.Text);
                    myList.Add(publishingField.Text);
                    myList.Add(fieldCategory.Text);
                    myList.Add(subcategoryField.Text);
                    myList.Add(path);
                    break;
                }
            }
            return myList;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void LanguageChanged_Click(object sender, EventArgs e)
        {
            if (sender is ToolStripMenuItem)
            {
                ToolStripMenuItem item = (ToolStripMenuItem)sender;

                string PreLanguage = CurrentLanguage;
                CurrentLanguage = item.Text;

                if (PreLanguage != CurrentLanguage)
                {
                    LanguageChange?.Invoke();
                }
            }
        }
        private void button_addBook_Click(object sender, EventArgs e)
        {
            Add?.Invoke();
        }
        private void button_deleteBook_Click(object sender, EventArgs e)
        {
            Delete?.Invoke();
        }
        private void button_editBook_Click(object sender, EventArgs e)
        {
            EditingTextBoxes?.Invoke();
        }
        private void buttonChange_Click(object sender, EventArgs e)
        {
            EditingChooseBook?.Invoke();
        }
        private void buttonChoose_Click(object sender, EventArgs e)
        {
            ChangePicture?.Invoke();
        }
        private void button_SearchBook_Click(object sender, EventArgs e)
        {
            Find?.Invoke();
        }
        private void button_backToView_Click(object sender, EventArgs e)
        {
            Back?.Invoke();
        }
    }
}
