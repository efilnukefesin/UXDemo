﻿using NET.efilnukefesin.Apps.UXDemo.Navigation.Attributes;
using NET.efilnukefesin.Apps.UXDemo.Navigation.Interfaces;
using NET.efilnukefesin.Apps.UXDemo.ViewModelLocator.Interfaces;
using NET.efilnukefesin.Implementations.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace NET.efilnukefesin.Apps.UXDemo.Navigation
{
    public class NavigationService : INavigationService
    {
        #region Properties

        private Dictionary<object, string> viewsAndViewModels;

        private ILocator viewModelLocator;

        #endregion Properties

        #region Construction

        public NavigationService(/*ILocator ViewModelLocator*/)
        {
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
            throw new NotImplementedException();
        }
        #endregion Navigate

        #endregion Methods

        #region Events

        #endregion Events
    }
}