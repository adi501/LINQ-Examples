using System;
using System.Linq;

namespace Linq
{
    public partial class Find_the_odd_numbers_in_the_int_array : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int[] ary4 = new int[] { 10, 27, 35, 40, 50, 11, 23, 25, 39, 22, 36 };
            var oddnumbers = from values in ary4
                             where (int)values % 2 == 1
                             orderby (int)values
                             select new { OddNumbers = values };
            gv1.DataSource = oddnumbers;
            gv1.DataBind();

        }
    }
}