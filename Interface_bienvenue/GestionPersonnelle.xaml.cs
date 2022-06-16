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
using MySql.Data.MySqlClient;
using System.Diagnostics;

namespace Interface_bienvenue
{
   
    public partial class GestionPersonnelle : Window
    {
        
        private MySqlConnection conn = new MySqlConnection("SERVER = localhost; PORT = 3308; DATABASE = 'vaovao'; UID = root; PASSWORD =");
        

        public GestionPersonnelle()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void tableau_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void butAjouter_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                conn.Open();
                String requeteInsertion = "insert into employe values ('" + textCIN.Text + "', '" + textSexe.Text + "', '" + textStatutMatrimonial.Text + "', '" + textTelephone.Text + "', '" + textNbEnfant.Text + "', '" + textTelephone.Text + "', '" + textAdresse.Text + "', '" + textNationalite.Text + "', '" + dateEntree.SelectedDate + "', '" + dateSortie.SelectedDate + "', '" + textPhoto.Text + "', '" + dateNaissance.SelectedDate + "', '" + textCV.Text + "', '" + textNumCompteBanque.Text + "', '" + textIdPoste.Text + "', '" + textMobile.Text + "')";
                MySqlCommand cmd = new MySqlCommand(requeteInsertion, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Ajout effectué");
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Oprération arrêtée" + ex);
            }

        }

        private void butSupprimer_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                conn.Open();
                String requeteInsertion = "delete from employe where ( '" + textCIN.Text + "', '" + textSexe.Text + "', '" + textStatutMatrimonial.Text + "', '" + textTelephone.Text + "', '" + textNbEnfant.Text + "', '" + textTelephone.Text + "', '" + textAdresse.Text + "', '" + textNationalite.Text + "', '" + dateEntree.SelectedDate + "', '" + dateSortie.SelectedDate + "', '" + textPhoto.Text + "', '" + dateNaissance.SelectedDate+ "', '" + textCV.Text + "', '" + textNumCompteBanque.Text + "', '" + textIdPoste.Text + "', '" + textMobile.Text + "')";
                MySqlCommand cmd = new MySqlCommand(requeteInsertion, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Ajout effectué");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oprération arrêtée" + ex);
            }

        }

        private void butAnnuler_Click(object sender, RoutedEventArgs e)
        {
            MainWindow kozy = new MainWindow();
            kozy.Show();
            this.Hide();
        }
    }
}
