using System;
using Il2CppDummyDll;

namespace Torappu.UI.TemplateShop
{
	// Token: 0x02003D4F RID: 15695
	[Token(Token = "0x2003D4F")]
	public class TemplateGetGoodListResponse
	{
		// Token: 0x0601872E RID: 100142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601872E")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public TemplateGetGoodListResponse()
		{
		}

		// Token: 0x0401DE96 RID: 122518
		[Token(Token = "0x401DE96")]
		[FieldOffset(Offset = "0x10")]
		public TemplateShopData data;

		// Token: 0x0401DE97 RID: 122519
		[Token(Token = "0x401DE97")]
		[FieldOffset(Offset = "0x18")]
		public long nextSyncTime;
	}
}
