using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.Friend;

namespace Torappu
{
	// Token: 0x02000684 RID: 1668
	[Token(Token = "0x2000684")]
	public class BuildingGetFriendSortListInfoResponse : PlayerDeltaResponse
	{
		// Token: 0x060062B2 RID: 25266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062B2")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public BuildingGetFriendSortListInfoResponse()
		{
		}

		// Token: 0x04002E40 RID: 11840
		[Token(Token = "0x4002E40")]
		[FieldOffset(Offset = "0x28")]
		public List<FriendSortViewModel> result;

		// Token: 0x04002E41 RID: 11841
		[Token(Token = "0x4002E41")]
		[FieldOffset(Offset = "0x30")]
		public List<string> starFriendList;
	}
}
