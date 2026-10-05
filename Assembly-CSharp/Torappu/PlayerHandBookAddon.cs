using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000901 RID: 2305
	[Token(Token = "0x2000901")]
	public class PlayerHandBookAddon
	{
		// Token: 0x060065D9 RID: 26073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065D9")]
		[Address(RVA = "0x1EFABB0", Offset = "0x1EF97B0", VA = "0x181EFABB0")]
		public PlayerHandBookAddon()
		{
		}

		// Token: 0x040033A1 RID: 13217
		[Token(Token = "0x40033A1")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, PlayerHandBookAddon.GetInfo> stage;

		// Token: 0x040033A2 RID: 13218
		[Token(Token = "0x40033A2")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, PlayerHandBookAddon.GetInfo> story;

		// Token: 0x02000902 RID: 2306
		[Token(Token = "0x2000902")]
		public class GetInfo
		{
			// Token: 0x060065DA RID: 26074 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60065DA")]
			[Address(RVA = "0x1EEA6C0", Offset = "0x1EE92C0", VA = "0x181EEA6C0")]
			public GetInfo()
			{
			}

			// Token: 0x040033A3 RID: 13219
			[Token(Token = "0x40033A3")]
			[FieldOffset(Offset = "0x10")]
			public long fts;

			// Token: 0x040033A4 RID: 13220
			[Token(Token = "0x40033A4")]
			[FieldOffset(Offset = "0x18")]
			public long rts;
		}
	}
}
