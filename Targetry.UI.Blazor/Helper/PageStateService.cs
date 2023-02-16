using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Targetry.UI.BlazorHelper
{
    public class PageStateService
    {
        public event Action<string> OnPageTitleChanged;

        public void PageTitleChanged(string pageTitle)
        {
            OnPageTitleChanged?.Invoke(pageTitle);
        }
    }
}
