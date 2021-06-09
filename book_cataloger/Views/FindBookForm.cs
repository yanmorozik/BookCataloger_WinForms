using book_cataloger.Interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace book_cataloger.Views
{
    public partial class FindBookForm : Form, IViewFindBook
    {
        public event Action Find;
        public FindBookForm()
        {
            InitializeComponent();
        }
        public new void Show()
        {
            ShowDialog();
        }
        public void SetLanguage()
        {
            label_autor.Text = Properties.Resources.Label_Autor;
            label_name.Text = Properties.Resources.Label_Name;
            label_yearPublish.Text = Properties.Resources.Label_YearPublication;
            label_publishingHouse.Text = Properties.Resources.Label_PublishinghHouse;
            label_category.Text = Properties.Resources.Label_Category;
            label_subcategory.Text = Properties.Resources.Label_Subcategory;
            label_search.Text = Properties.Resources.Label_SearchTitle;
            button_search.Text = Properties.Resources.Button_Search;
            button_back.Text = Properties.Resources.Button_Back;
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
        public List<string> GetListBook()
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
        private void button_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button_search_Click(object sender, EventArgs e)
        {
            Find?.Invoke();
            this.Hide();
        }
    }
}