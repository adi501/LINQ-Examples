using System;
using System.Linq;

namespace Linq
{
    public partial class Find_the_numbers_between_20_and_35_from_the_int_array : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int[] ary2 = new int[] { 10, 27, 35, 40, 50, 11, 23, 25, 39, 22, 36 };
            var res = from values in ary2
                      where (int)values >= 20 && (int)values <= 35
                      orderby (int)values
                      select new { ValuesBetween20_35 = values };
            gv1.DataSource = res;
            gv1.DataBind();

        }
    }
}