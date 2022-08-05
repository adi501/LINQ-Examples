using System;
using System.Linq;

namespace Linq
{
    public partial class LINQ_to_Strings_Split_String_with_space : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string input = "linq to string example-sdafsd-dsfds";
            var wordsorderbylength = from str in input.Split(' ','-')
                                     orderby str.Length
                                     select new { words_in_line=  str, words_in_line1 = str };
            gv1.DataSource = wordsorderbylength;
            gv1.DataBind();

        }
    }
}