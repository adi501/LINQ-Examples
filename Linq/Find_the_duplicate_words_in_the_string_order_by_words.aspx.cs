using System;
using System.Linq;

namespace Linq
{
    public partial class Find_the_duplicate_words_in_the_string_order_by_words : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string input2 = "This This This sentance contains duplicate words and the following linq query will find the duplicate words in this";
            var duplicatewords = from str in input2.ToLowerInvariant().Split()
                                 group str by str into temp
                                 orderby temp.Key
                                 where temp.Count() > 1
                                 select new { DuplicateWords = temp.Key };
            gv1.DataSource = duplicatewords;
            gv1.DataBind();

        }
    }
}