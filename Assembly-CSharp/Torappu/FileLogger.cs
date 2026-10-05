using System;
using System.IO;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu
{
	// Token: 0x0200054F RID: 1359
	[Token(Token = "0x200054F")]
	public class FileLogger : IDisposable, IHotfixable
	{
		// Token: 0x06005AB1 RID: 23217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AB1")]
		[Address(RVA = "0x1AEECA0", Offset = "0x1AED8A0", VA = "0x181AEECA0")]
		public FileLogger(FileLogger.Options options, string nameFormat)
		{
		}

		// Token: 0x06005AB2 RID: 23218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AB2")]
		[Address(RVA = "0x1AEE880", Offset = "0x1AED480", VA = "0x181AEE880", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06005AB3 RID: 23219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AB3")]
		[Address(RVA = "0x1AEE9F0", Offset = "0x1AED5F0", VA = "0x181AEE9F0")]
		public void Log(FileLogger.LogLevel level, string message)
		{
		}

		// Token: 0x06005AB4 RID: 23220 RVA: 0x0002EA58 File Offset: 0x0002CC58
		[Token(Token = "0x6005AB4")]
		[Address(RVA = "0x1AEE810", Offset = "0x1AED410", VA = "0x181AEE810")]
		public bool CheckLogLevel(FileLogger.LogLevel level)
		{
			return default(bool);
		}

		// Token: 0x17000C98 RID: 3224
		// (get) Token: 0x06005AB5 RID: 23221 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005AB6 RID: 23222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C98")]
		public string path
		{
			[Token(Token = "0x6005AB5")]
			[Address(RVA = "0x1AEF110", Offset = "0x1AEDD10", VA = "0x181AEF110")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005AB6")]
			[Address(RVA = "0x1AEF170", Offset = "0x1AEDD70", VA = "0x181AEF170")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06005AB7 RID: 23223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AB7")]
		[Address(RVA = "0x1AEEBC0", Offset = "0x1AED7C0", VA = "0x181AEEBC0")]
		private void _OnCatchLog(string logString, string stackTrace, LogType type)
		{
		}

		// Token: 0x06005AB8 RID: 23224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AB8")]
		[Address(RVA = "0x1AEEAB0", Offset = "0x1AED6B0", VA = "0x181AEEAB0")]
		private string _GenFilePath(string format)
		{
			return null;
		}

		// Token: 0x06005AB9 RID: 23225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005AB9")]
		[Address(RVA = "0x1AEE950", Offset = "0x1AED550", VA = "0x181AEE950")]
		public static string GetLogDirPath(string dir)
		{
			return null;
		}

		// Token: 0x04002069 RID: 8297
		[Token(Token = "0x4002069")]
		[FieldOffset(Offset = "0x10")]
		private readonly FileLogger.Options m_options;

		// Token: 0x0400206A RID: 8298
		[Token(Token = "0x400206A")]
		[FieldOffset(Offset = "0x18")]
		private readonly StreamWriter m_streamWriter;

		// Token: 0x0400206C RID: 8300
		[Token(Token = "0x400206C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0400206D RID: 8301
		[Token(Token = "0x400206D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Dispose;

		// Token: 0x0400206E RID: 8302
		[Token(Token = "0x400206E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Log;

		// Token: 0x0400206F RID: 8303
		[Token(Token = "0x400206F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CheckLogLevel;

		// Token: 0x04002070 RID: 8304
		[Token(Token = "0x4002070")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_path;

		// Token: 0x04002071 RID: 8305
		[Token(Token = "0x4002071")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_path;

		// Token: 0x04002072 RID: 8306
		[Token(Token = "0x4002072")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnCatchLog;

		// Token: 0x04002073 RID: 8307
		[Token(Token = "0x4002073")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__GenFilePath;

		// Token: 0x04002074 RID: 8308
		[Token(Token = "0x4002074")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_GetLogDirPath;

		// Token: 0x02000550 RID: 1360
		[Token(Token = "0x2000550")]
		public enum LogLevel
		{
			// Token: 0x04002076 RID: 8310
			[Token(Token = "0x4002076")]
			DEBUG,
			// Token: 0x04002077 RID: 8311
			[Token(Token = "0x4002077")]
			INFO,
			// Token: 0x04002078 RID: 8312
			[Token(Token = "0x4002078")]
			WARN,
			// Token: 0x04002079 RID: 8313
			[Token(Token = "0x4002079")]
			ERROR,
			// Token: 0x0400207A RID: 8314
			[Token(Token = "0x400207A")]
			FATAL
		}

		// Token: 0x02000551 RID: 1361
		[Token(Token = "0x2000551")]
		public struct Options
		{
			// Token: 0x0400207B RID: 8315
			[Token(Token = "0x400207B")]
			[FieldOffset(Offset = "0x0")]
			public FileLogger.LogLevel logLevel;

			// Token: 0x0400207C RID: 8316
			[Token(Token = "0x400207C")]
			[FieldOffset(Offset = "0x4")]
			public bool receiveUnityLog;

			// Token: 0x0400207D RID: 8317
			[Token(Token = "0x400207D")]
			[FieldOffset(Offset = "0x5")]
			public bool autoFlush;
		}
	}
}
