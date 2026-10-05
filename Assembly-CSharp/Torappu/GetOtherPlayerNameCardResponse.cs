using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000734 RID: 1844
	[Token(Token = "0x2000734")]
	public class GetOtherPlayerNameCardResponse : PlayerDeltaResponse
	{
		// Token: 0x0600639E RID: 25502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600639E")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public GetOtherPlayerNameCardResponse()
		{
		}

		// Token: 0x04002FA5 RID: 12197
		[Token(Token = "0x4002FA5")]
		[FieldOffset(Offset = "0x28")]
		public FriendDataWithNameCard nameCard;
	}
}
