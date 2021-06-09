using book_cataloger.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace book_cataloger
{
    public partial class AddBookForm : Form, IViewAddBook
    {
        public event Action AddChooseBook;
        public event Action SetBookPath;

        public AddBookForm()
        {
            InitializeComponent();
        }
        public void SetLanguage()
        {
            label_enterAuthor.Text = Properties.Resources.Label_EnterAutor;
            label_enterName.Text = Properties.Resources.Label_EnterName;
            label_enterYearPublishing.Text = Properties.Resources.Label_EnterYearPublishing;
            label_enterPublishingHouse.Text = Properties.Resources.Label_EnterPublishinghHouse;
            label_enterCategory.Text = Properties.Resources.Label_ChooseCategory;
            label_enterSubcategory.Text = Properties.Resources.Label_ChooseSubcategory;
            label_addCoverImage.Text = Properties.Resources.Label_AddCoverBook;
            button_addPicture.Text = Properties.Resources.Button_Add;
            button_addBook.Text = Properties.Resources.Button_AddBook;
            button_back.Text = Properties.Resources.Button_Back;
            label_note.Text = Properties.Resources.Label_Note;
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
            else
            {
                throw new Exception();
            }
        }
        public List<string> GetBookInfo(string path)
        {
            var myList = new List<string>();
            myList.Add(authorField.Text);
            myList.Add(nameField.Text);
            myList.Add(fieldYearPublication.Text);
            myList.Add(publishingField.Text);
            myList.Add(fieldCategory.Text);
            myList.Add(subcategoryField.Text);
            myList.Add(path);
            return myList;
        }
        public new void Show()
        {
            ShowDialog();
        }
        public bool DataChecking()
        {
            if (authorField.Text == "" || nameField.Text == "" || publishingField.Text == "" || fieldCategory.Text == "" || subcategoryField.Text == "" || fieldYearPublication.Text == "")
            {
                return true;
            }
            return false;
        }
        public void ShowMessageBox(string message)
        {
            MessageBox.Show(message);
        }
        public void HideForm()
        {
            this.Hide();
        }

        private void button_addBook_Click(object sender, EventArgs e)
        {
            AddChooseBook?.Invoke();
        }
        private void button_addPicture_Click(object sender, EventArgs e)
        {
            SetBookPath?.Invoke();
        }
        private void button_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
