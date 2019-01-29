using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void FileUploadButton_Click(object sender, EventArgs e)
    {
        if (MyFileUpload.HasFile)
        {
           
            Debug.WriteLine(MyFileUpload.FileName);
            Debug.WriteLine(MyFileUpload.FileBytes);
            Debug.WriteLine(MyFileUpload.FileContent);
            System.IO.Stream myStream;


            StringBuilder displayString = new StringBuilder();

            // Get the length MyFileUpload the file.
          int  fileLen = MyFileUpload.PostedFile.ContentLength;

            // Display the length of the file in a label.
        Debug.WriteLine( "The length of the file is " +
                               fileLen.ToString() + " bytes.");

            // Create a byte array to hold the contents of the file.
            Byte[] Input = new Byte[fileLen];

            // Initialize the stream to read the uploaded file.
            myStream = MyFileUpload.FileContent;

            // Read the file into the byte array.
            myStream.Read(Input, 0, fileLen);

            // Copy the byte array to a string.
            for (int loop1 = 0; loop1 < fileLen; loop1++)
            {
                displayString.Append(Input[loop1].ToString());
            }

            Debug.WriteLine("源字符串"+ displayString.ToString());
            String path = Server.MapPath("~/File/test");
            FileStream fs= File.Create(path);

            fs.Write(Input,0,Input.Length);
            fs.Close();
            myStream.Close();


             String ss = SecurityHelper.EncryptDES(displayString.ToString(), "DESECODE");

            Debug.WriteLine("加密过的字符串"+ss);
           String Decode= SecurityHelper.DecryptDES(ss, "DESECODE");
            Debug.WriteLine("解密过的字符串"+Decode);
            //string filePath = Server.MapPath("~/File/");
            //string fileName = MyFileUpload.PostedFile.FileName;
            //MyFileUpload.SaveAs(filePath + fileName);
            //Response.Write("<p >上传成功!</p>");


            //int FileLen = MyFileUpload.;//获取上传文件的大小

            //byte[] input = new byte[FileLen];

            //System.IO.Stream UpLoadStream = MyFileUpload.PostedFile.InputStream;
            //UpLoadStream.Read(input, 0, FileLen);
            //UpLoadStream.Position = 0;
            //System.IO.StreamReader sr = new System.IO.StreamReader(UpLoadStream, System.Text.Encoding.Default);
            //Msg.Text = "您上传的文件内容是：<br/><br/>" + sr.ReadToEnd();
            //Console.Write(sr.ReadToEnd());
            //sr.Close();
            //UpLoadStream.Close();
            //UpLoadStream = null;
            //sr = null;
        }
        else
        {
            Response.Write("<p >请选择要上传的文件!</p>");
        }
    }
}