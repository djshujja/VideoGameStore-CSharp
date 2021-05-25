using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppProps;
using DAL;

namespace BLL
{
    public class CustomerBLL
    {
        CustomerDAL cDal = new CustomerDAL();
        public bool registrationBLL(Customer c)
        {
            return cDal.registration(c);
        }

        public DataTable loginBLL(Customer c)
        {
            return cDal.login(c);
        }
    }
}
