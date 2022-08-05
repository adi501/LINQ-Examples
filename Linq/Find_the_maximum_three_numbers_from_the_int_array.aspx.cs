using System;
using System.Linq;

namespace Linq
{
    public partial class Find_the_maximum_three_numbers_from_the_int_array : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int[] ary1 = new int[] { 10, 27, 35, 40, 50, 11, 23, 25, 39, 22, 36 };

            var maxvalues = (from values in ary1
                             orderby (int)values descending
                             select new { Max3Values = values }).Take(3);
            gv1.DataSource = maxvalues;
            gv1.DataBind();

        }
    }
}