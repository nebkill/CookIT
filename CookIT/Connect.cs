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
            string readCommand = "INSERT INTO recepten (Naam,Description,Auteur,Video,Rating,Dieet,Benodigdheden,Image,Ingredienten,Stappen) VALUES (?naam,?desc,?auteur,?video,?rating,?dieet,?benodigdheden,?image,?ingredienten,?stappen);";
            if (OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = readCommand;

                cmd.Parameters.Add("?naam", MySqlDbType.VarChar).Value = recept.naam;
                cmd.Parameters.Add("?desc", MySqlDbType.VarChar).Value = recept.desc;
                cmd.Parameters.Add("?auteur", MySqlDbType.VarChar).Value = recept.auteur;
                cmd.Parameters.Add("?video", MySqlDbType.VarChar).Value = recept.video;
                cmd.Parameters.Add("?rating", MySqlDbType.Int32).Value = recept.rating;
                cmd.Parameters.Add("?dieet", MySqlDbType.VarChar).Value = recept.dieet;
                cmd.Parameters.Add("?benodigdheden", MySqlDbType.VarChar).Value = recept.benodigdheden;
                cmd.Parameters.Add("?image", MySqlDbType.VarChar).Value = recept.image;
                cmd.Parameters.Add("?ingredienten", MySqlDbType.VarChar).Value = recept.ingredienten;
                cmd.Parameters.Add("?stappen", MySqlDbType.VarChar).Value = recept.stappen;

                cmd.ExecuteNonQuery();
                CloseConnection();
            }
        }
    }
}

