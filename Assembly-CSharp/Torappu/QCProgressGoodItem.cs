using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200086F RID: 2159
	[Token(Token = "0x200086F")]
	public class QCProgressGoodItem
	{
		// Token: 0x06006508 RID: 25864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006508")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public QCProgressGoodItem()
		{
		}

		// Token: 0x040031D6 RID: 12758
		[Token(Token = "0x40031D6")]
		[FieldOffset(Offset = "0x10")]
		public int order;

		// Token: 0x040031D7 RID: 12759
		[Token(Token = "0x40031D7")]
		[FieldOffset(Offset = "0x14")]
		public int price;

		// Token: 0x040031D8 RID: 12760
		[Token(Token = "0x40031D8")]
		[FieldOffset(Offset = "0x18")]
		public string displayName;

		// Token: 0x040031D9 RID: 12761
		[Token(Token = "0x40031D9")]
		[FieldOffset(Offset = "0x20")]
		public ItemBundle item;
	}
}
