using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HTMLAnalyze
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnparser_Click(object sender, EventArgs e)
        {
            HttpWebRequest htm = (HttpWebRequest)WebRequest.Create("http://www.yahoo.com");
            htm.UserAgent = ".NET";
            HttpWebResponse rep = (HttpWebResponse)htm.GetResponse();
            Stream stream = rep.GetResponseStream();
            StreamReader reader = new StreamReader(stream);
            string htmlText = reader.ReadToEnd();
            txtResponse.Value = htmlText;
        }
    }
}