using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000727 RID: 1831
	[Token(Token = "0x2000727")]
	public class SearchPlayerResponse
	{
		// Token: 0x06006392 RID: 25490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006392")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SearchPlayerResponse()
		{
		}

		// Token: 0x04002F90 RID: 12176
		[Token(Token = "0x4002F90")]
		[FieldOffset(Offset = "0x10")]
		public List<FriendDataWithNameCard> players;

		// Token: 0x04002F91 RID: 12177
		[Token(Token = "0x4002F91")]
		[FieldOffset(Offset = "0x18")]
		public List<FriendStatus> friendStatusList;

		// Token: 0x04002F92 RID: 12178
		[Token(Token = "0x4002F92")]
		[FieldOffset(Offset = "0x20")]
		public List<string> resultIdList;
	}
}
