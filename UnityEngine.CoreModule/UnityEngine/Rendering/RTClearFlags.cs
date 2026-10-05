using System;
using Il2CppDummyDll;

namespace UnityEngine.Rendering
{
	// Token: 0x02000267 RID: 615
	[Token(Token = "0x2000267")]
	[Flags]
	public enum RTClearFlags
	{
		// Token: 0x0400073B RID: 1851
		[Token(Token = "0x400073B")]
		None = 0,
		// Token: 0x0400073C RID: 1852
		[Token(Token = "0x400073C")]
		Color = 1,
		// Token: 0x0400073D RID: 1853
		[Token(Token = "0x400073D")]
		Depth = 2,
		// Token: 0x0400073E RID: 1854
		[Token(Token = "0x400073E")]
		Stencil = 4,
		// Token: 0x0400073F RID: 1855
		[Token(Token = "0x400073F")]
		All = 7,
		// Token: 0x04000740 RID: 1856
		[Token(Token = "0x4000740")]
		DepthStencil = 6,
		// Token: 0x04000741 RID: 1857
		[Token(Token = "0x4000741")]
		ColorDepth = 3,
		// Token: 0x04000742 RID: 1858
		[Token(Token = "0x4000742")]
		ColorStencil = 5
	}
}
