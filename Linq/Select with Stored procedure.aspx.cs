using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Linq
{
    public partial class Select_with_Stored_procedure : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (DatabaseDataContext db = new DatabaseDataContext())
            {
                var data = db.get_emps_all();
                gv1.DataSource = data;
                gv1.DataBind();
            }
        }
    }
}