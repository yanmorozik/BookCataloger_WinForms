using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_cataloger.Interfaces
{
    interface IViewFindBook
    {
        event Action Find;
        void Show();
        void SetLanguage();
        List<string> GetListBook();
    }
}
