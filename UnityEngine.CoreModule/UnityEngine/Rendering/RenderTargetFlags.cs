using System;
using Il2CppDummyDll;

namespace UnityEngine.Rendering
{
	// Token: 0x02000256 RID: 598
	[Token(Token = "0x2000256")]
	[Flags]
	public enum RenderTargetFlags
	{
		// Token: 0x040006EB RID: 1771
		[Token(Token = "0x40006EB")]
		None = 0,
		// Token: 0x040006EC RID: 1772
		[Token(Token = "0x40006EC")]
		ReadOnlyDepth = 1,
		// Token: 0x040006ED RID: 1773
		[Token(Token = "0x40006ED")]
		ReadOnlyStencil = 2,
		// Token: 0x040006EE RID: 1774
		[Token(Token = "0x40006EE")]
		ReadOnlyDepthStencil = 3
	}
}
