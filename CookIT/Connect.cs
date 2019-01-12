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
            CloseConnection();
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
            string readCommand = "INSERT INTO Recept (recept_naam,recept_desc,recept_auteur,recept_video,recept_rating,recept_people,recept_average,recept_dieet,recept_benodigdheden,recept_image,recept_ingredienten,recept_stappen) VALUES (?naam,?desc,?auteur,?video,?rating,?people,?average,?dieet,?benodigdheden,?image,?ingredienten,?stappen);";
            if (OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = readCommand;

                StringBuilder sbStappen = new StringBuilder();
                foreach(string item in recept.stappen)
                {
                    sbStappen.Append(item).Append('*');
                    sbStappen.Remove(sbStappen.Length - 1, 1);
                }
                StringBuilder sbBenodigdheden = new StringBuilder();
                foreach (string item in recept.benodigdheden)
                {
                    sbBenodigdheden.Append(item).Append('*');
                    sbBenodigdheden.Remove(sbBenodigdheden.Length - 1, 1);
                }
                StringBuilder sbIngredienten = new StringBuilder();
                foreach (string item in recept.ingredienten)
                {
                    sbIngredienten.Append(item).Append('*');
                    sbIngredienten.Remove(sbIngredienten.Length - 1, 1);
                }
                //stappen.Join("-", recept.stappen.ToArray());
                cmd.Parameters.Add("?naam", MySqlDbType.VarChar).Value = recept.naam;
                cmd.Parameters.Add("?desc", MySqlDbType.VarChar).Value = recept.desc;
                cmd.Parameters.Add("?auteur", MySqlDbType.VarChar).Value = recept.auteur;
                cmd.Parameters.Add("?video", MySqlDbType.VarChar).Value = recept.video;
                cmd.Parameters.Add("?rating", MySqlDbType.Int32).Value = recept.rating;
                cmd.Parameters.Add("?people", MySqlDbType.VarChar).Value = 0;
                cmd.Parameters.Add("?average", MySqlDbType.Float).Value = 0F;
                cmd.Parameters.Add("?dieet", MySqlDbType.VarChar).Value = recept.dieet;
                cmd.Parameters.Add("?benodigdheden", MySqlDbType.VarChar).Value = sbBenodigdheden;
                cmd.Parameters.Add("?image", MySqlDbType.VarChar).Value = recept.image;
                cmd.Parameters.Add("?ingredienten", MySqlDbType.VarChar).Value = sbIngredienten.ToString();
                cmd.Parameters.Add("?stappen", MySqlDbType.VarChar).Value = sbStappen.ToString();

                cmd.ExecuteNonQuery();

                CloseConnection();
            }
        }

        /*
         * Vraag alle recepten op en store deze in een DataTable
         * Returns: DataTable
         */
        public DataTable getRecepten()
        {
            DataTable dt = new DataTable();
            string query = "SELECT * FROM Recept";
            if (OpenConnection())
            {
                MySqlDataAdapter mda = new MySqlDataAdapter();
                mda.SelectCommand = new MySqlCommand(query, connection);
                mda.Fill(dt);
                CloseConnection();
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

        /*
         * Updated van de rating van een recept doormiddel van de ID van een recept en de rating die doorgegeven doormiddel van de amount tussen 1 en 5
         */
        public void updateRating(int ID, int amount)
        {
            string query = "UPDATE TABLE Recept SET recept_rating= recept_rating + " + amount + ",recept_peoplerated = recept_peoplerated + 1, recept_ratingaverage = recept_rating/recept_peoplerated WHERE recept_ID=" + ID;
            if (OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                CloseConnection();
            }
        }
        /*
         * Aanvragen van top 10 recepten gebaseerd op de Average van alle recepten | TotalVoteScore / PeopleWhoVoted
         * Returned : DataTable;
        */
        public DataTable dtTopFour()
        {
            DataTable dtTopTen = new DataTable();
            string query = "SELECT * FROM Recept ORDER BY recept_average DESC LIMIT 4";
                //"SELECT * FROM recept WHERE recept.recept_ratingaverage LIMIT 10;";
                //"SELECT FROm recepten WHERE ID NOT IN(SELECT TOP 10 ID FROM recepten ORDER BY recept_ratingaverage)";
            if (OpenConnection())
            {
                MySqlDataAdapter mda = new MySqlDataAdapter();
                mda.SelectCommand = new MySqlCommand(query, connection);
                mda.Fill(dtTopTen);
                CloseConnection();
            }
            return dtTopTen;
        }

        /*
         * single recept getter voor receptlistview();
         * Returned: Recept;
         * Zoek in de DB voor het recept door middel van de ID die meegegeven word in het recept zelf.
        */
        public Recept getRecept(int id)
        {
            Recept receptByID = new Recept();
            string query = "SELECT row FROM Recept WHERE ID=?ID";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.Add("?ID", MySqlDbType.Int32).Value = id;
            MySqlDataReader reader = cmd.ExecuteReader();
            //reader loop die er voor gaat zorgen dat alle data gestored gaat worden in een Recept Object
            while (reader.Read())
            {

                string[] benodigdheden = reader["recept_benodigdheden"].ToString().Split('*');
                string[] ingredienten = reader["recept_ingredienten"].ToString().Split('*');
                string[] stappenArray = reader["recept_stappen"].ToString().Split('*');
                
                List<string> stappen = new List<string>();
                List<string> ben = new List<string>();
                List<string> ingre = new List<string>();
                foreach (string item in stappenArray)
                {
                    stappen.Add(item);
                }
                foreach(string item in benodigdheden)
                {
                    ben.Add(item);
                }
                foreach(string item in ingredienten)
                {
                    ingre.Add(item);
                }
                //Store alle data ban die regel via een reader in het object
                receptByID = new Recept(Convert.ToInt32(reader["ID"]), reader["recept_naam"].ToString(), reader["recept_desc"].ToString(), reader["recept_auteur"].ToString(), reader["recept_video"].ToString(), Convert.ToInt32(reader["recept_rating"]), reader["recept_dieet"].ToString(), ben, reader["recept_image"].ToString(), ingre, stappen);
                CloseConnection();
            }
            //return het object gevuld
            return receptByID;
        }
        public DataTable getUsers()
        {
            DataTable userTable = new DataTable();
            string query = "SELECT * FROM Users";
            if (OpenConnection())
            {
                MySqlDataAdapter mda = new MySqlDataAdapter();
                mda.SelectCommand = new MySqlCommand(query, connection);
                mda.Fill(userTable);
                CloseConnection();
            }
            return userTable;
        }
        public void registerUser(LogIn log)
        {
            string query = "INSERT INTO users (UID,PASS,Email.Voornaam,Achternaam,Rol) VALUES (?uid.?pass,?email,?voornaam,?achternaam,?rol)";
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = query;
            cmd.Connection = connection;

            cmd.Parameters.Add("?uid", MySqlDbType.VarChar).Value = log.gebruikersnaam;
            cmd.Parameters.Add("?pass", MySqlDbType.VarChar).Value = log.wachtwoord;
            cmd.Parameters.Add("?email", MySqlDbType.VarChar).Value = log.email;
            cmd.Parameters.Add("?voornaam", MySqlDbType.VarChar).Value = log.voorNaam;
            cmd.Parameters.Add("?achternaam", MySqlDbType.VarChar).Value = log.achterNaam;
            cmd.Parameters.Add("?rol", MySqlDbType.Int32).Value = log.rol;

            cmd.ExecuteNonQuery();
            CloseConnection();

        }
        public DataTable getSearchData(string value)
        {
            DataTable searchDT = new DataTable();
            string query = "SELECT * FROM Recept WHERE CONCAT(`recept_naam`,`recept_desc`) like '%"+ value + "%'";
            if (OpenConnection())
            {
                MySqlDataAdapter mda = new MySqlDataAdapter();
                mda.SelectCommand = new MySqlCommand(query, connection);
                mda.Fill(searchDT);
                CloseConnection();
            }
            return searchDT;
        }
    }
}