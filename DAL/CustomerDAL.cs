using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppProps;

namespace DAL
{
    public class CustomerDAL
    {
        Dbcon db = new Dbcon();
        public bool registration(Customer c)
        {
            string qry = $"INSERT INTO customer (Email,Name,Password) VALUES('{c.Email}', '{c.Name}', '{c.Password}')";
            return db.UDI(qry);
        }

        public DataTable login(Customer c)
        {
            string qry = $"SELECT Password FROM customer WHERE Email={c.Email}";
            return db.Search(qry);
        }

    }
}
