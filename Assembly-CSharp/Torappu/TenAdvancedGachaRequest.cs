using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200075A RID: 1882
	[Token(Token = "0x200075A")]
	public class TenAdvancedGachaRequest
	{
		// Token: 0x060063C4 RID: 25540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063C4")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public TenAdvancedGachaRequest()
		{
		}

		// Token: 0x04002FE0 RID: 12256
		[Token(Token = "0x4002FE0")]
		[FieldOffset(Offset = "0x10")]
		public string poolId;

		// Token: 0x04002FE1 RID: 12257
		[Token(Token = "0x4002FE1")]
		[FieldOffset(Offset = "0x18")]
		public GachaType useTkt;

		// Token: 0x04002FE2 RID: 12258
		[Token(Token = "0x4002FE2")]
		[FieldOffset(Offset = "0x20")]
		public List<CombineGachaItem> itemList;
	}
}
