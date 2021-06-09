using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using book_cataloger.Interfaces;
using book_cataloger.Models;
using book_cataloger.Views;

namespace book_cataloger.Presenters
{
    class PresenterMain
    {
        private readonly IMainView View;
        private readonly IMainModel Model;

        public Book UnchangedBook { get; set; }
        public string UnchangedPath { get; set; }
        public PresenterMain(IMainView View, IMainModel Model)
        {
            this.View = View;
            this.Model = Model;
            Model.GetAllBooks();

            foreach (var book in Model.Books)
            {
                View.AddBookToForm(book);
            }

            this.View.Add += () => AddBook();
            this.View.Find += () => FindBooks();
            this.View.Delete += () => DeleteBook();
            this.View.Back += () => ReviewAllBooks();
            this.View.ChangePicture += () => ChangePicture();
            this.View.EditingTextBoxes += () => EditingTextBoxes();
            this.View.EditingChooseBook += () => EditingBook(UnchangedBook, UnchangedPath);
            this.View.LanguageChange += () => ChangeLanguage(this.View.CurrentLanguage);

            SetLanguages();
        }
        private void AddBook()
        {
            View.ClearTextBox();
            PresenterAddBook prM = new PresenterAddBook(new AddBookForm(), new ModelAddBook(Model.Books));
            prM.Run();
            View.ClearForm();
            foreach (var book in Model.Books)
            {
                View.AddBookToForm(book);
            }
            Model.RecordAllBooks(Model.Path1,Model.Books);
        }
        private void DeleteBook()
        {
            if (View.BookIsSelected())
            {
                Model.RemoveUnnecessaryBook(View.GetUnnecessaryBook());
                View.ClearForm();
                foreach (var book in Model.Books)
                {
                    View.AddBookToForm(book);
                }
                Model.RecordAllBooks(Model.Path1,Model.Books);
            }
            else
            {
                View.ShowMessageBox(Properties.Resources.MessageChooseBook);
            }
            View.ClearTextBox();
        }
        private void EditingTextBoxes()
        {
            if (View.BookIsSelected())
            {
                View.CloseInterface();
                View.OpenItemsForEdit();

                UnchangedBook = Model.SetUnchangedData(View.GetUnchangedData());
                UnchangedPath = Model.SetUnchangedPath(UnchangedBook);
            }
            else
            {
                View.ShowMessageBox(Properties.Resources.MessageChooseBook);
            }
        }
        private void EditingBook(Book book, string path)
        {
            if (View.DataChecking())
            {
                View.ShowMessageBox(Properties.Resources.MessageFillAllFields);
            }
            else
            {
                try
                {
                    Model.EditingBook(book, View.GetDataForEditingBook(book, Model.Books, path));

                    View.СloseItemsForEdit();
                    View.ClearForm();

                    foreach (var books in Model.Books)
                    {
                        View.AddBookToForm(books);
                    }
                    Model.RecordAllBooks(Model.Path1, Model.Books);
                    View.OpenInterface();
                }
                catch (Exception)
                {
                    View.ShowMessageBox(Properties.Resources.MessageNotCapitalLetter);
                }
            }
        }
        private void FindBooks()
        {
            View.ClearTextBox();
            PresenterFindBook prF = new PresenterFindBook(new FindBookForm(), new ModelFindBook(Model.Books, Model.FindBooks));
            if (prF.Run())
            {
                View.CloseInterface();
                View.AddButton_BackToView();
                View.OpenMainTable();
                View.ClearForm();

                foreach (var book in Model.FindBooks)
                {
                    View.AddBookToForm(book);
                }
                Model.RecordAllBooks(Model.Path2,Model.FindBooks);
            }
            else
            {
                View.ClearForm();
                foreach (var book in Model.FindBooks)
                {
                    View.AddBookToForm(book);
                }
            }
        }
        private void ReviewAllBooks()
        {
            View.OpenInterface();
            View.ClearForm();

            foreach (var book in Model.Books)
            {
                View.AddBookToForm(book);
            }
            View.HideButton_BackToView();
            View.ClearTextBox();
        }
        private void ChangePicture()
        {
            UnchangedPath = View.GetPath();
        }
        private void SetLanguages()
        {
            Model.SetLanguages();
            View.SetLanguages(Model.Languages);
            View.SetLanguage();
        }
        private void ChangeLanguage(string language)
        {
            if (Model.ChangeLanguage(language))
            {
                View.SetLanguage();
            }
        }
        public void Run()
        {
            View.Show();
        }
    }
}