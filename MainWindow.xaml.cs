using KfksScore.Interfaces;
using KfksScore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KfksScore
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public MainWindow()
        {
            InitializeComponent();

            //this.DataContext = Board;
            // this.DataContext = Timer;
            this.DataContext = this;
            IsTatamiVisible = false;
            TatamiValue = 1;

            // eSBoard.Board = Board;
        }

        private ESBoard eSBoard;
        #region Public properties

        public Timer Timer { get; set; } = new Timer();
        public IESBoard Board { get; set; } = new Board();


        public string CompetitionName { get { return Board.CompetitionName; } set { Board.CompetitionName = value; } }
        public string CompetitionCategory { get { return Board.CompetitionCategory; } set { Board.CompetitionCategory = value; } }
        public string CompetitionTime { get { return Board.CompetitionTime; } set { Board.CompetitionTime = value; } }
        public string CompetitionScore { get { return Board.CompetitionScore; } set { Board.CompetitionScore = value; } }
        //public string TimeElapsed { get { return Timer.TimeElapsed; } set { Timer.TimeElapsed = value; } }

        

        private decimal _tatamiValue;
        public decimal TatamiValue
        {
            get { return _tatamiValue; }
            set { _tatamiValue = value; OnPropertyChanged("TatamiValue"); }
        }

        private bool _isTatamiVisible;
        public bool IsTatamiVisible
        {
            get { return _isTatamiVisible; }
            set { _isTatamiVisible = value; OnPropertyChanged("IsTatamiVisible"); }
        }

        #endregion
        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
        #endregion
        private void ESBoard_Button_Click(object sender, RoutedEventArgs e)
        {
            if (eSBoard == null)
            {
                eSBoard = new ESBoard(Board,Timer);
                eSBoard.Show();
            }

            //if (eSBoard.ShowDialog().Equals(true))
            //{

            //}
        }

        private void TimerStart_Click(object sender, RoutedEventArgs e)
        {
            //Timer?.StartTimer();
            Timer?.StartTimerNew();


        }

        private void TimerStop_Click(object sender, RoutedEventArgs e)
        {
            Timer?.StopTimer();
           //Timer?.PauseStart();
        }

        private void TatamiLeft_Checked(object sender, RoutedEventArgs e)
        {
                IsTatamiVisible = true;
            TatamiRight.IsChecked = true;
        }

        private void TatamiRight_Checked(object sender, RoutedEventArgs e)
        {
            IsTatamiVisible = true;
            TatamiLeft.IsChecked = true;
        }

        private void TatamiLeft_Unchecked(object sender, RoutedEventArgs e)
        {
            IsTatamiVisible = false;
            TatamiRight.IsChecked = false;
        }

        private void TatamiRight_Unchecked(object sender, RoutedEventArgs e)
        {
            IsTatamiVisible = false;
            TatamiLeft.IsChecked = false;
        }
    }
}
