using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Battle.AutoChess
{
	// Token: 0x02002785 RID: 10117
	[Token(Token = "0x2002785")]
	public struct ChessBasicInfo
	{
		// Token: 0x04012855 RID: 75861
		[Token(Token = "0x4012855")]
		[FieldOffset(Offset = "0x0")]
		public string charId;

		// Token: 0x04012856 RID: 75862
		[Token(Token = "0x4012856")]
		[FieldOffset(Offset = "0x8")]
		public bool isGolden;

		// Token: 0x04012857 RID: 75863
		[Token(Token = "0x4012857")]
		[FieldOffset(Offset = "0xC")]
		public AutoChessItemType itemType;

		// Token: 0x04012858 RID: 75864
		[Token(Token = "0x4012858")]
		[FieldOffset(Offset = "0x10")]
		public int itemLevel;

		// Token: 0x04012859 RID: 75865
		[Token(Token = "0x4012859")]
		[FieldOffset(Offset = "0x18")]
		public List<string> basicBondIds;
	}
}
