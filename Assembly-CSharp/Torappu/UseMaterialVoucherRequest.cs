using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200079B RID: 1947
	[Token(Token = "0x200079B")]
	public class UseMaterialVoucherRequest
	{
		// Token: 0x0600641B RID: 25627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600641B")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public UseMaterialVoucherRequest()
		{
		}

		// Token: 0x04003071 RID: 12401
		[Token(Token = "0x4003071")]
		[FieldOffset(Offset = "0x10")]
		public string instId;

		// Token: 0x04003072 RID: 12402
		[Token(Token = "0x4003072")]
		[FieldOffset(Offset = "0x18")]
		public string itemId;

		// Token: 0x04003073 RID: 12403
		[Token(Token = "0x4003073")]
		[FieldOffset(Offset = "0x20")]
		public int count;
	}
}
