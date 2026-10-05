using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020021E9 RID: 8681
	[Token(Token = "0x20021E9")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class DeckBuffUtil
	{
		// Token: 0x0600D940 RID: 55616 RVA: 0x0004EDF8 File Offset: 0x0004CFF8
		[Token(Token = "0x600D940")]
		[Address(RVA = "0x35DE710", Offset = "0x35DD310", VA = "0x1835DE710")]
		public static int CalculateDeckBuffPriority(Deck.Card.DeckBuffWrapper deckBuff)
		{
			return 0;
		}

		// Token: 0x0400EA4D RID: 59981
		[Token(Token = "0x400EA4D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CalculateDeckBuffPriority;
	}
}
