using System;
using Il2CppDummyDll;

namespace AliyunSLS
{
	// Token: 0x02000021 RID: 33
	[Token(Token = "0x2000021")]
	public class DnsRequest : PingRequest
	{
		// Token: 0x06000098 RID: 152 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000098")]
		[Address(RVA = "0x5BDFF90", Offset = "0x5BDEB90", VA = "0x185BDFF90")]
		public DnsRequest()
		{
		}

		// Token: 0x04000084 RID: 132
		[Token(Token = "0x4000084")]
		[FieldOffset(Offset = "0x40")]
		public string type;

		// Token: 0x04000085 RID: 133
		[Token(Token = "0x4000085")]
		[FieldOffset(Offset = "0x48")]
		public string nameServer;
	}
}
