using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004F7C RID: 20348
	[Token(Token = "0x2004F7C")]
	public class EnemyDuelMultiBattleFinishResponse : DefaultFinishBattleResponse
	{
		// Token: 0x0601E41B RID: 123931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E41B")]
		[Address(RVA = "0x10D1D40", Offset = "0x10D0940", VA = "0x1810D1D40")]
		public EnemyDuelMultiBattleFinishResponse()
		{
		}

		// Token: 0x040285F5 RID: 165365
		[Token(Token = "0x40285F5")]
		[FieldOffset(Offset = "0xA0")]
		public ChoiceCntInfo choiceCnt;

		// Token: 0x040285F6 RID: 165366
		[Token(Token = "0x40285F6")]
		[FieldOffset(Offset = "0xA8")]
		public string commentId;

		// Token: 0x040285F7 RID: 165367
		[Token(Token = "0x40285F7")]
		[FieldOffset(Offset = "0xB0")]
		public bool isHighScore;

		// Token: 0x040285F8 RID: 165368
		[Token(Token = "0x40285F8")]
		[FieldOffset(Offset = "0xB8")]
		public List<RankInfo> rankList;

		// Token: 0x040285F9 RID: 165369
		[Token(Token = "0x40285F9")]
		[FieldOffset(Offset = "0xC0")]
		public DailyMissionInfo dailyMission;

		// Token: 0x040285FA RID: 165370
		[Token(Token = "0x40285FA")]
		[FieldOffset(Offset = "0xC8")]
		public int bp;
	}
}
