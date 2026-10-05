using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020006DE RID: 1758
	[Token(Token = "0x20006DE")]
	public class CrisisBuyShopRequest
	{
		// Token: 0x0600632D RID: 25389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600632D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CrisisBuyShopRequest()
		{
		}

		// Token: 0x04002EEE RID: 12014
		[Token(Token = "0x4002EEE")]
		[FieldOffset(Offset = "0x10")]
		public string goodId;

		// Token: 0x04002EEF RID: 12015
		[Token(Token = "0x4002EEF")]
		[FieldOffset(Offset = "0x18")]
		public int count;

		// Token: 0x04002EF0 RID: 12016
		[Token(Token = "0x4002EF0")]
		[FieldOffset(Offset = "0x1C")]
		public int perm;
	}
}
