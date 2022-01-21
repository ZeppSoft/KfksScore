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
        public string TimeElapsed { get; set; } 

        private DispatcherTimer timer;
        private Stopwatch stopWatch;
        private bool isPaused;

        [Obsolete]
        public void StartTimer()
        {
            timer = new DispatcherTimer();
            timer.Tick += dispatcherTimerTick_;
            timer.Interval = new TimeSpan(0, 0, 0, 0, 1);
            stopWatch = new Stopwatch();
            stopWatch.Start();
            timer.Start();
            isPaused = false;
        }

        public void StartTimerNew(bool resume = false)
        {
            if (timer != null && timer.IsEnabled)
                return;

            if (!resume || CountDownTime == TimeSpan.MinValue)
            {
                CountDownTime = TimeSet;
            }

            timer = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, dispatcherTimerTickNew, Application.Current.Dispatcher);
            timer.Start();
        }

        public void StopTimer()
        {
            timer?.Stop();
        }

        public void PauseStart()
        {
           if(timer.IsEnabled && isPaused)
            {
                timer.Start();
                isPaused = false;
            }
           else
            {
                timer.Stop();
                isPaused = true;
            }
        }
        public TimeSpan TimeSet { get; set; } = TimeSpan.FromMinutes(3);//TimeSpan.FromSeconds(10);

        public TimeSpan CountDownTime { get; set; } = TimeSpan.MinValue;

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            //TimeElapsed = stopWatch.Elapsed.TotalMilliseconds.ToString(); // Format as you wish

            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
        #endregion

        [Obsolete]
        private void dispatcherTimerTick_(object sender, EventArgs e)
        {
            TimeElapsed = stopWatch.Elapsed.TotalMilliseconds.ToString(); // Format as you wish
            OnPropertyChanged("TimeElapsed");
        }

        private void dispatcherTimerTickNew(object sender, EventArgs e)
        {
            TimeElapsed = CountDownTime.ToString(@"mm\:ss");//.ToString("c");

            if (CountDownTime == TimeSpan.Zero) 
                timer.Stop();

            CountDownTime = CountDownTime.Add(TimeSpan.FromSeconds(-1));

            OnPropertyChanged("TimeElapsed");
           
        }

            
    }
}
