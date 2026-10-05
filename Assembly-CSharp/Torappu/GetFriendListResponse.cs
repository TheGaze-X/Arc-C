using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000729 RID: 1833
	[Token(Token = "0x2000729")]
	public class GetFriendListResponse : PlayerDeltaResponse
	{
		// Token: 0x06006394 RID: 25492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006394")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public GetFriendListResponse()
		{
		}

		// Token: 0x04002F94 RID: 12180
		[Token(Token = "0x4002F94")]
		[FieldOffset(Offset = "0x28")]
		public List<FriendDataWithNameCard> friends;

		// Token: 0x04002F95 RID: 12181
		[Token(Token = "0x4002F95")]
		[FieldOffset(Offset = "0x30")]
		public List<string> friendAlias;

		// Token: 0x04002F96 RID: 12182
		[Token(Token = "0x4002F96")]
		[FieldOffset(Offset = "0x38")]
		public List<string> resultIdList;
	}
}
