using DatabaseLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccess
{
    public static partial class Model
    {
        static SqlDatabase db = new SqlDatabase();
        public static List<T> SelectGeneric<T>(object item, string tableName = null) where T : new()
        {
            return db.GetList<T>(item.ToSqlSelect(tableName), item.ToSqlParameter());
        }

       public static int DeleteGeneric(object item, string tableName)
        {
           var sql = item.ToSqlDelete(tableName);
            var param = item.ToSqlParameter();
            return db.ExecuteNonQuery(sql, param);
        }
        
        
       
    }
}
