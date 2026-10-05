using System;
using Il2CppDummyDll;

namespace HGSDK
{
	// Token: 0x02000162 RID: 354
	[Token(Token = "0x2000162")]
	public class SendPhoneCodeRequest : APIV2RequestBase
	{
		// Token: 0x06000524 RID: 1316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000524")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SendPhoneCodeRequest()
		{
		}

		// Token: 0x040006B8 RID: 1720
		[Token(Token = "0x40006B8")]
		[FieldOffset(Offset = "0x20")]
		public int type;
	}
}
