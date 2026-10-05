using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Runes.Internal
{
	// Token: 0x020028C6 RID: 10438
	[Token(Token = "0x20028C6")]
	public class DCardBuffByProfessionRune : BasicDeckCardRune
	{
		// Token: 0x060115DB RID: 71131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60115DB")]
		[Address(RVA = "0x93A5F0", Offset = "0x9391F0", VA = "0x18093A5F0")]
		protected DCardBuffByProfessionRune()
		{
		}

		// Token: 0x060115DC RID: 71132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60115DC")]
		[Address(RVA = "0x93A3B0", Offset = "0x938FB0", VA = "0x18093A3B0", Slot = "12")]
		public override void PreprocessDeck(IList<Deck.Card> cards)
		{
		}

		// Token: 0x04013697 RID: 79511
		[Token(Token = "0x4013697")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04013698 RID: 79512
		[Token(Token = "0x4013698")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_PreprocessDeck;
	}
}
