using SmartShop.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartShop.Entities
{
	/// <summary>
	/// 短信容器
	/// </summary>
	public class SmsContext
	{
		/// <summary>
		/// 功能名
		/// 值设为 send
		/// </summary>
		private string Cmd = "send";
		/// <summary>
		/// 企业Id
		/// </summary>
		private int EprId = 382;
		/// <summary>
		/// 用户Id
		/// </summary>
		private string UserId = "szhait";
		/// <summary>
		/// 时间戳
		/// 时间戳(1970.1.1至今的总秒毫数)
		/// </summary>
		private long Timestamp { get; set; }
		/// <summary>
		/// Key
		/// Md5_32(企业Id+用户Id+用户密码+时间戳),”+”是连接符
		/// </summary>
		private string Key { get; set; }
		/// <summary>
		/// 消息编号
		/// </summary>
		public int MsgId { get; set; }
		/// <summary>
		/// 返回结果格式
		/// 1: json方式返回  2:xml方式返回
		/// </summary>
		private int Format = 1;
		/// <summary>
		/// 发送对象的号码
		/// 多个号码间用半角逗号分隔
		/// </summary>
		public string Mobile { get; set; }
		/// <summary>
		/// 发送内容
		/// 发送内容 需要urlencoder utf-8格式
		/// </summary>
		public string Content { get; set; }

		/// <summary>
		/// 输出Url参数
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			Timestamp = Utility.GetCurrentTimeMillis();
			return string.Format("cmd={0}&eprId={1}&userId={2}&key={3}&timestamp={4}&format={5}&mobile={6}&msgId={7}&content={8}",
				Cmd, EprId, UserId,
				Encrypt.MD5(string.Format("{0}{1}{2}{3}", EprId, UserId, "Hait382", Timestamp)),
				Timestamp, Format, Mobile, MsgId, System.Web.HttpUtility.UrlEncode(Content));
		}

		#region == 小工具 ==

		#endregion
	}
	/// <summary>
	/// 短信发送结果
	/// </summary>
	public class SmsResult
	{
		/// <summary>
		/// 短信发送结果
		/// </summary>
		public string result { get; set; }
		/// <summary>
		/// 短信提示信息
		/// </summary>
		public string tip { get; set; }
	}
}
