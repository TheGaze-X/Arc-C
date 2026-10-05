using System;
using Il2CppDummyDll;

namespace HGSDK
{
	// Token: 0x02000164 RID: 356
	[Token(Token = "0x2000164")]
	public class GrantInfoRequest : APIV2RequestBase
	{
		// Token: 0x06000526 RID: 1318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000526")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public GrantInfoRequest()
		{
		}

		// Token: 0x040006BA RID: 1722
		[Token(Token = "0x40006BA")]
		[FieldOffset(Offset = "0x20")]
		public string appCode;
	}
}
