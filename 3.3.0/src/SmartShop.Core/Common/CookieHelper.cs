using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace SmartShop.Common
{
    public class CookieHelper
    {
        /// <summary>
        /// 读取cookie
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static string GetCookie(string name)
        {
            if (HttpContext.Current.Request.Cookies != null && HttpContext.Current.Request.Cookies[name] != null)
            {
                HttpCookie cookie = HttpContext.Current.Request.Cookies[name];
                return HttpUtility.UrlDecode(cookie.Value);
            }
            return "";
        }
        /// <summary>
        /// 写cookie值
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        public static void SetCookie(string name, string value)
        {
            string cookivalue = HttpUtility.UrlEncode(value);
            HttpCookie cookie = new HttpCookie(name, cookivalue);
            HttpContext.Current.Response.Cookies.Add(cookie);
        }
        /// <summary>
        /// 写cookie值，设置有效期 单位小时
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <param name="expires"></param>
        public static void SetCookie(string name, string value,int expires)
        {
            string cookivalue = HttpUtility.UrlEncode(value);
            HttpCookie cookie = new HttpCookie(name, cookivalue);
            cookie.Expires.AddHours(expires);
            HttpContext.Current.Response.Cookies.Add(cookie);
        }
        /// <summary>
        /// 删除cookie
        /// </summary>
        /// <param name="name"></param>
        public static void RomoveCookie(string name)
        {
            if (HttpContext.Current.Request.Cookies != null && HttpContext.Current.Request.Cookies[name] != null)
            {
                HttpCookie cookie = HttpContext.Current.Request.Cookies[name];
                cookie.Expires.AddDays(-1);
                HttpContext.Current.Response.Cookies.Set(cookie);
                HttpContext.Current.Request.Cookies.Remove(name);
            }
        }

        /// <summary>
        /// 清除缓存
        /// </summary>
        public static void ClearCookie()
        {
            var cookies = HttpContext.Current.Request.Cookies;
            if (cookies != null)
            {
                foreach (HttpCookie cookie in cookies)
                {
                    cookie.Expires.AddDays(-1);
                    HttpContext.Current.Response.Cookies.Set(cookie);
                    
                }
                HttpContext.Current.Request.Cookies.Clear();
            }
        }
    }
}
