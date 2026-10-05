using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000898 RID: 2200
	[Token(Token = "0x2000898")]
	public class SpecialItemInfo
	{
		// Token: 0x06006537 RID: 25911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006537")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SpecialItemInfo()
		{
		}

		// Token: 0x0400324E RID: 12878
		[Token(Token = "0x400324E")]
		[FieldOffset(Offset = "0x10")]
		public bool showPreview;

		// Token: 0x0400324F RID: 12879
		[Token(Token = "0x400324F")]
		[FieldOffset(Offset = "0x18")]
		public string specialDesc;

		// Token: 0x04003250 RID: 12880
		[Token(Token = "0x4003250")]
		[FieldOffset(Offset = "0x20")]
		public string specialBtnText;
	}
}
