using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000AB5 RID: 2741
	[Token(Token = "0x2000AB5")]
	public class PlayerRoguelikeZone
	{
		// Token: 0x06006772 RID: 26482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006772")]
		[Address(RVA = "0x1EFD210", Offset = "0x1EFBE10", VA = "0x181EFD210")]
		public PlayerRoguelikeZone()
		{
		}

		// Token: 0x040039CA RID: 14794
		[Token(Token = "0x40039CA")]
		[FieldOffset(Offset = "0x10")]
		public string zoneId;

		// Token: 0x040039CB RID: 14795
		[Token(Token = "0x40039CB")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<int, PlayerRoguelikeNode> nodes;
	}
}
