using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020007BB RID: 1979
	[Token(Token = "0x20007BB")]
	public class GetMetaInfoListResponse
	{
		// Token: 0x06006439 RID: 25657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006439")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public GetMetaInfoListResponse()
		{
		}

		// Token: 0x040030CC RID: 12492
		[Token(Token = "0x40030CC")]
		[FieldOffset(Offset = "0x10")]
		public List<MailMetaInfo> result;
	}
}
