using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_cataloger
{
    [Serializable]
    public class Book
    {
        private string author;
        private string name;
        private string publishingHouse;
        private string category;
        private string subCategory;
        private int yearPublish;
        public string Author
        {
            get
            {
                return author;
            }
            set
            {
                if (!char.IsUpper(value[0]))
                {
                    throw new ArgumentException();
                }
                else
                {
                    author = value;
                }
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (!char.IsUpper(value[0]))
                {
                    throw new ArgumentException();
                }
                else
                {
                    name = value;
                }
            }
        }
        public int YearPublish
        {
            get
            {
                return yearPublish;
            }
            set
            {
                if (value>2020)
                {
                    throw new ArgumentException();
                }
                else
                {
                    yearPublish = value;
                }
            }
        }
        public string PublishingHouse
        {
            get
            {
                return publishingHouse;
            }
            set
            {
                if (!char.IsUpper(value[0]))
                {
                    throw new ArgumentException();
                }
                else
                {
                    publishingHouse = value;
                }

            }
        }
        public string PathPicture { get; set; }
        public string Category
        {
            get
            {
                return category;
            }
            set
            {
                if (!char.IsUpper(value[0]))
                {
                    throw new ArgumentException();
                }
                else
                {
                    category = value;
                }
            }
        }
        public string SubCategory
        {
            get
            {
                return subCategory;
            }
            set
            {
                if (!char.IsUpper(value[0]))
                {
                    throw new ArgumentException();
                }
                else
                {
                    subCategory = value;
                }
            }
        }

        public Book()
        {

        }
    }
}
