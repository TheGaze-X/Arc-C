using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020009F7 RID: 2551
	[Token(Token = "0x20009F7")]
	public class PlayerSixStar
	{
		// Token: 0x060066BD RID: 26301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066BD")]
		[Address(RVA = "0x1EFE740", Offset = "0x1EFD340", VA = "0x181EFE740")]
		public PlayerSixStar()
		{
		}

		// Token: 0x0400373A RID: 14138
		[Token(Token = "0x400373A")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, PlayerSixStarStage> stages;

		// Token: 0x0400373B RID: 14139
		[Token(Token = "0x400373B")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, PlayerSixStarMilestone> groups;
	}
}
