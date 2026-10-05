using System;
using Il2CppDummyDll;

namespace HGSDK
{
	// Token: 0x02000163 RID: 355
	[Token(Token = "0x2000163")]
	public class SendPhoneCodeResponse : APIV2ResponseBase
	{
		// Token: 0x06000525 RID: 1317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000525")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SendPhoneCodeResponse()
		{
		}

		// Token: 0x040006B9 RID: 1721
		[Token(Token = "0x40006B9")]
		public const int STATUS_INVALID_ACCOUNT = 103;
	}
}
