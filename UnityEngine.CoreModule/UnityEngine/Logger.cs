using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine
{
	// Token: 0x020000CA RID: 202
	[Token(Token = "0x20000CA")]
	public class Logger : ILogger, ILogHandler
	{
		// Token: 0x0600069E RID: 1694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600069E")]
		[Address(RVA = "0x594B7F0", Offset = "0x594A3F0", VA = "0x18594B7F0")]
		public Logger(ILogHandler logHandler)
		{
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x0600069F RID: 1695 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060006A0 RID: 1696 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000192")]
		public ILogHandler logHandler
		{
			[Token(Token = "0x600069F")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60006A0")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x060006A1 RID: 1697 RVA: 0x00003A20 File Offset: 0x00001C20
		// (set) Token: 0x060006A2 RID: 1698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000193")]
		public bool logEnabled
		{
			[Token(Token = "0x60006A1")]
			[Address(RVA = "0x4F4E70", Offset = "0x4F3A70", VA = "0x1804F4E70", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006A2")]
			[Address(RVA = "0x4F4E80", Offset = "0x4F3A80", VA = "0x1804F4E80", Slot = "14")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x060006A3 RID: 1699 RVA: 0x00003A38 File Offset: 0x00001C38
		// (set) Token: 0x060006A4 RID: 1700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000194")]
		public LogType filterLogType
		{
			[Token(Token = "0x60006A3")]
			[Address(RVA = "0x4EA880", Offset = "0x4E9480", VA = "0x1804EA880", Slot = "15")]
			[CompilerGenerated]
			get
			{
				return LogType.Error;
			}
			[Token(Token = "0x60006A4")]
			[Address(RVA = "0x4EAC10", Offset = "0x4E9810", VA = "0x1804EAC10", Slot = "16")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x00003A50 File Offset: 0x00001C50
		[Token(Token = "0x60006A5")]
		[Address(RVA = "0x594B190", Offset = "0x5949D90", VA = "0x18594B190", Slot = "6")]
		public bool IsLogTypeAllowed(LogType logType)
		{
			return default(bool);
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60006A6")]
		[Address(RVA = "0x594B020", Offset = "0x5949C20", VA = "0x18594B020")]
		private static string GetString(object message)
		{
			return null;
		}

		// Token: 0x060006A7 RID: 1703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006A7")]
		[Address(RVA = "0x594B580", Offset = "0x594A180", VA = "0x18594B580", Slot = "7")]
		public void Log(LogType logType, object message)
		{
		}

		// Token: 0x060006A8 RID: 1704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006A8")]
		[Address(RVA = "0x594B6B0", Offset = "0x594A2B0", VA = "0x18594B6B0", Slot = "8")]
		public void Log(LogType logType, object message, Object context)
		{
		}

		// Token: 0x060006A9 RID: 1705 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006A9")]
		[Address(RVA = "0x594B1B0", Offset = "0x5949DB0", VA = "0x18594B1B0", Slot = "9")]
		public void LogError(string tag, object message)
		{
		}

		// Token: 0x060006AA RID: 1706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006AA")]
		[Address(RVA = "0x594B330", Offset = "0x5949F30", VA = "0x18594B330", Slot = "12")]
		public void LogException(Exception exception, Object context)
		{
		}

		// Token: 0x060006AB RID: 1707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006AB")]
		[Address(RVA = "0x594B440", Offset = "0x594A040", VA = "0x18594B440", Slot = "10")]
		public void LogFormat(LogType logType, string format, params object[] args)
		{
		}

		// Token: 0x060006AC RID: 1708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60006AC")]
		[Address(RVA = "0x594B4E0", Offset = "0x594A0E0", VA = "0x18594B4E0", Slot = "11")]
		public void LogFormat(LogType logType, Object context, string format, params object[] args)
		{
		}
	}
}
