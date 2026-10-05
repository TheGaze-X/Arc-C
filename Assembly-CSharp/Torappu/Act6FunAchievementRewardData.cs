using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000EC2 RID: 3778
	[Token(Token = "0x2000EC2")]
	public class Act6FunAchievementRewardData
	{
		// Token: 0x06006B92 RID: 27538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B92")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act6FunAchievementRewardData()
		{
		}

		// Token: 0x04004FDF RID: 20447
		[Token(Token = "0x4004FDF")]
		[FieldOffset(Offset = "0x10")]
		public ItemBundle reward;

		// Token: 0x04004FE0 RID: 20448
		[Token(Token = "0x4004FE0")]
		[FieldOffset(Offset = "0x18")]
		public int sortId;

		// Token: 0x04004FE1 RID: 20449
		[Token(Token = "0x4004FE1")]
		[FieldOffset(Offset = "0x1C")]
		public int achievementCount;
	}
}
