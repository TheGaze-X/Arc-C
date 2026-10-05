using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Runes.Internal
{
	// Token: 0x020028C7 RID: 10439
	[Token(Token = "0x20028C7")]
	public class DCardBuffRuneWithVerify : BasicDeckCardRune
	{
		// Token: 0x060115DD RID: 71133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60115DD")]
		[Address(RVA = "0x93A870", Offset = "0x939470", VA = "0x18093A870")]
		protected DCardBuffRuneWithVerify()
		{
		}

		// Token: 0x060115DE RID: 71134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60115DE")]
		[Address(RVA = "0x93A690", Offset = "0x939290", VA = "0x18093A690", Slot = "12")]
		public override void PreprocessDeck(IList<Deck.Card> cards)
		{
		}

		// Token: 0x04013699 RID: 79513
		[Token(Token = "0x4013699")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0401369A RID: 79514
		[Token(Token = "0x401369A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_PreprocessDeck;
	}
}
