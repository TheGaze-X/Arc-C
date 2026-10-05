using System;
using Il2CppDummyDll;

namespace Torappu.UI.TemplateShop
{
	// Token: 0x02003D50 RID: 15696
	[Token(Token = "0x2003D50")]
	public class TemplateBuyGoodRequest
	{
		// Token: 0x0601872F RID: 100143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601872F")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public TemplateBuyGoodRequest()
		{
		}

		// Token: 0x0401DE98 RID: 122520
		[Token(Token = "0x401DE98")]
		[FieldOffset(Offset = "0x10")]
		public string shopId;

		// Token: 0x0401DE99 RID: 122521
		[Token(Token = "0x401DE99")]
		[FieldOffset(Offset = "0x18")]
		public string goodId;

		// Token: 0x0401DE9A RID: 122522
		[Token(Token = "0x401DE9A")]
		[FieldOffset(Offset = "0x20")]
		public int count;
	}
}
