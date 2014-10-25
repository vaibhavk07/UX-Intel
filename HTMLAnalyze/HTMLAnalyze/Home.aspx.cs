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
            addwebpage.InnerHtml = String.Empty;
            addlink.InnerHtml = String.Empty;
            addscript.InnerHtml = String.Empty;
            addstyle.InnerHtml = String.Empty;
            string url = "https://" + txturl.Text;
            HtmlWeb webpage = new HtmlWeb();
            HtmlDocument doc = webpage.Load(url);

            string htmlText = doc.DocumentNode.InnerHtml;

            var scripts = doc.DocumentNode.Descendants("script");
            var styles = doc.DocumentNode.Descendants("style");
            var links = doc.DocumentNode.Descendants("link");
            StringBuilder sb = new StringBuilder();
            foreach (var script in scripts)
            {
                sb.Append(script.OuterHtml.Replace("src=\"/", "src=\"" + url + "/"));
            }
            addscript.InnerHtml = sb.ToString();
            sb.Clear();

            foreach (var style in styles)
            {
                sb.Append(style.OuterHtml);
            }
            addstyle.InnerHtml = sb.ToString();
            sb.Clear();

            foreach (var link in links)
            {
                if (!link.OuterHtml.Contains("href=\"//"))
                {
                    sb.Append(link.OuterHtml.Replace("href=\"/", "href=\"" + url + "/"));
                }
                else
                {
                    sb.Append(link.OuterHtml);
                }
            }
            addlink.InnerHtml = sb.ToString();
            var tbody = doc.DocumentNode.Descendants("body");

            StringBuilder body_html = new StringBuilder();
            foreach (var item in tbody)
            {
                addwebpage.InnerHtml = item.InnerHtml;
            }
            BTNanalyze.Visible = true;
        }
    }
}