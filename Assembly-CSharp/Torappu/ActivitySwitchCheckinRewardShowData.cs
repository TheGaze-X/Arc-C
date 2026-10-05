using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000E2A RID: 3626
	[Token(Token = "0x2000E2A")]
	public class ActivitySwitchCheckinRewardShowData
	{
		// Token: 0x06006AFE RID: 27390 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006AFE")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActivitySwitchCheckinRewardShowData()
		{
		}

		// Token: 0x04004B7F RID: 19327
		[Token(Token = "0x4004B7F")]
		[FieldOffset(Offset = "0x10")]
		public string checkinId;

		// Token: 0x04004B80 RID: 19328
		[Token(Token = "0x4004B80")]
		[FieldOffset(Offset = "0x18")]
		public string rewardsTitle;

		// Token: 0x04004B81 RID: 19329
		[Token(Token = "0x4004B81")]
		[FieldOffset(Offset = "0x20")]
		public ActivitySwitchCheckinRewardItemShowData[] rewardShowItemDatas;

		// Token: 0x04004B82 RID: 19330
		[Token(Token = "0x4004B82")]
		[FieldOffset(Offset = "0x28")]
		public ActivitySwitchCheckinMainRewardShowData mainRewardShowData;
	}
}
