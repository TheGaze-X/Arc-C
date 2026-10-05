using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001314 RID: 4884
	[Token(Token = "0x2001314")]
	public class ShopRecommendGroup
	{
		// Token: 0x06007291 RID: 29329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007291")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ShopRecommendGroup()
		{
		}

		// Token: 0x04006C41 RID: 27713
		[Token(Token = "0x4006C41")]
		[FieldOffset(Offset = "0x10")]
		public int[] recommendGroup;

		// Token: 0x04006C42 RID: 27714
		[Token(Token = "0x4006C42")]
		[FieldOffset(Offset = "0x18")]
		public List<ShopRecommendData> dataList;
	}
}
