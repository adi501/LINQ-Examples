using System;
using System.Linq;

namespace Linq
{
    public partial class Find_the_even_numbers_in_the_int_array : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int[] ary3 = new int[] { 10, 27, 35, 40, 50, 11, 23, 25, 39, 22, 36 };
            var evennumbers = from values in ary3
                              where (int)values % 2 == 0
                              orderby (int)values
                              select new { EvenNumbers = values };
            gv1.DataSource = evennumbers;
            gv1.DataBind();


        }
    }
}