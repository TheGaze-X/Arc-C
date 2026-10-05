using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000547 RID: 1351
	[Token(Token = "0x2000547")]
	public static class DFLogger
	{
		// Token: 0x17000C8E RID: 3214
		// (get) Token: 0x06005A67 RID: 23143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C8E")]
		public static string logPath
		{
			[Token(Token = "0x6005A67")]
			[Address(RVA = "0x1AEC590", Offset = "0x1AEB190", VA = "0x181AEC590")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005A68 RID: 23144 RVA: 0x0002E998 File Offset: 0x0002CB98
		[Token(Token = "0x6005A68")]
		[Address(RVA = "0x1AEB2A0", Offset = "0x1AE9EA0", VA = "0x181AEB2A0")]
		public static bool CheckLogLevel(FileLogger.LogLevel level)
		{
			return default(bool);
		}

		// Token: 0x06005A69 RID: 23145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A69")]
		[Address(RVA = "0x1AEC070", Offset = "0x1AEAC70", VA = "0x181AEC070")]
		public static void InitIfNot(FileLogger.Options options, string format = "{0}/DF-{1}-{2}.log")
		{
		}

		// Token: 0x06005A6A RID: 23146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A6A")]
		[Address(RVA = "0x1AEB350", Offset = "0x1AE9F50", VA = "0x181AEB350")]
		public static void CloseIfNot()
		{
		}

		// Token: 0x06005A6B RID: 23147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A6B")]
		[Address(RVA = "0x1AEC130", Offset = "0x1AEAD30", VA = "0x181AEC130")]
		public static void Log(FileLogger.LogLevel level, string message)
		{
		}

		// Token: 0x06005A6C RID: 23148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A6C")]
		[Address(RVA = "0x1AEB470", Offset = "0x1AEA070", VA = "0x181AEB470")]
		public static void Debug(string message)
		{
		}

		// Token: 0x06005A6D RID: 23149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A6D")]
		[Address(RVA = "0x1AEB4D0", Offset = "0x1AEA0D0", VA = "0x181AEB4D0")]
		public static void Debug(string message, object arg0)
		{
		}

		// Token: 0x06005A6E RID: 23150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A6E")]
		[Address(RVA = "0x1AEB5F0", Offset = "0x1AEA1F0", VA = "0x181AEB5F0")]
		public static void Debug(string message, object arg0, object arg1)
		{
		}

		// Token: 0x06005A6F RID: 23151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A6F")]
		[Address(RVA = "0x1AEB550", Offset = "0x1AEA150", VA = "0x181AEB550")]
		public static void Debug(string message, object arg0, object arg1, object arg2)
		{
		}

		// Token: 0x06005A70 RID: 23152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A70")]
		[Address(RVA = "0x1AEB680", Offset = "0x1AEA280", VA = "0x181AEB680")]
		public static void Debug(string message, object arg0, object arg1, object arg2, object arg3)
		{
		}

		// Token: 0x06005A71 RID: 23153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A71")]
		[Address(RVA = "0x1AEBD80", Offset = "0x1AEA980", VA = "0x181AEBD80")]
		public static void Info(string message)
		{
		}

		// Token: 0x06005A72 RID: 23154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A72")]
		[Address(RVA = "0x1AEBD00", Offset = "0x1AEA900", VA = "0x181AEBD00")]
		public static void Info(string message, object arg0)
		{
		}

		// Token: 0x06005A73 RID: 23155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A73")]
		[Address(RVA = "0x1AEBC70", Offset = "0x1AEA870", VA = "0x181AEBC70")]
		public static void Info(string message, object arg0, object arg1)
		{
		}

		// Token: 0x06005A74 RID: 23156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A74")]
		[Address(RVA = "0x1AEBDE0", Offset = "0x1AEA9E0", VA = "0x181AEBDE0")]
		public static void Info(string message, object arg0, object arg1, object arg2)
		{
		}

		// Token: 0x06005A75 RID: 23157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A75")]
		[Address(RVA = "0x1AEBE80", Offset = "0x1AEAA80", VA = "0x181AEBE80")]
		public static void Info(string message, object arg0, object arg1, object arg2, object arg3)
		{
		}

		// Token: 0x06005A76 RID: 23158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A76")]
		[Address(RVA = "0x1AEC190", Offset = "0x1AEAD90", VA = "0x181AEC190")]
		public static void Warn(string message)
		{
		}

		// Token: 0x06005A77 RID: 23159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A77")]
		[Address(RVA = "0x1AEC510", Offset = "0x1AEB110", VA = "0x181AEC510")]
		public static void Warn(string message, object arg0)
		{
		}

		// Token: 0x06005A78 RID: 23160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A78")]
		[Address(RVA = "0x1AEC1F0", Offset = "0x1AEADF0", VA = "0x181AEC1F0")]
		public static void Warn(string message, object arg0, object arg1)
		{
		}

		// Token: 0x06005A79 RID: 23161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A79")]
		[Address(RVA = "0x1AEC470", Offset = "0x1AEB070", VA = "0x181AEC470")]
		public static void Warn(string message, object arg0, object arg1, object arg2)
		{
		}

		// Token: 0x06005A7A RID: 23162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A7A")]
		[Address(RVA = "0x1AEC280", Offset = "0x1AEAE80", VA = "0x181AEC280")]
		public static void Warn(string message, object arg0, object arg1, object arg2, object arg3)
		{
		}

		// Token: 0x06005A7B RID: 23163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A7B")]
		[Address(RVA = "0x1AEB910", Offset = "0x1AEA510", VA = "0x181AEB910")]
		public static void Error(string message)
		{
		}

		// Token: 0x06005A7C RID: 23164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A7C")]
		[Address(RVA = "0x1AEB970", Offset = "0x1AEA570", VA = "0x181AEB970")]
		public static void Error(string message, object arg0)
		{
		}

		// Token: 0x06005A7D RID: 23165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A7D")]
		[Address(RVA = "0x1AEBBE0", Offset = "0x1AEA7E0", VA = "0x181AEBBE0")]
		public static void Error(string message, object arg0, object arg1)
		{
		}

		// Token: 0x06005A7E RID: 23166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A7E")]
		[Address(RVA = "0x1AEB870", Offset = "0x1AEA470", VA = "0x181AEB870")]
		public static void Error(string message, object arg0, object arg1, object arg2)
		{
		}

		// Token: 0x06005A7F RID: 23167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A7F")]
		[Address(RVA = "0x1AEB9F0", Offset = "0x1AEA5F0", VA = "0x181AEB9F0")]
		public static void Error(string message, object arg0, object arg1, object arg2, object arg3)
		{
		}

		// Token: 0x0400203E RID: 8254
		[Token(Token = "0x400203E")]
		private const string FILE_NAME_FORMAT = "{0}/DF-{1}-{2}.log";

		// Token: 0x0400203F RID: 8255
		[Token(Token = "0x400203F")]
		[FieldOffset(Offset = "0x0")]
		private static FileLogger s_instance;
	}
}
