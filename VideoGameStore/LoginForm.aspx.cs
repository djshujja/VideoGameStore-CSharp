using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AppProps;
using BLL;


namespace VideoGameStore
{

    public partial class LoginForm : System.Web.UI.Page
    {
        CustomerBLL cBLL = new CustomerBLL();
        Customer _customer = new Customer();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void HandleLogin(object sender, EventArgs e)
        {
            string password  = Password.Text;
            string email = Email.Text;
            _customer.Email = email;
            _customer.Password = password;

            DataTable dt = cBLL.loginBLL(_customer);
            if(dt != null)
            {
                if(password.Equals(dt.Rows[0]["Password"].ToString()))
                {
                    Session["email"] = email;
                    Response.Redirect("Home.html");
                }
                else
                {
                    Response.Write("<script> alert('wrong password!') </script>");
                }
            }
        }
    }
}