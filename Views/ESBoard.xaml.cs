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
using System.Windows.Shapes;
using System.Windows.Forms;
using Timer = KfksScore.Models.Timer;

namespace KfksScore
{
    /// <summary>
    /// Interaction logic for ESBoard.xaml
    /// </summary>
    public partial class ESBoard : Window
    {
        public IESBoard Board { get; set; }
        public Timer Timer { get; set; }

      
        public ESBoard(IESBoard board, Timer timer)
        {
            InitializeComponent();
            this.Owner = App.Current.MainWindow;

            //Board = new Board();

            Timer = timer;
            FillBoard(board);

            //this.DataContext = Board;
            this.DataContext = this;

        }
        private Screen GetSecondaryScreen()
        {
            foreach (Screen screen in Screen.AllScreens)
            {
                if (screen != Screen.PrimaryScreen)
                    return screen;
            }
            return Screen.PrimaryScreen;
        }

        private void Window_LocationChanged(object sender, EventArgs e)
        {
           



            //System.Windows.Forms.SystemInformation.MonitorCount;

            var currentScreen = GetSecondaryScreen();

            var controlsize = (double)Math.Round((400 / 1080.0) * currentScreen.Bounds.Height, 0);

            System.Windows.Application.Current.Resources.Remove("ControlFontSize");
            System.Windows.Application.Current.Resources.Add("ControlFontSize", controlsize);

            //if (Screen.PrimaryScreen != currentScreen)
            //{
          
                Board.FormSizeWidth = currentScreen.Bounds.Width; //1280;//currentScreen.Bounds.Width; //(currentScreen.Bounds.Width / 2) - 100;
                Board.FormSizeHeight = currentScreen.Bounds.Height;//720;//currentScreen.Bounds.Height;//currentScreen.Bounds.Height - 250;

                //Board.DisplayWidth = (int)(Board.FormSizeWidth * 0.50) -50;//(int)(Board.FormSizeWidth * 0.48);//(int)(Board.FormSizeWidth * 0.42); //(Board.FormSizeWidth / 2) - 100; //540 42%
                //Board.DisplayHeight = (int)(Board.FormSizeHeight * 0.65) ;//(int)(Board.FormSizeHeight * 0.65) ;////Board.FormSizeHeight/5;
                Board.ScoreFontSize = (int)Math.Round((25 / 1080.0) * currentScreen.Bounds.Height, 0);
              
            //this.WindowState = WindowState.Maximized;
            //}
        }
        private void FillBoard(IESBoard board)
        {
            Board = board;
            //LeftCompetitorPanel.Visibility = Visibility.Collapsed;
           
        }

        private void Board_Closed(object sender, EventArgs e)
        {
            var owner = (KfksScore.MainWindow)this.Owner  ;
            owner.eSBoard = null;
            owner.ContentBoardButton = "Електронне табло";
        }
    }
}
