using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.Friend;

namespace Torappu
{
	// Token: 0x02000725 RID: 1829
	[Token(Token = "0x2000725")]
	public class GetSortListInfoResponse : PlayerDeltaResponse
	{
		// Token: 0x06006390 RID: 25488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006390")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public GetSortListInfoResponse()
		{
		}

		// Token: 0x04002F8D RID: 12173
		[Token(Token = "0x4002F8D")]
		[FieldOffset(Offset = "0x28")]
		public List<FriendSortViewModel> result;

		// Token: 0x04002F8E RID: 12174
		[Token(Token = "0x4002F8E")]
		[FieldOffset(Offset = "0x30")]
		public List<string> starFriendList;
	}
}
