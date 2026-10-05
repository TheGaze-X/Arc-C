using System;
using Il2CppDummyDll;

namespace Torappu.UI.AutoChess
{
	// Token: 0x02006261 RID: 25185
	[Token(Token = "0x2006261")]
	public class AutoChessCreateTeamResponse : PlayerDeltaResponse
	{
		// Token: 0x0602456C RID: 148844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602456C")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public AutoChessCreateTeamResponse()
		{
		}

		// Token: 0x04032894 RID: 206996
		[Token(Token = "0x4032894")]
		[FieldOffset(Offset = "0x28")]
		public AutoChessServiceCommonResultType result;

		// Token: 0x04032895 RID: 206997
		[Token(Token = "0x4032895")]
		[FieldOffset(Offset = "0x30")]
		public AutoChessTeamInfo team;
	}
}
