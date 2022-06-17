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
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Test kozy = new Test();
            kozy.Show();
            this.Hide();
        }

        private void Button_Click_1()
        {

        }

        private void butCreer_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
