using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020012C8 RID: 4808
	[Token(Token = "0x20012C8")]
	public class SandboxV2ShopDialogData
	{
		// Token: 0x06007241 RID: 29249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007241")]
		[Address(RVA = "0x2210A00", Offset = "0x220F600", VA = "0x182210A00")]
		public SandboxV2ShopDialogData()
		{
		}

		// Token: 0x04006A38 RID: 27192
		[Token(Token = "0x4006A38")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, List<string>> seasonDialogs;

		// Token: 0x04006A39 RID: 27193
		[Token(Token = "0x4006A39")]
		[FieldOffset(Offset = "0x18")]
		public List<string> afterBuyDialogs;

		// Token: 0x04006A3A RID: 27194
		[Token(Token = "0x4006A3A")]
		[FieldOffset(Offset = "0x20")]
		public List<string> shopEmptyDialogs;
	}
}
