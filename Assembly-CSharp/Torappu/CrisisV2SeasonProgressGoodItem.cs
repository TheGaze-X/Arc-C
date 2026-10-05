using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000FBC RID: 4028
	[Token(Token = "0x2000FBC")]
	public class CrisisV2SeasonProgressGoodItem
	{
		// Token: 0x06006D03 RID: 27907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D03")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CrisisV2SeasonProgressGoodItem()
		{
		}

		// Token: 0x04005579 RID: 21881
		[Token(Token = "0x4005579")]
		[FieldOffset(Offset = "0x10")]
		public string goodId;

		// Token: 0x0400557A RID: 21882
		[Token(Token = "0x400557A")]
		[FieldOffset(Offset = "0x18")]
		public int order;

		// Token: 0x0400557B RID: 21883
		[Token(Token = "0x400557B")]
		[FieldOffset(Offset = "0x1C")]
		public int price;

		// Token: 0x0400557C RID: 21884
		[Token(Token = "0x400557C")]
		[FieldOffset(Offset = "0x20")]
		public ItemBundle item;
	}
}
