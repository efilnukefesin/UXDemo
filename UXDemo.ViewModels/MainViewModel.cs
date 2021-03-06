﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using NET.efilnukefesin.Common.Wpf.Commands;
using NET.efilnukefesin.Implementations.DependencyInjection;
using NET.efilnukefesin.Apps.UXDemo.Models;
using NET.efilnukefesin.Apps.UXDemo.Services.Interfaces;
using NET.efilnukefesin.Apps.UXDemo.Basics.Mvvm;
using NET.efilnukefesin.Apps.UXDemo.UserControls.ViewModels;
using NET.efilnukefesin.Implementations.Mvvm.Attributes;
using NET.efilnukefesin.Contracts.Mvvm;
using MaterialDesignThemes.Wpf;

namespace NET.efilnukefesin.Apps.UXDemo.ViewModels
{
    [Locator("MainViewModel")]
    public class MainViewModel : BaseViewModel
    {
        #region Properties

        public MenuUserControlViewModel Menu { get; set; }
        public ISnackbarMessageQueue SnackBarMessageQueue { get; set; }

        private INavigationService navigationService;

        #endregion Properties

        #region Construction

        public MainViewModel(INavigationService NavigationService, ISnackbarMessageQueue SnackBarMessageQueue)
            :base()
        {
            this.SnackBarMessageQueue = SnackBarMessageQueue;  //TODO: move into View? Due to independency reasons and stuff?
            this.navigationService = NavigationService;
            this.Menu = new MenuUserControlViewModel(this.navigationService);
        }
        #endregion Construction

        #region Methods

        #region dispose
        protected override void dispose()
        {
            this.Menu = null;
        }
        #endregion dispose

        #endregion Methods
    }
}
