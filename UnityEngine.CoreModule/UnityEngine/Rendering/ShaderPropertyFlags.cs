using System;
using Il2CppDummyDll;

namespace UnityEngine.Rendering
{
	// Token: 0x0200027D RID: 637
	[Token(Token = "0x200027D")]
	[Flags]
	public enum ShaderPropertyFlags
	{
		// Token: 0x040007C3 RID: 1987
		[Token(Token = "0x40007C3")]
		None = 0,
		// Token: 0x040007C4 RID: 1988
		[Token(Token = "0x40007C4")]
		HideInInspector = 1,
		// Token: 0x040007C5 RID: 1989
		[Token(Token = "0x40007C5")]
		PerRendererData = 2,
		// Token: 0x040007C6 RID: 1990
		[Token(Token = "0x40007C6")]
		NoScaleOffset = 4,
		// Token: 0x040007C7 RID: 1991
		[Token(Token = "0x40007C7")]
		Normal = 8,
		// Token: 0x040007C8 RID: 1992
		[Token(Token = "0x40007C8")]
		HDR = 16,
		// Token: 0x040007C9 RID: 1993
		[Token(Token = "0x40007C9")]
		Gamma = 32,
		// Token: 0x040007CA RID: 1994
		[Token(Token = "0x40007CA")]
		NonModifiableTextureData = 64,
		// Token: 0x040007CB RID: 1995
		[Token(Token = "0x40007CB")]
		MainTexture = 128,
		// Token: 0x040007CC RID: 1996
		[Token(Token = "0x40007CC")]
		MainColor = 256
	}
}
