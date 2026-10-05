using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001311 RID: 4881
	[Token(Token = "0x2001311")]
	public class ShopRecommendTemplateNormalFurnParam
	{
		// Token: 0x0600728E RID: 29326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600728E")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ShopRecommendTemplateNormalFurnParam()
		{
		}

		// Token: 0x04006C33 RID: 27699
		[Token(Token = "0x4006C33")]
		[FieldOffset(Offset = "0x10")]
		public long showStartTs;

		// Token: 0x04006C34 RID: 27700
		[Token(Token = "0x4006C34")]
		[FieldOffset(Offset = "0x18")]
		public long showEndTs;

		// Token: 0x04006C35 RID: 27701
		[Token(Token = "0x4006C35")]
		[FieldOffset(Offset = "0x20")]
		public string furnPackId;

		// Token: 0x04006C36 RID: 27702
		[Token(Token = "0x4006C36")]
		[FieldOffset(Offset = "0x28")]
		public bool isNew;

		// Token: 0x04006C37 RID: 27703
		[Token(Token = "0x4006C37")]
		[FieldOffset(Offset = "0x29")]
		public bool isPackSell;

		// Token: 0x04006C38 RID: 27704
		[Token(Token = "0x4006C38")]
		[FieldOffset(Offset = "0x2C")]
		public int count;

		// Token: 0x04006C39 RID: 27705
		[Token(Token = "0x4006C39")]
		[FieldOffset(Offset = "0x30")]
		public string colorBack;

		// Token: 0x04006C3A RID: 27706
		[Token(Token = "0x4006C3A")]
		[FieldOffset(Offset = "0x38")]
		public string colorText;

		// Token: 0x04006C3B RID: 27707
		[Token(Token = "0x4006C3B")]
		[FieldOffset(Offset = "0x40")]
		public string actId;
	}
}
