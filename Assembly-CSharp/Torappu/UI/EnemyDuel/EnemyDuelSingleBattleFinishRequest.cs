using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.EnemyDuel;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004F7E RID: 20350
	[Token(Token = "0x2004F7E")]
	public class EnemyDuelSingleBattleFinishRequest : CommonFinishBattleRequest
	{
		// Token: 0x0601E41E RID: 123934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E41E")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public EnemyDuelSingleBattleFinishRequest()
		{
		}

		// Token: 0x040285FC RID: 165372
		[Token(Token = "0x40285FC")]
		[FieldOffset(Offset = "0x20")]
		public string activityId;

		// Token: 0x040285FD RID: 165373
		[Token(Token = "0x40285FD")]
		[FieldOffset(Offset = "0x28")]
		public EnemyDuelSingleFinishSettle settle;

		// Token: 0x040285FE RID: 165374
		[Token(Token = "0x40285FE")]
		[FieldOffset(Offset = "0x30")]
		public List<EnemyDuelRoundSurviveUnit> surviveUnits;

		// Token: 0x040285FF RID: 165375
		[Token(Token = "0x40285FF")]
		[FieldOffset(Offset = "0x38")]
		public List<EnemyDuelRoundBornUnit> bornUnits;
	}
}
