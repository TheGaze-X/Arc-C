using System;
using Il2CppDummyDll;

namespace UnityEngine
{
	// Token: 0x020000C8 RID: 200
	[Token(Token = "0x20000C8")]
	public interface ILogger : ILogHandler
	{
		// Token: 0x17000190 RID: 400
		// (get) Token: 0x06000695 RID: 1685
		[Token(Token = "0x17000190")]
		ILogHandler logHandler { [Token(Token = "0x6000695")] get; }

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x06000696 RID: 1686
		[Token(Token = "0x17000191")]
		bool logEnabled { [Token(Token = "0x6000696")] get; }

		// Token: 0x06000697 RID: 1687
		[Token(Token = "0x6000697")]
		bool IsLogTypeAllowed(LogType logType);

		// Token: 0x06000698 RID: 1688
		[Token(Token = "0x6000698")]
		void Log(LogType logType, object message);

		// Token: 0x06000699 RID: 1689
		[Token(Token = "0x6000699")]
		void Log(LogType logType, object message, Object context);

		// Token: 0x0600069A RID: 1690
		[Token(Token = "0x600069A")]
		void LogError(string tag, object message);

		// Token: 0x0600069B RID: 1691
		[Token(Token = "0x600069B")]
		void LogFormat(LogType logType, string format, params object[] args);
	}
}
