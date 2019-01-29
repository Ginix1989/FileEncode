using System;
using System.Collections.Generic;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Data.Common;


/// <summary>
/// 数据管理类
/// 
/// DataConn 的摘要说明（将来还需要一个oledb版本用来支持别的数据库)
/// 
/// </summary>
/// 
namespace BaseDB
{
    public class DataManager
    {
        //读取webconfig中的链接字符串
        private static string strConn = System.Configuration.ConfigurationManager.ConnectionStrings["EncodeConnectDataBaseStr"].ToString().Trim();

        public DataManager()
        {

        }
        /// <summary>
        ///  根据查询语句返回结果集DataTable::记住定义错误页面
        /// </summary>
        /// <param name="strSql"></param>
        /// <returns></returns>
        /// 

        public static DataTable GetDataTable(string strSql = "select * from sys_Menu")
        {
            //定义返回对象
            DataTable dt = new DataTable();
            //创建连接字对象
            SqlConnection myConn = new SqlConnection(strConn);

            try
            {
                myConn.Open();
            }
            catch (Exception myConnError)
            {
                throw myConnError;
            }

            //创建数据适配器
            SqlDataAdapter myAdap = new SqlDataAdapter(strSql, myConn);
            //填充
            myAdap.Fill(dt);

            myConn.Close();

            myAdap.Dispose();
            //返回结果集
            return dt;
        }

        #region 测试
        //public static int ExcutSqls(List<DbCommand> strList)
        //{
        //    //定义事务
        //    DbTransaction transaction = null;

        //    SqlConnection myConn = new SqlConnection(strConn);

        //    string strErrorMsg = "";
        //    if (strList.Count > 0)
        //    {
        //        //
        //        try
        //        {
        //            myConn.Open();

        //            transaction = myConn.BeginTransaction();

        //            foreach (DbCommand command in strList)
        //            {
        //                strErrorMsg = command.CommandText;
        //                command.Transaction = transaction;
        //                command.Connection = myConn;
        //                command.ExecuteNonQuery();
        //            }

        //            transaction.Commit();
        //            return 0;

        //        }
        //        catch (Exception ex)
        //        {
        //            transaction.Rollback();
        //            return -1;
        //        }
        //        finally
        //        {
        //            transaction.Dispose();
        //            myConn.Close();
        //        }
        //    }
        //    return 0;
        //}
        #endregion

        /// <summary>
        ///   执行数据库操作（语句组）
        /// </summary>
        /// <param name="sqlString">要执行的语句组</param>
        /// <returns>0：正常返回；-1 回滚返回</returns>
        public static int ExcutSqls(ArrayList arrList)
        {
            //事务
            SqlTransaction transaction = null;
            //定义链接字符窜
            SqlConnection myConn = new SqlConnection(strConn);
            //执行命令
            SqlCommand myComm = new SqlCommand();
            //先判断sqlString是否有值
            if (arrList.Count != 0)
            {
                try
                {
                    //打开链接
                    myConn.Open();
                    //关联事务
                    transaction = myConn.BeginTransaction();
                    //用myconn实例myComm
                    myComm.Connection = myConn;
                    myComm.Transaction = transaction;
                    //循环读取数组
                    for (int isqlString = 0; isqlString < arrList.Count; isqlString++)
                    {
                        myComm.CommandText = arrList[isqlString].ToString();
                        myComm.ExecuteNonQuery();
                    }
                    //提交事务
                    transaction.Commit();
                    return 0;
                }
                catch (Exception ex)
                {
                    //回滚
                    transaction.Rollback();
                    transaction.Dispose();
                    return -1;
                }
                finally
                {
                    //释放
                    transaction.Dispose();
                    myComm.Dispose();
                    //关闭
                    myConn.Close();
                }
            }
            else
            {
                myConn.Dispose();
                myComm.Dispose();
                return 0;
            }
        }

        /// <summary>
        ///  执行数据库操作（语句）
        /// </summary>
        /// <param name="strSql">要执行的语句</param>
        /// <returns>0：正常返回；-1 回滚返回</returns>
        public static int ExcutStrSql(string strSql)
        {
            //事务
            SqlTransaction transaction = null;
            //定义链接字符窜
            SqlConnection myConn = new SqlConnection(strConn);
            //执行命令
            SqlCommand myComm = new SqlCommand();
            //先判断sqlString是否有值
            if (strSql.Trim() != "")
            {
                try
                {
                    //打开链接
                    myConn.Open();
                    //关联事务
                    transaction = myConn.BeginTransaction();
                    //用myconn实例myComm
                    myComm.Connection = myConn;
                    myComm.Transaction = transaction;
                    myComm.CommandText = strSql;
                    myComm.ExecuteNonQuery();
                    //提交事务
                    transaction.Commit();
                    return 0;
                }
                catch (Exception ex)
                {
                    //回滚
                    transaction.Rollback();
                    transaction.Dispose();
                    return -1;
                }
                finally
                {
                    //释放
                    transaction.Dispose();
                    myComm.Dispose();
                    //关闭
                    myConn.Close();
                }
            }
            else
            {
                myConn.Dispose();
                myComm.Dispose();
                return 0;
            }
        }

        /// <summary>
        ///  返回语句执行后的SYSID 
        /// </summary>
        /// <param name="strSql">需要执行的语句</param>
        /// <returns>-1:执行失败，-2没有语句</returns>
        public static int ExcutStrSqlReturnSYSID(string strSql)
        {
            //事务
            SqlTransaction transaction = null;
            //定义链接字符窜
            SqlConnection myConn = new SqlConnection(strConn);
            //执行命令
            SqlCommand myComm = new SqlCommand();
            //返回数据
            int Sysid;

            //先判断sqlString是否有值
            if (strSql.Trim() != "")
            {
                try
                {
                    //打开链接
                    myConn.Open();
                    //关联事务
                    transaction = myConn.BeginTransaction();
                    //用myconn实例myComm
                    myComm.Connection = myConn;
                    myComm.Transaction = transaction;
                    myComm.CommandText = strSql;
                    myComm.ExecuteNonQuery();
                    myComm.CommandText = "select @@IDENTITY as rowid";

                    Sysid = (Int32)myComm.ExecuteScalar();


                    //提交事务
                    transaction.Commit();
                    return Sysid;
                }
                catch (Exception ex)
                {
                    //回滚
                    transaction.Rollback();
                    transaction.Dispose();
                    return -1;
                }
                finally
                {
                    //释放
                    transaction.Dispose();
                    myComm.Dispose();
                    //关闭
                    myConn.Close();
                }
            }
            else
            {
                myConn.Dispose();
                myComm.Dispose();
                return -2;
            }
        }




    }
}