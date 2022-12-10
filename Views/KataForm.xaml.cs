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

        public KataForm(IKataForm kata, bool isLeft = false)
        {
            InitializeComponent();
            Kata = kata;
            IsLeft = isLeft;
            this.Owner = App.Current.MainWindow;
            this.DataContext = this;
        }

        private void ButtonSendScore_Click(object sender, RoutedEventArgs e)
        {
            var owner = (KfksScore.MainWindow)this.Owner;

            //DELETE IT
            //owner.KataResultLeft = new KataResult(10.3, "1+2+3");

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
    }
}
