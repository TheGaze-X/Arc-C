using System;
using Il2CppDummyDll;

namespace Torappu.UI.AutoChess
{
	// Token: 0x02006263 RID: 25187
	[Token(Token = "0x2006263")]
	public class AutoChessJoinTeamResponse : PlayerDeltaResponse
	{
		// Token: 0x0602456E RID: 148846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602456E")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public AutoChessJoinTeamResponse()
		{
		}

		// Token: 0x04032898 RID: 207000
		[Token(Token = "0x4032898")]
		[FieldOffset(Offset = "0x28")]
		public AutoChessServiceCommonResultType result;

		// Token: 0x04032899 RID: 207001
		[Token(Token = "0x4032899")]
		[FieldOffset(Offset = "0x30")]
		public AutoChessTeamInfo team;
	}
}
