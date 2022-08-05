using System;
using System.Linq;

namespace Linq
{
    public partial class Find_the_distinct_words_in_the_string_order_by_words : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string input1 = "hi Hellow HI world hellow world world hi hi";
            var wordsuinque = from str in input1.ToLowerInvariant().Split().Distinct()
                              select new { DistinctWords = str };
            gv1.DataSource = wordsuinque;
            gv1.DataBind();

        }
    }
}