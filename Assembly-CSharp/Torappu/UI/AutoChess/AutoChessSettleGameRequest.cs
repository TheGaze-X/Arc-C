using System;
using Il2CppDummyDll;

namespace Torappu.UI.AutoChess
{
	// Token: 0x02006270 RID: 25200
	[Token(Token = "0x2006270")]
	public class AutoChessSettleGameRequest
	{
		// Token: 0x06024591 RID: 148881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024591")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public AutoChessSettleGameRequest()
		{
		}

		// Token: 0x040328AE RID: 207022
		[Token(Token = "0x40328AE")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x040328AF RID: 207023
		[Token(Token = "0x40328AF")]
		[FieldOffset(Offset = "0x18")]
		public bool quitBattle;
	}
}
