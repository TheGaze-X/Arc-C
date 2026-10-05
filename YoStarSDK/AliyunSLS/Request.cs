using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace AliyunSLS
{
	// Token: 0x0200001A RID: 26
	[Token(Token = "0x200001A")]
	public class Request
	{
		// Token: 0x06000091 RID: 145 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000091")]
		[Address(RVA = "0x5BE1ED0", Offset = "0x5BE0AD0", VA = "0x185BE1ED0")]
		public Request()
		{
		}

		// Token: 0x04000071 RID: 113
		[Token(Token = "0x4000071")]
		[FieldOffset(Offset = "0x10")]
		public string domain;

		// Token: 0x04000072 RID: 114
		[Token(Token = "0x4000072")]
		[FieldOffset(Offset = "0x18")]
		public string context;

		// Token: 0x04000073 RID: 115
		[Token(Token = "0x4000073")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, string> extension;

		// Token: 0x04000074 RID: 116
		[Token(Token = "0x4000074")]
		[FieldOffset(Offset = "0x28")]
		public callback_response complete_callback;
	}
}
