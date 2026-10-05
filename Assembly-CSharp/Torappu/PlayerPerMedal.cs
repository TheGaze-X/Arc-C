using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000A41 RID: 2625
	[Token(Token = "0x2000A41")]
	public class PlayerPerMedal
	{
		// Token: 0x06006700 RID: 26368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006700")]
		[Address(RVA = "0x1EFC070", Offset = "0x1EFAC70", VA = "0x181EFC070")]
		public PlayerPerMedal()
		{
		}

		// Token: 0x04003820 RID: 14368
		[Token(Token = "0x4003820")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x04003821 RID: 14369
		[Token(Token = "0x4003821")]
		[FieldOffset(Offset = "0x18")]
		public List<int[]> val;

		// Token: 0x04003822 RID: 14370
		[Token(Token = "0x4003822")]
		[FieldOffset(Offset = "0x20")]
		public long fts;

		// Token: 0x04003823 RID: 14371
		[Token(Token = "0x4003823")]
		[FieldOffset(Offset = "0x28")]
		public long rts;

		// Token: 0x04003824 RID: 14372
		[Token(Token = "0x4003824")]
		[FieldOffset(Offset = "0x30")]
		public string reward;
	}
}
