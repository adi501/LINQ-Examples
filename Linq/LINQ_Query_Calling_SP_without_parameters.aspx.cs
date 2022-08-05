using System;

namespace Linq
{
    public partial class LINQ_Query_Calling_SP_without_parameters : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MyDBDataContext sqlObj = new MyDBDataContext();
            gv1.DataSource = sqlObj.Sp_getDepartment();
            gv1.DataBind();

        }
    }
}