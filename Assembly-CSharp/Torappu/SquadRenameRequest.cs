using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020008AB RID: 2219
	[Token(Token = "0x20008AB")]
	public class SquadRenameRequest
	{
		// Token: 0x06006555 RID: 25941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006555")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SquadRenameRequest()
		{
		}

		// Token: 0x0400327C RID: 12924
		[Token(Token = "0x400327C")]
		[FieldOffset(Offset = "0x10")]
		public string squadId;

		// Token: 0x0400327D RID: 12925
		[Token(Token = "0x400327D")]
		[FieldOffset(Offset = "0x18")]
		public string name;
	}
}
