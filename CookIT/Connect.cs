using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookIT
{
    class Connect
    {
        string server, database, uid, password;
        MySqlConnection connection;
        public Connect()
        {
            server = "";
            database = "";
            uid = "";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
                database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }
        //gebruik deze method om de database connectie te openen
        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                Debug.WriteLine(ex.ToString());

            }
            return false;
        }
        //gebruik deze method om de database connectie te sluiten.
        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Debug.WriteLine(ex.ToString());
                return false;
            }
        }
        //Insert een recept naar de table Recepten
        public void insertRecept(Recept recept)
        {
            //Queries en commands enzo.
        }
    }
}
