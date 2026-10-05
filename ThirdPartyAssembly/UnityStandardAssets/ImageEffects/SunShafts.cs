using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x02000063 RID: 99
	[Token(Token = "0x2000063")]
	[AddComponentMenu("Image Effects/Rendering/Sun Shafts")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	public class SunShafts : PostEffectsBase
	{
		// Token: 0x06000259 RID: 601 RVA: 0x00002940 File Offset: 0x00000B40
		[Token(Token = "0x6000259")]
		[Address(RVA = "0x52FF190", Offset = "0x52FDD90", VA = "0x1852FF190", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		// Token: 0x0600025A RID: 602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600025A")]
		[Address(RVA = "0x52FF220", Offset = "0x52FDE20", VA = "0x1852FF220")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0600025B RID: 603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600025B")]
		[Address(RVA = "0x52FFAB0", Offset = "0x52FE6B0", VA = "0x1852FFAB0")]
		public SunShafts()
		{
		}

		// Token: 0x04000290 RID: 656
		[Token(Token = "0x4000290")]
		[FieldOffset(Offset = "0x28")]
		public SunShafts.SunShaftsResolution resolution;

		// Token: 0x04000291 RID: 657
		[Token(Token = "0x4000291")]
		[FieldOffset(Offset = "0x2C")]
		public SunShafts.ShaftsScreenBlendMode screenBlendMode;

		// Token: 0x04000292 RID: 658
		[Token(Token = "0x4000292")]
		[FieldOffset(Offset = "0x30")]
		public Transform sunTransform;

		// Token: 0x04000293 RID: 659
		[Token(Token = "0x4000293")]
		[FieldOffset(Offset = "0x38")]
		public int radialBlurIterations;

		// Token: 0x04000294 RID: 660
		[Token(Token = "0x4000294")]
		[FieldOffset(Offset = "0x3C")]
		public Color sunColor;

		// Token: 0x04000295 RID: 661
		[Token(Token = "0x4000295")]
		[FieldOffset(Offset = "0x4C")]
		public Color sunThreshold;

		// Token: 0x04000296 RID: 662
		[Token(Token = "0x4000296")]
		[FieldOffset(Offset = "0x5C")]
		public float sunShaftBlurRadius;

		// Token: 0x04000297 RID: 663
		[Token(Token = "0x4000297")]
		[FieldOffset(Offset = "0x60")]
		public float sunShaftIntensity;

		// Token: 0x04000298 RID: 664
		[Token(Token = "0x4000298")]
		[FieldOffset(Offset = "0x64")]
		public float maxRadius;

		// Token: 0x04000299 RID: 665
		[Token(Token = "0x4000299")]
		[FieldOffset(Offset = "0x68")]
		public bool useDepthTexture;

		// Token: 0x0400029A RID: 666
		[Token(Token = "0x400029A")]
		[FieldOffset(Offset = "0x70")]
		public Shader sunShaftsShader;

		// Token: 0x0400029B RID: 667
		[Token(Token = "0x400029B")]
		[FieldOffset(Offset = "0x78")]
		private Material sunShaftsMaterial;

		// Token: 0x0400029C RID: 668
		[Token(Token = "0x400029C")]
		[FieldOffset(Offset = "0x80")]
		public Shader simpleClearShader;

		// Token: 0x0400029D RID: 669
		[Token(Token = "0x400029D")]
		[FieldOffset(Offset = "0x88")]
		private Material simpleClearMaterial;

		// Token: 0x02000064 RID: 100
		[Token(Token = "0x2000064")]
		public enum SunShaftsResolution
		{
			// Token: 0x0400029F RID: 671
			[Token(Token = "0x400029F")]
			Low,
			// Token: 0x040002A0 RID: 672
			[Token(Token = "0x40002A0")]
			Normal,
			// Token: 0x040002A1 RID: 673
			[Token(Token = "0x40002A1")]
			High
		}

		// Token: 0x02000065 RID: 101
		[Token(Token = "0x2000065")]
		public enum ShaftsScreenBlendMode
		{
			// Token: 0x040002A3 RID: 675
			[Token(Token = "0x40002A3")]
			Screen,
			// Token: 0x040002A4 RID: 676
			[Token(Token = "0x40002A4")]
			Add
		}
	}
}
