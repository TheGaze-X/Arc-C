using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x0200454D RID: 17741
	[Token(Token = "0x200454D")]
	public class GameSettleMonthTeam
	{
		// Token: 0x0601B0A5 RID: 110757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B0A5")]
		[Address(RVA = "0x142F460", Offset = "0x142E060", VA = "0x18142F460")]
		public GameSettleMonthTeam()
		{
		}

		// Token: 0x04022BD1 RID: 142289
		[Token(Token = "0x4022BD1")]
		[FieldOffset(Offset = "0x10")]
		public GameSettleBpInfo bp;

		// Token: 0x04022BD2 RID: 142290
		[Token(Token = "0x4022BD2")]
		[FieldOffset(Offset = "0x18")]
		public int gp;

		// Token: 0x04022BD3 RID: 142291
		[Token(Token = "0x4022BD3")]
		[FieldOffset(Offset = "0x20")]
		public List<ItemBundle> items;

		// Token: 0x04022BD4 RID: 142292
		[Token(Token = "0x4022BD4")]
		[FieldOffset(Offset = "0x28")]
		public GameSettleMissionStatus mission;
	}
}
