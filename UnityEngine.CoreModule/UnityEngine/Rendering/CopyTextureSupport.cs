using System;
using Il2CppDummyDll;

namespace UnityEngine.Rendering
{
	// Token: 0x02000263 RID: 611
	[Token(Token = "0x2000263")]
	[Flags]
	public enum CopyTextureSupport
	{
		// Token: 0x04000728 RID: 1832
		[Token(Token = "0x4000728")]
		None = 0,
		// Token: 0x04000729 RID: 1833
		[Token(Token = "0x4000729")]
		Basic = 1,
		// Token: 0x0400072A RID: 1834
		[Token(Token = "0x400072A")]
		Copy3D = 2,
		// Token: 0x0400072B RID: 1835
		[Token(Token = "0x400072B")]
		DifferentTypes = 4,
		// Token: 0x0400072C RID: 1836
		[Token(Token = "0x400072C")]
		TextureToRT = 8,
		// Token: 0x0400072D RID: 1837
		[Token(Token = "0x400072D")]
		RTToTexture = 16
	}
}
