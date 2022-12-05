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


        private int _competitorLeftScore;
        public int CompetitorLeftScore
        {
            get { return _competitorLeftScore; }
            set { _competitorLeftScore = value; OnPropertyChanged("CompetitorLeftScore"); }
        }

        private int _competitorRightScore;
        public int CompetitorRightScore
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
