using System;
using System.Linq;
using System.Xml.Linq;

namespace Linq
{
    public partial class Reading_XML_using_LINQ : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(Server.MapPath("~/XML/Countries.xml"));
                string path = dir.ToString();
                XDocument xdoc = XDocument.Load(path);
                var countires = from country in xdoc.Descendants("countries").Elements("country").Attributes("name") select country.Value;
                ddl_Country.DataSource = countires;
                ddl_Country.DataBind();

                var cities = from country in xdoc.Descendants("countries").Elements("country")
                             where country.Attribute("name").Value == ddl_Country.SelectedValue
                             from city in country.Elements("city")
                             orderby city.Value
                             select city.Value;

                ddl_City.DataSource = cities;
                ddl_City.DataBind();
            }

        }

        protected void ddl_Country_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(Server.MapPath("~/XML/Countries.xml"));
                string path = dir.ToString();
                XDocument xdoc = XDocument.Load(path);
                var cities = from country in xdoc.Descendants("countries").Elements("country")
                             where country.Attribute("name").Value == ddl_Country.SelectedValue
                             from city in country.Elements("city")
                             orderby city.Value
                             select city.Value;

                ddl_City.DataSource = cities;
                ddl_City.DataBind();
            }
            catch
            {
            }

        }
    }
}