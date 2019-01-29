using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;

/// <summary>
/// Common 的摘要说明
/// </summary>
public class CommonTool
{
    public CommonTool()
    {
        //
        // TODO: 在此处添加构造函数逻辑
        //
    }
    /// <summary>
    /// DataTable转Json
    /// </summary>
    /// <param name="dtb"></param>
    /// <returns></returns>
    public static string  DataTableToJson(DataTable dtb)
    {
        JavaScriptSerializer json = new JavaScriptSerializer();
        ArrayList dic = new ArrayList();

        foreach (DataRow row in dtb.Rows)
        {
            Dictionary<string, object> drow = new Dictionary<string, object>();
            foreach (DataColumn col in dtb.Columns)
            {
                drow.Add(col.ColumnName, row[col.ColumnName]);
            }
            dic.Add(drow);
        }
        return json.Serialize(dic);
    }

}