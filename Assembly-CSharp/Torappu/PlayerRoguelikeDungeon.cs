using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000AB6 RID: 2742
	[Token(Token = "0x2000AB6")]
	public class PlayerRoguelikeDungeon
	{
		// Token: 0x06006773 RID: 26483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006773")]
		[Address(RVA = "0x1EFC9A0", Offset = "0x1EFB5A0", VA = "0x181EFC9A0")]
		public PlayerRoguelikeDungeon()
		{
		}

		// Token: 0x040039CC RID: 14796
		[Token(Token = "0x40039CC")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<int, PlayerRoguelikeZone> zones;
	}
}
