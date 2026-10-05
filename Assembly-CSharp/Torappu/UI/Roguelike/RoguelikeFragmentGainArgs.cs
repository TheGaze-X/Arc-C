using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200541E RID: 21534
	[Token(Token = "0x200541E")]
	public class RoguelikeFragmentGainArgs
	{
		// Token: 0x0601FAA1 RID: 129697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601FAA1")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeFragmentGainArgs()
		{
		}

		// Token: 0x0402AB4F RID: 174927
		[Token(Token = "0x402AB4F")]
		[FieldOffset(Offset = "0x10")]
		public List<RoguelikeFragmentGainItem> items;
	}
}
