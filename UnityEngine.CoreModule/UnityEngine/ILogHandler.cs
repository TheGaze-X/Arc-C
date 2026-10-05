using System;
using Il2CppDummyDll;

namespace UnityEngine
{
	// Token: 0x020000C9 RID: 201
	[Token(Token = "0x20000C9")]
	public interface ILogHandler
	{
		// Token: 0x0600069C RID: 1692
		[Token(Token = "0x600069C")]
		void LogFormat(LogType logType, Object context, string format, params object[] args);

		// Token: 0x0600069D RID: 1693
		[Token(Token = "0x600069D")]
		void LogException(Exception exception, Object context);
	}
}
