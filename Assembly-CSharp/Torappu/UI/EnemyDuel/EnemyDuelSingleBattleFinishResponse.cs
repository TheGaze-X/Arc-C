using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004F7F RID: 20351
	[Token(Token = "0x2004F7F")]
	public class EnemyDuelSingleBattleFinishResponse : DefaultFinishBattleResponse
	{
		// Token: 0x0601E41F RID: 123935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E41F")]
		[Address(RVA = "0x10D1D40", Offset = "0x10D0940", VA = "0x1810D1D40")]
		public EnemyDuelSingleBattleFinishResponse()
		{
		}

		// Token: 0x04028600 RID: 165376
		[Token(Token = "0x4028600")]
		[FieldOffset(Offset = "0xA0")]
		public ChoiceCntInfo choiceCnt;

		// Token: 0x04028601 RID: 165377
		[Token(Token = "0x4028601")]
		[FieldOffset(Offset = "0xA8")]
		public string commentId;

		// Token: 0x04028602 RID: 165378
		[Token(Token = "0x4028602")]
		[FieldOffset(Offset = "0xB0")]
		public bool isHighScore;

		// Token: 0x04028603 RID: 165379
		[Token(Token = "0x4028603")]
		[FieldOffset(Offset = "0xB8")]
		public List<RankInfo> rankList;

		// Token: 0x04028604 RID: 165380
		[Token(Token = "0x4028604")]
		[FieldOffset(Offset = "0xC0")]
		public DailyMissionInfo dailyMission;

		// Token: 0x04028605 RID: 165381
		[Token(Token = "0x4028605")]
		[FieldOffset(Offset = "0xC8")]
		public int bp;
	}
}
