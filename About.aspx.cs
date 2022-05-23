using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _3E_ProyectoFinal_NeshoPablo
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {         
            var identidad = (FormsIdentity)Context.User.Identity;

            if (identidad.Ticket.UserData != "1")
            {          
                Response.Redirect("Default", true);
            }

        }
    }
}