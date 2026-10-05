using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.Roguelike.RL03
{
	// Token: 0x02005848 RID: 22600
	[Token(Token = "0x2005848")]
	public class RL03UseTotemResponse : PlayerDeltaResponse
	{
		// Token: 0x06021052 RID: 135250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021052")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public RL03UseTotemResponse()
		{
		}

		// Token: 0x0402CEA0 RID: 183968
		[Token(Token = "0x402CEA0")]
		[FieldOffset(Offset = "0x28")]
		public List<string> nodeIndex;
	}
}
