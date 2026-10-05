using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000A30 RID: 2608
	[Token(Token = "0x2000A30")]
	public class PlayerInviteData
	{
		// Token: 0x060066EE RID: 26350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066EE")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PlayerInviteData()
		{
		}

		// Token: 0x040037EE RID: 14318
		[Token(Token = "0x40037EE")]
		[FieldOffset(Offset = "0x10")]
		public bool closeAccept;

		// Token: 0x040037EF RID: 14319
		[Token(Token = "0x40037EF")]
		[FieldOffset(Offset = "0x11")]
		public bool newInvite;

		// Token: 0x040037F0 RID: 14320
		[Token(Token = "0x40037F0")]
		[FieldOffset(Offset = "0x18")]
		public List<PlayerInviteInfo> inviteList;
	}
}
