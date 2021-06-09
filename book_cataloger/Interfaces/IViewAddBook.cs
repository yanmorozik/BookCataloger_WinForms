using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_cataloger.Interfaces
{
    interface IViewAddBook
    {
        event Action AddChooseBook;
        event Action SetBookPath;

        void Show();
        void HideForm();
        string GetPath();
        void SetLanguage();
        bool DataChecking();
        void ShowMessageBox(string message);
        List<string> GetBookInfo(string Path);
    }
}
