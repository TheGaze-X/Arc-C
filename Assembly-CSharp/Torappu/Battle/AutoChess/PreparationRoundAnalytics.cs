using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Battle.AutoChess
{
	// Token: 0x02002718 RID: 10008
	[Token(Token = "0x2002718")]
	public class PreparationRoundAnalytics
	{
		// Token: 0x06010472 RID: 66674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010472")]
		[Address(RVA = "0x80A5E0", Offset = "0x8091E0", VA = "0x18080A5E0")]
		public PreparationRoundAnalytics()
		{
		}

		// Token: 0x04012306 RID: 74502
		[Token(Token = "0x4012306")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, int> chessGained;

		// Token: 0x04012307 RID: 74503
		[Token(Token = "0x4012307")]
		[FieldOffset(Offset = "0x18")]
		public int coinCost;
	}
}
