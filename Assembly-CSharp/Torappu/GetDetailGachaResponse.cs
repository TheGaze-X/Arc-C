using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200075F RID: 1887
	[Token(Token = "0x200075F")]
	public class GetDetailGachaResponse
	{
		// Token: 0x060063C9 RID: 25545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063C9")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public GetDetailGachaResponse()
		{
		}

		// Token: 0x04002FE9 RID: 12265
		[Token(Token = "0x4002FE9")]
		[FieldOffset(Offset = "0x10")]
		public GachaDetailData detailInfo;

		// Token: 0x04002FEA RID: 12266
		[Token(Token = "0x4002FEA")]
		[FieldOffset(Offset = "0x18")]
		public GachaDetailData.GachaObjGroupType gachaObjGroupType;

		// Token: 0x04002FEB RID: 12267
		[Token(Token = "0x4002FEB")]
		[FieldOffset(Offset = "0x1C")]
		public bool hasRateUp;
	}
}
