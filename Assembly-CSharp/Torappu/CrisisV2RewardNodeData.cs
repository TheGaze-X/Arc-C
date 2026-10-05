using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000FC4 RID: 4036
	[Token(Token = "0x2000FC4")]
	public class CrisisV2RewardNodeData
	{
		// Token: 0x06006D0E RID: 27918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D0E")]
		[Address(RVA = "0x21013C0", Offset = "0x20FFFC0", VA = "0x1821013C0")]
		public CrisisV2RewardNodeData()
		{
		}

		// Token: 0x040055AA RID: 21930
		[Token(Token = "0x40055AA")]
		[FieldOffset(Offset = "0x10")]
		public string slotId;

		// Token: 0x040055AB RID: 21931
		[Token(Token = "0x40055AB")]
		[FieldOffset(Offset = "0x18")]
		public int requestBagCnt;

		// Token: 0x040055AC RID: 21932
		[Token(Token = "0x40055AC")]
		[FieldOffset(Offset = "0x20")]
		public string goodId;

		// Token: 0x040055AD RID: 21933
		[Token(Token = "0x40055AD")]
		[FieldOffset(Offset = "0x28")]
		public string previewTitle;

		// Token: 0x040055AE RID: 21934
		[Token(Token = "0x40055AE")]
		[FieldOffset(Offset = "0x30")]
		public string previewDesc;

		// Token: 0x040055AF RID: 21935
		[Token(Token = "0x40055AF")]
		[FieldOffset(Offset = "0x38")]
		public string missionListTitle;

		// Token: 0x040055B0 RID: 21936
		[Token(Token = "0x40055B0")]
		[FieldOffset(Offset = "0x40")]
		public string missionListDesc;

		// Token: 0x040055B1 RID: 21937
		[Token(Token = "0x40055B1")]
		[FieldOffset(Offset = "0x48")]
		public int missionSortId;

		// Token: 0x040055B2 RID: 21938
		[Token(Token = "0x40055B2")]
		[FieldOffset(Offset = "0x50")]
		public ItemBundle reward;

		// Token: 0x040055B3 RID: 21939
		[Token(Token = "0x40055B3")]
		[FieldOffset(Offset = "0x58")]
		public List<string> requestBagIdList;
	}
}
