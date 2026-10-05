using System;
using Il2CppDummyDll;

namespace AliyunSLS
{
	// Token: 0x0200001B RID: 27
	[Token(Token = "0x200001B")]
	public class Response
	{
		// Token: 0x06000092 RID: 146 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000092")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Response()
		{
		}

		// Token: 0x04000075 RID: 117
		[Token(Token = "0x4000075")]
		[FieldOffset(Offset = "0x10")]
		public ReqType type;

		// Token: 0x04000076 RID: 118
		[Token(Token = "0x4000076")]
		[FieldOffset(Offset = "0x18")]
		public string content;

		// Token: 0x04000077 RID: 119
		[Token(Token = "0x4000077")]
		[FieldOffset(Offset = "0x20")]
		public string context;

		// Token: 0x04000078 RID: 120
		[Token(Token = "0x4000078")]
		[FieldOffset(Offset = "0x28")]
		public string error;
	}
}
