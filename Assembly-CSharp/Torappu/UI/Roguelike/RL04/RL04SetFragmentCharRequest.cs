using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.Roguelike.RL04
{
	// Token: 0x0200570A RID: 22282
	[Token(Token = "0x200570A")]
	public class RL04SetFragmentCharRequest
	{
		// Token: 0x06020AC5 RID: 133829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020AC5")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RL04SetFragmentCharRequest()
		{
		}

		// Token: 0x0402C577 RID: 181623
		[Token(Token = "0x402C577")]
		[FieldOffset(Offset = "0x10")]
		public List<string> troopCarry;
	}
}
