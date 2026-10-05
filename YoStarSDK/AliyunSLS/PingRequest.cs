using System;
using Il2CppDummyDll;

namespace AliyunSLS
{
	// Token: 0x0200001C RID: 28
	[Token(Token = "0x200001C")]
	public class PingRequest : Request
	{
		// Token: 0x06000093 RID: 147 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000093")]
		[Address(RVA = "0x5BE1B80", Offset = "0x5BE0780", VA = "0x185BE1B80")]
		public PingRequest()
		{
		}

		// Token: 0x04000079 RID: 121
		[Token(Token = "0x4000079")]
		[FieldOffset(Offset = "0x30")]
		public int size;

		// Token: 0x0400007A RID: 122
		[Token(Token = "0x400007A")]
		[FieldOffset(Offset = "0x34")]
		public int maxTimes;

		// Token: 0x0400007B RID: 123
		[Token(Token = "0x400007B")]
		[FieldOffset(Offset = "0x38")]
		public int timeout;
	}
}
