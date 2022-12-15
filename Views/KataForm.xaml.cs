using DevExpress.ClipboardSource.SpreadsheetML;
using KfksScore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace KfksScore.Views
{
    /// <summary>
    /// Interaction logic for KataForm.xaml
    /// </summary>
    public partial class KataForm : Window
    {
        public IKataForm Kata{ get; set; }
        public bool IsLeft { get; set; }
        private int minScore = 5;

        public KataForm(IKataForm kata, int judgesNum,  bool isLeft = false)
        {
            InitializeComponent();
            Kata = kata;
            IsLeft = isLeft;
            this.Owner = App.Current.MainWindow;
            this.DataContext = this;
            JudgesNum = judgesNum;

            //judgeScore1Check.IsChecked = true;
            //judgeScore2Check.IsChecked = true;
            //judgeScore3Check.IsChecked = true;
            //judgeScore4Check.IsChecked = true;
            //judgeScore5Check.IsChecked = true;
        }

        private void ButtonSendScore_Click(object sender, RoutedEventArgs e)
        {
            var owner = (KfksScore.MainWindow)this.Owner;

           

            if (Kata != null && Kata.AverageScore != 0 && Kata.AverageScore > 0)
            {
                Kata.ScoreHistory = Kata.GetScoreHistory();

                if (IsLeft)
                    owner.KataResultLeft = new KataResult(Kata.AverageScore, Kata.ScoreHistory);
                else
                    owner.KataResultRight = new KataResult(Kata.AverageScore, Kata.ScoreHistory);
            }

            Close();
        }

        private void JudgeScore1Changed(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Kata.AverageScore = Kata.CalculateAverage();
        }

        private void JudgeScore2Changed(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Kata.AverageScore = Kata.CalculateAverage();
        }

        private void JudgeScore3Changed(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Kata.AverageScore = Kata.CalculateAverage();
        }

        private void JudgeScore4Changed(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Kata.AverageScore = Kata.CalculateAverage();
        }

        private void JudgeScore5Changed(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e)
        {
            Kata.AverageScore = Kata.CalculateAverage();
        }

        private void judgeScore1Check_Checked(object sender, RoutedEventArgs e)
        {
            judgeScore1Label.IsEnabled = true;
            judgeScore1.IsEnabled = true;
            Kata.JudgeScore1 = minScore;
        }

        private void judgeScore1Check_UnChecked(object sender, RoutedEventArgs e)
        {
            //judgeScore1Label.IsEnabled = false;
            //judgeScore1.IsEnabled = false;
            //Kata.JudgeScore1 = 0;
        }

        private void judgeScore2Check_Checked(object sender, RoutedEventArgs e)
        {
            judgeScore2Label.IsEnabled = true;
            judgeScore2.IsEnabled = true;
            Kata.JudgeScore2 = minScore;

        }

        private void judgeScore2Check_UnChecked(object sender, RoutedEventArgs e)
        {
            //judgeScore2Label.IsEnabled = false;
            //judgeScore2.IsEnabled = false;
            //Kata.JudgeScore2 = 0;

        }

        private void judgeScore3Check_Checked(object sender, RoutedEventArgs e)
        {
            judgeScore3Label.IsEnabled = true;
            judgeScore3.IsEnabled = true;
            Kata.JudgeScore3 = minScore;

        }

        private void judgeScore3Check_UnChecked(object sender, RoutedEventArgs e)
        {
            //judgeScore3Label.IsEnabled = false;
            //judgeScore3.IsEnabled = false;
            //Kata.JudgeScore3 = 0;

        }

        private void judgeScore4Check_Checked(object sender, RoutedEventArgs e)
        {
            judgeScore4Label.IsEnabled = true;
            judgeScore4.IsEnabled = true;
            Kata.JudgeScore4 = minScore;

        }

        private void judgeScore4Check_UnChecked(object sender, RoutedEventArgs e)
        {
            judgeScore4Label.IsEnabled = false;
            judgeScore4.IsEnabled = false;
            Kata.JudgeScore4 = 0;

        }

        private void judgeScore5Check_Checked(object sender, RoutedEventArgs e)
        {
            judgeScore5Label.IsEnabled = true;
            judgeScore5.IsEnabled = true;
            Kata.JudgeScore5 = minScore;

        }

        private void judgeScore5Check_UnChecked(object sender, RoutedEventArgs e)
        {
            judgeScore5Label.IsEnabled = false;
            judgeScore5.IsEnabled = false;
            Kata.JudgeScore5 = 0;

        }

        private int _judgesNum;
        public int JudgesNum 
        {
            get { return _judgesNum; }
            set { _judgesNum = value; if (_judgesNum > 0) SetJudges(_judgesNum); }
        }

        

        private void SetJudges(int judgesNum)
        {
            switch (judgesNum)
            {
                case 3:
                    {
                        judgeScore1Check.IsChecked = null;
                        judgeScore1Check.IsChecked = true;
                        Kata.JudgeScore1 = minScore;

                        judgeScore2Check.IsChecked = null;
                        judgeScore2Check.IsChecked = true;
                        Kata.JudgeScore2 = minScore;

                        judgeScore3Check.IsChecked = null;
                        judgeScore3Check.IsChecked = true;
                        Kata.JudgeScore3 = minScore;

                        judgeScore4Check.IsChecked = null;
                        judgeScore4Check.IsChecked = false;
                        Kata.JudgeScore4 = 0;

                        judgeScore5Check.IsChecked = null;
                        judgeScore5Check.IsChecked = false;
                        Kata.JudgeScore5 = 0;
                    }
                    break;
                case 4:
                    {
                        judgeScore1Check.IsChecked = null;
                        judgeScore1Check.IsChecked = true;
                        Kata.JudgeScore1 = minScore;

                        judgeScore2Check.IsChecked = null;
                        judgeScore2Check.IsChecked = true;
                        Kata.JudgeScore2 = minScore;

                        judgeScore3Check.IsChecked = null;
                        judgeScore3Check.IsChecked = true;
                        Kata.JudgeScore3 = minScore;

                        judgeScore4Check.IsChecked = null;
                        judgeScore4Check.IsChecked = true;
                        Kata.JudgeScore4 = minScore;

                        judgeScore5Check.IsChecked = null;
                        judgeScore5Check.IsChecked = false;
                        Kata.JudgeScore5 = 0;
                    }
                    break;
                case 5:
                    {
                        judgeScore1Check.IsChecked = null;
                        judgeScore1Check.IsChecked = true;
                        Kata.JudgeScore1 = minScore;

                        judgeScore2Check.IsChecked = null;
                        judgeScore2Check.IsChecked = true;
                        Kata.JudgeScore2 = minScore;

                        judgeScore3Check.IsChecked = null;
                        judgeScore3Check.IsChecked = true;
                        Kata.JudgeScore3 = minScore;

                        judgeScore4Check.IsChecked = null;
                        judgeScore4Check.IsChecked = true;
                        Kata.JudgeScore4 = minScore;

                        judgeScore5Check.IsChecked = null;
                        judgeScore5Check.IsChecked = true;
                        Kata.JudgeScore5 = minScore;
                    }
                    break;
            }
        }

        private void KataForm_Closed(object sender, EventArgs e)
        {
            var owner = (KfksScore.MainWindow)this.Owner;
            owner.KataFormViewModel = null;
        }
    }
}
