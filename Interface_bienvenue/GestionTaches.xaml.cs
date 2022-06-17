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

namespace Interface_bienvenue
{
    /// <summary>
    /// Logique d'interaction pour GestionTaches.xaml
    /// </summary>
    public partial class GestionTaches : Window
    {
        public GestionTaches()
        {
            InitializeComponent();
            fenetrePrincipale.Visibility = Visibility.Visible;
            fenetreRechercher.Visibility = Visibility.Hidden;
            fenetreAssigner.Visibility = Visibility.Hidden;
            fenetreCreer.Visibility = Visibility.Hidden;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            fenetrePrincipale.Visibility = Visibility.Visible;
            fenetreRechercher.Visibility = Visibility.Hidden;
            fenetreAssigner.Visibility = Visibility.Hidden;
            fenetreCreer.Visibility = Visibility.Hidden;
        }

        private void butRechercher_Click(object sender, RoutedEventArgs e)
        {
            fenetrePrincipale.Visibility = Visibility.Hidden;
            fenetreRechercher.Visibility = Visibility.Visible;
            fenetreAssigner.Visibility = Visibility.Hidden;
            fenetreCreer.Visibility = Visibility.Hidden;
        }

        private void butAssigner_Click(object sender, RoutedEventArgs e)
        {
            fenetrePrincipale.Visibility = Visibility.Hidden;
            fenetreRechercher.Visibility = Visibility.Visible;
            fenetreAssigner.Visibility = Visibility.Hidden;
            fenetreCreer.Visibility = Visibility.Hidden;
        }

        private void butModifier_Click(object sender, RoutedEventArgs e)
        {
            fenetrePrincipale.Visibility = Visibility.Hidden;
            fenetreRechercher.Visibility = Visibility.Hidden;
            fenetreAssigner.Visibility = Visibility.Visible;
            fenetreCreer.Visibility = Visibility.Hidden;

        }

        private void butSupprimer_Click(object sender, RoutedEventArgs e)
        {
            fenetrePrincipale.Visibility = Visibility.Hidden;
            fenetreRechercher.Visibility = Visibility.Visible;
            fenetreAssigner.Visibility = Visibility.Hidden;
            fenetreCreer.Visibility = Visibility.Hidden;
        }

        private void butCreer_Click(object sender, RoutedEventArgs e)
        {
            fenetrePrincipale.Visibility = Visibility.Hidden;
            fenetreRechercher.Visibility = Visibility.Hidden;
            fenetreAssigner.Visibility = Visibility.Hidden;
            fenetreCreer.Visibility = Visibility.Visible;
        }

        private void butRetour_Click(object sender, RoutedEventArgs e)
        {
            MainWindow kozy = new MainWindow();
            kozy.Show();
            this.Hide();
        }
    }
}
