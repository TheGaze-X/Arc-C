using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x0200006E RID: 110
	[Token(Token = "0x200006E")]
	[AddComponentMenu("Image Effects/Camera/Vignette and Chromatic Aberration")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	public class VignetteAndChromaticAberration : PostEffectsBase
	{
		// Token: 0x0600026C RID: 620 RVA: 0x000029D0 File Offset: 0x00000BD0
		[Token(Token = "0x600026C")]
		[Address(RVA = "0x5302470", Offset = "0x5301070", VA = "0x185302470", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		// Token: 0x0600026D RID: 621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600026D")]
		[Address(RVA = "0x5302570", Offset = "0x5301170", VA = "0x185302570")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0600026E RID: 622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600026E")]
		[Address(RVA = "0x5302BE0", Offset = "0x53017E0", VA = "0x185302BE0")]
		public VignetteAndChromaticAberration()
		{
		}

		// Token: 0x040002D6 RID: 726
		[Token(Token = "0x40002D6")]
		[FieldOffset(Offset = "0x28")]
		public VignetteAndChromaticAberration.AberrationMode mode;

		// Token: 0x040002D7 RID: 727
		[Token(Token = "0x40002D7")]
		[FieldOffset(Offset = "0x2C")]
		public float intensity;

		// Token: 0x040002D8 RID: 728
		[Token(Token = "0x40002D8")]
		[FieldOffset(Offset = "0x30")]
		public float chromaticAberration;

		// Token: 0x040002D9 RID: 729
		[Token(Token = "0x40002D9")]
		[FieldOffset(Offset = "0x34")]
		public float axialAberration;

		// Token: 0x040002DA RID: 730
		[Token(Token = "0x40002DA")]
		[FieldOffset(Offset = "0x38")]
		public float blur;

		// Token: 0x040002DB RID: 731
		[Token(Token = "0x40002DB")]
		[FieldOffset(Offset = "0x3C")]
		public float blurSpread;

		// Token: 0x040002DC RID: 732
		[Token(Token = "0x40002DC")]
		[FieldOffset(Offset = "0x40")]
		public float luminanceDependency;

		// Token: 0x040002DD RID: 733
		[Token(Token = "0x40002DD")]
		[FieldOffset(Offset = "0x44")]
		public float blurDistance;

		// Token: 0x040002DE RID: 734
		[Token(Token = "0x40002DE")]
		[FieldOffset(Offset = "0x48")]
		public Shader vignetteShader;

		// Token: 0x040002DF RID: 735
		[Token(Token = "0x40002DF")]
		[FieldOffset(Offset = "0x50")]
		public Shader separableBlurShader;

		// Token: 0x040002E0 RID: 736
		[Token(Token = "0x40002E0")]
		[FieldOffset(Offset = "0x58")]
		public Shader chromAberrationShader;

		// Token: 0x040002E1 RID: 737
		[Token(Token = "0x40002E1")]
		[FieldOffset(Offset = "0x60")]
		private Material m_VignetteMaterial;

		// Token: 0x040002E2 RID: 738
		[Token(Token = "0x40002E2")]
		[FieldOffset(Offset = "0x68")]
		private Material m_SeparableBlurMaterial;

		// Token: 0x040002E3 RID: 739
		[Token(Token = "0x40002E3")]
		[FieldOffset(Offset = "0x70")]
		private Material m_ChromAberrationMaterial;

		// Token: 0x0200006F RID: 111
		[Token(Token = "0x200006F")]
		public enum AberrationMode
		{
			// Token: 0x040002E5 RID: 741
			[Token(Token = "0x40002E5")]
			Simple,
			// Token: 0x040002E6 RID: 742
			[Token(Token = "0x40002E6")]
			Advanced
		}
	}
}
