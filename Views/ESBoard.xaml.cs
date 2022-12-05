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

            if (Screen.PrimaryScreen != currentScreen)
            {
                Board.FormSizeWidth = currentScreen.Bounds.Width; //(currentScreen.Bounds.Width / 2) - 100;
                Board.FormSizeHeight = currentScreen.Bounds.Height;//currentScreen.Bounds.Height - 250;
                //this.WindowState = WindowState.Maximized;
            }
        }
        private void FillBoard(IESBoard board)
        {
            Board = board;

            //DisplayWidth = (int)System.Windows.SystemParameters.PrimaryScreenWidth / 2;
            //DisplayHeight = (int)System.Windows.SystemParameters.PrimaryScreenHeight / 2;
        }
    }
}
