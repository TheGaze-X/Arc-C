using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000A3D RID: 2621
	[Token(Token = "0x2000A3D")]
	public class PlayerEnemyHandBook
	{
		// Token: 0x060066FC RID: 26364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066FC")]
		[Address(RVA = "0x1EF9F40", Offset = "0x1EF8B40", VA = "0x181EF9F40")]
		public PlayerEnemyHandBook()
		{
		}

		// Token: 0x04003817 RID: 14359
		[Token(Token = "0x4003817")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, int> enemies;

		// Token: 0x04003818 RID: 14360
		[Token(Token = "0x4003818")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, List<string>> stage;
	}
}
