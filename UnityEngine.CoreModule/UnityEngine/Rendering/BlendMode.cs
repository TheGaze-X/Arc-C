using System;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine.Rendering
{
	// Token: 0x02000248 RID: 584
	[Token(Token = "0x2000248")]
	[NativeHeader("Runtime/GfxDevice/GfxDeviceTypes.h")]
	public enum BlendMode
	{
		// Token: 0x0400064E RID: 1614
		[Token(Token = "0x400064E")]
		Zero,
		// Token: 0x0400064F RID: 1615
		[Token(Token = "0x400064F")]
		One,
		// Token: 0x04000650 RID: 1616
		[Token(Token = "0x4000650")]
		DstColor,
		// Token: 0x04000651 RID: 1617
		[Token(Token = "0x4000651")]
		SrcColor,
		// Token: 0x04000652 RID: 1618
		[Token(Token = "0x4000652")]
		OneMinusDstColor,
		// Token: 0x04000653 RID: 1619
		[Token(Token = "0x4000653")]
		SrcAlpha,
		// Token: 0x04000654 RID: 1620
		[Token(Token = "0x4000654")]
		OneMinusSrcColor,
		// Token: 0x04000655 RID: 1621
		[Token(Token = "0x4000655")]
		DstAlpha,
		// Token: 0x04000656 RID: 1622
		[Token(Token = "0x4000656")]
		OneMinusDstAlpha,
		// Token: 0x04000657 RID: 1623
		[Token(Token = "0x4000657")]
		SrcAlphaSaturate,
		// Token: 0x04000658 RID: 1624
		[Token(Token = "0x4000658")]
		OneMinusSrcAlpha
	}
}
