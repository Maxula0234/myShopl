using System;
using MySql.Data.MySqlClient;
namespace myShopl.shop
{
    public class TV : LargeHomeAppliances
    {
        private decimal _diagonal;
        private bool _3dTech = false;
        private bool _dolbyDigital;
        private string _table = "Tv";


        public override int Id {
            get
            {
                MySqlConnection connection = new MySqlConnection(_connStr);
                connection.Open();
                string queryCount = $"Select count(Id) from {_table}";
                MySqlCommand count = new MySqlCommand(queryCount,connection);
                string countStringTable = count.ExecuteScalar().ToString();
                int Id = Convert.ToInt32(countStringTable)+1;
                return Id;
            }
        }
        public decimal Diagonal { get { return _diagonal; } set { _diagonal = value; } }
        public bool Tech3d { get { return _3dTech; } set { _3dTech = value; } }
        public bool DolbyDigital { get { return _dolbyDigital; } set { _dolbyDigital = value; } }
    }
}