using DevExpress.XtraRichEdit.Import.OpenDocument;
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
using System.Windows.Threading;

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
            Init();
          
            
        }

        public void Init()
        {
            this.DataContext = this;
            IsTatamiVisible = false;
            TatamiValue = 1;
            CompetitorLeftScore = 0;
            CompetitorRightScore = 0;
            IsVeterans = false;
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
            CompetitorLeftScoreHistory = String.Empty;
            CompetitorRightScoreHistory = String.Empty;

            ScorePlus.IsChecked = true;

            CompetitionName = "Зимове змагання КФКС";
            CompetitionCategory = String.Empty;//"Хлопчики 10-11 років вагою до 42кг";


            DisplayWidth = ((int)System.Windows.SystemParameters.PrimaryScreenWidth / 2) - 100;
            DisplayHeight = (int)System.Windows.SystemParameters.PrimaryScreenHeight - 300;
            CompetitorLeftName = "Петренко Петро";
            CompetitorRightName = "Васильченко Василь";
            Board.ScoreFontSize = 4000;
        }

        private ESBoard eSBoard;
        #region Public properties

        public Timer Timer { get; set; } = new Timer();
        //public DispatcherTimer WaitTimer { get; set; } 

        public IESBoard Board { get; set; } = new Board();

        
        public string CompetitionName { get { return Board.CompetitionName; } set { Board.CompetitionName = value; } }
        public string CompetitionCategory { get { return Board.CompetitionCategory; } set { Board.CompetitionCategory = value; } }
        public string CompetitionTime { get { return Board.CompetitionTime; } set { Board.CompetitionTime = value; } }
        public string CompetitionScore { get { return Board.CompetitionScore; } set { Board.CompetitionScore = value; } }
        //public string TimeElapsed { get { return Timer.TimeElapsed; } set { Timer.TimeElapsed = value; } }
        public string TimeDescription { get { return Board.TimeDescription; } set { Board.TimeDescription = value; OnPropertyChanged("TimeDescription"); } }

        public string CompetitorLeftScoreHistory { get { return Board.CompetitorLeftScoreHistory; } set { Board.CompetitorLeftScoreHistory = value; OnPropertyChanged("CompetitorLeftScoreHistory"); } }

        public string CompetitorRightScoreHistory { get { return Board.CompetitorRightScoreHistory; } set { Board.CompetitorRightScoreHistory = value; OnPropertyChanged("CompetitorRightScoreHistory"); } }

        public decimal TatamiValue
        {
            get { return Board.TatamiNumber; }
            set { Board.TatamiNumber = value; OnPropertyChanged("TatamiValue"); }
        }

        public string ScoreSign { get; set; } = "+";

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

        private string _leftOneButtonContent = "1";
        public string LeftOneButtonContent
        {
            get { return _leftOneButtonContent; }
            set { _leftOneButtonContent = value; OnPropertyChanged("LeftOneButtonContent"); }
        }

        private string _leftTwoButtonContent = "2";
        public string LeftTwoButtonContent
        {
            get { return _leftTwoButtonContent; }
            set { _leftTwoButtonContent = value; OnPropertyChanged("LeftTwoButtonContent"); }
        }
        private string _leftThreeButtonContent = "3";
        public string LeftThreeButtonContent
        {
            get { return _leftThreeButtonContent; }
            set { _leftThreeButtonContent = value; OnPropertyChanged("LeftThreeButtonContent"); }
        }
        private string _leftFourButtonContent = "4";
        public string LeftFourButtonContent
        {
            get { return _leftFourButtonContent; }
            set { _leftFourButtonContent = value; OnPropertyChanged("LeftFourButtonContent"); }
        }
        private string _leftFiveButtonContent = "5";
        public string LeftFiveButtonContent
        {
            get { return _leftFiveButtonContent; }
            set { _leftFiveButtonContent = value; OnPropertyChanged("LeftFiveButtonContent"); }
        }
        private string _leftSixButtonContent = "6";
        public string LeftSixButtonContent
        {
            get { return _leftSixButtonContent; }
            set { _leftSixButtonContent = value; OnPropertyChanged("LeftSixButtonContent"); }
        }
        private string _leftSevenButtonContent = "7";
        public string LeftSevenButtonContent
        {
            get { return _leftSevenButtonContent; }
            set { _leftSevenButtonContent = value; OnPropertyChanged("LeftSevenButtonContent"); }
        }


        private string _rightOneButtonContent = "1";
        public string RightOneButtonContent
        {
            get { return _rightOneButtonContent; }
            set { _rightOneButtonContent = value; OnPropertyChanged("RightOneButtonContent"); }
        }
        private string _rightTwoButtonContent = "2";
        public string RightTwoButtonContent
        {
            get { return _rightTwoButtonContent; }
            set { _rightTwoButtonContent = value; OnPropertyChanged("RightTwoButtonContent"); }
        }
        private string _rightThreeButtonContent = "3";
        public string RightThreeButtonContent
        {
            get { return _rightThreeButtonContent; }
            set { _rightThreeButtonContent = value; OnPropertyChanged("RightThreeButtonContent"); }
        }
        private string _rightFourButtonContent = "4";
        public string RightFourButtonContent
        {
            get { return _rightFourButtonContent; }
            set { _rightFourButtonContent = value; OnPropertyChanged("RightFourButtonContent"); }
        }
        private string _rightFiveButtonContent = "5";
        public string RightFiveButtonContent
        {
            get { return _rightFiveButtonContent; }
            set { _rightFiveButtonContent = value; OnPropertyChanged("RightFiveButtonContent"); }
        }
        private string _rightSixButtonContent = "6";
        public string RightSixButtonContent
        {
            get { return _rightSixButtonContent; }
            set { _rightSixButtonContent = value; OnPropertyChanged("RightSixButtonContent"); }
        }
        private string _rightSevenButtonContent = "7";
        public string RightSevenButtonContent
        {
            get { return _rightSevenButtonContent; }
            set { _rightSevenButtonContent = value; OnPropertyChanged("RightSevenButtonContent"); }
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

        private string _timerButtonText = "Почати";
        public string TimerButtonText
        {
            get { return _timerButtonText; }
            set { _timerButtonText = value; OnPropertyChanged("TimerButtonText"); }
        }

        private string _waitForCompetitorLeftText = "Очікування спортсмена";
        public string WaitForCompetitorLeftText
        {
            get { return _waitForCompetitorLeftText; }
            set { _waitForCompetitorLeftText = value; OnPropertyChanged("WaitForCompetitorLeftText"); }
        }

        private string _waitForCompetitorRightText = "Очікування спортсмена";
        public string WaitForCompetitorRightText
        {
            get { return _waitForCompetitorRightText; }
            set { _waitForCompetitorRightText = value; OnPropertyChanged("WaitForCompetitorRightText"); }
        }


        //private string _waitForCompetitorLeftText = "Очікування спортсмена";
        public string WaitForCompetitorLeftTime
        {
            get { return Board.WaitForCompetitorLeftText; }
            set { Board.WaitForCompetitorLeftText = value; OnPropertyChanged("WaitForCompetitorLeftTime"); }
        }

        //private string _waitForCompetitorRightText = "Очікування спортсмена";
        public string WaitForCompetitorRightTime
        {
            get { return Board.WaitForCompetitorRightText; }
            set { Board.WaitForCompetitorRightText = value; OnPropertyChanged("WaitForCompetitorRightTime"); }
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

            //if (FirstTechAction.IsChecked == true)
            //{

            //}


            switch(TimerButtonText)
            {
                case "Почати":
                    {
                        TimerButtonText = "Зупинити";
                        if (FirstTechAction.IsChecked == true)
                        {
                            Timer?.StartTimerNew(true);
                        }
                        else
                            Timer?.StartTimerNew();
                    }
                    break;

                case "Зупинити":
                    {
                        TimerButtonText = "Продовжити";
                        Timer?.PauseStop();
                    }
                    break;

                case "Продовжити":
                    {
                        TimerButtonText = "Зупинити";
                        Timer?.PauseStart();
                    }
                    break;

                
            }

           
           // Timer?.StartTimerNew();


        }

        private void TimerStop_Click(object sender, RoutedEventArgs e)
        {
            Timer?.StopTimer();
            TimerButtonText = "Почати";

            if (mainTime.IsChecked == true)
            {
                Timer.TimeSet = new TimeSpan(0, (int)MainTimeMin, (int)MainTimeSec);
            }

            else if (addTime.IsChecked == true)
            {
                Timer.TimeSet = new TimeSpan(0, (int)AddTimeMin, (int)AddTimeSec);
            }
            else if (waitTime.IsChecked == true)
            {
                Timer.TimeSet = new TimeSpan(0, (int)WaitTimeMin, (int)WaitTimeSec);
            }
            else if (FirstTechAction.IsChecked == true)
            {
                Timer.TimeSet = new TimeSpan(0, 0, 0);
            }

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

        private void mainTime_Checked(object sender, RoutedEventArgs e)
        {
            Timer.TimeSet = new TimeSpan(0, (int)MainTimeMin, (int)MainTimeSec);
            TimeDescription = "Основний час";
        }
        private void MainTimeMinChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            if (mainTime.IsChecked == true)
            {
                Timer.TimeSet = new TimeSpan(0, (int)MainTimeMin, (int)MainTimeSec);
            }
        }

        private void MainTimeSecChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            if (mainTime.IsChecked == true)
            {
                Timer.TimeSet = new TimeSpan(0, (int)MainTimeMin, (int)MainTimeSec);
            }
        }
        private void addTime_Checked(object sender, RoutedEventArgs e)
        {
            Timer.TimeSet = new TimeSpan(0, (int)AddTimeMin, (int)AddTimeSec);
            TimeDescription = "Додатковий час";


        }
        private void AddTimeMinChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            if (addTime.IsChecked == true)
            {
                Timer.TimeSet = new TimeSpan(0, (int)AddTimeMin, (int)AddTimeSec);
            }
        }
        private void AddTimeSecChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            if (addTime.IsChecked == true)
            {
                Timer.TimeSet = new TimeSpan(0, (int)AddTimeMin, (int)AddTimeSec);
            }
        }
        private void waitTime_Checked(object sender, RoutedEventArgs e)
        {
            Timer.TimeSet = new TimeSpan(0, (int)WaitTimeMin, (int)WaitTimeSec);
            TimeDescription = "Час очікування";
            
        }
        private void WaitTimeMinChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            if (waitTime.IsChecked == true)
            {
                Timer.TimeSet = new TimeSpan(0, (int)WaitTimeMin, (int)WaitTimeSec);
            }
        }
        private void WaitTimeSecChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            if (waitTime.IsChecked == true)
            {
                Timer.TimeSet = new TimeSpan(0, (int)WaitTimeMin, (int)WaitTimeSec);
            }
        }
        private void SexM_Checked(object sender, RoutedEventArgs e)
        {
            UpdateCompetitionCategory();
        }

        private void SexM_UnChecked(object sender, RoutedEventArgs e)
        {
            IsFeMale = true;
        }

        private void SexF_Checked(object sender, RoutedEventArgs e)
        {
            UpdateCompetitionCategory();
        }

        private void Veterans_Checked(object sender, RoutedEventArgs e)
        {
            UpdateCompetitionCategory();
        }

        private void Veterans_UnChecked(object sender, RoutedEventArgs e)
        {
            UpdateCompetitionCategory();
        }

        private void WeightAbove_Checked(object sender, RoutedEventArgs e)
        {
            UpdateCompetitionCategory();
        }

        private void WeightTo_Checked(object sender, RoutedEventArgs e)
        {
            UpdateCompetitionCategory();
        }

        private void YearsFromChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            UpdateCompetitionCategory();
        }
        private void YearsToChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            UpdateCompetitionCategory();
        }
        private void CompetitorsWeightChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            UpdateCompetitionCategory();
        }

        DispatcherTimer WaitTimerLeft { get; set; }
        DispatcherTimer WaitTimerRight { get; set; }

        TimeSpan CountDownTimeLeft { get; set; } = TimeSpan.MinValue;
        TimeSpan CountDownTimeRight { get; set; } = TimeSpan.MinValue;

        private void WaitForCompetitorLeft(object sender, RoutedEventArgs e)
        {
            if (WaitTimerLeft == null)
                WaitTimerLeft = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Send, dispatcherTimerLeft, Application.Current.Dispatcher);


            if (WaitForCompetitorLeftText.Equals("Очікування спортсмена"))
            {
                CountDownTimeLeft = new TimeSpan(0, (int)WaitTimeMin, (int)WaitTimeSec);
                WaitTimerLeft.Start();
            }
            else
            {
                WaitTimerLeft.Stop();
                WaitForCompetitorLeftText = "Очікування спортсмена";
                WaitTimerLeft = null;
                WaitForCompetitorLeftTime = String.Empty;
            }
        }

        public void dispatcherTimerLeft(object sender, EventArgs e)
        {
           var TimeElapsed = CountDownTimeLeft.ToString(@"mm\:ss");//.ToString("c");
            WaitForCompetitorLeftText = TimeElapsed;
            WaitForCompetitorLeftTime = TimeElapsed;

            if (CountDownTimeLeft == TimeSpan.Zero)
                WaitTimerLeft.Stop();

            CountDownTimeLeft = CountDownTimeLeft.Add(TimeSpan.FromSeconds(-1));
        }

        private void WaitForCompetitorRight(object sender, RoutedEventArgs e)
        {
            if (WaitTimerRight == null)
                WaitTimerRight = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Send, dispatcherTimerRight, Application.Current.Dispatcher);


            if (WaitForCompetitorRightText.Equals("Очікування спортсмена"))
            {
                CountDownTimeRight = new TimeSpan(0, (int)WaitTimeMin, (int)WaitTimeSec);
                WaitTimerRight.Start();
            }
            else
            {
                WaitTimerRight.Stop();
                WaitForCompetitorRightText = "Очікування спортсмена";
                WaitTimerRight = null;
                WaitForCompetitorRightTime = String.Empty;
            }

        }
        public void dispatcherTimerRight(object sender, EventArgs e)
        {
            var TimeElapsed = CountDownTimeRight.ToString(@"mm\:ss");//.ToString("c");
            WaitForCompetitorRightText = TimeElapsed;
            WaitForCompetitorRightTime = TimeElapsed;

            if (CountDownTimeRight == TimeSpan.Zero)
                WaitTimerRight.Stop();

            CountDownTimeRight = CountDownTimeRight.Add(TimeSpan.FromSeconds(-1));
        }

        private void FirstTechAction_Checked(object sender, RoutedEventArgs e)
        {
            TimeDescription = "До першої технічної дії";
            Timer.TimeSet = new TimeSpan(0, 0, 0);
        }

        private void PlusScoreChecked(object sender, RoutedEventArgs e)
        {
            ScoreSign = "+";

            LeftOneButtonContent = $"+1";
            LeftTwoButtonContent = $"+2";
            LeftThreeButtonContent = $"+3";
            LeftFourButtonContent = $"+4";
            LeftFiveButtonContent = $"+5";
            LeftSixButtonContent = $"+6";
            LeftSevenButtonContent = $"+7";

            RightOneButtonContent = $"+1";
            RightTwoButtonContent = $"+2";
            RightThreeButtonContent = $"+3";
            RightFourButtonContent = $"+4";
            RightFiveButtonContent = $"+5";
            RightSixButtonContent = $"+6";
            RightSevenButtonContent = $"+7";
        }

        private void MinusScoreChecked(object sender, RoutedEventArgs e)
        {
            ScoreSign = "-";

            LeftOneButtonContent = $"-1";
            LeftTwoButtonContent = $"-2";
            LeftThreeButtonContent = $"-3";
            LeftFourButtonContent = $"-4";
            LeftFiveButtonContent = $"-5";
            LeftSixButtonContent = $"-6";
            LeftSevenButtonContent = $"-7";

            RightOneButtonContent = $"-1";
            RightTwoButtonContent = $"-2";
            RightThreeButtonContent = $"-3";
            RightFourButtonContent = $"-4";
            RightFiveButtonContent = $"-5";
            RightSixButtonContent = $"-6";
            RightSevenButtonContent = $"-7";
        }

        private void LeftOneButtonPressed(object sender, RoutedEventArgs e)
        {
            var score = CalculateScore(1, CompetitorLeftScore);
            CompetitorLeftScore = score;

            if (CompetitorLeftScore > 0)
                CompetitorLeftScoreHistory += $" {ScoreSign}{"1"}";
        }

        private void LeftTwoButtonPressed(object sender, RoutedEventArgs e)
        {
            var score = CalculateScore(2, CompetitorLeftScore);
            CompetitorLeftScore = score;

            if (CompetitorLeftScore > 0)
                CompetitorLeftScoreHistory += $" {ScoreSign}{"2"}";
        }

        private void LeftThreeButtonPressed(object sender, RoutedEventArgs e)
        {
            var score = CalculateScore(3, CompetitorLeftScore);
            CompetitorLeftScore = score;

            if (CompetitorLeftScore > 0)
                CompetitorLeftScoreHistory += $" {ScoreSign}{"3"}";
        }

        private void LeftFourButtonPressed(object sender, RoutedEventArgs e)
        {
            var score = CalculateScore(4, CompetitorLeftScore);
            CompetitorLeftScore = score;

            if (CompetitorLeftScore > 0)
                CompetitorLeftScoreHistory += $" {ScoreSign}{"4"}";
        }

        private void LeftFiveButtonPressed(object sender, RoutedEventArgs e)
        {
            var score = CalculateScore(5, CompetitorLeftScore);
            CompetitorLeftScore = score;

            if (CompetitorLeftScore > 0)
                CompetitorLeftScoreHistory += $" {ScoreSign}{"5"}";
        }

        private void LeftSixButtonPressed(object sender, RoutedEventArgs e)
        {
            var score = CalculateScore(6, CompetitorLeftScore);
            CompetitorLeftScore = score;

            if (CompetitorLeftScore > 0)
                CompetitorLeftScoreHistory += $" {ScoreSign}{"6"}";
        }

        private void LeftSevenButtonPressed(object sender, RoutedEventArgs e)
        {
            var score = CalculateScore(7, CompetitorLeftScore);
            CompetitorLeftScore = score;

            if (CompetitorLeftScore > 0)
                CompetitorLeftScoreHistory += $" {ScoreSign}{"7"}";
        }

        private void RightOneButtonPressed(object sender, RoutedEventArgs e)
        {
            var score = CalculateScore(1, CompetitorRightScore);
            CompetitorRightScore = score;

            if (CompetitorRightScore > 0)
                CompetitorRightScoreHistory += $" {ScoreSign}{"1"}";
        }

        private void RightTwoButtonPressed(object sender, RoutedEventArgs e)
        {
            var score = CalculateScore(2, CompetitorRightScore);
            CompetitorRightScore = score;

            if (CompetitorRightScore > 0)
                CompetitorRightScoreHistory += $" {ScoreSign}{"2"}";
        }

        private void RightThreeButtonPressed(object sender, RoutedEventArgs e)
        {
            var score = CalculateScore(3, CompetitorRightScore);
            CompetitorRightScore = score;

            if (CompetitorRightScore > 0)
                CompetitorRightScoreHistory += $" {ScoreSign}{"3"}";
        }

        private void RightFourButtonPressed(object sender, RoutedEventArgs e)
        {
            var score = CalculateScore(4, CompetitorRightScore);
            CompetitorRightScore = score;

            if (CompetitorRightScore > 0)
                CompetitorRightScoreHistory += $" {ScoreSign}{"4"}";
        }

        private void RightFiveButtonPressed(object sender, RoutedEventArgs e)
        {
            var score = CalculateScore(5, CompetitorRightScore);
            CompetitorRightScore = score;

            if (CompetitorRightScore > 0)
                CompetitorRightScoreHistory += $" {ScoreSign}{"5"}";
        }

        private void RightSixButtonPressed(object sender, RoutedEventArgs e)
        {
            var score = CalculateScore(6, CompetitorRightScore);
            CompetitorRightScore = score;

            if (CompetitorRightScore > 0)
                CompetitorRightScoreHistory += $" {ScoreSign}{"6"}";
        }

        private void RightSevenButtonPressed(object sender, RoutedEventArgs e)
        {
            var score = CalculateScore(7, CompetitorRightScore);
            CompetitorRightScore = score;

            if (CompetitorRightScore > 0)
                CompetitorRightScoreHistory += $" {ScoreSign}{"7"}";
        }

        private int CalculateScore(int scoreNewValue, int scoreCurrentValue)
        {
            int score = 0;

            if (ScoreSign.Equals("+"))
            {
                score = scoreCurrentValue + scoreNewValue;
            }
            else if (ScoreSign.Equals("-"))
            {
                if (scoreCurrentValue == 0 || scoreCurrentValue < 0)
                {
                   
                    return scoreCurrentValue;
                }
                score = scoreCurrentValue - scoreNewValue;
            }

            if (score <= 0)
                return 0;

            return score;
        }
        private void UpdateCompetitionCategory()
        {
            string res = string.Empty;

            StringBuilder sb = new StringBuilder();

            if (IsMale)
            {
                if (IsVeterans)
                    sb.Append("Чоловіки ветерани ");
                else
                    sb.Append("Хлопчики ");
            }
            else if (IsFeMale)
            {
                if (IsVeterans)
                    sb.Append("Жінки ветерани ");
                else
                    sb.Append("Дівчата ");
            }


            if (IsVeterans)
            {
                if (IsWeightOver)
                    sb.Append("вагою понад ");
                else if (IsWeightTo)
                    sb.Append("вагою до ");
            }
            else
            {
                sb.Append($"{YearsFrom}-{YearsTo} років ");

                if (IsWeightOver)
                    sb.Append("вагою понад ");
                else if (IsWeightTo)
                    sb.Append("вагою до ");
            }

            sb.Append($"{CompetitorsWeight} кг") ;

            CompetitionCategory = sb.ToString();
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            Init();
        }
        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void TimeResetButtonClick(object sender, RoutedEventArgs e)
        {
            if (mainTime.IsChecked == true)
            {
                MainTimeMin = 3;
                MainTimeSec = 0;
                Timer.TimeSet = new TimeSpan(0, (int)MainTimeMin, (int) MainTimeSec);
            }

            else if (addTime.IsChecked == true)
            {
                AddTimeMin = 1;
                AddTimeSec = 0;
                Timer.TimeSet = new TimeSpan(0, (int)AddTimeMin, (int)AddTimeSec);
            }
            else if (waitTime.IsChecked == true)
            {
                WaitTimeMin = 1;
                WaitTimeSec = 0;
                Timer.TimeSet = new TimeSpan(0, (int)WaitTimeMin, (int)WaitTimeSec);
            }
            else if (FirstTechAction.IsChecked == true)
            {
                Timer.TimeSet = new TimeSpan(0, 0, 0);
            }
        }

        private void HistoryResetButtonClick(object sender, RoutedEventArgs e)
        {
            CompetitorLeftScoreHistory = String.Empty;
            CompetitorRightScoreHistory = String.Empty;
        }

        private void ScoreResetButtonClick(object sender, RoutedEventArgs e)
        {
            CompetitorLeftScore = 0;
            CompetitorRightScore = 0;
        }

        private void AtanaiResetButtonClick(object sender, RoutedEventArgs e)
        {

        }

        private void AtanaiOneLeftButton_Checked(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Board.AtanaiOneLeft))
            {
                Board.AtanaiOneLeft = "1 Чукоку";
            }
        }

        private void AtanaiOneLeftButton_UnChecked(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(Board.AtanaiOneLeft))
            {
                Board.AtanaiOneLeft = string.Empty;
            }
        }
    }
}
