using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000A2F RID: 2607
	[Token(Token = "0x2000A2F")]
	public class PlayerInviteInfo
	{
		// Token: 0x060066ED RID: 26349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066ED")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PlayerInviteInfo()
		{
		}

		// Token: 0x040037EA RID: 14314
		[Token(Token = "0x40037EA")]
		[FieldOffset(Offset = "0x10")]
		public string uid;

		// Token: 0x040037EB RID: 14315
		[Token(Token = "0x40037EB")]
		[FieldOffset(Offset = "0x18")]
		public int idx;

		// Token: 0x040037EC RID: 14316
		[Token(Token = "0x40037EC")]
		[FieldOffset(Offset = "0x20")]
		public long ts;

		// Token: 0x040037ED RID: 14317
		[Token(Token = "0x40037ED")]
		[FieldOffset(Offset = "0x28")]
		public List<string> msg;
	}
}
