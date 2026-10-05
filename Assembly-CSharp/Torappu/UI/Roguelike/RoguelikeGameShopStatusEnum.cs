using System;
using Il2CppDummyDll;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020054EA RID: 21738
	[Token(Token = "0x20054EA")]
	[Flags]
	public enum RoguelikeGameShopStatusEnum
	{
		// Token: 0x0402B247 RID: 176711
		[Token(Token = "0x402B247")]
		NONE = 0,
		// Token: 0x0402B248 RID: 176712
		[Token(Token = "0x402B248")]
		BUY = 1,
		// Token: 0x0402B249 RID: 176713
		[Token(Token = "0x402B249")]
		RECYCLE = 2,
		// Token: 0x0402B24A RID: 176714
		[Token(Token = "0x402B24A")]
		GOODS_DETAIL = 4,
		// Token: 0x0402B24B RID: 176715
		[Token(Token = "0x402B24B")]
		BANK_ENTRY = 8,
		// Token: 0x0402B24C RID: 176716
		[Token(Token = "0x402B24C")]
		BANK_INVESTMENT = 16,
		// Token: 0x0402B24D RID: 176717
		[Token(Token = "0x402B24D")]
		BANK_WITHDRAWAL = 32,
		// Token: 0x0402B24E RID: 176718
		[Token(Token = "0x402B24E")]
		BANK_FAULTY = 64,
		// Token: 0x0402B24F RID: 176719
		[Token(Token = "0x402B24F")]
		NORMAL = 3
	}
}
