using System;
using Il2CppDummyDll;

namespace AliyunSLS
{
	// Token: 0x0200001D RID: 29
	[Token(Token = "0x200001D")]
	public class HttpRequest : PingRequest
	{
		// Token: 0x06000094 RID: 148 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000094")]
		[Address(RVA = "0x5BE00A0", Offset = "0x5BDECA0", VA = "0x185BE00A0")]
		public HttpRequest()
		{
		}

		// Token: 0x0400007C RID: 124
		[Token(Token = "0x400007C")]
		[FieldOffset(Offset = "0x40")]
		public string ip;

		// Token: 0x0400007D RID: 125
		[Token(Token = "0x400007D")]
		[FieldOffset(Offset = "0x48")]
		public bool headerOnly;

		// Token: 0x0400007E RID: 126
		[Token(Token = "0x400007E")]
		[FieldOffset(Offset = "0x4C")]
		public int downloadBytesLimit;
	}
}
