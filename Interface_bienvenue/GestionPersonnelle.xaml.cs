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
       
        private MySqlConnection conn = new MySqlConnection("SERVER=127.0.0.1;PORT=3308;DATABASE=vaovao;UID=root;PASSWORD=");


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
           
                conn.Open();
                String requeteInsertion = "INSERT INTO `employe`(`idEmploye`, `CINEmp`, `Sexemp`, `StatutMatrimonial`, `NombreEnfant`, `Telephone`, `Adresse`, `Nationalite`, `DateEntree`, `DateSortie`, `UrlPhoto`, `DateNaissance`, `urlCV`, `NumCompteBanque`, `idDepartement`, `idPoste`, `Téléphone 2`)values(null,'"
                + textCIN.Text + "', '" + textSexe.Text + "', '" + textStatutMatrimonial.Text + "', '"
                + textTelephone.Text + "', '" + textNbEnfant.Text + "', '" + textTelephone.Text + "', '"
                + textAdresse.Text + "', '" + textNationalite.Text + "', '" + dateEntree.SelectedDate + "', '" 
                + dateSortie.SelectedDate + "', '" + textPhoto.Text + "', '" + dateNaissance.SelectedDate + "', '" 
                + textCV.Text + "', '" + textNumCompteBanque.Text + "', '" + textIdPoste.Text + "', '" + textMobile.Text + "')";
                MySqlCommand cmd = new MySqlCommand(requeteInsertion, conn);
                
                MessageBox.Show("Ajout effectué");
               
                try
                {
                cmd.ExecuteNonQuery();
                    
                }



                    catch (Exception ex)
                    {
                        MessageBox.Show("Oprération arrêtée" + ex);
                    }
            Employe emp = new Employe(

                        textStatutMatrimonial.Text,
                    textSexe.Text,
                    textAdresse.Text,
                    textMobile.Text,
                    textTelephone.Text,
                    textNationalite.Text,
                    textCIN.Text,
                    textNbEnfant.Text,
                    dateNaissance.Text,
                    dateEntree.Text,
                    dateSortie.Text
                    );
            tableau.Items.Add(emp);
            conn.Close();

        }
            

        private void butSupprimer_Click(object sender, RoutedEventArgs e)
        {
            conn.Open();
            try
            {

                String requeteSuppression = "delete from employe where CINEmp = " + textCIN.Text + " or Sexemp = " + textSexe.Text + " or StatutMatrimonial = " + textStatutMatrimonial.Text + " or Telephone = " + textTelephone.Text + " or NombreEnfant = " + textNbEnfant.Text + " or Telephone 2 = " + textMobile.Text + " or Adresse = " + textAdresse.Text + " or Nationalite = " + textNationalite.Text + " or DateEntree = " + dateEntree.SelectedDate + " or DateSortie = " + dateSortie.SelectedDate + " or DateNaissance = " + dateNaissance.SelectedDate + " or NumCompteBanque = " + textNumCompteBanque.Text + "";
                MySqlCommand cmd = new MySqlCommand(requeteSuppression, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Suppression effectuée");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Oprération arrêtée" + ex);
            }
            conn.Close();

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


            String requeteRechercher = "select from employe where CINEmp = " + textCIN.Text + " or Sexemp = " + textSexe.Text + " or StatutMatrimonial = " + textStatutMatrimonial.Text + " or Telephone = " + textTelephone.Text + " or NombreEnfant = " + textNbEnfant.Text + " or Telephone 2 = " + textMobile.Text + " or Adresse = " + textAdresse.Text + " or Nationalite = " + textNationalite.Text + " or DateEntree = " + dateEntree.SelectedDate + " or DateSortie = " + dateSortie.SelectedDate + " or DateNaissance = " + dateNaissance.SelectedDate + " or NumCompteBanque = " + textNumCompteBanque.Text + "";
            MySqlCommand cmd = new MySqlCommand(requeteRechercher, conn);
            
            using (DbDataReader reader = cmd.ExecuteReader())

                try
                {
                    reader.Read();
                    Employe emp = new Employe (
                    textStatutMatrimonial.Text = reader.GetString(0),
                    textSexe.Text = reader.GetString(1),
                    textAdresse.Text = reader.GetString(2),
                    textMobile.Text = reader.GetString(3),
                    textTelephone.Text = reader.GetString(4),
                    textNationalite.Text = reader.GetString(5),
                    textCIN.Text = reader.GetString(6),
                    textNbEnfant.Text = reader.GetString(7),
                    dateNaissance.Text = reader.GetString(8),
                    dateEntree.Text = reader.GetString(9),
                    dateSortie.Text = reader.GetString(10)
                    );
                    tableau.Items.Add(emp);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Oprération arrêtée" + ex);
                }
            conn.Close();
        }

        private void butModifier_Click(object sender, RoutedEventArgs e)
        {
            conn.Open();
             
        }
    }
}
