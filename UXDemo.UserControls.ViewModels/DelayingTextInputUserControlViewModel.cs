using NET.efilnukefesin.Apps.UXDemo.Basics.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace NET.efilnukefesin.Apps.UXDemo.UserControls.ViewModels
{
    public class DelayingTextInputUserControlViewModel : BaseViewModel
    {
        #region Properties

        public string Text { get; set; }
        public string Hint { get; set; }
        public TimeSpan Delay { get; set; } = new TimeSpan(0, 0, 0, 0, 500);

        public Action ActionToExecute { get; set; }

        private Timer DelayTimer;

        #endregion Properties

        #region Construction

        public DelayingTextInputUserControlViewModel()
        {
            // init timer with default delay
            this.DelayTimer = new Timer(this.Delay.TotalMilliseconds);

            // attach event
            this.DelayTimer.Elapsed += this.delayTimer_Elapsed;
        }

        #endregion Construction

        #region Methods

        #region OnTextChanged
        public void OnTextChanged()
        {
            // reset / start timer
            this.DelayTimer?.Stop();
            this.DelayTimer?.Start();
        }
        #endregion OnTextChanged

        #region delayTimer_Elapsed
        private void delayTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            // stop timer
            this.DelayTimer.Stop();

            //execute Action
            this.ActionToExecute?.Invoke();
        }
        #endregion delayTimer_Elapsed

        #region dispose
        protected override void dispose()
        {
            this.DelayTimer.Elapsed -= this.delayTimer_Elapsed;
            this.DelayTimer = null;
            this.ActionToExecute = null;
        }
        #endregion dispose

        #endregion Methods
    }
}
