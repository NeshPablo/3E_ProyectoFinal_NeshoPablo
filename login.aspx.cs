using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _3E_ProyectoFinal_NeshoPablo
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            string usuario = Login1.UserName;
            string password = Login1.Password;

            if ((usuario == "ABC") && (password == "123"))
            {
                FormsAuthenticationTicket tkt;
                string cookiestr;
                HttpCookie ck;
                tkt = new FormsAuthenticationTicket(1, Login1.UserName, DateTime.Now,
                DateTime.Now.AddMinutes(30), Login1.RememberMeSet, "2");
                cookiestr = FormsAuthentication.Encrypt(tkt);
                ck = new HttpCookie(FormsAuthentication.FormsCookieName, cookiestr);
                if (Login1.RememberMeSet)
                    ck.Expires = tkt.Expiration;
                ck.Path = FormsAuthentication.FormsCookiePath;
                Response.Cookies.Add(ck);

                string strRedirect;
                strRedirect = Request["ReturnUrl"];
                if (strRedirect == null)
                    strRedirect = "Default.aspx";
                Response.Redirect(strRedirect, true);
            }
        }    
    }
}