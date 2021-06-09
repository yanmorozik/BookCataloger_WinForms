using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_cataloger.Interfaces
{
    interface IModelAddBook
    {
        List<Book> Books { get; set; }
        Book SetBookInfo(List<string> myList);
        void AddToList(Book book);
        string AddStandartPicture();
    }
}
