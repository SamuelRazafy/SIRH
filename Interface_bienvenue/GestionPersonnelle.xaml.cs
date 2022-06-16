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
using System.Data.Common;


namespace Interface_bienvenue
{
   
    public partial class GestionPersonnelle : Window
    {
        
        private MySqlConnection conn = new MySqlConnection("SERVER = localhost; PORT = 3308; DATABASE = 'vaovao'; UID = root; PASSWORD =");
        

        public GestionPersonnelle()
        {
            InitializeComponent();
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
                String requeteSuppression = "delete from employe where CINEmp = "+textCIN.Text+" or Sexemp = "+textSexe.Text+" or StatutMatrimonial = "+textStatutMatrimonial.Text+" or Telephone = "+textTelephone.Text+" or NombreEnfant = "+textNbEnfant.Text+" or Telephone 2 = " + textMobile.Text + " or Adresse = "+textAdresse.Text+" or Nationalite = "+textNationalite.Text+" or DateEntree = "+dateEntree.SelectedDate+" or DateSortie = "+dateSortie.SelectedDate+" or DateNaissance = "+dateNaissance.SelectedDate+" or NumCompteBanque = "+textNumCompteBanque.Text+"";
                MySqlCommand cmd = new MySqlCommand(requeteSuppression, conn);
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

        private void butRechercher_Click(object sender, RoutedEventArgs e)
        {
            conn.Open();
            
                
                String requeteRechercher = "delete from employe where CINEmp = " + textCIN.Text + " or Sexemp = " + textSexe.Text + " or StatutMatrimonial = " + textStatutMatrimonial.Text + " or Telephone = " + textTelephone.Text + " or NombreEnfant = " + textNbEnfant.Text + " or Telephone 2 = " + textMobile.Text + " or Adresse = " + textAdresse.Text + " or Nationalite = " + textNationalite.Text + " or DateEntree = " + dateEntree.SelectedDate + " or DateSortie = " + dateSortie.SelectedDate + " or DateNaissance = " + dateNaissance.SelectedDate + " or NumCompteBanque = " + textNumCompteBanque.Text + "";
                MySqlCommand cmd = new MySqlCommand(requeteRechercher, conn);
                cmd.ExecuteNonQuery();
                using (DbDataReader reader = cmd.ExecuteReader())

            try
            {
                reader.Read();
                    textStatutMatrimonial.Text = reader.GetString(0);

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oprération arrêtée" + ex);
            }
            conn.Close();

        }
    }
}
