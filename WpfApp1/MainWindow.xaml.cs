using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfApp1
{
   
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnZatwierdz_Click(object sender, RoutedEventArgs e)
        {
            var txtImie = (TextBox)FindName("txtImie");
            var txtWiek = (TextBox)FindName("txtWiek");
            var txtOcena = (TextBox)FindName("txtOcena");
            var txtWynik = (TextBlock)FindName("txtWynik");

            string imie = txtImie.Text.Trim();
            string wiek = txtWiek.Text.Trim();
            string ocena = txtOcena.Text.Trim();

           
            if (string.IsNullOrWhiteSpace(imie) || string.IsNullOrWhiteSpace(wiek) || string.IsNullOrWhiteSpace(ocena))
            {
                txtWynik.Foreground = Brushes.Red;
                txtWynik.Text = "Błąd: Wszystkie pola muszą być uzupełnione!";
                return;
            }

          
            if (!int.TryParse(wiek, out int wiekLiczba) || wiekLiczba <= 0)
            {
                txtWynik.Foreground = Brushes.Red;
                txtWynik.Text = "Błąd: Wiek musi być poprawną liczbą dodatnią!";
                return;
            }

            if (!int.TryParse(ocena, out int ocenaLiczba) || ocenaLiczba < 1 || ocenaLiczba > 6)
            {
                txtWynik.Foreground = Brushes.Red;
                txtWynik.Text = "Błąd: Ocena musi być liczbą całkowitą z zakresu 1–6!";
                return;
            }

      
            txtWynik.Foreground = Brushes.Green;
            txtWynik.Text = $"Imię: {imie}\nWiek: {wiekLiczba}\nOcena: {ocenaLiczba}";
        }

        private void BtnResetuj_Click(object sender, RoutedEventArgs e)
        {
            var txtImie = (TextBox)FindName("txtImie");
            var txtWiek = (TextBox)FindName("txtWiek");
            var txtOcena = (TextBox)FindName("txtOcena");
            var txtWynik = (TextBlock)FindName("txtWynik");

            
            txtImie.Clear();
            txtWiek.Clear();
            txtOcena.Clear();
            txtWynik.Text = string.Empty;
        }
    }
}