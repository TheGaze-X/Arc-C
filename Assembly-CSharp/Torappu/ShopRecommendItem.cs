using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200130D RID: 4877
	[Token(Token = "0x200130D")]
	public class ShopRecommendItem
	{
		// Token: 0x06007286 RID: 29318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007286")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ShopRecommendItem()
		{
		}

		// Token: 0x04006C13 RID: 27667
		[Token(Token = "0x4006C13")]
		[FieldOffset(Offset = "0x10")]
		public string tagId;

		// Token: 0x04006C14 RID: 27668
		[Token(Token = "0x4006C14")]
		[FieldOffset(Offset = "0x18")]
		public string displayType;

		// Token: 0x04006C15 RID: 27669
		[Token(Token = "0x4006C15")]
		[FieldOffset(Offset = "0x20")]
		public string tagName;

		// Token: 0x04006C16 RID: 27670
		[Token(Token = "0x4006C16")]
		[FieldOffset(Offset = "0x28")]
		public RecommendItemTagTips itemTag;

		// Token: 0x04006C17 RID: 27671
		[Token(Token = "0x4006C17")]
		[FieldOffset(Offset = "0x2C")]
		public int orderNum;

		// Token: 0x04006C18 RID: 27672
		[Token(Token = "0x4006C18")]
		[FieldOffset(Offset = "0x30")]
		public long startDatetime;

		// Token: 0x04006C19 RID: 27673
		[Token(Token = "0x4006C19")]
		[FieldOffset(Offset = "0x38")]
		public long endDatetime;

		// Token: 0x04006C1A RID: 27674
		[Token(Token = "0x4006C1A")]
		[FieldOffset(Offset = "0x40")]
		public List<ShopRecommendGroup> groupList;

		// Token: 0x04006C1B RID: 27675
		[Token(Token = "0x4006C1B")]
		[FieldOffset(Offset = "0x48")]
		public ShopKeeperWord tagWord;

		// Token: 0x04006C1C RID: 27676
		[Token(Token = "0x4006C1C")]
		[FieldOffset(Offset = "0x50")]
		public ShopRecommendTemplateType templateType;

		// Token: 0x04006C1D RID: 27677
		[Token(Token = "0x4006C1D")]
		[FieldOffset(Offset = "0x58")]
		public ShopRecommendTemplateParam templateParam;
	}
}
