using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Drawing;


namespace ControlWeb
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Ctrl.BorderStyle = BorderStyle.Groove;
            Ctrl.Text = "Desarrollo de Aplicaciones";

            //ARGB
            int alpha = 255, red = 0, green = 255, blue = 0;
            Ctrl.ForeColor = Color.FromArgb(alpha, red, green, blue);
            //Color .NET
            Ctrl.ForeColor = Color.Crimson;
            //Color HTML
            Ctrl.ForeColor = ColorTranslator.FromHtml("Blue");


            Ctrl.Font.Name = "Verdana";
            Ctrl.Font.Bold = true;
            Ctrl.Font.Size = FontUnit.Small;
            Ctrl.Font.Size = FontUnit.Point(14);

            if (!this.IsPostBack)
            {
                chklst.Items.Add("C");
                chklst.Items.Add("C++");
                chklst.Items.Add("C#");
                chklst.Items.Add("C");
                chklst.Items.Add("VB .NET");
                chklst.Items.Add("Pascal");
            }

        }

        protected void cmdOK_Click(object sender, EventArgs e)
        {
           
                lblResult.Text = "Tu escogiste: <base>";
                foreach (ListItem lstItem in chklst.Items)
                {
                    if (lstItem.Selected == true)
                        lblResult.Text += "<br/>" + lstItem.Text;
                }
                lblResult.Text += "<br/>";

        }
    }
}