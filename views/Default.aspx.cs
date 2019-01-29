using BaseDB;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class views_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void test(object sender, EventArgs e)
    {
        //Response.ContentType = "application/json";
        //Hashtable hash = new Hashtable();
        //hash.Add("error", "");
        //hash.Add("key2", "val2");
        ////序列化
        //string o = new JavaScriptSerializer().Serialize(hash);//值："{\"Name\":\"苹果\",\"Price\":5.5}"
        //Response.Write(o);
        DataTable dt = DataManager.GetDataTable("select * from menu_info where id<9 order by id asc");
        String menuCollection = CommonTool.DataTableToJson(dt);//DataTable转Json
        Context.Response.ContentType = "application/json";
        Context.Response.Write(menuCollection);
        Context.Response.End();

    }
}