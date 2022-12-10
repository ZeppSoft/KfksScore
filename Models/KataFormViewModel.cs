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
    public class KataFormViewModel : IKataForm, INotifyPropertyChanged
    {
        public double JudgeScore1 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double JudgeScore2 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double JudgeScore3 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double JudgeScore4 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double JudgeScore5 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double AverageScore { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string ScoreHistory { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
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
