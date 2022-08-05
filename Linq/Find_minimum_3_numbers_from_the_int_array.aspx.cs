using System;
using System.Linq;

namespace Linq
{
    public partial class Find_minimum_3_numbers_from_the_int_array : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int[] ary5 = new int[] { 10, 27, 35, 40, 50, 11, 23, 25, 39, 22, 36 };
            var minvalues = (from values in ary5
                             orderby (int)values ascending
                             select new { Min3Values = values }).Take(3);
            gv1.DataSource = minvalues;
            gv1.DataBind();

        }
    }
}