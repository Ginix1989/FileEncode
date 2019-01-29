using BaseDB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class views_main : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    /// <summary>
    /// 根据权限获取菜单
    /// </summary>
    /// <returns>菜单列表</returns>
    public String getMenu()
    {
        DataTable dt = DataManager.GetDataTable("select * from menu_info where id<9 order by id asc");
        String menuCollection = CommonTool.DataTableToJson(dt);//DataTable转Json
        return menuCollection;
    }
}
