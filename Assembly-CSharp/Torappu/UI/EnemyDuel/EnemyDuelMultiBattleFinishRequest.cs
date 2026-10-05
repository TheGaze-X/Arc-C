using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.EnemyDuel;

namespace Torappu.UI.EnemyDuel
{
	// Token: 0x02004F7B RID: 20347
	[Token(Token = "0x2004F7B")]
	public class EnemyDuelMultiBattleFinishRequest : CommonFinishBattleRequest
	{
		// Token: 0x0601E41A RID: 123930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E41A")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public EnemyDuelMultiBattleFinishRequest()
		{
		}

		// Token: 0x040285F1 RID: 165361
		[Token(Token = "0x40285F1")]
		[FieldOffset(Offset = "0x20")]
		public string activityId;

		// Token: 0x040285F2 RID: 165362
		[Token(Token = "0x40285F2")]
		[FieldOffset(Offset = "0x28")]
		public string sceneId;

		// Token: 0x040285F3 RID: 165363
		[Token(Token = "0x40285F3")]
		[FieldOffset(Offset = "0x30")]
		public List<EnemyDuelRoundSurviveUnit> surviveUnits;

		// Token: 0x040285F4 RID: 165364
		[Token(Token = "0x40285F4")]
		[FieldOffset(Offset = "0x38")]
		public List<EnemyDuelRoundBornUnit> bornUnits;
	}
}
