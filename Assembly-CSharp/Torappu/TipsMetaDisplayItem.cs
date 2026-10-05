using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020010FA RID: 4346
	[Token(Token = "0x20010FA")]
	public class TipsMetaDisplayItem : IMetaDisplayItem
	{
		// Token: 0x06006EA9 RID: 28329 RVA: 0x00032268 File Offset: 0x00030468
		[Token(Token = "0x6006EA9")]
		[Address(RVA = "0x54A780", Offset = "0x549380", VA = "0x18054A780", Slot = "4")]
		public MetaUIDisplayType GetDisplayType()
		{
			return MetaUIDisplayType.TIPS;
		}

		// Token: 0x06006EAA RID: 28330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006EAA")]
		[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70", Slot = "5")]
		public CommonAvailCheck GetAvailCheckNullable()
		{
			return null;
		}

		// Token: 0x06006EAB RID: 28331 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006EAB")]
		[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070", Slot = "6")]
		public string GetRelatedActId()
		{
			return null;
		}

		// Token: 0x06006EAC RID: 28332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EAC")]
		[Address(RVA = "0x21170B0", Offset = "0x2115CB0", VA = "0x1821170B0")]
		public TipsMetaDisplayItem()
		{
		}

		// Token: 0x04005D1C RID: 23836
		[Token(Token = "0x4005D1C")]
		[FieldOffset(Offset = "0x10")]
		public string tipsId;

		// Token: 0x04005D1D RID: 23837
		[Token(Token = "0x4005D1D")]
		[FieldOffset(Offset = "0x18")]
		public string loadingPic;

		// Token: 0x04005D1E RID: 23838
		[Token(Token = "0x4005D1E")]
		[FieldOffset(Offset = "0x20")]
		public CommonAvailCheck availCheck;

		// Token: 0x04005D1F RID: 23839
		[Token(Token = "0x4005D1F")]
		[FieldOffset(Offset = "0x28")]
		public string relateActId;

		// Token: 0x04005D20 RID: 23840
		[Token(Token = "0x4005D20")]
		[FieldOffset(Offset = "0x30")]
		public bool isAllStageActive;

		// Token: 0x04005D21 RID: 23841
		[Token(Token = "0x4005D21")]
		[FieldOffset(Offset = "0x38")]
		public List<string> stageIdList;

		// Token: 0x04005D22 RID: 23842
		[Token(Token = "0x4005D22")]
		[FieldOffset(Offset = "0x40")]
		public List<string> zoneIdList;

		// Token: 0x04005D23 RID: 23843
		[Token(Token = "0x4005D23")]
		[FieldOffset(Offset = "0x48")]
		public TipData[] tips;
	}
}
