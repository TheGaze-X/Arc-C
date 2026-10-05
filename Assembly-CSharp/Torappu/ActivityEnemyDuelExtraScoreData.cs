using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000E04 RID: 3588
	[Token(Token = "0x2000E04")]
	public class ActivityEnemyDuelExtraScoreData
	{
		// Token: 0x06006AD5 RID: 27349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AD5")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActivityEnemyDuelExtraScoreData()
		{
		}

		// Token: 0x04004A83 RID: 19075
		[Token(Token = "0x4004A83")]
		[FieldOffset(Offset = "0x10")]
		public int rankMin;

		// Token: 0x04004A84 RID: 19076
		[Token(Token = "0x4004A84")]
		[FieldOffset(Offset = "0x14")]
		public int rankMax;

		// Token: 0x04004A85 RID: 19077
		[Token(Token = "0x4004A85")]
		[FieldOffset(Offset = "0x18")]
		public int tokenNum;
	}
}
