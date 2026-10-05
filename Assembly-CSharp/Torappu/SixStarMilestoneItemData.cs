using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200136E RID: 4974
	[Token(Token = "0x200136E")]
	[Serializable]
	public class SixStarMilestoneItemData : IComparable
	{
		// Token: 0x06007339 RID: 29497 RVA: 0x00033288 File Offset: 0x00031488
		[Token(Token = "0x6007339")]
		[Address(RVA = "0x2211540", Offset = "0x2210140", VA = "0x182211540", Slot = "4")]
		public int CompareTo(object obj)
		{
			return 0;
		}

		// Token: 0x0600733A RID: 29498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600733A")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SixStarMilestoneItemData()
		{
		}

		// Token: 0x04006E3D RID: 28221
		[Token(Token = "0x4006E3D")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x04006E3E RID: 28222
		[Token(Token = "0x4006E3E")]
		[FieldOffset(Offset = "0x18")]
		public int sortId;

		// Token: 0x04006E3F RID: 28223
		[Token(Token = "0x4006E3F")]
		[FieldOffset(Offset = "0x1C")]
		public int nodePoint;

		// Token: 0x04006E40 RID: 28224
		[Token(Token = "0x4006E40")]
		[FieldOffset(Offset = "0x20")]
		public SixStarMilestoneRewardType rewardType;

		// Token: 0x04006E41 RID: 28225
		[Token(Token = "0x4006E41")]
		[FieldOffset(Offset = "0x28")]
		public string unlockStageFog;

		// Token: 0x04006E42 RID: 28226
		[Token(Token = "0x4006E42")]
		[FieldOffset(Offset = "0x30")]
		public string unlockStageId;

		// Token: 0x04006E43 RID: 28227
		[Token(Token = "0x4006E43")]
		[FieldOffset(Offset = "0x38")]
		public string unlockStageName;

		// Token: 0x04006E44 RID: 28228
		[Token(Token = "0x4006E44")]
		[FieldOffset(Offset = "0x40")]
		public List<ItemBundle> rewardList;
	}
}
