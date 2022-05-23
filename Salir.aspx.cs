using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _3E_ProyectoFinal_NeshoPablo
{
    public partial class Salir : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
                FormsAuthentication.SignOut();
               //FormsAuthentication.RedirectToLoginPage();
               Response.Redirect("Default");
            
        }
    }
}