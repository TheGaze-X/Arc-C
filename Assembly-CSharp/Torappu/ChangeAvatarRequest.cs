using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020007D0 RID: 2000
	[Token(Token = "0x20007D0")]
	public class ChangeAvatarRequest
	{
		// Token: 0x06006455 RID: 25685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006455")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ChangeAvatarRequest()
		{
		}

		// Token: 0x040030DF RID: 12511
		[Token(Token = "0x40030DF")]
		[FieldOffset(Offset = "0x10")]
		public PlayerAvatarType type;

		// Token: 0x040030E0 RID: 12512
		[Token(Token = "0x40030E0")]
		[FieldOffset(Offset = "0x18")]
		public string id;
	}
}
