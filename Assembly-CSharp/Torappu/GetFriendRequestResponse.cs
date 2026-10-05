using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200072B RID: 1835
	[Token(Token = "0x200072B")]
	public class GetFriendRequestResponse : PlayerDeltaResponse
	{
		// Token: 0x06006396 RID: 25494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006396")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public GetFriendRequestResponse()
		{
		}

		// Token: 0x04002F98 RID: 12184
		[Token(Token = "0x4002F98")]
		[FieldOffset(Offset = "0x28")]
		public List<FriendData> requestList;

		// Token: 0x04002F99 RID: 12185
		[Token(Token = "0x4002F99")]
		[FieldOffset(Offset = "0x30")]
		public List<string> resultIdList;
	}
}
