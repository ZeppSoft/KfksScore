using KfksScore.Interfaces;
using KfksScore.Models;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KfksScore
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = Board;

           // eSBoard.Board = Board;
        }

        private ESBoard eSBoard;
        public IESBoard Board { get; set; } = new Board();
        //public IESBoard Board { get; set; }
        public string CompetitionName { get { return Board.CompetitionName; } set { Board.CompetitionName = value; } }
        public string CompetitionCategory { get { return Board.CompetitionCategory; } set { Board.CompetitionCategory = value; } }
        public string CompetitionTime { get { return Board.CompetitionTime; } set { Board.CompetitionTime = value; } }
        public string CompetitionScore { get { return Board.CompetitionScore; } set { Board.CompetitionScore = value; } }

        private void ESBoard_Button_Click(object sender, RoutedEventArgs e)
        {
            if (eSBoard == null)
            {
                eSBoard = new ESBoard(Board);
                eSBoard.Show();
            }

            //if (eSBoard.ShowDialog().Equals(true))
            //{

            //}
        }
    }
}
