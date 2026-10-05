using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200072E RID: 1838
	[Token(Token = "0x200072E")]
	public class SetStarFriendListRequest
	{
		// Token: 0x06006399 RID: 25497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006399")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SetStarFriendListRequest()
		{
		}

		// Token: 0x04002F9B RID: 12187
		[Token(Token = "0x4002F9B")]
		[FieldOffset(Offset = "0x10")]
		public List<string> idList;
	}
}
