using KfksScore.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace KfksScore.Models
{
    public class Board : IESBoard, INotifyPropertyChanged
    {
        public Board()
        {
            //CompetitionName = "Зимове змагання КФКС";
            //CompetitionCategory = "Хлопчики 10-11 років вагою до 42кг";

            //DisplayWidth = ((int)System.Windows.SystemParameters.PrimaryScreenWidth / 2) - 100;
            //DisplayHeight = (int)System.Windows.SystemParameters.PrimaryScreenHeight - 250;

            //CompetitorLeftScore = 1;
            //CompetitorRightScore = 2;

            //CompetitorLeftName = "Петренко Петро";
            //CompetitorRightName = "Васильченко Василь";

        }
       
        #region IESBoard
        private string _competitionName;
        public string CompetitionName 
        { 
            get { return _competitionName; }
            set { _competitionName = value; OnPropertyChanged("CompetitionName"); }
        }

        private string _сompetitionCategory;
        public string CompetitionCategory
        {
            get { return _сompetitionCategory; }
            set { _сompetitionCategory = value; OnPropertyChanged("CompetitionCategory"); }
        }
        private string _сompetitionTime;
        public string CompetitionTime
        {
            get { return _сompetitionTime; }
            set { _сompetitionTime = value; OnPropertyChanged("CompetitionTime"); }
        }

        private string _сompetitionScore;
        public string CompetitionScore
        {
            get { return _сompetitionScore; }
            set { _сompetitionScore = value; OnPropertyChanged("CompetitionScore"); }
        }

        private int _displayWidth;
        public int DisplayWidth
        {
            get { return _displayWidth; }
            set { _displayWidth = value; OnPropertyChanged("DisplayWidth"); }
        }

        private int _displayHeight;
        public int DisplayHeight
        {
            get { return _displayHeight; }
            set { _displayHeight = value; OnPropertyChanged("DisplayHeight"); }
        }


        private double _competitorLeftScore;
        public double CompetitorLeftScore
        {
            get { return _competitorLeftScore; }
            set { _competitorLeftScore = value; OnPropertyChanged("CompetitorLeftScore"); }
        }

        private double _competitorRightScore;
        public double CompetitorRightScore
        {
            get { return _competitorRightScore; }
            set { _competitorRightScore = value; OnPropertyChanged("CompetitorRightScore"); }
        }

        private string _competitorLeftName;
        public string CompetitorLeftName
        {
            get { return _competitorLeftName; }
            set { _competitorLeftName = value; OnPropertyChanged("CompetitorLeftName"); }
        }

        private string _competitorRightName;
        public string CompetitorRightName
        {
            get { return _competitorRightName; }
            set { _competitorRightName = value; OnPropertyChanged("CompetitorRightName"); }
        }

        private int _formSizeWidth = (int)System.Windows.SystemParameters.PrimaryScreenWidth;
        public int FormSizeWidth 
        {
            get { return _formSizeWidth; }
            set { _formSizeWidth = value; OnPropertyChanged("FormSizeWidth"); }
        }

        private int _formSizeHeight = (int)System.Windows.SystemParameters.PrimaryScreenHeight;
        public int FormSizeHeight
        {
            get { return _formSizeHeight; }
            set { _formSizeHeight = value; OnPropertyChanged("FormSizeHeight"); }
        }

        private decimal _tatamiNumber = 0;
        public decimal TatamiNumber
        {
            get { return _tatamiNumber; }
            set { _tatamiNumber = value; OnPropertyChanged("TatamiNumber"); }
        }


        private string _competitorLeftScoreHistory;
        public string CompetitorLeftScoreHistory
        {
            get { return _competitorLeftScoreHistory; }
            set { _competitorLeftScoreHistory = value; OnPropertyChanged("CompetitorLeftScoreHistory"); }
        }

        private string _competitorRightScoreHistory;
        public string CompetitorRightScoreHistory
        {
            get { return _competitorRightScoreHistory; }
            set { _competitorRightScoreHistory = value; OnPropertyChanged("CompetitorRightScoreHistory"); }
        }

        private string _timeDescription;

        public string TimeDescription 
        {
            get { return _timeDescription; }
            set { _timeDescription = value; OnPropertyChanged("TimeDescription"); }
        }
        private string _waitForCompetitorLeftText;
        public string WaitForCompetitorLeftText
        {
            get { return _waitForCompetitorLeftText; }
            set { _waitForCompetitorLeftText = value; OnPropertyChanged("WaitForCompetitorLeftText"); }
        }

        private string _waitForCompetitorRightText;
        public string WaitForCompetitorRightText
        {
            get { return _waitForCompetitorRightText; }
            set { _waitForCompetitorRightText = value; OnPropertyChanged("WaitForCompetitorRightText"); }
        }

        private string _atanaiOneLeft = string.Empty;
        public string AtanaiOneLeft 
        {
            get { return _atanaiOneLeft; }
            set { _atanaiOneLeft = value; OnPropertyChanged("AtanaiOneLeft"); }
        }

        private string _atanaiTwoLeft = string.Empty;
        public string AtanaiTwoLeft
        {
            get { return _atanaiTwoLeft; }
            set { _atanaiTwoLeft = value; OnPropertyChanged("AtanaiTwoLeft"); }
        }
        private string _atanaiThreeLeft = string.Empty;
        public string AtanaiThreeLeft
        {
            get { return _atanaiThreeLeft; }
            set { _atanaiThreeLeft = value; OnPropertyChanged("AtanaiThreeLeft"); }
        }
        private string _atanaiFourLeft = string.Empty;
        public string AtanaiFourLeft
        {
            get { return _atanaiFourLeft; }
            set { _atanaiFourLeft = value; OnPropertyChanged("AtanaiFourLeft"); }
        }

        private string _atanaiFiveLeft = string.Empty;
        public string AtanaiFiveLeft
        {
            get { return _atanaiFiveLeft; }
            set { _atanaiFiveLeft = value; OnPropertyChanged("AtanaiFiveLeft"); }
        }

        private string _atanaiSixLeft = string.Empty;
        public string AtanaiSixLeft
        {
            get { return _atanaiSixLeft; }
            set { _atanaiSixLeft = value; OnPropertyChanged("AtanaiSixLeft"); }
        }

        private string _atanaiSevenLeft = string.Empty;
        public string AtanaiSevenLeft
        {
            get { return _atanaiSevenLeft; }
            set { _atanaiSevenLeft = value; OnPropertyChanged("AtanaiSevenLeft"); }
        }

        private string _atanaiEightLeft = string.Empty;
        public string AtanaiEightLeft
        {
            get { return _atanaiEightLeft; }
            set { _atanaiEightLeft = value; OnPropertyChanged("AtanaiEightLeft"); }
        }

        private string _atanaiNineLeft = string.Empty;
        public string AtanaiNineLeft
        {
            get { return _atanaiNineLeft; }
            set { _atanaiNineLeft = value; OnPropertyChanged("AtanaiNineLeft"); }
        }

        private string _atanaiTenLeft = string.Empty;
        public string AtanaiTenLeft
        {
            get { return _atanaiTenLeft; }
            set { _atanaiTenLeft = value; OnPropertyChanged("AtanaiTenLeft"); }
        }

        private int _scoreFontSize;
        public int ScoreFontSize 
        {
            get { return _scoreFontSize; }
            set { _scoreFontSize = value; OnPropertyChanged("ScoreFontSize"); }
        }

        private string _atanaiOneRight = string.Empty;
        public string AtanaiOneRight
        {
            get { return _atanaiOneRight; }
            set { _atanaiOneRight = value; OnPropertyChanged("AtanaiOneRight"); }
        }

        private string _atanaiTwoRight = string.Empty;
        public string AtanaiTwoRight
        {
            get { return _atanaiTwoRight; }
            set { _atanaiTwoRight = value; OnPropertyChanged("AtanaiTwoRight"); }
        }

        private string _atanaiThreeRight = string.Empty;
        public string AtanaiThreeRight
        {
            get { return _atanaiThreeRight; }
            set { _atanaiThreeRight = value; OnPropertyChanged("AtanaiThreeRight"); }
        }

        private string _atanaiFourRight = string.Empty;
        public string AtanaiFourRight
        {
            get { return _atanaiFourRight; }
            set { _atanaiFourRight = value; OnPropertyChanged("AtanaiFourRight"); }
        }

        private string _atanaiFiveRight = string.Empty;
        public string AtanaiFiveRight
        {
            get { return _atanaiFiveRight; }
            set { _atanaiFiveRight = value; OnPropertyChanged("AtanaiFiveRight"); }
        }

        private string _atanaiSixRight = string.Empty;
        public string AtanaiSixRight
        {
            get { return _atanaiSixRight; }
            set { _atanaiSixRight = value; OnPropertyChanged("AtanaiSixRight"); }
        }

        private string _atanaiSevenRight = string.Empty;
        public string AtanaiSevenRight
        {
            get { return _atanaiSevenRight; }
            set { _atanaiSevenRight = value; OnPropertyChanged("AtanaiSevenRight"); }
        }

        private string _atanaiEightRight = string.Empty;
        public string AtanaiEightRight
        {
            get { return _atanaiEightRight; }
            set { _atanaiEightRight = value; OnPropertyChanged("AtanaiEightRight"); }
        }

        private string _atanaiNineRight = string.Empty;
        public string AtanaiNineRight
        {
            get { return _atanaiNineRight; }
            set { _atanaiNineRight = value; OnPropertyChanged("AtanaiNineRight"); }
        }

        private string _atanaiTenRight = string.Empty;
        public string AtanaiTenRight
        {
            get { return _atanaiTenRight; }
            set { _atanaiTenRight = value; OnPropertyChanged("AtanaiTenRight"); }
        }

       

        // public Timer Timer { get; set; } = new Timer();
        #endregion

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
        #endregion
    }
}
