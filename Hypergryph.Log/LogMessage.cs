using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Hypergryph.Log
{
	// Token: 0x02000005 RID: 5
	[Token(Token = "0x2000005")]
	public struct LogMessage
	{
		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x0")]
		public string message;

		// Token: 0x0400000D RID: 13
		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x8")]
		public Exception exception;

		// Token: 0x0400000E RID: 14
		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x10")]
		public LogLevel logLevel;

		// Token: 0x0400000F RID: 15
		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x18")]
		public string colorTag;

		// Token: 0x04000010 RID: 16
		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x20")]
		public string channel;

		// Token: 0x04000011 RID: 17
		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x28")]
		public UnityEngine.Object context;
	}
}
