using book_cataloger.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_cataloger.Presenters
{
    class PresenterFindBook
    {
        private readonly IViewFindBook View;
        private readonly IModelFindBook Model;
        public PresenterFindBook(IViewFindBook View, IModelFindBook Model)
        {
            this.View = View;
            this.Model = Model;

            this.View.Find += () => FindBook();
            View.SetLanguage();
            Model.Flag = false;
        }
        private void FindBook()
        {
            Model.FoundBooks.Clear();
            Model.FindBooks(View.GetListBook());
            Model.Flag = true;
        }
        public bool Run()
        {
            View.Show();
            return Model.Flag;
        }
    }
}
