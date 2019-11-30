using BlackJack.Classes;
using System.Collections.Generic;
using System;
using System.Windows;
using System.Windows.Controls;

namespace BlackJack
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        public static bool BUSTED = false;

        public static int HouseProfileID = 0;
        public static int PlayerProfileID = 1;


        public MainWindow()
        {
            InitializeComponent();
            StartGame();
        }



        //START GAME
        void StartGame()
        {
            PlayerModule.GeneratePlayer(PlayerProfileID);
            HideUI();
            PlayerPlay2FirstCards();
        }



        //RESET
        void Reset()
        {
            PlayerModule.ResetTotalPointsValues();
            BUSTED = false;
            StartGame();
        }



        //BUTTONS
        private void Button_SplitDeck_Click(object sender, RoutedEventArgs e)
        {
        }
        private void Button_Stop_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Button_AddCard_Click(object sender, RoutedEventArgs e)
        {
            PlayerButtonAddCard();
        }
        private void Button_Reset_Click(object sender, RoutedEventArgs e)
        {
            Reset();
        }



        //UI
        private void HideUI()
        {
            BackgroundOfGame.Source = ImageModule.GetBackground(); //TODO: MAKE BACKGROUND WORK

            Label_HouseCard1.Visibility = Visibility.Hidden;
            Label_HouseCard2.Visibility = Visibility.Hidden;
            Label_HouseCard3.Visibility = Visibility.Hidden;
            Label_HouseCard4.Visibility = Visibility.Hidden;
            Label_HouseCard5.Visibility = Visibility.Hidden;

            Label_Busted.Visibility = Visibility.Hidden;

            Image_Card3.Visibility = Visibility.Hidden;
            Image_Card4.Visibility = Visibility.Hidden;
            Image_Card5.Visibility = Visibility.Hidden;
            Image_Card6.Visibility = Visibility.Hidden;
        }



        //DISPLAY POINTS 
        private void DisplayPoints()
        {
            //if you lost, it will show the "BUSTED" label
            if (BUSTED == true)
            {
                Label_Busted.Visibility = Visibility.Visible;
            }
            else
            {
                //Show total points
                Label_Points.Content = PlayerModule.GetTotalPoints();
            }
        }



        //PLAY THE FIRST TWO CARDS
        private void PlayerPlay2FirstCards()
        {
            //Get Card #1
            Card Card1 = Mechanics.PlayCard();

            Image_Card1.Source = ImageModule.GetImage(Card1.CardId);

            //Get Card #2
            Card Card2 = Mechanics.PlayCard();

            Image_Card2.Source = ImageModule.GetImage(Card2.CardId);

            //Mostrar a pontuação
            DisplayPoints();
        }



        //PLAY ONE CARD WHEN BUTTON CLICKED
        private void PlayerButtonAddCard()
        {
            //Função para adicionar cartas
            int CurrentCount = PlayerModule.Player_CardsPlayed.Count;

            if (BUSTED != true)
            {
                switch (CurrentCount)
                {
                    case 2: //se ja houverem duas cartas pode jogar a terceira
                        Card Card3 = Mechanics.PlayCard();

                        Image_Card3.Visibility = Visibility.Visible;
                        Image_Card3.Source = ImageModule.GetImage(Card3.CardId);
                        break;

                    case 3://se ja houverem tres cartas pode jogar a quarta
                        Card Card4 = Mechanics.PlayCard();

                        Image_Card4.Visibility = Visibility.Visible;
                        Image_Card4.Source = ImageModule.GetImage(Card4.CardId);
                        break;

                    case 4://se ja houverem quatro cartas pode jogar a quinta
                        Card Card5 = Mechanics.PlayCard();

                        Image_Card5.Visibility = Visibility.Visible;
                        Image_Card5.Source = ImageModule.GetImage(Card5.CardId);
                        break;

                    case 5://se ja houverem cinco cartas pode jogar a sexta
                        Card Card6 = Mechanics.PlayCard();

                        Image_Card6.Visibility = Visibility.Visible;
                        Image_Card6.Source = ImageModule.GetImage(Card6.CardId);
                        break;
                }
            }
            //mostrar a pontuação
            DisplayPoints();
        }
    }
}
