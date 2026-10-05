using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000A44 RID: 2628
	[Token(Token = "0x2000A44")]
	public class PlayerMedalCustom
	{
		// Token: 0x06006703 RID: 26371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006703")]
		[Address(RVA = "0x1EFB310", Offset = "0x1EF9F10", VA = "0x181EFB310")]
		public PlayerMedalCustom()
		{
		}

		// Token: 0x04003828 RID: 14376
		[Token(Token = "0x4003828")]
		[FieldOffset(Offset = "0x10")]
		public string currentIndex;

		// Token: 0x04003829 RID: 14377
		[Token(Token = "0x4003829")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, PlayerMedalCustomLayout> customs;
	}
}
