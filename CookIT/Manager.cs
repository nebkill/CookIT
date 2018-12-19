using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookIT
{
    class Manager
    {
        Connect con = new Connect();
        PDFHandler ph = new PDFHandler();
        /**
         * Gebruik deze functie om met de database to communiceren om 
         * nieuwe recepten aan de recepten table toe te voegen.
         **/
        public void insertRecept(Recept recept)
        {
            con.insertRecept(recept);
        }
        /*
         * Update Rating doormiddel vna de ID mee te geven van het recept en de rating(1/5) via de amount parameter
         */
        public void updateRating(int ID, int amount)
        {
            con.updateRating(ID,amount);
        }
        /*
         * Verkrijg een datatable met de top tien gebasseerd op de rating van: TotalRating/People = AverageRating;
         * Returns: DataTable
         */
        public DataTable getTopTen()
        {
            return con.getTopTen();
        }
        /*
         * Verkrijg alle recepten van de database
         * Returns: DataTable
         */
        public DataTable getRecepten()
        {
            return con.getRecepten();
        }
        /*
         * Verkrijg het recept doormiddel met het doorsturen van het recept weer te storen in het object.
         * Returns: Recept;
         */
        public Recept getRecept(int id)
        {
            return con.getRecept(id);
        }
        public void createPDF(Recept recept)
        {
            ph.createPDF(recept);
        }
        public DataTable getUsers()
        {
            return con.getUsers();
        }
        public void registerUser(LogIn log)
        {
            con.registerUser(log);
        }
        public DataTable searchData(string value)
        {
            return con.getSearchData(value);
        }
    }
}
