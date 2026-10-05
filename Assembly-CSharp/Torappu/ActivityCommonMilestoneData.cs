using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000E82 RID: 3714
	[Token(Token = "0x2000E82")]
	public class ActivityCommonMilestoneData
	{
		// Token: 0x06006B4E RID: 27470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006B4E")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ActivityCommonMilestoneData()
		{
		}

		// Token: 0x04004E2C RID: 20012
		[Token(Token = "0x4004E2C")]
		[FieldOffset(Offset = "0x10")]
		public string milestoneId;

		// Token: 0x04004E2D RID: 20013
		[Token(Token = "0x4004E2D")]
		[FieldOffset(Offset = "0x18")]
		public int milestoneLvl;

		// Token: 0x04004E2E RID: 20014
		[Token(Token = "0x4004E2E")]
		[FieldOffset(Offset = "0x1C")]
		public int tokenNum;

		// Token: 0x04004E2F RID: 20015
		[Token(Token = "0x4004E2F")]
		[FieldOffset(Offset = "0x20")]
		public ItemBundle rewardItem;

		// Token: 0x04004E30 RID: 20016
		[Token(Token = "0x4004E30")]
		[FieldOffset(Offset = "0x28")]
		public long availableTime;
	}
}
