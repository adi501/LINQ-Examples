using System;
using System.Linq;

namespace Linq
{
    public partial class Find_the_gif_image_in_a_folder_order_by_image_size : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(Server.MapPath("~/Images"));
            var giffiles = from file in dir.GetFiles()
                           where file.Extension == ".gif" || file.Extension == ".png"
                           orderby file.Length
                           select new { FileName = file.Name, FileSize = (file.Length / 1024) + " KB" };
            gv1.DataSource = giffiles;
            gv1.DataBind();
        }
    }
}