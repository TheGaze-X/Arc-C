using System;
using Il2CppDummyDll;

namespace AliyunSLS
{
	// Token: 0x02000020 RID: 32
	[Token(Token = "0x2000020")]
	public class MtrRequest : PingRequest
	{
		// Token: 0x06000097 RID: 151 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000097")]
		[Address(RVA = "0x5BE1980", Offset = "0x5BE0580", VA = "0x185BE1980")]
		public MtrRequest()
		{
		}

		// Token: 0x04000081 RID: 129
		[Token(Token = "0x4000081")]
		[FieldOffset(Offset = "0x40")]
		public int maxTTL;

		// Token: 0x04000082 RID: 130
		[Token(Token = "0x4000082")]
		[FieldOffset(Offset = "0x44")]
		public int maxPaths;

		// Token: 0x04000083 RID: 131
		[Token(Token = "0x4000083")]
		[FieldOffset(Offset = "0x48")]
		public int protocol;
	}
}
