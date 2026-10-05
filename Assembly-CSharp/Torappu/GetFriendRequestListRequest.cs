using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200072A RID: 1834
	[Token(Token = "0x200072A")]
	public class GetFriendRequestListRequest
	{
		// Token: 0x06006395 RID: 25493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006395")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public GetFriendRequestListRequest()
		{
		}

		// Token: 0x04002F97 RID: 12183
		[Token(Token = "0x4002F97")]
		[FieldOffset(Offset = "0x10")]
		public List<string> idList;
	}
}
