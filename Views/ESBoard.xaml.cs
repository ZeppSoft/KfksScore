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

namespace KfksScore
{
    /// <summary>
    /// Interaction logic for ESBoard.xaml
    /// </summary>
    public partial class ESBoard : Window
    {
        public IESBoard board { get; set; }
        public ESBoard()
        {
            InitializeComponent();
            this.Owner = App.Current.MainWindow;

            board = new Board();


            FillBoard();

            this.DataContext = board;
        }
        private void FillBoard()
        {

        }
    }
}
