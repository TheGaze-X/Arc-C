using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200111F RID: 4383
	[Token(Token = "0x200111F")]
	public class TotalCheckinData
	{
		// Token: 0x06006EE1 RID: 28385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EE1")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public TotalCheckinData()
		{
		}

		// Token: 0x04005DEE RID: 24046
		[Token(Token = "0x4005DEE")]
		[FieldOffset(Offset = "0x10")]
		public int order;

		// Token: 0x04005DEF RID: 24047
		[Token(Token = "0x4005DEF")]
		[FieldOffset(Offset = "0x18")]
		public OpenServerItemData item;

		// Token: 0x04005DF0 RID: 24048
		[Token(Token = "0x4005DF0")]
		[FieldOffset(Offset = "0x20")]
		public int colorId;
	}
}
