using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    public class SqliteDataAccess
    {
        public static List<Item> LoadItems()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString())) //connection to database, protects as from error
            {
                var output = cnn.Query<Item>("select * from Item", new DynamicParameters()); //return type object
                return output.ToList();
            }
        } 
        
        public static void SaveItem(Item item)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Item (Name, Details, Price, CategoryID) values (@Name, @Details, @Price, @CategoryID)"  , item);
            }
        } 

        public static void DeleteItem(Item item) // neistrina
        {
            using (IDbConnection cnp = new SQLiteConnection(LoadConnectionString()))
            {
                cnp.Execute("delete from Item where Name=@Name", item);
            }
        }

        public static void UpdateItem(Item item)
        {
            using (IDbConnection cnp = new SQLiteConnection(LoadConnectionString()))
            {
                cnp.Execute("update Item set Price=@Price where Name = @Name", item);
            }
        }

        public static List<Customer> LoadCustomer() //nepamirsti klases Customer deklaruoti kaip public!!!
        {
            using (IDbConnection cpp = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cpp.Query<Customer>("select * from Customer", new DynamicParameters()); //return type object
                return output.ToList();
            }
        }
/*
        private static string LoadConnectionString()
        {
            throw new NotImplementedException();
        }
    }
    */
        public static void SaveCustomer(Customer customer)
        {
          using (IDbConnection cpp = new SQLiteConnection(LoadConnectionString()))
            {
            cpp.Execute("insert into Customer (Username, Password, Name, Surname, Email) values (@Username, @Password, @Name, @Surname, @Email)", customer);
            }
        } 
        
    
private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
