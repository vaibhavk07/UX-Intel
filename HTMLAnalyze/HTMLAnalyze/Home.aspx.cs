using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HtmlAgilityPack;
using System.Text;

namespace HTMLAnalyze
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnparser_Click(object sender, EventArgs e)
        {
            //HtmlAgilityPack
            HtmlWeb webpage = new HtmlWeb();
            //HtmlDocument doc = webpage.Load("https://app.vwo.com/#/login/");
            HtmlDocument doc = webpage.Load("https://www.facebook.com/");

            string htmlText = doc.DocumentNode.InnerHtml;//doc.ToString();
            //txtResponse.Value = htmlText;

            var scripts = doc.DocumentNode.Descendants("script");
            var styles = doc.DocumentNode.Descendants("style");
            StringBuilder sb = new StringBuilder();
            foreach (var script in scripts)
            {
                sb.Append(script.OuterHtml);
            }
            addscript.InnerHtml = sb.ToString();
            sb.Clear();

            foreach (var style in styles)
            {
                sb.Append(style.OuterHtml);
            }
            addstyle.InnerHtml = sb.ToString();

            //foreach (var scriptnode in script)
            //{
            //    doc.DocumentNode.RemoveChild(scriptnode);
            //}
            var tbody = doc.DocumentNode.Descendants("body");

            StringBuilder body_html = new StringBuilder();
            foreach (var item in tbody)
            {
                //var filter_webpage = item.Descendants();
                //foreach (var t_elements in filter_webpage)
                //{
                //    if (t_elements.Name.ToString().ToLower() != "script"&&t_elements.NodeType!= HtmlNodeType.Text)
                //        body_html.Append(t_elements.OuterHtml);
                //}
                addwebpage.InnerHtml = item.InnerHtml;
//                txtResponse.Value = item.InnerHtml;
            }
            
            //var body = doc.DocumentNode.Descendants();
            //    string bbody = "";
            //    foreach (var item in body)
            //    {
            //        if (item.Name.ToString().ToLower() == "script")
            //            continue;
            //        bbody += item.OuterHtml;
            //    }
            //    var divbody = bbody.ToString();
            //    txtResponse.Value = divbody;
            //HttpWebRequest htm = (HttpWebRequest)WebRequest.Create("http://www.yahoo.com");
            //htm.UserAgent = Request.UserAgent;
            //HttpWebResponse rep = (HttpWebResponse)htm.GetResponse();
            //Stream stream = rep.GetResponseStream();
            //StreamReader reader = new StreamReader(stream);
            //string htmlText = reader.ReadToEnd();
            //txtResponse.Value = htmlText;
        }
    }
}