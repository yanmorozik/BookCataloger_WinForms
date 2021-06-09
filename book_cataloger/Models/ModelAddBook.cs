using book_cataloger.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_cataloger
{
    class ModelAddBook : IModelAddBook
    {
        public List<Book> Books { get; set; }
        public ModelAddBook(List<Book> books)
        {
            Books = books;
        }
        public void AddToList(Book book)
        {
            Books.Add(book);
        }
        public Book SetBookInfo(List<string> myList)
        {
            Book book = new Book();
            book.Author = myList[0];
            book.Name = myList[1];
            book.YearPublish = int.Parse(myList[2]);
            book.PublishingHouse = myList[3];
            book.Category = myList[4];
            book.SubCategory = myList[5];
            book.PathPicture = myList[6];
            return book;
        }
        public string AddStandartPicture()
        {
            return @"C:\Users\User\Desktop\cover books\standartbook.jpg";
        }
    }
}
