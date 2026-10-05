using System;
using Il2CppDummyDll;
using UnityEngine.Scripting;

namespace UnityEngine.TextCore.LowLevel
{
	// Token: 0x0200000A RID: 10
	[Token(Token = "0x200000A")]
	[UsedByNativeCode]
	public enum GlyphPackingMode
	{
		// Token: 0x04000056 RID: 86
		[Token(Token = "0x4000056")]
		BestShortSideFit,
		// Token: 0x04000057 RID: 87
		[Token(Token = "0x4000057")]
		BestLongSideFit,
		// Token: 0x04000058 RID: 88
		[Token(Token = "0x4000058")]
		BestAreaFit,
		// Token: 0x04000059 RID: 89
		[Token(Token = "0x4000059")]
		BottomLeftRule,
		// Token: 0x0400005A RID: 90
		[Token(Token = "0x400005A")]
		ContactPointRule
	}
}
