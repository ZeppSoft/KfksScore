using KfksScore.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace KfksScore.Models
{
    public class Board : IESBoard, INotifyPropertyChanged
    {
        public Board()
        {
            //CompetitionName = "Название соревнования";
            //CompetitionCategory = "Мальчики 10-11 лет весом до 42кг";
            //CompetitionTime = "Основное время";
            //CompetitionScore = "Счёт";
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
