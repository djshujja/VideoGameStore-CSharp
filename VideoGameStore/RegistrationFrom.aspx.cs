using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AppProps;
using BLL;


namespace VideoGameStore
{
    public partial class RegistrationFrom : System.Web.UI.Page
    {
        CustomerBLL cBLL = new CustomerBLL();
        Customer _customer = new Customer();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void HandleRegister(object sender, EventArgs e)
        {
            _customer.Email = Email.Text;
            _customer.Name = Name.Text;
            _customer.Password = Password.Text;
            if(cBLL.registrationBLL(_customer))
            {
                Response.Write("<script>alert('registered!')</script>");
            } else
            {
                Response.Write("<script>alert('no registered!')</script>");
            }
        }
    }
}