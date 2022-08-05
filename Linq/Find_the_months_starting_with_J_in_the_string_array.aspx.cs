using System;
using System.Linq;

namespace Linq
{
    public partial class Find_the_months_starting_with_J_in_the_string_array : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string[] ary = new string[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };
            var res = from months in ary
                      where months.StartsWith("J")
                      select new { MonthStartWith_J = months };
            gv1.DataSource = res;
            gv1.DataBind();

        }
    }
}