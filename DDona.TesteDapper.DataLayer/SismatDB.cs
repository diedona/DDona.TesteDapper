using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDona.TesteDapper.DataLayer
{
    public class SismatDB
    {
        private string _connectionString { get; set; }

        public SismatDB(string contextName)
        {
            _connectionString = ConfigurationManager.AppSettings[contextName];
        }

        public T Get<T>(string sql)
        {
            try
            {
                using (IDbConnection db = new SqlConnection(this._connectionString))
                {
                    return db.Query<T>(sql).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<T> GetList<T>(string sql)
        {
            try
            {
                using (IDbConnection db = new SqlConnection(this._connectionString))
                {
                    return db.Query<T>(sql);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
