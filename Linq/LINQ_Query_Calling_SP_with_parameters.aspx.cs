using System;

namespace Linq
{
    public partial class LINQ_Query_Calling_SP_with_parameters : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_insert_Click(object sender, EventArgs e)
        {
            MyDBDataContext sqlObj = new MyDBDataContext();
            sqlObj.Sp_insertDepartment("Test Department",true);

        }
    }
}