using System;
using Il2CppDummyDll;

namespace Torappu.UI.AutoChess
{
	// Token: 0x02006280 RID: 25216
	[Token(Token = "0x2006280")]
	public class AutoChessStartMatchResponse : PlayerDeltaResponse
	{
		// Token: 0x060245A3 RID: 148899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60245A3")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public AutoChessStartMatchResponse()
		{
		}

		// Token: 0x040328EE RID: 207086
		[Token(Token = "0x40328EE")]
		[FieldOffset(Offset = "0x28")]
		public AutoChessServiceCommonResultType result;
	}
}
