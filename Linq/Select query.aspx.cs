using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Linq
{
    public partial class Select_query : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (DatabaseDataContext db = new DatabaseDataContext())
            {
                var data = from a in db.tbl_emps select a;
                gv1.DataSource = data;
                gv1.DataBind();
            }

using (DatabaseDataContext db = new DatabaseDataContext())
{
    var data = (from a in db.tbl_emps where a.Id == 100 select a).FirstOrDefault();
    if (data != null)
        db.tbl_emps.DeleteOnSubmit(data);
    db.SubmitChanges();
}

        }
    }
}