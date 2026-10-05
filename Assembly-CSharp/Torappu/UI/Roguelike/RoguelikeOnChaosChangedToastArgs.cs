using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200541C RID: 21532
	[Token(Token = "0x200541C")]
	public class RoguelikeOnChaosChangedToastArgs
	{
		// Token: 0x0601FA9F RID: 129695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FA9F")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeOnChaosChangedToastArgs()
		{
		}

		// Token: 0x0402AB4B RID: 174923
		[Token(Token = "0x402AB4B")]
		[FieldOffset(Offset = "0x10")]
		public bool upgrade;

		// Token: 0x0402AB4C RID: 174924
		[Token(Token = "0x402AB4C")]
		[FieldOffset(Offset = "0x18")]
		public List<string> chaosIds;
	}
}
