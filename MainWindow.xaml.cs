﻿using KfksScore.Interfaces;
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
            CompetitorLeftScore = 0;
            CompetitorRightScore = 0;
            IsMale = true;
            YearsFrom = 10;
            YearsTo = 11;
            IsWeightTo = true;
            CompetitorsWeight = 42;
            IsMainTime = true;
            MainTimeMin = 3;
            MainTimeSec = 0;
            AddTimeMin = 1;
            AddTimeSec = 0;
            WaitTimeMin = 1;
            WaitTimeSec = 0;
            CompetitorLeftScoreHistory = "1+2+3";
            CompetitorRightScoreHistory = "3+2+1";

            CompetitionName = "Зимове змагання КФКС";
            CompetitionCategory = "Хлопчики 10-11 років вагою до 42кг";


            DisplayWidth = ((int)System.Windows.SystemParameters.PrimaryScreenWidth / 2) - 100;
            DisplayHeight = (int)System.Windows.SystemParameters.PrimaryScreenHeight - 300;
            CompetitorLeftName = "Петренко Петро";
            CompetitorRightName = "Васильченко Василь";

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

        public string CompetitorLeftScoreHistory { get { return Board.CompetitorLeftScoreHistory; } set { Board.CompetitorLeftScoreHistory = value; } }

        public string CompetitorRightScoreHistory { get { return Board.CompetitorRightScoreHistory; } set { Board.CompetitorRightScoreHistory = value; } }

        public decimal TatamiValue
        {
            get { return Board.TatamiNumber; }
            set { Board.TatamiNumber = value; OnPropertyChanged("TatamiValue"); }
        }

        private bool _isTatamiVisible;
        public bool IsTatamiVisible
        {
            get { return _isTatamiVisible; }
            set { _isTatamiVisible = value; OnPropertyChanged("IsTatamiVisible"); }
        }

        private bool _isMale;
        public bool IsMale
        {
            get { return _isMale; }
            set { _isMale = value; OnPropertyChanged("IsMale"); }
        }

        private bool _isFeMale;
        public bool IsFeMale
        {
            get { return _isFeMale; }
            set { _isFeMale = value; OnPropertyChanged("IsFeMale"); }
        }

        private bool _isVeterans;
        public bool IsVeterans
        {
            get { return _isVeterans; }
            set { _isVeterans = value; OnPropertyChanged("IsVeterans"); }
        }

        private decimal _yearsFrom;
        public decimal YearsFrom
        {
            get { return _yearsFrom; }
            set { _yearsFrom = value; OnPropertyChanged("YearsFrom"); }
        }

        private decimal _yearsTo;
        public decimal YearsTo
        {
            get { return _yearsTo; }
            set { _yearsTo = value; OnPropertyChanged("YearsTo"); }
        }

        private bool _isWeightOver;
        public bool IsWeightOver
        {
            get { return _isWeightOver; }
            set { _isWeightOver = value; OnPropertyChanged("IsWeightOver"); }
        }

        private bool _isWeightTo;
        public bool IsWeightTo
        {
            get { return _isWeightTo; }
            set { _isWeightTo = value; OnPropertyChanged("IsWeightTo"); }
        }

        private decimal _competitorsWeight;
        public decimal CompetitorsWeight
        {
            get { return _competitorsWeight; }
            set { _competitorsWeight = value; OnPropertyChanged("CompetitorsWeight"); }
        }


        private bool _isMainTime;
        public bool IsMainTime
        {
            get { return _isMainTime; }
            set { _isMainTime = value; OnPropertyChanged("IsMainTime"); }
        }

        private decimal _mainTimeMin;
        public decimal MainTimeMin
        {
            get { return _mainTimeMin; }
            set { _mainTimeMin = value; OnPropertyChanged("MainTimeMin"); }
        }

        private decimal _mainTimeSec;
        public decimal MainTimeSec
        {
            get { return _mainTimeSec; }
            set { _mainTimeSec = value; OnPropertyChanged("MainTimeSec"); }
        }


        private bool _isAddTime;
        public bool IsAddTime
        {
            get { return _isAddTime; }
            set { _isAddTime = value; OnPropertyChanged("IsAddTime"); }
        }

        private decimal _addTimeMin;
        public decimal AddTimeMin
        {
            get { return _addTimeMin; }
            set { _addTimeMin = value; OnPropertyChanged("AddTimeMin"); }
        }

        private decimal _addTimeSec;
        public decimal AddTimeSec
        {
            get { return _addTimeSec; }
            set { _addTimeSec = value; OnPropertyChanged("AddTimeSec"); }
        }


        private bool _isWaitTime;
        public bool IsWaitTime
        {
            get { return _isWaitTime; }
            set { _isWaitTime = value; OnPropertyChanged("IsWaitTime"); }
        }

        private decimal _waitTimeMin;
        public decimal WaitTimeMin
        {
            get { return _waitTimeMin; }
            set { _waitTimeMin = value; OnPropertyChanged("WaitTimeMin"); }
        }

        private decimal _waitTimeSec;
        public decimal WaitTimeSec
        {
            get { return _waitTimeSec; }
            set { _waitTimeSec = value; OnPropertyChanged("WaitTimeSec"); }
        }


        public int DisplayWidth
        {
            get { return Board.DisplayWidth; }
            set { Board.DisplayWidth = value; OnPropertyChanged("DisplayWidth"); }
        }

        public int DisplayHeight
        {
            get { return Board.DisplayHeight; }
            set { Board.DisplayHeight = value; OnPropertyChanged("DisplayHeight"); }
        }

        public string CompetitorLeftName
        {
            get { return Board.CompetitorLeftName; }
            set { Board.CompetitorLeftName = value; OnPropertyChanged("CompetitorLeftName"); }
        }

        public string CompetitorRightName
        {
            get { return Board.CompetitorRightName; }
            set { Board.CompetitorRightName = value; OnPropertyChanged("CompetitorRightName"); }
        }


        public int CompetitorLeftScore
        {
            get { return Board.CompetitorLeftScore; }
            set { Board.CompetitorLeftScore = value; OnPropertyChanged("CompetitorLeftScore"); }
        }

        public int CompetitorRightScore
        {
            get { return Board.CompetitorRightScore; }
            set { Board.CompetitorRightScore = value; OnPropertyChanged("CompetitorRightScore"); }
        }

        //private int _competitorLeftScore;
        //public int CompetitorLeftScore
        //{
        //    get { return _competitorLeftScore; }
        //    set { _competitorLeftScore = value; OnPropertyChanged("CompetitorLeftScore"); }
        //}

        //private int _competitorRightScore;
        //public int CompetitorRightScore
        //{
        //    get { return _competitorRightScore; }
        //    set { _competitorRightScore = value; OnPropertyChanged("CompetitorRightScore"); }
        //}

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
