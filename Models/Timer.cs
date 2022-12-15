using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace KfksScore.Models
{
    public class Timer : INotifyPropertyChanged
    {

        //public string TimeElapsed { get; set; } = "00:00";

        private string _timeElapsed = "00:00";
        public string TimeElapsed 
        {
            get { return _timeElapsed; }
            set { _timeElapsed = value; OnPropertyChanged("TimeElapsed"); }
        } 


        private DispatcherTimer timer;
        private Stopwatch stopWatch;
        private bool isPaused;
        private bool isWaiting;

        //[Obsolete]
        //public void StartTimer()
        //{
        //    timer = new DispatcherTimer();
        //    timer.Tick += dispatcherTimerTick_;
        //    timer.Interval = new TimeSpan(0, 0, 0, 0, 1);
        //    stopWatch = new Stopwatch();
        //    stopWatch.Start();
        //    timer.Start();
        //    isPaused = false;
        //}

        //public void StartTimerNew(bool resume = false)
        //{
        //    if (timer != null && timer.IsEnabled)
        //        return;

        //    if (!resume || CountDownTime == TimeSpan.MinValue)
        //    {
        //        CountDownTime = TimeSet;
        //    }

        //    timer = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Send, dispatcherTimerTickNew, Application.Current.Dispatcher);
        //    timer.Start();
        //}

        public void StartTimerDelegate(EventHandler method)
        {
            timer = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Send, method, Application.Current.Dispatcher);
            timer.Start();
        }

        public void StartTimerNew(bool isWaiting = false)
        {
            this.isWaiting = isWaiting;

            if (timer != null && timer.IsEnabled)
                return;

            if (CountDownTime == TimeSpan.MinValue)
            {
                if (isWaiting)
                    CountDownTime = TimeSet.Add(TimeSpan.FromSeconds(+1));
                else
                    CountDownTime = TimeSet.Add(TimeSpan.FromSeconds(-1));
            }

            timer = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Send, dispatcherTimerTickNew, Application.Current.Dispatcher);
            timer.Start();
        }


        public void StopTimer()
        {
            timer?.Stop();
        }

        public void PauseStart()
        {
            //if(timer.IsEnabled && isPaused)
            if (isPaused)
            {
                timer.Start();
                isPaused = false;
            }
           //else
           // {
           //     timer.Stop();
           //     isPaused = true;
           // }
        }
        
        public void PauseStop()
        {
            timer.Stop();
            isPaused = true;
        }
        //public TimeSpan TimeSet { get; set; } = TimeSpan.FromMinutes(3);//TimeSpan.FromSeconds(10);
        private TimeSpan _timeSet = TimeSpan.FromMinutes(3);
        public TimeSpan TimeSet 
        {
            get { return _timeSet; }
            set { _timeSet = value; TimeElapsed = _timeSet.ToString(@"mm\:ss"); } 
        } 


        public TimeSpan CountDownTime { get; set; } = TimeSpan.MinValue;
       // public TimeSpan Time { get; set; } = TimeSpan.MinValue;

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            //TimeElapsed = stopWatch.Elapsed.TotalMilliseconds.ToString(); // Format as you wish

            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
        #endregion

        //[Obsolete]
        //private void dispatcherTimerTick_(object sender, EventArgs e)
        //{
        //    TimeElapsed = stopWatch.Elapsed.TotalMilliseconds.ToString(); // Format as you wish
        //    OnPropertyChanged("TimeElapsed");
        //}

        private void dispatcherTimerTickNew(object sender, EventArgs e)
        {
            if (!isWaiting)
            {
                TimeElapsed = CountDownTime.ToString(@"mm\:ss");//.ToString("c");

                if (CountDownTime == TimeSpan.Zero)
                    timer.Stop();

                CountDownTime = CountDownTime.Add(TimeSpan.FromSeconds(-1));
            }
            else
            {
                TimeElapsed = CountDownTime.ToString(@"mm\:ss");//.ToString("c");
                CountDownTime = CountDownTime.Add(TimeSpan.FromSeconds(+1));
            }

            OnPropertyChanged("TimeElapsed");
           
        }

            
    }
}
