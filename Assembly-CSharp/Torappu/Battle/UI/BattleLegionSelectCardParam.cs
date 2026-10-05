using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Battle.UI
{
	// Token: 0x020032E6 RID: 13030
	[Token(Token = "0x20032E6")]
	public struct BattleLegionSelectCardParam
	{
		// Token: 0x0401899C RID: 100764
		[Token(Token = "0x401899C")]
		[FieldOffset(Offset = "0x0")]
		public int selectRangeNum;

		// Token: 0x0401899D RID: 100765
		[Token(Token = "0x401899D")]
		[FieldOffset(Offset = "0x4")]
		public int canSelectNum;

		// Token: 0x0401899E RID: 100766
		[Token(Token = "0x401899E")]
		[FieldOffset(Offset = "0x8")]
		public int goldNumWhenSellCard;

		// Token: 0x0401899F RID: 100767
		[Token(Token = "0x401899F")]
		[FieldOffset(Offset = "0xC")]
		public LegionCardLibraryType cardType;

		// Token: 0x040189A0 RID: 100768
		[Token(Token = "0x40189A0")]
		[FieldOffset(Offset = "0x10")]
		public bool discardUnselected;

		// Token: 0x040189A1 RID: 100769
		[Token(Token = "0x40189A1")]
		[FieldOffset(Offset = "0x11")]
		public bool putInPendingIfHandFull;

		// Token: 0x040189A2 RID: 100770
		[Token(Token = "0x40189A2")]
		[FieldOffset(Offset = "0x14")]
		public LegionSelectCardType selectCardType;

		// Token: 0x040189A3 RID: 100771
		[Token(Token = "0x40189A3")]
		[FieldOffset(Offset = "0x18")]
		public ProfessionCategory filterProfession;

		// Token: 0x040189A4 RID: 100772
		[Token(Token = "0x40189A4")]
		[FieldOffset(Offset = "0x20")]
		public List<string> cardKeys;

		// Token: 0x040189A5 RID: 100773
		[Token(Token = "0x40189A5")]
		[FieldOffset(Offset = "0x28")]
		public List<Deck.Card> cardList;
	}
}
