using System;
using Il2CppDummyDll;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x0200454B RID: 17739
	[Token(Token = "0x200454B")]
	public class GameSettleRecord
	{
		// Token: 0x0601B0A3 RID: 110755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B0A3")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public GameSettleRecord()
		{
		}

		// Token: 0x04022BC3 RID: 142275
		[Token(Token = "0x4022BC3")]
		[FieldOffset(Offset = "0x10")]
		public int cntZone;

		// Token: 0x04022BC4 RID: 142276
		[Token(Token = "0x4022BC4")]
		[FieldOffset(Offset = "0x14")]
		public int cntBattle;

		// Token: 0x04022BC5 RID: 142277
		[Token(Token = "0x4022BC5")]
		[FieldOffset(Offset = "0x18")]
		public int cntBattleElite;

		// Token: 0x04022BC6 RID: 142278
		[Token(Token = "0x4022BC6")]
		[FieldOffset(Offset = "0x1C")]
		public int cntBattleBoss;

		// Token: 0x04022BC7 RID: 142279
		[Token(Token = "0x4022BC7")]
		[FieldOffset(Offset = "0x20")]
		public int cntArrivedNode;

		// Token: 0x04022BC8 RID: 142280
		[Token(Token = "0x4022BC8")]
		[FieldOffset(Offset = "0x24")]
		public int cntRecruitChar;

		// Token: 0x04022BC9 RID: 142281
		[Token(Token = "0x4022BC9")]
		[FieldOffset(Offset = "0x28")]
		public int cntUpgradeChar;
	}
}
