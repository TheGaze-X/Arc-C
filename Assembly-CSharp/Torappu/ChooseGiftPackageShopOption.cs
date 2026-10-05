using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000896 RID: 2198
	[Token(Token = "0x2000896")]
	public class ChooseGiftPackageShopOption
	{
		// Token: 0x06006535 RID: 25909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006535")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ChooseGiftPackageShopOption()
		{
		}

		// Token: 0x04003239 RID: 12857
		[Token(Token = "0x4003239")]
		[FieldOffset(Offset = "0x10")]
		public string goodId;

		// Token: 0x0400323A RID: 12858
		[Token(Token = "0x400323A")]
		[FieldOffset(Offset = "0x18")]
		public string OptionId;

		// Token: 0x0400323B RID: 12859
		[Token(Token = "0x400323B")]
		[FieldOffset(Offset = "0x20")]
		public int orderNum;

		// Token: 0x0400323C RID: 12860
		[Token(Token = "0x400323C")]
		[FieldOffset(Offset = "0x28")]
		public ItemBundle item;
	}
}
