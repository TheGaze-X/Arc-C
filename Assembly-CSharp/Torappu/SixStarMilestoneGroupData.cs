using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200136C RID: 4972
	[Token(Token = "0x200136C")]
	[Serializable]
	public class SixStarMilestoneGroupData
	{
		// Token: 0x06007338 RID: 29496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007338")]
		[Address(RVA = "0x22114B0", Offset = "0x22100B0", VA = "0x1822114B0")]
		public SixStarMilestoneGroupData()
		{
		}

		// Token: 0x04006E37 RID: 28215
		[Token(Token = "0x4006E37")]
		[FieldOffset(Offset = "0x10")]
		public string groupId;

		// Token: 0x04006E38 RID: 28216
		[Token(Token = "0x4006E38")]
		[FieldOffset(Offset = "0x18")]
		public List<string> stageIdList;

		// Token: 0x04006E39 RID: 28217
		[Token(Token = "0x4006E39")]
		[FieldOffset(Offset = "0x20")]
		public List<SixStarMilestoneItemData> milestoneDataList;
	}
}
