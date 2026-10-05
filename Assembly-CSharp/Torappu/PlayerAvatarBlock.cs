using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000A49 RID: 2633
	[Token(Token = "0x2000A49")]
	public class PlayerAvatarBlock
	{
		// Token: 0x06006708 RID: 26376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006708")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PlayerAvatarBlock()
		{
		}

		// Token: 0x04003834 RID: 14388
		[Token(Token = "0x4003834")]
		[FieldOffset(Offset = "0x10")]
		public long ts;

		// Token: 0x04003835 RID: 14389
		[Token(Token = "0x4003835")]
		[FieldOffset(Offset = "0x18")]
		public string src;
	}
}
