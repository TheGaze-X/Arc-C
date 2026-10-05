using System;
using Il2CppDummyDll;

namespace System.Diagnostics
{
	// Token: 0x02000106 RID: 262
	[Token(Token = "0x2000106")]
	internal static class TraceInternal
	{
		// Token: 0x17000108 RID: 264
		// (get) Token: 0x0600066C RID: 1644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000108")]
		public static TraceListenerCollection Listeners
		{
			[Token(Token = "0x600066C")]
			[Address(RVA = "0x5119EC0", Offset = "0x5118AC0", VA = "0x185119EC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x0600066D RID: 1645 RVA: 0x00004920 File Offset: 0x00002B20
		[Token(Token = "0x17000109")]
		public static bool AutoFlush
		{
			[Token(Token = "0x600066D")]
			[Address(RVA = "0x5119DB0", Offset = "0x51189B0", VA = "0x185119DB0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x0600066E RID: 1646 RVA: 0x00004938 File Offset: 0x00002B38
		[Token(Token = "0x1700010A")]
		public static int IndentLevel
		{
			[Token(Token = "0x600066E")]
			[Address(RVA = "0x5119E10", Offset = "0x5118A10", VA = "0x185119E10")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x0600066F RID: 1647 RVA: 0x00004950 File Offset: 0x00002B50
		[Token(Token = "0x1700010B")]
		public static int IndentSize
		{
			[Token(Token = "0x600066F")]
			[Address(RVA = "0x5119E60", Offset = "0x5118A60", VA = "0x185119E60")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000670 RID: 1648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000670")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		private static void InitializeSettings()
		{
		}

		// Token: 0x0400046A RID: 1130
		[Token(Token = "0x400046A")]
		[FieldOffset(Offset = "0x0")]
		private static string appName;

		// Token: 0x0400046B RID: 1131
		[Token(Token = "0x400046B")]
		[FieldOffset(Offset = "0x8")]
		private static TraceListenerCollection listeners;

		// Token: 0x0400046C RID: 1132
		[Token(Token = "0x400046C")]
		[FieldOffset(Offset = "0x10")]
		private static bool autoFlush;

		// Token: 0x0400046D RID: 1133
		[Token(Token = "0x400046D")]
		[ThreadStatic]
		private static int indentLevel;

		// Token: 0x0400046E RID: 1134
		[Token(Token = "0x400046E")]
		[FieldOffset(Offset = "0x14")]
		private static int indentSize;

		// Token: 0x0400046F RID: 1135
		[Token(Token = "0x400046F")]
		[FieldOffset(Offset = "0x18")]
		internal static readonly object critSec;
	}
}
