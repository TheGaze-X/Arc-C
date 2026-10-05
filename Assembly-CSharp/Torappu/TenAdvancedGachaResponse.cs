using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200075B RID: 1883
	[Token(Token = "0x200075B")]
	public class TenAdvancedGachaResponse : PlayerDeltaResponse
	{
		// Token: 0x060063C5 RID: 25541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063C5")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public TenAdvancedGachaResponse()
		{
		}

		// Token: 0x04002FE3 RID: 12259
		[Token(Token = "0x4002FE3")]
		[FieldOffset(Offset = "0x28")]
		public int result;

		// Token: 0x04002FE4 RID: 12260
		[Token(Token = "0x4002FE4")]
		[FieldOffset(Offset = "0x30")]
		public GachaResult[] gachaResultList;
	}
}
