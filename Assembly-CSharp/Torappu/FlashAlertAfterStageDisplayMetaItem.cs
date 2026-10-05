using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020010FC RID: 4348
	[Token(Token = "0x20010FC")]
	public class FlashAlertAfterStageDisplayMetaItem : IMetaDisplayItem
	{
		// Token: 0x06006EB1 RID: 28337 RVA: 0x00032298 File Offset: 0x00030498
		[Token(Token = "0x6006EB1")]
		[Address(RVA = "0x54B0E0", Offset = "0x549CE0", VA = "0x18054B0E0", Slot = "4")]
		public MetaUIDisplayType GetDisplayType()
		{
			return MetaUIDisplayType.TIPS;
		}

		// Token: 0x06006EB2 RID: 28338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006EB2")]
		[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "5")]
		public CommonAvailCheck GetAvailCheckNullable()
		{
			return null;
		}

		// Token: 0x06006EB3 RID: 28339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006EB3")]
		[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0", Slot = "6")]
		public string GetRelatedActId()
		{
			return null;
		}

		// Token: 0x06006EB4 RID: 28340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EB4")]
		[Address(RVA = "0x21049A0", Offset = "0x21035A0", VA = "0x1821049A0")]
		public FlashAlertAfterStageDisplayMetaItem()
		{
		}

		// Token: 0x04005D29 RID: 23849
		[Token(Token = "0x4005D29")]
		[FieldOffset(Offset = "0x10")]
		public string flashAlertId;

		// Token: 0x04005D2A RID: 23850
		[Token(Token = "0x4005D2A")]
		[FieldOffset(Offset = "0x18")]
		public CommonAvailCheck availCheck;

		// Token: 0x04005D2B RID: 23851
		[Token(Token = "0x4005D2B")]
		[FieldOffset(Offset = "0x20")]
		public bool isAllStageActive;

		// Token: 0x04005D2C RID: 23852
		[Token(Token = "0x4005D2C")]
		[FieldOffset(Offset = "0x28")]
		public List<string> stageIdList;

		// Token: 0x04005D2D RID: 23853
		[Token(Token = "0x4005D2D")]
		[FieldOffset(Offset = "0x30")]
		public string relateActId;

		// Token: 0x04005D2E RID: 23854
		[Token(Token = "0x4005D2E")]
		[FieldOffset(Offset = "0x38")]
		public string detailText;

		// Token: 0x04005D2F RID: 23855
		[Token(Token = "0x4005D2F")]
		[FieldOffset(Offset = "0x40")]
		public bool isBasicInfo;

		// Token: 0x04005D30 RID: 23856
		[Token(Token = "0x4005D30")]
		[FieldOffset(Offset = "0x44")]
		public int times;
	}
}
