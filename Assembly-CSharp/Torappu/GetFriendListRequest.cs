using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000728 RID: 1832
	[Token(Token = "0x2000728")]
	public class GetFriendListRequest
	{
		// Token: 0x06006393 RID: 25491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006393")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public GetFriendListRequest()
		{
		}

		// Token: 0x04002F93 RID: 12179
		[Token(Token = "0x4002F93")]
		[FieldOffset(Offset = "0x10")]
		public List<string> idList;
	}
}
