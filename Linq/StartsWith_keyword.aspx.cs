using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Linq
{
    public partial class StartsWith_keyword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_search_Click(object sender, EventArgs e)
        {
using (DatabaseDataContext db = new DatabaseDataContext())
{
    var data = from a in db.tbl_emps where a.Name.StartsWith(txt_name.Text) select a;
    gv1.DataSource = data;
    gv1.DataBind();
}
        }
    }
}