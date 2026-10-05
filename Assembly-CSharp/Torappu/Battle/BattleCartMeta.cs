using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Battle
{
	// Token: 0x020020A5 RID: 8357
	[Token(Token = "0x20020A5")]
	public struct BattleCartMeta
	{
		// Token: 0x0400D920 RID: 55584
		[Token(Token = "0x400D920")]
		[FieldOffset(Offset = "0x0")]
		public Dictionary<CartComponents.CartAccessoryPos, string> cartComponentDict;
	}
}
