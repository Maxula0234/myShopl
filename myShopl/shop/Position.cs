using MySql.Data.MySqlClient;
using  System;

namespace myShopl.shop
{
    public abstract class Position
    {
        //Атрибуты класса - 
        private int _id;
        private string _name;
        private decimal _weigth = 0;
        private string _color = "Black";
        private string _producer;
        public string _connStr = "server=localhost;user=root;database=shop;password=root;";


        //Свойства атрибутов 
        public virtual int Id { get; }

        public virtual string Name { get { return _name; } set { _name = value; } }
        public virtual decimal Weigth { get { return _weigth; } set { _weigth = value; } }
        public virtual string Color { get { return _color; } set { _color = value; } }
        public virtual string Producer { get { return _producer; } set { _producer = value; } }

        public string ConnectString
        {
            get { return _connStr; }
        }
        // Методы класса - метод делает

    }
}