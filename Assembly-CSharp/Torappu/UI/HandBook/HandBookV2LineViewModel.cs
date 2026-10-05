using System;
using Il2CppDummyDll;

namespace Torappu.UI.HandBook
{
	// Token: 0x0200672A RID: 26410
	[Token(Token = "0x200672A")]
	public class HandBookV2LineViewModel
	{
		// Token: 0x06025E13 RID: 155155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E13")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public HandBookV2LineViewModel()
		{
		}

		// Token: 0x04035483 RID: 218243
		[Token(Token = "0x4035483")]
		[FieldOffset(Offset = "0x10")]
		public HandBookV2GroupPosData.LineData data;

		// Token: 0x04035484 RID: 218244
		[Token(Token = "0x4035484")]
		[FieldOffset(Offset = "0x18")]
		public HandBookV2GroupCharViewModel viewModel;
	}
}
