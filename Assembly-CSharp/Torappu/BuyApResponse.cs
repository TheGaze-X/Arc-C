using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000770 RID: 1904
	[Token(Token = "0x2000770")]
	public class BuyApResponse : PlayerDeltaResponse
	{
		// Token: 0x060063E6 RID: 25574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063E6")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public BuyApResponse()
		{
		}

		// Token: 0x04002FFF RID: 12287
		[Token(Token = "0x4002FFF")]
		[FieldOffset(Offset = "0x28")]
		public int result;
	}
}
