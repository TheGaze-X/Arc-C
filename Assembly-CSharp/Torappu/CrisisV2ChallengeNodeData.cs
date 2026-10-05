using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000FC3 RID: 4035
	[Token(Token = "0x2000FC3")]
	public class CrisisV2ChallengeNodeData
	{
		// Token: 0x06006D0D RID: 27917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D0D")]
		[Address(RVA = "0x2100DD0", Offset = "0x20FF9D0", VA = "0x182100DD0")]
		public CrisisV2ChallengeNodeData()
		{
		}

		// Token: 0x040055A3 RID: 21923
		[Token(Token = "0x40055A3")]
		[FieldOffset(Offset = "0x10")]
		public string slotId;

		// Token: 0x040055A4 RID: 21924
		[Token(Token = "0x40055A4")]
		[FieldOffset(Offset = "0x18")]
		public string previewTitle;

		// Token: 0x040055A5 RID: 21925
		[Token(Token = "0x40055A5")]
		[FieldOffset(Offset = "0x20")]
		public string previewDesc;

		// Token: 0x040055A6 RID: 21926
		[Token(Token = "0x40055A6")]
		[FieldOffset(Offset = "0x28")]
		public int missionSortId;

		// Token: 0x040055A7 RID: 21927
		[Token(Token = "0x40055A7")]
		[FieldOffset(Offset = "0x30")]
		public List<CrisisV2RewardItemData> rewardList;

		// Token: 0x040055A8 RID: 21928
		[Token(Token = "0x40055A8")]
		[FieldOffset(Offset = "0x38")]
		public int requiredSlotCount;

		// Token: 0x040055A9 RID: 21929
		[Token(Token = "0x40055A9")]
		[FieldOffset(Offset = "0x40")]
		public List<string> slotIdList;
	}
}
