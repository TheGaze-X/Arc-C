using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000EC4 RID: 3780
	[Token(Token = "0x2000EC4")]
	public class Act6FunData
	{
		// Token: 0x06006B94 RID: 27540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B94")]
		[Address(RVA = "0x1FF7870", Offset = "0x1FF6470", VA = "0x181FF7870")]
		public Act6FunData()
		{
		}

		// Token: 0x04004FE7 RID: 20455
		[Token(Token = "0x4004FE7")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, Act6FunStageAdditionData> stageAdditionMap;

		// Token: 0x04004FE8 RID: 20456
		[Token(Token = "0x4004FE8")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, List<Act6FunAchievementData>> stageAchievementMap;

		// Token: 0x04004FE9 RID: 20457
		[Token(Token = "0x4004FE9")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, Act6FunAchievementRewardData> achievementRewardList;

		// Token: 0x04004FEA RID: 20458
		[Token(Token = "0x4004FEA")]
		[FieldOffset(Offset = "0x28")]
		public Act6FunConst constData;
	}
}
