using System;
using Il2CppDummyDll;

namespace AliyunSLS
{
	// Token: 0x0200001E RID: 30
	[Token(Token = "0x200001E")]
	public class TcpPingRequest : PingRequest
	{
		// Token: 0x06000095 RID: 149 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000095")]
		[Address(RVA = "0x5BE6F20", Offset = "0x5BE5B20", VA = "0x185BE6F20")]
		public TcpPingRequest()
		{
		}

		// Token: 0x0400007F RID: 127
		[Token(Token = "0x400007F")]
		[FieldOffset(Offset = "0x40")]
		public int port;

		// Token: 0x04000080 RID: 128
		[Token(Token = "0x4000080")]
		[FieldOffset(Offset = "0x48")]
		public string payload;
	}
}
