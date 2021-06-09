using book_cataloger.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_cataloger.Models
{
    class ModelFindBook : IModelFindBook
    {
        public bool Flag { get; set; }
        public List<Book> FoundBooks { get; set; } = new List<Book>();
        public List<Book> Books { get ; set ; }
        public ModelFindBook(List<Book> books, List<Book> findBooks)
        {
            Books = books;
            FoundBooks = findBooks;
        }
        public void FindBooks(List<string> myList)
        {
            List<Book> newList = new List<Book>();
            newList.AddRange(Books);
            FoundBooks.Clear();
            if (myList[0] != "")
            {
                newList = newList.FindAll(bk => bk.Author.ToLower().Contains(myList[0].ToLower()));
            }
            if (myList[1] != "")
            {
                newList = newList.FindAll(bk => bk.Name.ToLower().Contains(myList[1].ToLower()));
            }
            if (myList[2] != "")
            {
                newList = newList.FindAll(bk => bk.YearPublish == int.Parse(myList[2]));
            }
            if (myList[3] != "")
            {
                newList = newList.FindAll(bk => bk.PublishingHouse.ToLower().Contains(myList[3].ToLower()));
            }
            if (myList[4] != "")
            {
                newList = newList.FindAll(bk => bk.Category.ToLower().Contains(myList[4].ToLower()));
            }
            if (myList[5] != "")
            {
                newList = newList.FindAll(bk => bk.SubCategory.ToLower().Contains(myList[5].ToLower()));
            }
            FoundBooks.AddRange(newList);
        }
    }
}
