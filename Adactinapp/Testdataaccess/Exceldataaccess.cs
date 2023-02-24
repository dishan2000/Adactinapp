using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.OleDb;
using Dapper;


namespace Adactinapp.Testdataaccess
{
    class Exceldataaccess
    {
        public static string TestDataFileConnection()
        {
            var FileName = ConfigurationManager.AppSettings["TestDataSheetPath"];
            var con = String.Format(@"provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=Excel 12.0;", FileName);
            return con;

        }
        public static userdata GetTestdata(String keyName)
        {
            using (var connection = new OleDbConnection(TestDataFileConnection()))
            {
                connection.Open();
                var query = string.Format("select * from [DataSet$] where key'{0}", keyName);
                var value = connection.Query<userdata>(query).FirstOrDefault();
                connection.Close();
                return value;

            }
        }

    }
}
