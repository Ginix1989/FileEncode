﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class views_ServePage_uploadFile : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //判断是否异步请求
        if (Request.QueryString["method"] == "saveFile")
        {
            saveFile();

        }
    }
    public void saveFile()
    {
        HttpPostedFile oFile = HttpContext.Current.Request.Files["txt_file"];
        StringBuilder displayString = new StringBuilder();
        //    var oStream = oFile.InputStream;



        // Get the length MyFileUpload the file.
        int fileLen = oFile.ContentLength;

        // Display the length of the file in a label.
        Debug.WriteLine("The length of the file is " +
                               fileLen.ToString() + " bytes.");

        // Create a byte array to hold the contents of the file.
        Byte[] Input = new Byte[fileLen];

        // Initialize the stream to read the uploaded file.
        // myStream = MyFileUpload.FileContent;

        // Read the file into the byte array.
        oFile.InputStream.Read(Input, 0, fileLen);

        // Copy the byte array to a string.
        for (int loop1 = 0; loop1 < fileLen; loop1++)
        {
            displayString.Append(Input[loop1].ToString());
        }

        Debug.WriteLine("源字符串" + displayString.ToString());
        string timeSstring = DateTime.Now.ToString("yyyyMMddhhmmss");
     
        String path = Server.MapPath("~/File/" + timeSstring + oFile.FileName);
        FileStream fs = File.Create(path);

        fs.Write(Input, 0, Input.Length);
        fs.Close();
        oFile.InputStream.Close();
        Hashtable hash = new Hashtable();
        hash.Add("error", "");
        //序列化
        string o = new JavaScriptSerializer().Serialize(hash);//
        Context.Response.ContentType = "application/json";
        Context.Response.Write(o);
        Context.Response.End();

        // return "{\"error\":\"\"}";


    }
}