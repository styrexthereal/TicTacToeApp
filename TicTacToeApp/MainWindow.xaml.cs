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

namespace TicTacToeApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string X = "X";
        private const string O = "O";
        private string turn = X;
        private int turnCount = 0;


        public MainWindow()
        {
            InitializeComponent();
        }
        int count = 0;

        void click_start(object sender, RoutedEventArgs e)
        {
            btn_1.IsEnabled = true;
            btn_2.IsEnabled = true;
            btn_3.IsEnabled = true;
            btn_4.IsEnabled = true;
            btn_5.IsEnabled = true;
            btn_6.IsEnabled = true;
            btn_7.IsEnabled = true;
            btn_8.IsEnabled = true;
            btn_9.IsEnabled = true;

            btn_1.Content = "";
            btn_2.Content = "";
            btn_3.Content = "";
            btn_4.Content = "";
            btn_5.Content = "";
            btn_6.Content = "";
            btn_7.Content = "";
            btn_8.Content = "";
            btn_9.Content = "";

            lbl_popup.Visibility = Visibility.Hidden;
        }

        void click_1(object sender, RoutedEventArgs e)
        {
            btn_1.Content = turn;
            btn_1.IsEnabled = false;
            CheckForWinner();
            SwitchTurn();
        }

        void click_2(object sender, RoutedEventArgs e)
        {
            btn_2.Content = turn;
            btn_2.IsEnabled = false;
            CheckForWinner();
            SwitchTurn();
        }

        void click_3(object sender, RoutedEventArgs e)
        {
            btn_3.Content = turn;
            btn_3.IsEnabled = false;
            CheckForWinner();
            SwitchTurn();
        }

        void click_4(object sender, RoutedEventArgs e)
        {
            btn_4.Content = turn;
            btn_4.IsEnabled = false;
            CheckForWinner();
            SwitchTurn();
        }

        void click_5(object sender, RoutedEventArgs e)
        {
            btn_5.Content = turn;
            btn_5.IsEnabled = false;
            CheckForWinner();
            SwitchTurn();
        }

        void click_6(object sender, RoutedEventArgs e)
        {
            btn_6.Content = turn;
            btn_6.IsEnabled = false;
            CheckForWinner();
            SwitchTurn();
        }

        void click_7(object sender, RoutedEventArgs e)
        {
            btn_7.Content = turn;
            btn_7.IsEnabled = false;
            CheckForWinner();
            SwitchTurn();
        }

        void click_8(object sender, RoutedEventArgs e)
        {
            btn_8.Content = turn;
            btn_8.IsEnabled = false;
            CheckForWinner();
            SwitchTurn();
        }

        void click_9(object sender, RoutedEventArgs e)
        {
            btn_9.Content = turn;
            btn_9.IsEnabled = false;
            CheckForWinner();
            SwitchTurn();
        }

        private void SwitchTurn()
        {
            if (turn == X)
            {
                turn = O;
            }
            else
            {
                turn = X;
            }
        }

        private void CheckForWinner()
        {
            if (
                (btn_1.Content == btn_2.Content && btn_2.Content == btn_3.Content && !btn_1.IsEnabled) || // erste Reihe überprüfen
                (btn_4.Content == btn_5.Content && btn_5.Content == btn_6.Content && !btn_4.IsEnabled) || // zweite Reihe überprüfen
                (btn_7.Content == btn_8.Content && btn_8.Content == btn_9.Content && !btn_7.IsEnabled) || // dritte Reihe überprüfen
                (btn_1.Content == btn_4.Content && btn_4.Content == btn_7.Content && !btn_1.IsEnabled) || // erste Spalte überprüfen
                (btn_2.Content == btn_5.Content && btn_5.Content == btn_8.Content && !btn_2.IsEnabled) || // zweite Spalte überprüfen
                (btn_3.Content == btn_6.Content && btn_6.Content == btn_9.Content && !btn_3.IsEnabled) || // dritte Spalte überprüfen
                (btn_1.Content == btn_5.Content && btn_5.Content == btn_9.Content && !btn_1.IsEnabled) || // diagonal 1
                (btn_3.Content == btn_5.Content && btn_5.Content == btn_7.Content && !btn_3.IsEnabled) // diagonal 2
                )
            {
                lbl_popup.Visibility = Visibility.Visible;
                lbl_popup.Content = $"Spieler {turn} hat gewonnen!";
                turnCount = 0;
            }
            else
            {
                turnCount++;
                if (turnCount == 9)
                {
                    lbl_popup.Visibility = Visibility.Visible;
                    lbl_popup.Content = "Unentschieden!";
                }
            }
        }
    }
}