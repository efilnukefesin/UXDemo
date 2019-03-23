using System;
using System.Collections.Generic;
using System.Text;

namespace NET.efilnukefesin.Apps.UXDemo.Navigation.Interfaces
{
    public interface INavigationPresenter
    {
        void RegisterPresenter(object Presenter);
        void Present(object View);
    }
}
