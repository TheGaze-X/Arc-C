using System;
using Il2CppDummyDll;

namespace Torappu.UI.AutoChess
{
	// Token: 0x0200625C RID: 25180
	[Token(Token = "0x200625C")]
	public class AutoChessGetFriendAssistListResponse : PlayerDeltaResponse
	{
		// Token: 0x06024567 RID: 148839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024567")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public AutoChessGetFriendAssistListResponse()
		{
		}

		// Token: 0x04032889 RID: 206985
		[Token(Token = "0x4032889")]
		[FieldOffset(Offset = "0x28")]
		public SquadAssistData[] assistList;
	}
}
