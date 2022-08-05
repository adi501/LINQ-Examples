using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Linq
{
    public partial class OrderByDescending : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
using (DatabaseDataContext db = new DatabaseDataContext())
{
    var data = from a in db.tbl_emps orderby a.Name descending select a;
    gv1.DataSource = data;
    gv1.DataBind();
}
        }
    }
}