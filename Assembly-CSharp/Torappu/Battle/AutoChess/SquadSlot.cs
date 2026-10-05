using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Battle.AutoChess
{
	// Token: 0x0200270E RID: 9998
	[Token(Token = "0x200270E")]
	public class SquadSlot
	{
		// Token: 0x06010468 RID: 66664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010468")]
		[Address(RVA = "0x80B700", Offset = "0x80A300", VA = "0x18080B700")]
		public SquadSlot()
		{
		}

		// Token: 0x040122D3 RID: 74451
		[Token(Token = "0x40122D3")]
		[FieldOffset(Offset = "0x10")]
		public string chessId;

		// Token: 0x040122D4 RID: 74452
		[Token(Token = "0x40122D4")]
		[FieldOffset(Offset = "0x18")]
		public string charId;

		// Token: 0x040122D5 RID: 74453
		[Token(Token = "0x40122D5")]
		[FieldOffset(Offset = "0x20")]
		public string cultivateEffectId;

		// Token: 0x040122D6 RID: 74454
		[Token(Token = "0x40122D6")]
		[FieldOffset(Offset = "0x28")]
		public string currentEquip;

		// Token: 0x040122D7 RID: 74455
		[Token(Token = "0x40122D7")]
		[FieldOffset(Offset = "0x30")]
		public string skinId;

		// Token: 0x040122D8 RID: 74456
		[Token(Token = "0x40122D8")]
		[FieldOffset(Offset = "0x38")]
		public PlayerActivity.PlayerActAutoChessActivity.AutoChessCharType type;

		// Token: 0x040122D9 RID: 74457
		[Token(Token = "0x40122D9")]
		[FieldOffset(Offset = "0x3C")]
		public int potentialRank;

		// Token: 0x040122DA RID: 74458
		[Token(Token = "0x40122DA")]
		[FieldOffset(Offset = "0x40")]
		public int skillIndex;

		// Token: 0x040122DB RID: 74459
		[Token(Token = "0x40122DB")]
		[FieldOffset(Offset = "0x48")]
		public List<string> bondList;
	}
}
