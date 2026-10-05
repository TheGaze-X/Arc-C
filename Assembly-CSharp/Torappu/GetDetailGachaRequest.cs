using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200075E RID: 1886
	[Token(Token = "0x200075E")]
	public class GetDetailGachaRequest
	{
		// Token: 0x060063C8 RID: 25544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063C8")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public GetDetailGachaRequest()
		{
		}

		// Token: 0x04002FE7 RID: 12263
		[Token(Token = "0x4002FE7")]
		[FieldOffset(Offset = "0x10")]
		public string poolId;

		// Token: 0x04002FE8 RID: 12264
		[Token(Token = "0x4002FE8")]
		[FieldOffset(Offset = "0x18")]
		public GachaDetailData.GachaObjGroupType gachaObjGroupType;
	}
}
