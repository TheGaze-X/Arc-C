using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Hypergryph.Log;
using Il2CppDummyDll;
using Torappu;

namespace UnityEngine
{
	// Token: 0x02000003 RID: 3
	[Token(Token = "0x2000003")]
	public static class DLog
	{
		// Token: 0x0600001B RID: 27 RVA: 0x000021BC File Offset: 0x000003BC
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x54DB9F0", Offset = "0x54DA5F0", VA = "0x1854DB9F0")]
		public static bool AddDefaultLogger(ILogger logger)
		{
			return default(bool);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000021D4 File Offset: 0x000003D4
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x54DD0A0", Offset = "0x54DBCA0", VA = "0x1854DD0A0")]
		public static bool RemoveDefaultLogger(ILogger logger)
		{
			return default(bool);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x54DD210", Offset = "0x54DBE10", VA = "0x1854DD210")]
		public static void SetLogLevel(LogLevel level)
		{
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600001E")]
		[Address(RVA = "0x54DBAA0", Offset = "0x54DA6A0", VA = "0x1854DBAA0")]
		public static void AddLogLevel(LogLevel level)
		{
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x54DD140", Offset = "0x54DBD40", VA = "0x1854DD140")]
		public static void RemoveLogLevel(LogLevel level)
		{
		}

		// Token: 0x06000020 RID: 32 RVA: 0x000021EC File Offset: 0x000003EC
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x54DBC80", Offset = "0x54DA880", VA = "0x1854DBC80")]
		public static bool CheckLogLevel(LogLevel level)
		{
			return default(bool);
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000021 RID: 33 RVA: 0x00002204 File Offset: 0x00000404
		[Token(Token = "0x17000001")]
		public static bool enableLogInfo
		{
			[Token(Token = "0x6000021")]
			[Address(RVA = "0x54DD9A0", Offset = "0x54DC5A0", VA = "0x1854DD9A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x54DD1A0", Offset = "0x54DBDA0", VA = "0x1854DD1A0")]
		public static void SetLogChannelEnabled(LogChannel channel, bool val)
		{
		}

		// Token: 0x06000023 RID: 35 RVA: 0x0000221C File Offset: 0x0000041C
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x54DBB00", Offset = "0x54DA700", VA = "0x1854DBB00")]
		public static bool CheckLogChannelEnabled(LogChannel channel)
		{
			return default(bool);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002234 File Offset: 0x00000434
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x54DBB60", Offset = "0x54DA760", VA = "0x1854DBB60")]
		public static bool CheckLogLevelAndChannel(LogLevel level, LogChannel channel)
		{
			return default(bool);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x54DCAE0", Offset = "0x54DB6E0", VA = "0x1854DCAE0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("TEST")]
		public static void Log(string message)
		{
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x54DC8F0", Offset = "0x54DB4F0", VA = "0x1854DC8F0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("TEST")]
		public static void Log(LogChannel channel, string message)
		{
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x54DC9E0", Offset = "0x54DB5E0", VA = "0x1854DC9E0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("TEST")]
		public static void Log(LogChannel channel, LogColorTag color, string message)
		{
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x54DCD00", Offset = "0x54DB900", VA = "0x1854DCD00")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("TEST")]
		public static void Log(LogChannel channel, LogColorTag color, Object context, string message)
		{
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x54DCFA0", Offset = "0x54DBBA0", VA = "0x1854DCFA0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("TEST")]
		public static void Log(LogChannel channel, Object context, string message)
		{
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x54DC810", Offset = "0x54DB410", VA = "0x1854DC810")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("TEST")]
		public static void LogWarning(string message)
		{
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x54DC140", Offset = "0x54DAD40", VA = "0x1854DC140")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("TEST")]
		public static void LogWarning(LogChannel channel, string message)
		{
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x54DC230", Offset = "0x54DAE30", VA = "0x1854DC230")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("TEST")]
		public static void LogWarning(LogChannel channel, LogColorTag color, string message)
		{
		}

		// Token: 0x0600002D RID: 45 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x54DC5C0", Offset = "0x54DB1C0", VA = "0x1854DC5C0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("TEST")]
		public static void LogWarning(LogChannel channel, LogColorTag color, Object context, string message)
		{
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600002E")]
		[Address(RVA = "0x54DC330", Offset = "0x54DAF30", VA = "0x1854DC330")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("TEST")]
		public static void LogWarning(LogChannel channel, Object context, string message)
		{
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600002F")]
		[Address(RVA = "0x54DC040", Offset = "0x54DAC40", VA = "0x1854DC040")]
		public static void LogImportant(LogChannel channel, LogColorTag color, string message)
		{
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000030")]
		[Address(RVA = "0x54DBDD0", Offset = "0x54DA9D0", VA = "0x1854DBDD0")]
		public static void LogError(string message)
		{
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000031")]
		[Address(RVA = "0x54DBCE0", Offset = "0x54DA8E0", VA = "0x1854DBCE0")]
		public static void LogError(LogChannel channel, string message)
		{
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000032")]
		[Address(RVA = "0x54DBF80", Offset = "0x54DAB80", VA = "0x1854DBF80")]
		public static void LogException(Exception e)
		{
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000033")]
		[Address(RVA = "0x54DBEB0", Offset = "0x54DAAB0", VA = "0x1854DBEB0")]
		public static void LogException(Object context, Exception e)
		{
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000034")]
		[Address(RVA = "0x54DCBC0", Offset = "0x54DB7C0", VA = "0x1854DCBC0")]
		[Obsolete("Try to use Log with chanel")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("TEST")]
		public static void Log(string message, Object context)
		{
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000035")]
		[Address(RVA = "0x54DCE10", Offset = "0x54DBA10", VA = "0x1854DCE10")]
		[Obsolete("Try to use Log with chanel")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("TEST")]
		public static void Log(string message, Color color)
		{
		}

		// Token: 0x06000036 RID: 54 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000036")]
		[Address(RVA = "0x54DC6D0", Offset = "0x54DB2D0", VA = "0x1854DC6D0")]
		[Obsolete("Try to use Log with chanel")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("TEST")]
		public static void LogWarning(string message, Object context)
		{
		}

		// Token: 0x06000037 RID: 55 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000037")]
		[Address(RVA = "0x54DC430", Offset = "0x54DB030", VA = "0x1854DC430")]
		[Obsolete("Try to use Log with chanel")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("TEST")]
		public static void LogWarning(string message, Color color)
		{
		}

		// Token: 0x06000038 RID: 56 RVA: 0x0000224C File Offset: 0x0000044C
		[Token(Token = "0x6000038")]
		[Address(RVA = "0x54DD3B0", Offset = "0x54DBFB0", VA = "0x1854DD3B0")]
		private static LogMessage _CreateLog(LogLevel logLevel, LogChannel channel, LogColorTag colorTag = LogColorTag.None, [Optional] string message, [Optional] Exception exception, [Optional] Object context)
		{
			return default(LogMessage);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002264 File Offset: 0x00000464
		[Token(Token = "0x6000039")]
		[Address(RVA = "0x54DD2C0", Offset = "0x54DBEC0", VA = "0x1854DD2C0")]
		private static LogMessage _CreateLegacyLog(string message, LogLevel logLevel)
		{
			return default(LogMessage);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x0000227C File Offset: 0x0000047C
		[Token(Token = "0x600003A")]
		[Address(RVA = "0x54DD300", Offset = "0x54DBF00", VA = "0x1854DD300")]
		private static LogMessage _CreateLegacyLog(string message, LogLevel logLevel, Color color)
		{
			return default(LogMessage);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00002294 File Offset: 0x00000494
		[Token(Token = "0x600003B")]
		[Address(RVA = "0x54DD270", Offset = "0x54DBE70", VA = "0x1854DD270")]
		private static bool _CheckLegacyLogEnabled(LogLevel logLevel)
		{
			return default(bool);
		}

		// Token: 0x04000001 RID: 1
		[Token(Token = "0x4000001")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		internal static ConsoleLogger s_consoleLogger;

		// Token: 0x04000002 RID: 2
		[Token(Token = "0x4000002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DLog.UnionLogger s_defaultLogger;

		// Token: 0x04000003 RID: 3
		[Token(Token = "0x4000003")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DLog.ThirdPartyLogger s_externalLogger;

		// Token: 0x04000004 RID: 4
		[Token(Token = "0x4000004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static LogLevel s_enabledLogLevel;

		// Token: 0x04000005 RID: 5
		[Token(Token = "0x4000005")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public static BitArray256 enabledLogChannel;

		// Token: 0x02000004 RID: 4
		[Token(Token = "0x2000004")]
		private class UnionLogger : ILogger
		{
			// Token: 0x0600003C RID: 60 RVA: 0x000022AC File Offset: 0x000004AC
			[Token(Token = "0x600003C")]
			[Address(RVA = "0x54F9940", Offset = "0x54F8540", VA = "0x1854F9940")]
			public bool Add(ILogger logger)
			{
				return default(bool);
			}

			// Token: 0x0600003D RID: 61 RVA: 0x000022C4 File Offset: 0x000004C4
			[Token(Token = "0x600003D")]
			[Address(RVA = "0x54F9B90", Offset = "0x54F8790", VA = "0x1854F9B90")]
			public bool Remove(ILogger logger)
			{
				return default(bool);
			}

			// Token: 0x0600003E RID: 62 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x600003E")]
			[Address(RVA = "0x54F99B0", Offset = "0x54F85B0", VA = "0x1854F99B0", Slot = "4")]
			public void Log(ref LogMessage msg)
			{
			}

			// Token: 0x0600003F RID: 63 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x600003F")]
			[Address(RVA = "0x54F9BF0", Offset = "0x54F87F0", VA = "0x1854F9BF0")]
			public UnionLogger()
			{
			}

			// Token: 0x04000006 RID: 6
			[Token(Token = "0x4000006")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private ListSet<ILogger> m_loggers;
		}

		// Token: 0x02000005 RID: 5
		[Token(Token = "0x2000005")]
		private class ThirdPartyLogger : ILogger
		{
			// Token: 0x06000040 RID: 64 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000040")]
			[Address(RVA = "0x54F01C0", Offset = "0x54EEDC0", VA = "0x1854F01C0", Slot = "4")]
			public void Log(ref LogMessage msg)
			{
			}

			// Token: 0x06000041 RID: 65 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000041")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ThirdPartyLogger()
			{
			}
		}
	}
}
