using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001310 RID: 4880
	[Token(Token = "0x2001310")]
	public class ShopRecommendTemplateNormalSkinParam
	{
		// Token: 0x0600728D RID: 29325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600728D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ShopRecommendTemplateNormalSkinParam()
		{
		}

		// Token: 0x04006C2B RID: 27691
		[Token(Token = "0x4006C2B")]
		[FieldOffset(Offset = "0x10")]
		public long showStartTs;

		// Token: 0x04006C2C RID: 27692
		[Token(Token = "0x4006C2C")]
		[FieldOffset(Offset = "0x18")]
		public long showEndTs;

		// Token: 0x04006C2D RID: 27693
		[Token(Token = "0x4006C2D")]
		[FieldOffset(Offset = "0x20")]
		public List<string> skinIds;

		// Token: 0x04006C2E RID: 27694
		[Token(Token = "0x4006C2E")]
		[FieldOffset(Offset = "0x28")]
		public string skinGroupName;

		// Token: 0x04006C2F RID: 27695
		[Token(Token = "0x4006C2F")]
		[FieldOffset(Offset = "0x30")]
		public string brandIconId;

		// Token: 0x04006C30 RID: 27696
		[Token(Token = "0x4006C30")]
		[FieldOffset(Offset = "0x38")]
		public string colorBack;

		// Token: 0x04006C31 RID: 27697
		[Token(Token = "0x4006C31")]
		[FieldOffset(Offset = "0x40")]
		public string colorText;

		// Token: 0x04006C32 RID: 27698
		[Token(Token = "0x4006C32")]
		[FieldOffset(Offset = "0x48")]
		public string text;
	}
}
