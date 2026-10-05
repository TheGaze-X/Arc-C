using System;
using Il2CppDummyDll;

namespace Torappu.UI.AutoChess
{
	// Token: 0x02006279 RID: 25209
	[Token(Token = "0x2006279")]
	public class AutoChessSettleGameResponse : PlayerDeltaResponse
	{
		// Token: 0x0602459C RID: 148892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602459C")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public AutoChessSettleGameResponse()
		{
		}

		// Token: 0x040328E2 RID: 207074
		[Token(Token = "0x40328E2")]
		[FieldOffset(Offset = "0x28")]
		public int result;

		// Token: 0x040328E3 RID: 207075
		[Token(Token = "0x40328E3")]
		[FieldOffset(Offset = "0x30")]
		public AutoChessSeasonSettleGameInfo gameSettleData;
	}
}
