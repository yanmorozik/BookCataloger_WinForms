using book_cataloger.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;   //так можно?

namespace book_cataloger.Presenters
{
    class PresenterAddBook
    {
        public string Path { get; set; }

        private readonly IViewAddBook View;
        private readonly IModelAddBook Model;

        public PresenterAddBook(IViewAddBook View, IModelAddBook Model)
        {
            this.View = View;
            this.Model = Model;

            this.View.SetBookPath += () => SetBookPath();      
            this.View.AddChooseBook += () => AddBook();
            View.SetLanguage();
        }

        public void SetBookPath()
        {
            try
            {
                Path = View.GetPath();
            }
            catch (Exception)
            {
                View.ShowMessageBox(Properties.Resources.MessageError);
            }
        }
        public void AddBook()
        {
            bool flag;
            if (View.DataChecking())
            {
                View.ShowMessageBox(Properties.Resources.MessageFillAllFields);
                flag = false;
            }
            else
            {
                try
                {
                    if (Path==null)
                    {
                        Path = Model.AddStandartPicture();
                    }               
                    Model.AddToList(Model.SetBookInfo(View.GetBookInfo(Path)));
                    flag = true;
                }
                catch (Exception)
                {
                    View.ShowMessageBox(Properties.Resources.MessageNotCapitalLetter);
                    flag = false;
                }
            }
            if (flag)
            {
                View.HideForm();
            }
        }
        public void Run()
        {
            View.Show();
        }
    }
}

