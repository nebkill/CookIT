using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CookIT
{
    class Connect
    {
        string server, database, uid, password;
        MySqlConnection connection;
        public Connect()
        {
            server = "cookitapp.eu";
            database = "CookItApp";
            uid = "CookITAdmin";
            password = "!";
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
                MessageBox.Show(ex.ToString());

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
                MessageBox.Show(ex.ToString());
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
                
                StringBuilder sbStappen = new StringBuilder();
                for (int i = 0; i < recept.stappen.Count; i++)
                {
                    sbStappen.Append("-").Append(recept.stappen[i]);
                }
                StringBuilder sbBenodigdheden = new StringBuilder();
                for(int i = 0; i < recept.benodigdheden.Length; i++)
                {
                    sbBenodigdheden.Append("-").Append(recept.benodigdheden[i]);
                }
                StringBuilder sbIngredienten = new StringBuilder();
                for (int i = 0; i < recept.ingredienten.Length; i++)
                {
                    sbIngredienten.Append("-").Append(recept.ingredienten[i]);
                }
                //stappen.Join("-", recept.stappen.ToArray());
                cmd.Parameters.Add("?naam", MySqlDbType.VarChar).Value = recept.naam;
                cmd.Parameters.Add("?desc", MySqlDbType.VarChar).Value = recept.desc;
                cmd.Parameters.Add("?auteur", MySqlDbType.VarChar).Value = recept.auteur;
                cmd.Parameters.Add("?video", MySqlDbType.VarChar).Value = recept.video;
                cmd.Parameters.Add("?rating", MySqlDbType.Int32).Value = recept.rating;
                cmd.Parameters.Add("?dieet", MySqlDbType.VarChar).Value = recept.dieet;
                cmd.Parameters.Add("?benodigdheden", MySqlDbType.VarChar).Value = sbBenodigdheden;
                cmd.Parameters.Add("?image", MySqlDbType.VarChar).Value = recept.image;
                cmd.Parameters.Add("?ingredienten", MySqlDbType.VarChar).Value = sbIngredienten.ToString();
                cmd.Parameters.Add("?stappen", MySqlDbType.VarChar).Value = sbStappen.ToString();

                cmd.ExecuteNonQuery();
                
                CloseConnection();
            }
        }
        public DataTable getRecepten()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM recepten";
            if (OpenConnection())
            {
                MySqlDataAdapter mda = new MySqlDataAdapter();
                mda.SelectCommand = new MySqlCommand(query, connection);
                mda.Fill(dt);
            }
            return dt;
        }
        /*
         * Gebuik dit om de connectie te testen
         * 
         * public void TestCon()
         * {
         *    if (OpenConnection())
         *   {
         *       MessageBox.Show("Connection created\n\n" + connection.State);
         *   }
         *   else
         *   {
         *        MessageBox.Show("Conn Not Established");
         *   }
        }*/
        public void updateRating(int ID, int amount)
        {
            string query = "UPDATE TABLE recepten SET recept_rating= recept_rating + " + amount + ",recept_peoplerated = recept_peoplerated + 1, recept_peopleaverage = recept_rating/recept_peoplerated WHERE recept_ID=" + ID;
            if (OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                CloseConnection();
            }
        }
    }
}

