using System;
using Il2CppDummyDll;

namespace HGSDK
{
	// Token: 0x02000146 RID: 326
	[Token(Token = "0x2000146")]
	public class CheckIdCardRequest
	{
		// Token: 0x06000503 RID: 1283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000503")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CheckIdCardRequest()
		{
		}

		// Token: 0x04000671 RID: 1649
		[Token(Token = "0x4000671")]
		[FieldOffset(Offset = "0x10")]
		public string token;

		// Token: 0x04000672 RID: 1650
		[Token(Token = "0x4000672")]
		[FieldOffset(Offset = "0x18")]
		public string idCardNum;
	}
}
