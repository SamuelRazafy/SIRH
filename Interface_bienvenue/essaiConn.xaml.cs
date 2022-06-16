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
    /// <summary>
    /// Interaction logic for essaiConn.xaml
    /// </summary>
    public partial class essaiConn : Window
    {
        private string email, password, sql;
        private Connection conn = new Connection();
        private MySqlCommand command;
        

        private void butGoogle_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("https://www.google.com/");
        }

        private void butFace_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("https://www.facebook.com/");
        }

       

        private void butAnnuler_Click(object sender, RoutedEventArgs e)
        {
            MainWindow kozy = new MainWindow();
            kozy.Show();
            this.Hide();
        }

       


        private void butInsc_Click(object sender, RoutedEventArgs e)
        {
            Test mande = new Test();
            mande.Show();
            this.Hide();
        }

        private void textMail_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textMdp_TextChanged(object sender, TextChangedEventArgs e)
        {
           
        }

        private void butMdp_Click(object sender, RoutedEventArgs e)
        {

        }

        private void choix_Checked(object sender, RoutedEventArgs e)
        {

        }

        public essaiConn()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            email = textMail.Text;
            password = textMdp.Password.ToString();
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Saisir email et mots de passe ");
            }
            else
            {
                sql = "SELECT * FROM utillisateur WHERE email = '" + email + "' AND mdp = '" + password + "'";
                if (conn.OpenConnection() == true)
                {
                    try
                    {
                        command = new MySqlCommand(sql, conn.get_connection());
                        object a = command.ExecuteScalar();
                        if (a == null)
                        {
                            MessageBox.Show("Invalide email ou mots de passe");
                        }
                        else
                        {
                            Test clt = new Test();
                            clt.Show();
                            this.Close();
                        }
                    }
                    catch (MySqlException x)
                    {
                        MessageBox.Show("" + x);
                    }

                    textMail.Text = "";
                    textMdp.Password = "";
                    conn.close_conn();
                }
            }
        }
    }
}
