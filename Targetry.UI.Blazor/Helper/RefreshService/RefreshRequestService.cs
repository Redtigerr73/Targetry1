using System;

namespace Targetry.UI.BlazorHelper.RefreshService
{
    public class RefreshRequestService : IRefreshRequestService
    {
       
        public event Action RefreshRequested;
      
        public void CallRequestRefresh()
        {
            RefreshRequested?.Invoke();
        }
    }
}
