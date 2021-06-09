using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_cataloger.Interfaces
{
    interface IMainModel
    {
        List<CultureInfo> Cultures { get; }
        List<Book> FindBooks { get; set; }
        List<string> Languages { get; }
        List<Book> Books { get; set; }
        string Path1 { get; set; }
        string Path2 { get; set; }

        void GetAllBooks();
        void SetLanguages();
        void RecordAllBooks(string path,List<Book> myList);
        string SetUnchangedPath(Book book);
        bool ChangeLanguage(string language);
        Book SetUnchangedData(List<string> info);
        void RemoveUnnecessaryBook(string nameUnnecessaryBook);
        void EditingBook(Book unchangingBook, List<string> myList);
    }
}
