using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x020036B5 RID: 14005
	[Token(Token = "0x20036B5")]
	[Serializable]
	public class BattleCartData
	{
		// Token: 0x06016414 RID: 91156 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016414")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BattleCartData()
		{
		}

		// Token: 0x0401AC35 RID: 109621
		[Token(Token = "0x401AC35")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<CartComponents.CartAccessoryPos, string> cartComponentDict;
	}
}
