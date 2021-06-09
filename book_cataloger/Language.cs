using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace book_cataloger.Views
{
    class Language
    {
        public static List<CultureInfo> GetAvailableCultures()
        {
            var res = new List<CultureInfo>();

            foreach (var item in Properties.Settings.Default.Cultures)
            {
                res.Add(CultureInfo.CreateSpecificCulture((string)item));
            }
            res.Add(CultureInfo.InvariantCulture);
            return res;
        }

        public static List<string> GetAvailableLanguages(List<CultureInfo> cultures)
        {
            var res = new List<string>();
            var current = CultureInfo.CurrentCulture;

            foreach (var item in cultures)
            {
                SetCurrent(item);

                res.Add(Properties.Resources.Language);
            }

            SetCurrent(current);
            return res;
        }
        public static void SetCurrent(CultureInfo culture)
        {
            Thread.CurrentThread.CurrentUICulture = culture;
        }
    }
}
