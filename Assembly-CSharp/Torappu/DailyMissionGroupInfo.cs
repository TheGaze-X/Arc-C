using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001106 RID: 4358
	[Token(Token = "0x2001106")]
	[Serializable]
	public class DailyMissionGroupInfo
	{
		// Token: 0x06006EC8 RID: 28360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EC8")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public DailyMissionGroupInfo()
		{
		}

		// Token: 0x04005D73 RID: 23923
		[Token(Token = "0x4005D73")]
		[FieldOffset(Offset = "0x10")]
		public long startTime;

		// Token: 0x04005D74 RID: 23924
		[Token(Token = "0x4005D74")]
		[FieldOffset(Offset = "0x18")]
		public long endTime;

		// Token: 0x04005D75 RID: 23925
		[Token(Token = "0x4005D75")]
		[FieldOffset(Offset = "0x20")]
		public string tagState;

		// Token: 0x04005D76 RID: 23926
		[Token(Token = "0x4005D76")]
		[FieldOffset(Offset = "0x28")]
		public List<DailyMissionGroupInfo.periodInfo> periodList;

		// Token: 0x02001107 RID: 4359
		[Token(Token = "0x2001107")]
		public class periodInfo
		{
			// Token: 0x06006EC9 RID: 28361 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006EC9")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public periodInfo()
			{
			}

			// Token: 0x04005D77 RID: 23927
			[Token(Token = "0x4005D77")]
			[FieldOffset(Offset = "0x10")]
			public string missionGroupId;

			// Token: 0x04005D78 RID: 23928
			[Token(Token = "0x4005D78")]
			[FieldOffset(Offset = "0x18")]
			public string rewardGroupId;

			// Token: 0x04005D79 RID: 23929
			[Token(Token = "0x4005D79")]
			[FieldOffset(Offset = "0x20")]
			public int[] period;
		}
	}
}
