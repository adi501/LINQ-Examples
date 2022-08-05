using System;
using System.Linq;

namespace Linq
{
    public partial class Find_the_names_which_are_having_lenght_more_than_4_in_the_string_array : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string[] ary2 = new string[] { "Ravi", "Ramana", "Brod", "Wess", "Vinay", "Smith", "Williams" };
            var names = from name in ary2
                        where name.Length > 4
                        select new { NameMoreThan4Digits = name };
            gv1.DataSource = names;
            gv1.DataBind();


        }
    }
}