using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000E05 RID: 3589
	[Token(Token = "0x2000E05")]
	public class ActivityEnemyDuelExtraScoreGroupData
	{
		// Token: 0x06006AD6 RID: 27350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AD6")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActivityEnemyDuelExtraScoreGroupData()
		{
		}

		// Token: 0x04004A86 RID: 19078
		[Token(Token = "0x4004A86")]
		[FieldOffset(Offset = "0x10")]
		public string modeId;

		// Token: 0x04004A87 RID: 19079
		[Token(Token = "0x4004A87")]
		[FieldOffset(Offset = "0x18")]
		public List<ActivityEnemyDuelExtraScoreData> data;
	}
}
