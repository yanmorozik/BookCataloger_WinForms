using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_cataloger.Interfaces
{
    interface IMainView
    {
        string CurrentLanguage { get; }

        event Action Add;
        event Action Delete;
        event Action EditingTextBoxes;
        event Action EditingChooseBook;
        event Action ChangePicture;
        event Action Find;
        event Action Back;
        event Action LanguageChange;
        void Show();
        void ClearForm();
        string GetPath();
        void SetLanguage();
        void ClearTextBox();
        bool DataChecking();
        void OpenMainTable();
        void OpenInterface();
        void CloseInterface();
        bool BookIsSelected();
        void OpenItemsForEdit();
        void СloseItemsForEdit();
        void AddButton_BackToView();
        void HideButton_BackToView();
        string GetUnnecessaryBook();
        void AddBookToForm(Book book);
        List<string> GetUnchangedData();
        void ShowMessageBox(string message);
        void SetLanguages(List<string> languages);
        void SetBookInfo(Book book, System.Windows.Forms.PictureBox pictureBox);
        List<string> GetDataForEditingBook(Book unchangingBook, List<Book> books, string path);
    }
}
