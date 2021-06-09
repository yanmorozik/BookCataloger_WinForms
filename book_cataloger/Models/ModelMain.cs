using book_cataloger.Interfaces;
using book_cataloger.Views;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_cataloger.Models
{
    class ModelMain : IMainModel
    {        
        public string Path1 { get; set; } = @"C:\Users\User\Desktop\Book_cataloger\book_cataloger\dataFile.xml";
        public string Path2 { get; set; } = @"C:\Users\User\Desktop\Book_cataloger\book_cataloger\dataFile2.xml";
        public List<Book> Books { get; set; } = new List<Book>();
        public List<Book> FindBooks { get; set; } = new List<Book>();
        public List<CultureInfo> Cultures { get; set; }
        public List<String> Languages { get; set; }

        public void GetAllBooks()
        {
            Books = SerializableFile.ReadFile(Path1);
        }
        public void SetLanguages()
        {
            var cultures = Language.GetAvailableCultures();
            var languages = Language.GetAvailableLanguages(cultures);
            Language.SetCurrent(cultures[0]);

            this.Languages = languages;
            this.Cultures = cultures;
        }
        public void RecordAllBooks(string path,List<Book> myList)
        {
            SerializableFile.WriteFile(myList, path);
        }
        public bool ChangeLanguage(string language)
        {
            if (Languages.Contains(language))
            {
                Language.SetCurrent(Cultures[Languages.IndexOf(language)]);
                return true;
            }
            return false;
        }
        public Book SetUnchangedData(List<string> myList)
        {
            Book book = new Book();
            book.Author = myList[0];
            book.Name = myList[1];
            book.YearPublish = int.Parse(myList[2]);
            book.PublishingHouse = myList[3];
            book.Category = myList[4];
            book.SubCategory = myList[5];
            return book;
        }
        public string SetUnchangedPath(Book UnchangedBook)
        {
            foreach (var book in Books)
            {
                if (book.Name == UnchangedBook.Name)
                {
                    return book.PathPicture;
                }
            }
            return null;

        }
        public void RemoveUnnecessaryBook(string nameUnnecessaryBook)
        {
            foreach (var book in Books)
            {
                if (nameUnnecessaryBook == book.Name)
                {
                    Books.Remove(book);
                    break;
                }
            }
        }
        public void EditingBook(Book unchangedBook, List<string> myList)
        {
            foreach (var book in Books)
            {
                if (book.Name == unchangedBook.Name)
                {
                    book.Author = myList[0];
                    book.Name = myList[1];
                    book.YearPublish = int.Parse(myList[2]);
                    book.PublishingHouse = myList[3];
                    book.Category = myList[4];
                    book.SubCategory = myList[5];
                    book.PathPicture = myList[6];
                }
            }
        }
    }
}
