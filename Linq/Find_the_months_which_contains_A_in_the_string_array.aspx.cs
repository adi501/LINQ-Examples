using System;
using System.Linq;

namespace Linq
{
    public partial class Find_the_months_which_contains_A_in_the_string_array : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string[] ary1 = new string[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            var month = from months in ary1
                        where months.ToLowerInvariant().Contains("a")
                        select new { MonthContains_A = months };
            gv1.DataSource = month;
            gv1.DataBind();

        }
    }
}