// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.1
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------
using System;
namespace MyClient
{
	public class AsyncEventArgs : EventArgs
	{
		/// <summary>
		/// 提示信息
		/// </summary>
		public string _msg;
		public Session _sessions;
		
		/// <summary>
		/// 是否已经处理过了
		/// </summary>
		public bool IsHandled { get; set; }
		
		public AsyncEventArgs(string msg)
		{
			this._msg = msg;
			IsHandled = false;
		}
		public AsyncEventArgs(Session session)
		{
			this._sessions = session;
			IsHandled = false;
		}
		public AsyncEventArgs(string msg, Session session)
		{
			this._msg = msg;
			this._sessions = session;
			IsHandled = false;
		}
	}
}

