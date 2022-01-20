using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace KfksScore.Models
{
    public class Timer : INotifyPropertyChanged
    {
       // public event PropertyChangedEventHandler PropertyChanged;
        public string TimeElapsed { get; set; } 

        private DispatcherTimer timer;
        private Stopwatch stopWatch;

        public void StartTimer()
        {
            timer = new DispatcherTimer();
            timer.Tick += dispatcherTimerTick_;
            timer.Interval = new TimeSpan(0, 0, 0, 0, 1);
            stopWatch = new Stopwatch();
            stopWatch.Start();
            timer.Start();
        }


        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            TimeElapsed = stopWatch.Elapsed.TotalMilliseconds.ToString(); // Format as you wish

            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
        #endregion
        private void dispatcherTimerTick_(object sender, EventArgs e)
        {
            TimeElapsed = stopWatch.Elapsed.TotalMilliseconds.ToString(); // Format as you wish
            OnPropertyChanged("TimeElapsed");
            //if (PropertyChanged != null)
               // PropertyChanged(this, new PropertyChangedEventArgs("TimeElapsed"));
        }
    }
}
