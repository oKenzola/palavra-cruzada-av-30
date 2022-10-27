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

namespace palavra_cruzada
    {
        public partial class MainWindow : Window
        {
            string palavra1 = "";
            string palavra2 = "";
            string palavra3 = "";
            string palavra4 = "";
            string palavra5 = "";
            string palavra6 = "";
            string palavra7 = "";
            string palavra8 = "";
            string palavra9 = "";
            string palavra10 = "";
            public MainWindow()
            {
                InitializeComponent();
            }

            private void click1(object sender, RoutedEventArgs e)
            {

                MessageBox.Show(
                "Sorvete feito de ______ de neve.",
                "Dica 1",
                MessageBoxButton.OK,
                MessageBoxImage.Information);

            }

            private void click2(object sender, RoutedEventArgs e)
            {
                MessageBox.Show(
                "Uma substituta para óculos.",
                "Dica 2",
                MessageBoxButton.OK,
                MessageBoxImage.Information);
            }

            private void click3(object sender, RoutedEventArgs e)
            {
                MessageBox.Show(
                "Um lugar com MUITA água",
                "Dica 3",
                MessageBoxButton.OK,
                MessageBoxImage.Information);
            }

            private void click4(object sender, RoutedEventArgs e)
            {
                MessageBox.Show(
                "Jogo do estilo FPS da empresa Riot Games",
                "Dica 4",
                MessageBoxButton.OK,
                MessageBoxImage.Information);
            }

            private void click5(object sender, RoutedEventArgs e)
            {
                MessageBox.Show(
                "Engine utilizada pela maioria dos jogos AAA.",
                "Dica 5",
                MessageBoxButton.OK,
                MessageBoxImage.Information);
            }

            private void click6(object sender, RoutedEventArgs e)
            {
                MessageBox.Show(
                "Um aplicativo muito utilizado para transportar pessoas.",
                "Dica 6",
                MessageBoxButton.OK,
                MessageBoxImage.Information);
            }

            private void click7(object sender, RoutedEventArgs e)
            {
                MessageBox.Show(
                "Hashira do fogo no anime Kimetsu no Yaiba.",
                "Dica 7",
                MessageBoxButton.OK,
                MessageBoxImage.Information);
            }

            private void click8(object sender, RoutedEventArgs e)
            {
                MessageBox.Show(
                "O maior medo do vivo é estar _____.",
                "Dica 8",
                MessageBoxButton.OK,
                MessageBoxImage.Information);
            }

            private void click9(object sender, RoutedEventArgs e)
            {
                MessageBox.Show(
                "Temos nosso próprio _____...",
                "Dica 9",
                MessageBoxButton.OK,
                MessageBoxImage.Information);
            }

            private void click10(object sender, RoutedEventArgs e)
            {
                MessageBox.Show(
                "Local mais alto de uma casa ou um parceiro musical do artista Matue.",
                "Dica 10",
                MessageBoxButton.OK,
                MessageBoxImage.Information);
            }
            private void logicaFlocos()
            {

            if (txtFlocos1.Text.ToUpper() == "F" && txtFlocos2.Text.ToUpper() == "L" && txtFlocos3_Teto4.Text.ToUpper() == "O" && txtFlocos4.Text.ToUpper() == "C" && txtFlocos5.Text.ToUpper() == "O" && txtFlocos6.Text.ToUpper() == "S")
                {
                    if (palavra1 == "FLOCOS")
                    {
                        txtFlocos1.Text = "F";
                        txtFlocos2.Text = "L";
                        txtFlocos3_Teto4.Text = "O";
                        txtFlocos4.Text = "C";
                        txtFlocos5.Text = "O";
                        txtFlocos6.Text = "S";
                        txtFlocos1.Background = Brushes.LightSkyBlue;
                        txtFlocos2.Background = Brushes.LightSkyBlue;
                        txtFlocos3_Teto4.Background = Brushes.LightSkyBlue;
                        txtFlocos4.Background = Brushes.LightSkyBlue;
                        txtFlocos5.Background = Brushes.LightSkyBlue;
                        txtFlocos6.Background = Brushes.LightSkyBlue;
                        txtFlocos1.IsEnabled = false;
                        txtFlocos2.IsEnabled = false;
                        txtFlocos3_Teto4.IsEnabled = false;
                        txtFlocos4.IsEnabled = false;
                        txtFlocos5.IsEnabled = false;
                        txtFlocos6.IsEnabled = false;
                    }
                }
            }

 
            private void logicaLente()
            {
                if (txtLente1.Text.ToUpper() == "L" && txtTeto2_txtLente2.Text.ToUpper() == "E" && txtLente3.Text.ToUpper() == "N" && txtLente4.Text.ToUpper() == "T" && txtLente5.Text.ToUpper() == "E")
                {
                    if (palavra2 == "LENTE")
                    {
                    txtLente1.Text = "L";
                    txtTeto2_txtLente2.Text = "E";
                    txtLente3.Text = "N";
                    txtLente4.Text = "T";
                    txtLente5.Text = "E";
                    txtLente1.Background = Brushes.LightSkyBlue;
                    txtTeto2_txtLente2.Background = Brushes.LightSkyBlue;
                    txtLente3.Background = Brushes.LightSkyBlue;
                    txtLente4.Background = Brushes.LightSkyBlue;
                    txtLente5.Background = Brushes.LightSkyBlue;
                    txtLente1.IsEnabled = false;
                    txtTeto2_txtLente2.IsEnabled = false;
                    txtLente3.IsEnabled = false;
                    txtLente4.IsEnabled = false;
                    txtLente5.IsEnabled = false;

                    }

                }
            }
        private void logicaPraia()
        {

            if (txtPraia1.Text.ToUpper() == "P" && txtPraia2.Text.ToUpper() == "R" && txtPraia3_Valorant2.Text.ToUpper() == "A" && txtPraia4.Text.ToUpper() == "I" && txtPraia5.Text.ToUpper() == "A")
            {
                if (palavra3 == "PRAIA")
                {
                    txtPraia1.Text = "P";
                    txtPraia2.Text = "R";
                    txtPraia3_Valorant2.Text = "A";
                    txtPraia4.Text = "I";
                    txtPraia5.Text = "A";
                    txtPraia1.Background = Brushes.LightSkyBlue;
                    txtPraia2.Background = Brushes.LightSkyBlue;
                    txtPraia3_Valorant2.Background = Brushes.LightSkyBlue;
                    txtPraia4.Background = Brushes.LightSkyBlue;
                    txtPraia5.Background = Brushes.LightSkyBlue;
                    txtPraia1.IsEnabled = false;
                    txtPraia2.IsEnabled = false;
                    txtPraia3_Valorant2.IsEnabled = false;
                    txtPraia4.IsEnabled = false;
                    txtPraia5.IsEnabled = false;
                }
            }
        }
        private void logicaValorant()
        {

            if (txtValorant1.Text.ToUpper() == "V" && txtPraia3_Valorant2.Text.ToUpper() == "A" && txtValorant3.Text.ToUpper() == "L" && txtValorant4.Text.ToUpper() == "O" && txtValorant5.Text.ToUpper() == "R" && txtValorant6.Text.ToUpper() == "A" && txtValorant7.Text.ToUpper() == "N" && txtValorant8_txtTempo1.Text.ToUpper() == "T")
            {
                if (palavra4 == "VALORANT")
                {
                    txtValorant1.Text = "V";
                    txtPraia3_Valorant2.Text = "A";
                    txtValorant3.Text = "L";
                    txtValorant4.Text = "O";
                    txtValorant5.Text = "R";
                    txtValorant6.Text = "A";
                    txtValorant7.Text = "N";
                    txtValorant8_txtTempo1.Text = "T";
                    txtValorant1.Background = Brushes.LightSkyBlue;
                    txtPraia3_Valorant2.Background = Brushes.LightSkyBlue;
                    txtValorant3.Background = Brushes.LightSkyBlue;
                    txtValorant4.Background = Brushes.LightSkyBlue;
                    txtValorant5.Background = Brushes.LightSkyBlue;
                    txtValorant6.Background = Brushes.LightSkyBlue;
                    txtValorant7.Background = Brushes.LightSkyBlue;
                    txtValorant8_txtTempo1.Background = Brushes.LightSkyBlue;
                    txtValorant1.IsEnabled = false;
                    txtPraia3_Valorant2.IsEnabled = false;
                    txtValorant3.IsEnabled = false;
                    txtValorant4.IsEnabled = false;
                    txtValorant5.IsEnabled = false;
                    txtValorant6.IsEnabled = false;
                    txtValorant7.IsEnabled = false;
                    txtValorant8_txtTempo1.IsEnabled = false;
                }
            }
        }
        private void logicaUnreal()
        {

            if (txtUnreal1_Uber1.Text.ToUpper() == "U" && txtUnreal2.Text.ToUpper() == "N" && txtUnreal3.Text.ToUpper() == "R" && txtUnreal4.Text.ToUpper() == "E" && txtUnreal5.Text.ToUpper() == "A" && txtUnreal6.Text.ToUpper() == "L")
            {
                if (palavra5 == "UNREAL")
                {
                    txtUnreal1_Uber1.Text = "U";
                    txtUnreal2.Text = "N";
                    txtUnreal3.Text = "R";
                    txtUnreal4.Text = "E";
                    txtUnreal5.Text = "A";
                    txtUnreal6.Text = "L";
                    txtUnreal1_Uber1.Background = Brushes.LightSkyBlue;
                    txtUnreal2.Background = Brushes.LightSkyBlue;
                    txtUnreal3.Background = Brushes.LightSkyBlue;
                    txtUnreal4.Background = Brushes.LightSkyBlue;
                    txtUnreal5.Background = Brushes.LightSkyBlue;
                    txtUnreal6.Background = Brushes.LightSkyBlue;
                    txtUnreal1_Uber1.IsEnabled = false;
                    txtUnreal2.IsEnabled = false;
                    txtUnreal3.IsEnabled = false;
                    txtUnreal4.IsEnabled = false;
                    txtUnreal5.IsEnabled = false;
                    txtUnreal6.IsEnabled = false;

                }
            }
        }
        private void logicaUber()
        {

            if (txtUnreal1_Uber1.Text.ToUpper() == "U" && txtUber2.Text.ToUpper() == "B" && txtUber3.Text.ToUpper() == "E" && txtUber4_txtRengoku1.Text.ToUpper() == "R")
            {
                if (palavra6 == "UBER")
                {
                    txtUnreal1_Uber1.Text = "U";
                    txtUber2.Text = "B";
                    txtUber3.Text = "E";
                    txtUber4_txtRengoku1.Text = "R";
                    txtUnreal1_Uber1.Background = Brushes.LightSkyBlue;
                    txtUber2.Background = Brushes.LightSkyBlue;
                    txtUber3.Background = Brushes.LightSkyBlue;
                    txtUber4_txtRengoku1.Background = Brushes.LightSkyBlue;
                    txtUnreal1_Uber1.IsEnabled = false;
                    txtUber2.IsEnabled = false;
                    txtUber3.IsEnabled = false;
                    txtUber4_txtRengoku1.IsEnabled = false;

                }
            }
        }
        private void logicaRengoku()
        {

            if (txtUber4_txtRengoku1.Text.ToUpper() == "R" && txtRengoku2.Text.ToUpper() == "E" && txtRengoku3.Text.ToUpper() == "N" && txtRengoku4.Text.ToUpper() == "G" && txtRengoku5_txtMorto2.Text.ToUpper() == "O" && txtRengoku6.Text.ToUpper() == "K" && txtRengoku7.Text.ToUpper() == "U")
            {
                if (palavra7 == "RENGOKU")
                {
                    txtUber4_txtRengoku1.Text = "R";
                    txtRengoku2.Text = "E";
                    txtRengoku3.Text = "N";
                    txtRengoku4.Text = "G";
                    txtRengoku5_txtMorto2.Text = "O";
                    txtRengoku6.Text = "K";
                    txtRengoku7.Text = "U";
                    txtUber4_txtRengoku1.Background = Brushes.LightSkyBlue;
                    txtRengoku2.Background = Brushes.LightSkyBlue;
                    txtRengoku3.Background = Brushes.LightSkyBlue;
                    txtRengoku4.Background = Brushes.LightSkyBlue;
                    txtRengoku5_txtMorto2.Background = Brushes.LightSkyBlue;
                    txtRengoku6.Background = Brushes.LightSkyBlue;
                    txtRengoku7.Background = Brushes.LightSkyBlue;
                    txtUber4_txtRengoku1.IsEnabled = false;
                    txtRengoku2.IsEnabled = false;
                    txtRengoku3.IsEnabled = false;
                    txtRengoku4.IsEnabled = false;
                    txtRengoku5_txtMorto2.IsEnabled = false;
                    txtRengoku6.IsEnabled = false;
                    txtRengoku7.IsEnabled = false;
                }
            }
        }
        private void logicaMorto()
        {

            if (txtMorto1.Text.ToUpper() == "M" && txtRengoku5_txtMorto2.Text.ToUpper() == "O" && txtMorto3.Text.ToUpper() == "R" && txtMorto4.Text.ToUpper() == "T" && txtMorto5.Text.ToUpper() == "O")
            {
                if (palavra8 == "MORTO")
                {
                    txtMorto1.Text = "M";
                    txtRengoku5_txtMorto2.Text = "O";
                    txtMorto3.Text = "R";
                    txtMorto4.Text = "T";
                    txtMorto5.Text = "O";
                    txtMorto1.Background = Brushes.LightSkyBlue;
                    txtRengoku5_txtMorto2.Background = Brushes.LightSkyBlue;
                    txtMorto3.Background = Brushes.LightSkyBlue;
                    txtMorto4.Background = Brushes.LightSkyBlue;
                    txtMorto5.Background = Brushes.LightSkyBlue;
                    txtMorto1.IsEnabled = false;
                    txtRengoku5_txtMorto2.IsEnabled = false;
                    txtMorto3.IsEnabled = false;
                    txtMorto4.IsEnabled = false;
                    txtMorto5.IsEnabled = false;
                }
            }
        }
        private void logicaTempo()
        {

            if (txtValorant8_txtTempo1.Text.ToUpper() == "T" && txtTempo2.Text.ToUpper() == "E" && txtTempo3.Text.ToUpper() == "M" && txtTempo4.Text.ToUpper() == "P" && txtTempo5.Text.ToUpper() == "O")
            {
                if (palavra9 == "TEMPO")
                {
                    txtValorant8_txtTempo1.Text = "T";
                    txtTempo2.Text = "E";
                    txtTempo3.Text = "M";
                    txtTempo4.Text = "P";
                    txtTempo5.Text = "O";
                    txtValorant8_txtTempo1.Background = Brushes.LightSkyBlue;
                    txtTempo2.Background = Brushes.LightSkyBlue;
                    txtTempo3.Background = Brushes.LightSkyBlue;
                    txtTempo4.Background = Brushes.LightSkyBlue;
                    txtTempo5.Background = Brushes.LightSkyBlue;
                    txtValorant8_txtTempo1.IsEnabled = false;
                    txtTempo2.IsEnabled = false;
                    txtTempo3.IsEnabled = false;
                    txtTempo4.IsEnabled = false;
                    txtTempo5.IsEnabled = false;
                }
            }
        }
        private void logicaTeto()
        {

            if (txtTeto1.Text.ToUpper() == "T" && txtTeto2_txtLente2.Text.ToUpper() == "E" && txtTeto3.Text.ToUpper() == "T" && txtFlocos3_Teto4.Text.ToUpper() == "O")
            {
                if (palavra10 == "TETO")
                {
                    txtTeto1.Text = "T";
                    txtTeto2_txtLente2.Text = "E";
                    txtTeto3.Text = "T";
                    txtFlocos3_Teto4.Text = "O";
                    txtTeto1.Background = Brushes.LightSkyBlue;
                    txtTeto2_txtLente2.Background = Brushes.LightSkyBlue;
                    txtTeto3.Background = Brushes.LightSkyBlue;
                    txtFlocos3_Teto4.Background = Brushes.LightSkyBlue;
                    txtTeto1.IsEnabled = false;
                    txtTeto2_txtLente2.IsEnabled = false;
                    txtTeto3.IsEnabled = false;
                    txtFlocos3_Teto4.IsEnabled = false;
                }
            }
        }


        private void verifica(object sender, KeyEventArgs e)
        {
            palavra1 = txtFlocos1.Text + txtFlocos2.Text + txtFlocos3_Teto4.Text + txtFlocos4.Text + txtFlocos5.Text + txtFlocos6.Text;
            palavra1 = palavra1.ToUpper();
            logicaFlocos();
            palavra2 = txtLente1.Text + txtTeto2_txtLente2.Text + txtLente3.Text + txtLente4.Text + txtLente5.Text;
            palavra2 = palavra2.ToUpper();
            logicaLente();
            palavra3 = txtPraia1.Text + txtPraia2.Text + txtPraia3_Valorant2.Text + txtPraia4.Text + txtPraia5.Text;
            palavra3 = palavra3.ToUpper();
            logicaPraia();
            palavra4 = txtValorant1.Text + txtPraia3_Valorant2.Text + txtValorant3.Text + txtValorant4.Text + txtValorant5.Text + txtValorant6.Text + txtValorant7.Text + txtValorant8_txtTempo1.Text;
            palavra4 = palavra4.ToUpper();
            logicaValorant();
            palavra5 = txtUnreal1_Uber1.Text + txtUnreal2.Text + txtUnreal3.Text + txtUnreal4.Text + txtUnreal5.Text + txtUnreal6.Text;
            palavra5 = palavra5.ToUpper();
            logicaUnreal();
            palavra6 = txtUnreal1_Uber1.Text + txtUber2.Text + txtUber3.Text + txtUber4_txtRengoku1.Text;
            palavra6 = palavra6.ToUpper();
            logicaUber();
            palavra7 = txtUber4_txtRengoku1.Text + txtRengoku2.Text + txtRengoku3.Text + txtRengoku4.Text + txtRengoku5_txtMorto2.Text + txtRengoku6.Text + txtRengoku7.Text;
            palavra7 = palavra7.ToUpper();
            logicaRengoku();
            palavra8 = txtMorto1.Text + txtRengoku5_txtMorto2.Text + txtMorto3.Text + txtMorto4.Text + txtMorto5.Text;
            palavra8 = palavra8.ToUpper();
            logicaMorto();
            palavra9 = txtValorant8_txtTempo1.Text + txtTempo2.Text + txtTempo3.Text + txtTempo4.Text + txtTempo5.Text;
            palavra9 = palavra9.ToUpper();
            logicaTempo();
            palavra10 = txtTeto1.Text + txtTeto2_txtLente2.Text + txtTeto3.Text + txtFlocos3_Teto4.Text;
            palavra10 = palavra10.ToUpper();
            logicaTeto();
            ganhou();
        }
        private void ganhou()
        {
            if (palavra1 == "FLOCOS" && palavra2 == "LENTE" && palavra3 == "PRAIA" && palavra4 == "VALORANT" && palavra5 == "UNREAL" && palavra6 == "UBER" && palavra7 == "RENGOKU" && palavra8 == "MORTO" && palavra9 == "TEMPO" && palavra10 == "TETO")
            {
                txt_ganhar.Visibility = Visibility.Visible;
            }
        }


    }
}
