using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MySql.Data.MySqlClient;

namespace Interface_bienvenue
{
    class Connection
    {
        
        MySqlConnection conn = new MySqlConnection("SERVER = localhost; PORT = 3308; DATABASE = 'vaovao'; UID = root; PASSWORD =");
        private void Initialize()
        {
            
        }
        public bool OpenConnection()
        {
            try
            {
                conn.Open();
                return true;
            }
            catch (MySqlException e)
            {
                switch (e.Number)
                {
                    case 0:
                        MessageBox.Show("impossible de se connecter au server");
                        break;
                    case 1:
                        MessageBox.Show("email/mots de passe n'est pas correct");
                        break;
                }
                return false;
            }
        }
        public void close_conn()
        {
            this.conn.Close();
        }
        public MySqlConnection get_connection()
        {
            return this.conn;
        }
    } 
}