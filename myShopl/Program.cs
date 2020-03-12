using System;
using myShopl.shop;
using MySql.Data.MySqlClient;
using  myShopl;
namespace myShopl
{
    class Program
    {
        static void Main(string[] args)
        {
            string connStr = "server=localhost;user=root;database=shop;password=root;";
            // Console.WriteLine(Function.Remove("laptop",6, connStr));
            Function.AddLaptops();
            Function.AddTv();
            Console.ReadLine();

        }
        
        
        
    }
    
    
    
}

