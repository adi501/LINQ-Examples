using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Linq
{
    public partial class Select_and_convert_Upper_and_lower_laters : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (DatabaseDataContext db = new DatabaseDataContext())
            {
                var data = from a in db.tbl_emps select new { Id = a.Id, Name_in_Upper = a.Name.ToUpper(), Name_in_lower = a.Name.ToLower() };
                gv1.DataSource = data;
                gv1.DataBind();
            }
        }
    }
}