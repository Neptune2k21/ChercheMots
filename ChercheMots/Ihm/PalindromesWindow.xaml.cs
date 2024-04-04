using System.Collections.Generic;
using System.Windows;

namespace ChercheMots.Ihm
{
    /// <summary>
    /// Logique d'interaction pour PalindromesWindow.xaml
    /// </summary>
    public partial class PalindromesWindow : Window
    {
        private Metier.Dictionnaire dico;

        public PalindromesWindow(Metier.Dictionnaire dico)
        {
            InitializeComponent();
            this.dico = dico;
            ChargerPalindromes();
        }

        private void ChargerPalindromes()
        {
            List<string> palindromes = dico.Palindromes();
            foreach (string palindrome in palindromes)
            {
                textBoxPalindromes.Text += palindrome + "\n";
            }
        }

        private void textBoxPalindromes(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

        }
    }
}
