using System;

namespace Targetry.UI.BlazorHelper.RefreshService
{
    public interface IRefreshRequestService
    {
        event Action RefreshRequested;
      
        void CallRequestRefresh();
    }
}
