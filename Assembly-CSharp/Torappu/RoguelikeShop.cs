using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200115C RID: 4444
	[Token(Token = "0x200115C")]
	public class RoguelikeShop
	{
		// Token: 0x06006F3B RID: 28475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006F3B")]
		[Address(RVA = "0x2112610", Offset = "0x2111210", VA = "0x182112610")]
		public RoguelikeShop()
		{
		}

		// Token: 0x04005F33 RID: 24371
		[Token(Token = "0x4005F33")]
		[FieldOffset(Offset = "0x10")]
		public List<RoguelikeGoods> goods;
	}
}
