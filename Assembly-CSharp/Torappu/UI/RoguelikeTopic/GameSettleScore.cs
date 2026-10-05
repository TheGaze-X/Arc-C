using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x0200454C RID: 17740
	[Token(Token = "0x200454C")]
	public class GameSettleScore
	{
		// Token: 0x0601B0A4 RID: 110756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B0A4")]
		[Address(RVA = "0x142F6B0", Offset = "0x142E2B0", VA = "0x18142F6B0")]
		public GameSettleScore()
		{
		}

		// Token: 0x04022BCA RID: 142282
		[Token(Token = "0x4022BCA")]
		[FieldOffset(Offset = "0x10")]
		public List<List<int>> detail;

		// Token: 0x04022BCB RID: 142283
		[Token(Token = "0x4022BCB")]
		[FieldOffset(Offset = "0x18")]
		public float scoreFactor;

		// Token: 0x04022BCC RID: 142284
		[Token(Token = "0x4022BCC")]
		[FieldOffset(Offset = "0x1C")]
		public float score;

		// Token: 0x04022BCD RID: 142285
		[Token(Token = "0x4022BCD")]
		[FieldOffset(Offset = "0x20")]
		public float buff;

		// Token: 0x04022BCE RID: 142286
		[Token(Token = "0x4022BCE")]
		[FieldOffset(Offset = "0x28")]
		public GameSettleBpInfo bp;

		// Token: 0x04022BCF RID: 142287
		[Token(Token = "0x4022BCF")]
		[FieldOffset(Offset = "0x30")]
		public int gp;

		// Token: 0x04022BD0 RID: 142288
		[Token(Token = "0x4022BD0")]
		[FieldOffset(Offset = "0x38")]
		public int[] accumulation;
	}
}
