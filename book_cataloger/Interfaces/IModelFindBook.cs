using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_cataloger.Interfaces
{
    interface IModelFindBook
    {
        bool Flag { get; set; }
        List<Book> Books { get; set; }
        List<Book> FoundBooks { get; set; }
        void FindBooks(List<string> myList);
    }
}
