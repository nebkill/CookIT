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
        /**
         * Gebruik deze functie om met de database to communiceren om 
         * nieuwe recepten aan de recepten table toe te voegen.
         **/
        public void insertRecept(Recept recept)
        {
            con.insertRecept(recept);
        }
        public void updateRating(int ID, int amount)
        {
            con.updateRating(ID,amount);
        }
        public DataTable getTopTen()
        {
            return con.getTopTen();
        }
        public DataTable getRecepten()
        {
            return con.getRecepten();
        }
    }
}
