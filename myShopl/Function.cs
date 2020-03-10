using System;
using myShopl.shop;
using MySql.Data.MySqlClient;

namespace myShopl
{
    public class Function
    {
        
        public static TV AddTv()
        {

            Console.WriteLine("Вы хотите добавить телевизор? y/n ");
            var key = Console.ReadKey();
            Console.Write(key.Key);
            switch(key.Key)
            {
                case ConsoleKey.Y:
                    {
                        TV tv = new TV();
                        MySqlConnection connection = new MySqlConnection(tv.ConnectString);
                        connection.Open();
                        Console.WriteLine("Введите название ТВ");
                        tv.Name = Console.ReadLine();
                        Console.WriteLine("Введите вес ТВ");
                        tv.Weigth = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("Введите цвет ТВ");
                        tv.Color = Console.ReadLine();
                        Console.WriteLine("Введите производителя ТВ");
                        tv.Producer = Console.ReadLine();
                        Console.WriteLine("Введите диагональ ТВ");
                        tv.Diagonal = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("Тв содержит технологию 3d? - 1/0");
                        var d3 = Console.ReadKey();
                         switch (d3.Key)
                            {
                            case ConsoleKey.D1:
                                {
                                    tv.Tech3d = true;
                                    break;
                                }
                            case ConsoleKey.D0:
                                {
                                    tv.Tech3d = false;
                                    break;
                                }
                        }  
                        Console.WriteLine("ТВ содержит технологию DolbyDigital? 1/0");
                        var Db = Console.ReadKey();
                        switch (Db.Key)
                          {
                            case ConsoleKey.D1:
                                {
                                    tv.DolbyDigital = true;
                                    break;
                                }
                            case ConsoleKey.D0:
                                {
                                    tv.DolbyDigital = false;
                                    break;
                                }

                        }
                        string sql = $"INSERT INTO shop.Tv (Id,Name, Weigth, Color,Producer,LargeHomeAPP,Diagonal,Tech3d,DolbyDigital) " +
                                     $"VALUES ({tv.Id},'{tv.Name}', {tv.Weigth}, '{tv.Color}','{tv.Producer}',1,{tv.Diagonal}, {tv.Tech3d}," +
                                     $"{tv.DolbyDigital})";
                        MySqlCommand command = new MySqlCommand(sql,connection);
                        command.ExecuteNonQuery(); 
                        connection.Close();
                        return tv;
                    }

                case ConsoleKey.N:
                    {
                        Console.WriteLine("Заврешаем работу приложения");
                        return null;
                    }
            }

            return null;

        }
        
        public static void  AddLaptops()
        {
            Console.WriteLine("Вы хотите добавить laptop? y/n ");
            var key = Console.ReadKey();
            Console.Write(key.Key);
            switch(key.Key)
            {
                case ConsoleKey.Y:
                    {
                        Laptops lap = new Laptops();
                        MySqlConnection connection = new MySqlConnection(lap.ConnectString);
                        connection.Open();
                        //
                        // string queryCount = "Select count(Id) from laptop";
                        // MySqlCommand count = new MySqlCommand(queryCount,connection);
                        // string countStringTable = count.ExecuteScalar().ToString();
                        // lap.Id = Convert.ToInt32(countStringTable);
                        

                        Console.WriteLine("Введите название laptop");
                        lap.Name = Console.ReadLine();
                        Console.WriteLine("Введите вес laptop");
                        lap.Weigth = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("Введите цвет laptop");
                        lap.Color = Console.ReadLine();
                        Console.WriteLine("Введите производителя laptop");
                        lap.Producer = Console.ReadLine();
                        Console.WriteLine("Введите диагональ laptop");
                        lap.Screen = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine("laptop содержит ssd - 1/0");
                        var d3 = Console.ReadKey();
                         switch (d3.Key)
                            {
                            case ConsoleKey.D1:
                                {
                                    lap.Ssd = true;
                                    break;
                                }
                            case ConsoleKey.D0:
                            {
                                lap.Ssd = false;
                                    break;
                                }
                        }  
                        Console.WriteLine("laptop содержит touchbar? 1/0");
                        var Db = Console.ReadKey();
                        switch (Db.Key)
                          {
                            case ConsoleKey.D1:
                                {
                                    lap.TouchBar = true;
                                    break;
                                }
                            case ConsoleKey.D0:
                                {
                                    lap.TouchBar = false;
                                    break;
                                }

                        }
                        string sql = $"INSERT INTO shop.laptop (Id,Name, Weigth, Color,Producer,Screen) VALUES ({lap.Id},'{lap.Name}', {lap.Weigth}, '{lap.Color}','{lap.Producer}',{lap.Screen})";
                        MySqlCommand command = new MySqlCommand(sql,connection);
                        command.ExecuteNonQuery(); //возвращает числом кол-во строк которые модифицированын
                        connection.Close();
                        // return lap;
                        break;
                    }
                case ConsoleKey.N:
                {
                    Console.WriteLine("Заврешаем работу приложения");
                        // return null;
                        break;
                }
            }

            // return null;

        }
        
        public static string CountItem(string typeItem, string connStr) {
            
            MySqlConnection connection = new MySqlConnection(connStr);
            connection.Open();
            string queryCount = $"Select count(Id) from {typeItem}";
            MySqlCommand count = new MySqlCommand(queryCount,connection);
            string countStringTable = $"Кол-во объектов [{typeItem}]: " + count.ExecuteScalar().ToString();
            return countStringTable;
        }
    }
}