using System;
using System.Windows;
using System.Windows.Controls;

namespace ChercheMots.Ihm
{
    /// <summary>
    /// Logique d'interaction pour ValeurWindow.xaml
    /// <author> HUGEROT Ethan </author>
    /// </summary>
    public partial class ValeurWindow : Window
    {
        private Metier.Dictionnaire dico;

        public ValeurWindow(Metier.Dictionnaire dico)
        {
            InitializeComponent();
            this.dico = dico;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string mot = textBoxMot.Text.ToUpper();
            try
            {
                int valeur = Metier.Dictionnaire.CalculerValeurMot(mot);
                AfficherResultat(valeur);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AfficherResultat(int valeur)
        {
            textBoxResultat.Text = valeur.ToString();
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
