using NET.efilnukefesin.Apps.UXDemo.Navigation.Attributes;
using NET.efilnukefesin.Apps.UXDemo.Navigation.Interfaces;
using NET.efilnukefesin.Apps.UXDemo.ViewModelLocator.Interfaces;
using NET.efilnukefesin.Implementations.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace NET.efilnukefesin.Apps.UXDemo.Navigation
{
    public class NavigationService : INavigationService
    {
        #region Properties

        private Dictionary<object, string> viewsAndViewModels;

        private ILocator viewModelLocator;
        private INavigationPresenter navigationPresenter;

        #endregion Properties

        #region Construction

        public NavigationService(INavigationPresenter NavigationPresenter)
        {
            this.navigationPresenter = NavigationPresenter;
            this.viewModelLocator = null;
            this.viewsAndViewModels = new Dictionary<object, string>();
            this.findViewsAndViewModels();
        }

        #endregion Construction

        #region Methods

        #region findViewsAndViewModels
        private void findViewsAndViewModels()
        {
            Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
            foreach (Assembly currentAssembly in assemblies)
            {
                foreach (Type currentType in currentAssembly.GetTypes())
                {
                    foreach (object customAttribute in currentType.GetCustomAttributes(true))
                    {
                        ViewModelAttribute viewModelAttribute = customAttribute as ViewModelAttribute;
                        if (viewModelAttribute != null)
                        {
                            if (!this.viewsAndViewModels.ContainsKey(viewModelAttribute.ViewModelName))
                            {
                                //object instance = DiManager.GetInstance().Resolve(currentType);
                                //this.viewsAndViewModels.Add(viewModelAttribute.ViewModelName, instance);
                                //this.viewsAndViewModels.Add(currentType, this.viewModelLocator.GetInstance(viewModelAttribute.ViewModelName));
                                this.viewsAndViewModels.Add(currentType, viewModelAttribute.ViewModelName);
                            }
                        }
                    }
                }
            }
        }
        #endregion findViewsAndViewModels

        #region Navigate
        public bool Navigate(string ViewModelName)
        {
            this.navigationPresenter.Present(this.viewsAndViewModels.Where(x => x.Value.Equals(ViewModelName)).FirstOrDefault().Key);
            return true;  //TODO: get error
        }
        #endregion Navigate

        #region CanNavigate
        public bool CanNavigate(string ViewModelName)
        {
            return this.viewsAndViewModels.Any(x => x.Value.Equals(ViewModelName));
        }
        #endregion CanNavigate

        #endregion Methods

        #region Events

        #endregion Events
    }
}