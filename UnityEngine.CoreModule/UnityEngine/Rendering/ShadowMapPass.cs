using System;
using Il2CppDummyDll;

namespace UnityEngine.Rendering
{
	// Token: 0x0200024F RID: 591
	[Token(Token = "0x200024F")]
	[Flags]
	public enum ShadowMapPass
	{
		// Token: 0x04000694 RID: 1684
		[Token(Token = "0x4000694")]
		PointlightPositiveX = 1,
		// Token: 0x04000695 RID: 1685
		[Token(Token = "0x4000695")]
		PointlightNegativeX = 2,
		// Token: 0x04000696 RID: 1686
		[Token(Token = "0x4000696")]
		PointlightPositiveY = 4,
		// Token: 0x04000697 RID: 1687
		[Token(Token = "0x4000697")]
		PointlightNegativeY = 8,
		// Token: 0x04000698 RID: 1688
		[Token(Token = "0x4000698")]
		PointlightPositiveZ = 16,
		// Token: 0x04000699 RID: 1689
		[Token(Token = "0x4000699")]
		PointlightNegativeZ = 32,
		// Token: 0x0400069A RID: 1690
		[Token(Token = "0x400069A")]
		DirectionalCascade0 = 64,
		// Token: 0x0400069B RID: 1691
		[Token(Token = "0x400069B")]
		DirectionalCascade1 = 128,
		// Token: 0x0400069C RID: 1692
		[Token(Token = "0x400069C")]
		DirectionalCascade2 = 256,
		// Token: 0x0400069D RID: 1693
		[Token(Token = "0x400069D")]
		DirectionalCascade3 = 512,
		// Token: 0x0400069E RID: 1694
		[Token(Token = "0x400069E")]
		Spotlight = 1024,
		// Token: 0x0400069F RID: 1695
		[Token(Token = "0x400069F")]
		Pointlight = 63,
		// Token: 0x040006A0 RID: 1696
		[Token(Token = "0x40006A0")]
		Directional = 960,
		// Token: 0x040006A1 RID: 1697
		[Token(Token = "0x40006A1")]
		All = 2047
	}
}
