using System;
using System.Collections;
using Il2CppDummyDll;

namespace System.Diagnostics
{
	// Token: 0x02000103 RID: 259
	[Token(Token = "0x2000103")]
	public class TraceEventCache
	{
		// Token: 0x17000102 RID: 258
		// (get) Token: 0x06000660 RID: 1632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000102")]
		public string Callstack
		{
			[Token(Token = "0x6000660")]
			[Address(RVA = "0x5119910", Offset = "0x5118510", VA = "0x185119910")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06000661 RID: 1633 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000103")]
		public Stack LogicalOperationStack
		{
			[Token(Token = "0x6000661")]
			[Address(RVA = "0x51199E0", Offset = "0x51185E0", VA = "0x1851199E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x06000662 RID: 1634 RVA: 0x00004890 File Offset: 0x00002A90
		[Token(Token = "0x17000104")]
		public DateTime DateTime
		{
			[Token(Token = "0x6000662")]
			[Address(RVA = "0x5119940", Offset = "0x5118540", VA = "0x185119940")]
			get
			{
				return default(DateTime);
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x06000663 RID: 1635 RVA: 0x000048A8 File Offset: 0x00002AA8
		[Token(Token = "0x17000105")]
		public int ProcessId
		{
			[Token(Token = "0x6000663")]
			[Address(RVA = "0x5119720", Offset = "0x5118320", VA = "0x185119720")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x06000664 RID: 1636 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000106")]
		public string ThreadId
		{
			[Token(Token = "0x6000664")]
			[Address(RVA = "0x5119B70", Offset = "0x5118770", VA = "0x185119B70")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000665 RID: 1637 RVA: 0x000048C0 File Offset: 0x00002AC0
		[Token(Token = "0x17000107")]
		public long Timestamp
		{
			[Token(Token = "0x6000665")]
			[Address(RVA = "0x5119BF0", Offset = "0x51187F0", VA = "0x185119BF0")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x06000666 RID: 1638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000666")]
		[Address(RVA = "0x5119770", Offset = "0x5118370", VA = "0x185119770")]
		private static void InitProcessInfo()
		{
		}

		// Token: 0x06000667 RID: 1639 RVA: 0x000048D8 File Offset: 0x00002AD8
		[Token(Token = "0x6000667")]
		[Address(RVA = "0x5119720", Offset = "0x5118320", VA = "0x185119720")]
		internal static int GetProcessId()
		{
			return 0;
		}

		// Token: 0x06000668 RID: 1640 RVA: 0x000048F0 File Offset: 0x00002AF0
		[Token(Token = "0x6000668")]
		[Address(RVA = "0x4D35CD0", Offset = "0x4D348D0", VA = "0x184D35CD0")]
		internal static int GetThreadId()
		{
			return 0;
		}

		// Token: 0x06000669 RID: 1641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000669")]
		[Address(RVA = "0x51198A0", Offset = "0x51184A0", VA = "0x1851198A0")]
		public TraceEventCache()
		{
		}

		// Token: 0x0400045A RID: 1114
		[Token(Token = "0x400045A")]
		[FieldOffset(Offset = "0x0")]
		private static int processId;

		// Token: 0x0400045B RID: 1115
		[Token(Token = "0x400045B")]
		[FieldOffset(Offset = "0x8")]
		private static string processName;

		// Token: 0x0400045C RID: 1116
		[Token(Token = "0x400045C")]
		[FieldOffset(Offset = "0x10")]
		private long timeStamp;

		// Token: 0x0400045D RID: 1117
		[Token(Token = "0x400045D")]
		[FieldOffset(Offset = "0x18")]
		private DateTime dateTime;

		// Token: 0x0400045E RID: 1118
		[Token(Token = "0x400045E")]
		[FieldOffset(Offset = "0x20")]
		private string stackTrace;
	}
}
