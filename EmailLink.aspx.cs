using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MailLinkControl
{
    public partial class EmailLink : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            thelink.ServerClick += new System.EventHandler(this.Link_Click);
            emailLink.Visible = false;
        }
        void Link_Click(Object sender, EventArgs e)
        {
            this.emailLink.ToEmail = txtToEmail.Text;
            this.emailLink.CCEmail = txtCCEmail.Text;
            this.emailLink.BCCEmail = txtBCCEmail.Text;
            this.emailLink.Subject = this.txtSubject.Text;
            this.emailLink.Body = this.txtBody.Text;
            emailLink.Visible = true;
        }
    }
}