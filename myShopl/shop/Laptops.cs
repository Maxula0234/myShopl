using System;
using MySql.Data.MySqlClient;
namespace myShopl.shop
{
    public class Laptops:Computer
    {
        private bool _touchBar = true;
        private string _timeWork;
        private decimal _diagonal;
        private string _colorLaptop;
        private string _table = "laptop";


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
        public bool TouchBar { get { return _touchBar; } set { _touchBar = value; } }
        public string TimeWork { get{ return _timeWork; }set { _timeWork = value; } }
        public decimal Diagonal { get{ return _diagonal; }set { _diagonal = value; } }
        public override string Color { get { return _colorLaptop; }set { _colorLaptop = value; }  }
    }
}