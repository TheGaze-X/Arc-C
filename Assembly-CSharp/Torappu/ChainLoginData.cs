using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200111E RID: 4382
	[Token(Token = "0x200111E")]
	public class ChainLoginData
	{
		// Token: 0x06006EE0 RID: 28384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006EE0")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ChainLoginData()
		{
		}

		// Token: 0x04005DEB RID: 24043
		[Token(Token = "0x4005DEB")]
		[FieldOffset(Offset = "0x10")]
		public int order;

		// Token: 0x04005DEC RID: 24044
		[Token(Token = "0x4005DEC")]
		[FieldOffset(Offset = "0x18")]
		public OpenServerItemData item;

		// Token: 0x04005DED RID: 24045
		[Token(Token = "0x4005DED")]
		[FieldOffset(Offset = "0x20")]
		public int colorId;
	}
}
