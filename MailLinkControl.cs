using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MailLinkControl
{
    [DefaultProperty("Text")]
    [ToolboxData("<{0}:MailLinkControl runat=server></{0}:MailLinkControl>")]
    public class MailLinkControl : WebControl
    {
        [Bindable(true)]
        [Category("Appearance")]
        [Localizable(true)]
        public string ToEmail
        {
            get
            {
                String s = (String)ViewState["ToEmail"];
                return ((s == null) ? "[ToEmail]" : s);
            }

            set
            {
                ViewState["ToEmail"] = value;
            }
        }
        [Bindable(true)]
        [Category("Appearance")]
        [Localizable(true)]
        public string CCEmail
        {
            get
            {
                String s = (String)ViewState["CCEmail"];
                return ((s == null) ? "[CCEmail]" : s);
            }

            set
            {
                ViewState["CCEmail"] = value;
            }
        }
        [Bindable(true)]
        [Category("Appearance")]
        [Localizable(true)]
        public string BCCEmail
        {
            get
            {
                String s = (String)ViewState["BCCEmail"];
                return ((s == null) ? "[BCCEmail]" : s);
            }

            set
            {
                ViewState["BCCEmail"] = value;
            }
        }
        [Bindable(true)]
        [Category("Appearance")]
        [Localizable(true)]
        public string Subject
        {
            get
            {
                String s = (String)ViewState["Subject"];
                return ((s == null) ? string.Empty : s);
            }

            set
            {
                ViewState["Subject"] = value;
            }
        }
        [Bindable(true)]
        [Category("Appearance")]
        [Localizable(true)]
        public string Body
        {
            get
            {
                String s = (String)ViewState["Body"];
                return ((s == null) ? string.Empty : s);
            }

            set
            {
                ViewState["Body"] = value;
            }
        }
        protected override void RenderContents(HtmlTextWriter output)
        {
            if (this.DesignMode) { RenderDesign(output); }
            else
            {
                if (this.Visible)
                {
                    RenderRuntime(output);
                }
                else
                {
                    return;
                }
            }
        }

        private void RenderRuntime(HtmlTextWriter output)
        {
            HyperLink link = new HyperLink();
            link.ID = this.ID;
            link.Text = this.Subject;
            link.NavigateUrl = string.Format("mailto:{0}", this.ToEmail);
            if (!string.IsNullOrEmpty(Subject))
            {
                link.NavigateUrl = link.NavigateUrl + "?subject=" + this.Subject;
                link.NavigateUrl = link.NavigateUrl + "&body=" + this.Body;
            }
            link.RenderControl(output);
        }

        private void RenderDesign(HtmlTextWriter output)
        {
            output.Write("To Email:{0}<br/>CCEmail:{1}<br/>BCCEmail:{2}<br/>Subject:{3}<br/>Body:{4}", this.ToEmail, this.CCEmail,this.BCCEmail, this.Subject, this.Body);
        }


    }
}
