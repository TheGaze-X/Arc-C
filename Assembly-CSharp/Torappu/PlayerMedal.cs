using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000A45 RID: 2629
	[Token(Token = "0x2000A45")]
	public class PlayerMedal
	{
		// Token: 0x06006704 RID: 26372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006704")]
		[Address(RVA = "0x1EFB3A0", Offset = "0x1EF9FA0", VA = "0x181EFB3A0")]
		public PlayerMedal()
		{
		}

		// Token: 0x0400382A RID: 14378
		[Token(Token = "0x400382A")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, PlayerPerMedal> medals;

		// Token: 0x0400382B RID: 14379
		[Token(Token = "0x400382B")]
		[FieldOffset(Offset = "0x18")]
		public PlayerMedalCustom custom;
	}
}
