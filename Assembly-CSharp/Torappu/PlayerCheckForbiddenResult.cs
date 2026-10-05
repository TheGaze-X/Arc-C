using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200077E RID: 1918
	[Token(Token = "0x200077E")]
	public class PlayerCheckForbiddenResult : PlayerSyncResult
	{
		// Token: 0x060063F7 RID: 25591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063F7")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PlayerCheckForbiddenResult()
		{
		}

		// Token: 0x0400301E RID: 12318
		[Token(Token = "0x400301E")]
		[FieldOffset(Offset = "0x10")]
		public List<string> gacha;

		// Token: 0x0400301F RID: 12319
		[Token(Token = "0x400301F")]
		[FieldOffset(Offset = "0x18")]
		public List<string> shop;
	}
}
