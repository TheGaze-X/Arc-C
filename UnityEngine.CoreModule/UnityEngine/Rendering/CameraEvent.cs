using System;
using Il2CppDummyDll;

namespace UnityEngine.Rendering
{
	// Token: 0x0200024C RID: 588
	[Token(Token = "0x200024C")]
	public enum CameraEvent
	{
		// Token: 0x04000673 RID: 1651
		[Token(Token = "0x4000673")]
		BeforeDepthTexture,
		// Token: 0x04000674 RID: 1652
		[Token(Token = "0x4000674")]
		AfterDepthTexture,
		// Token: 0x04000675 RID: 1653
		[Token(Token = "0x4000675")]
		BeforeDepthNormalsTexture,
		// Token: 0x04000676 RID: 1654
		[Token(Token = "0x4000676")]
		AfterDepthNormalsTexture,
		// Token: 0x04000677 RID: 1655
		[Token(Token = "0x4000677")]
		BeforeGBuffer,
		// Token: 0x04000678 RID: 1656
		[Token(Token = "0x4000678")]
		AfterGBuffer,
		// Token: 0x04000679 RID: 1657
		[Token(Token = "0x4000679")]
		BeforeLighting,
		// Token: 0x0400067A RID: 1658
		[Token(Token = "0x400067A")]
		AfterLighting,
		// Token: 0x0400067B RID: 1659
		[Token(Token = "0x400067B")]
		BeforeFinalPass,
		// Token: 0x0400067C RID: 1660
		[Token(Token = "0x400067C")]
		AfterFinalPass,
		// Token: 0x0400067D RID: 1661
		[Token(Token = "0x400067D")]
		BeforeForwardOpaque,
		// Token: 0x0400067E RID: 1662
		[Token(Token = "0x400067E")]
		AfterForwardOpaque,
		// Token: 0x0400067F RID: 1663
		[Token(Token = "0x400067F")]
		BeforeImageEffectsOpaque,
		// Token: 0x04000680 RID: 1664
		[Token(Token = "0x4000680")]
		AfterImageEffectsOpaque,
		// Token: 0x04000681 RID: 1665
		[Token(Token = "0x4000681")]
		BeforeSkybox,
		// Token: 0x04000682 RID: 1666
		[Token(Token = "0x4000682")]
		AfterSkybox,
		// Token: 0x04000683 RID: 1667
		[Token(Token = "0x4000683")]
		BeforeForwardAlpha,
		// Token: 0x04000684 RID: 1668
		[Token(Token = "0x4000684")]
		AfterForwardAlpha,
		// Token: 0x04000685 RID: 1669
		[Token(Token = "0x4000685")]
		BeforeImageEffects,
		// Token: 0x04000686 RID: 1670
		[Token(Token = "0x4000686")]
		AfterImageEffects,
		// Token: 0x04000687 RID: 1671
		[Token(Token = "0x4000687")]
		AfterEverything,
		// Token: 0x04000688 RID: 1672
		[Token(Token = "0x4000688")]
		BeforeReflections,
		// Token: 0x04000689 RID: 1673
		[Token(Token = "0x4000689")]
		AfterReflections,
		// Token: 0x0400068A RID: 1674
		[Token(Token = "0x400068A")]
		BeforeHaloAndLensFlares,
		// Token: 0x0400068B RID: 1675
		[Token(Token = "0x400068B")]
		AfterHaloAndLensFlares
	}
}
