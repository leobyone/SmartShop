using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SmartShop.Common
{

    public class Utility
    {
        /// <summary>
        /// xls文件转数据表
        /// </summary>
        /// <param name="fileName">文件名</param>
        /// <returns></returns>
        public static System.Data.DataTable XlsToData(string fileName)
        {
            string fileExtenSion;
            fileExtenSion = System.IO.Path.GetExtension(fileName);
            if (fileExtenSion.ToLower() != ".xls" && fileExtenSion.ToLower() != ".xlsx")
            {
                return null;
            }
            System.Data.OleDb.OleDbConnection conn = null;
            try
            {
                //HDR=Yes，这代表第一行是标题，不做为数据使用 ，如果用HDR=NO，则表示第一行不是标题，做为数据来使用。系统默认的是YES   
                string connstr2003 = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + fileName + ";Extended Properties='Excel 8.0;HDR=YES;IMEX=1;'";
                string connstr2007 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + fileName + ";Extended Properties=\"Excel 12.0;HDR=YES\"";

                if (fileExtenSion.ToLower() == ".xls")
                {
                    conn = new System.Data.OleDb.OleDbConnection(connstr2003);
                }
                else
                {
                    conn = new System.Data.OleDb.OleDbConnection(connstr2007);
                }
                conn.Open();
                string sql = "select * from [Sheet1$]";
                System.Data.OleDb.OleDbCommand cmd = new System.Data.OleDb.OleDbCommand(sql, conn);
                System.Data.DataTable dt = new System.Data.DataTable();
                System.Data.OleDb.OleDbDataReader sdr = cmd.ExecuteReader();

                dt.Load(sdr);
                sdr.Close();
                conn.Close();

                return dt;
            }
            catch
            {
                return null;
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }

        /// <summary>
        /// DateTime时间格式转换为Unix时间戳格式
        /// </summary>
        /// <param name="time"> DateTime时间格式</param>
        /// <returns>Unix时间戳格式</returns>
        public static long ConvertDateTime(System.DateTime time)
        {
            System.DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1));
            return (long)(time - startTime).TotalSeconds;
        }

        #region == 底层工具 ==
        /// <summary>
        /// 获取WebPage数据
        /// </summary>
        /// <param name="url">目标URL</param>
        /// <returns></returns>
        public static string GetResponse(string url, string Referer, System.Text.Encoding encoding)
        {
            HttpWebRequest urlRequest;
            HttpWebResponse urlResponse;
            StreamReader sr;
            string text = string.Empty;
            urlRequest = (HttpWebRequest)WebRequest.Create(url);
            urlRequest.Method = "GET";
            urlRequest.AllowAutoRedirect = false;
            urlRequest.MaximumAutomaticRedirections = 3;
            urlRequest.Timeout = 20000;
            urlRequest.Referer = Referer;
            urlRequest.Proxy = null;
            urlRequest.ContentType = "text/html;charset=GBK";
            urlRequest.UserAgent = "Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 6.0)";

            WebResponse wr = null;

            try
            {
                wr = urlRequest.GetResponse();
            }
            catch (WebException wex)
            {
                text = wex.Status.ToString();
            }

            if (wr != null)
            {
                try
                {
                    urlResponse = (HttpWebResponse)wr;
                    Stream s = urlResponse.GetResponseStream();
                    sr = new StreamReader(s, encoding);
                    text = sr.ReadToEnd();
                    sr.Close();
                    s.Close();
                }
                catch (Exception ex)
                {
                    text = ex.Message;
                }
            }
            return text;
        }

        /// <summary>
        /// 通过POST方式发送数据
        /// </summary>
        /// <param name="url">目标URL</param>
        /// <param name="strData">Post数据</param>
        /// <returns></returns>
        public static string POSTSend(string url, string strData)
        {
            string retString = string.Empty;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            byte[] bytes = Encoding.UTF8.GetBytes(strData);
            request.ContentLength = bytes.Length;
            request.AllowAutoRedirect = true;
            request.MaximumAutomaticRedirections = 5;
            request.Timeout = 20000;
            request.UserAgent = "Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 6.0)";
            request.Proxy = null;

            bool IsIn = true;
            try
            {
                Stream myRequestStream = request.GetRequestStream();
                myRequestStream.Write(bytes, 0, bytes.Length);
                myRequestStream.Close();
            }
            catch (WebException wex)
            {
                retString = wex.Status.ToString();
                IsIn = false;
            }
            if (IsIn == false)
            {
                return "访问超时.";
            }

            StreamReader myStreamReader = null;
            Stream myResponseStream = null;

            WebResponse wr = null;

            try
            {
                wr = request.GetResponse();
            }
            catch (WebException wex)
            {
                retString = wex.Status.ToString();
            }

            if (wr != null)
            {
                try
                {
                    HttpWebResponse response = (HttpWebResponse)wr;
                    myResponseStream = response.GetResponseStream();
                    if (myResponseStream != null)
                    {
                        myStreamReader = new StreamReader(myResponseStream, Encoding.UTF8);
                        retString = myStreamReader.ReadToEnd();

                        if (retString == null)
                        {
                            retString = string.Empty;
                        }
                    }

                }
                catch (Exception ex)
                {
                    retString = ex.Message;
                }
                finally
                {
                    myStreamReader.Close();
                    myResponseStream.Close();

                }
            }

            return retString;
        }

        /// <summary>
        /// 判断给定的字符串(strNumber)是否是数值型
        /// </summary>
        /// <param name="strNumber">要确认的字符串</param>
        /// <returns>是则返加true 不是则返回 false</returns>
        public static bool IsNumber(string strNumber)
        {
            return new Regex(@"^([0-9])[0-9]*(\.\w*)?$").IsMatch(strNumber);
        }

        /// <summary>
        /// 呈现分页按钮
        /// </summary>
        /// <param name="html">被扩展的HtmlHelper</param>
        /// <param name="money">金额</param>
        /// <returns></returns>
        public static string MonerFormat(decimal money)
        {
            string temp = money.ToString("F");
            temp = "￥" + temp.Replace(".00", "");

            return temp;
        }

        /// <summary>
        /// 获取自1970年1月1日0时起的毫秒数
        /// </summary>
        /// <returns></returns>
        public static long GetCurrentTimeMillis()
        {
            return (DateTime.UtcNow.Ticks - 621355968000000000) / 10000;
        }
        /// <summary>
        /// 执行URL编码
        /// </summary>
        /// <param name="input">The string to encode.</param>
        /// <returns>Encode string.</returns>
        private static string UrlEncode(string input)
        {
            System.Text.StringBuilder newBytes = new System.Text.StringBuilder();
            var urf8Bytes = System.Text.Encoding.UTF8.GetBytes(input);
            foreach (var item in urf8Bytes)
            {
                if (IsReverseChar((char)item))
                {
                    newBytes.Append('%');
                    newBytes.Append(ByteToHex(item));

                }
                else
                    newBytes.Append((char)item);
            }

            return newBytes.ToString();
        }

        public static bool IsReverseChar(char c)
        {
            return !((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') || (c >= '0' && c <= '9')
                    || c == '-' || c == '_' || c == '.' || c == '~');
        }
        public static string ByteToHex(byte b)
        {
            return b.ToString("x2").ToUpper();
        }
        #endregion
    }
}
