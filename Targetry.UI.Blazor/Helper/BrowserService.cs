using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace Targetry.UI.BlazorHelper
{
    public class BrowserService
    {
        private readonly IJSRuntime _js;

        public BrowserService(IJSRuntime js)
        {
            _js = js;
        }

        public async Task SetWindowTitle(string title)
        {
            await _js.InvokeAsync<object>("setTitle", title);
        }

        public async Task OpenLink(string link)
        {
            await _js.InvokeAsync<object>("open", link, "_blank");
        }

    }

}