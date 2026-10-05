using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Battle.UI
{
	// Token: 0x020032E7 RID: 13031
	[Token(Token = "0x20032E7")]
	public struct BattleLegionCardLibraryParam
	{
		// Token: 0x040189A6 RID: 100774
		[Token(Token = "0x40189A6")]
		[FieldOffset(Offset = "0x0")]
		public LegionCardLibraryType cardType;

		// Token: 0x040189A7 RID: 100775
		[Token(Token = "0x40189A7")]
		[FieldOffset(Offset = "0x8")]
		public List<Deck.Card> cardList;
	}
}
