﻿using NET.efilnukefesin.Contracts.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace NET.efilnukefesin.Apps.UXDemo.Navigation.Wpf
{
    public class WpfNavigationPresenter : INavigationPresenter
    {
        #region Properties

        private Frame presentationFrame;
        private object currentDataContext = null;

        private string bufferedViewUri = null;
        private object bufferedDataContext = null;

        #endregion Properties

        #region Construction

        #endregion Construction

        #region Methods

        #region Present
        public bool Present(string ViewUri, object DataContext)
        {
            bool result = false;
            try
            {
                if (this.presentationFrame != null)
                {
                    this.currentDataContext = DataContext;
                    this.presentationFrame.Navigate(new Uri("pack://application:,,,/UXDemo.Views.Wpf;component/" + ViewUri));

                    if ((Page)this.presentationFrame.Content != null)
                    {
                        ((Page)this.presentationFrame.Content).DataContext = null;
                    }

                    this.bufferedViewUri = null;
                    this.bufferedDataContext = null;

                    result = true;
                }
                else
                {
                    this.bufferedViewUri = ViewUri;
                    this.bufferedDataContext = DataContext;
                    result = true;
                }
            }
            catch (Exception ex)
            {

            }
            return result;
        }
        #endregion Present

        #region RegisterPresenter
        public void RegisterPresenter(object Presenter)
        {
            if (Presenter is Frame)
            {
                this.presentationFrame = (Frame)Presenter;
                this.presentationFrame.Navigated += this.presentationFrame_Navigated;
                if (this.bufferedViewUri != null && this.bufferedDataContext != null)
                {
                    this.Present(this.bufferedViewUri, this.bufferedDataContext);
                }
            }
        }
        #endregion RegisterPresenter

        #region presentationFrame_Navigated: set the datacontext after navigating as the content is now different
        /// <summary>
        /// set the datacontext after navigating as the content is now different
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void presentationFrame_Navigated(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {
            if ((Page)e.Content != null)
            {
                ((Page)e.Content).DataContext = this.currentDataContext;
            }
        }
        #endregion presentationFrame_Navigated

        #endregion Methods   
    }
}
