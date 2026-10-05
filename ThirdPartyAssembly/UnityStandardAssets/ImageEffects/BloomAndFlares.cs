using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x02000038 RID: 56
	[Token(Token = "0x2000038")]
	[AddComponentMenu("Image Effects/Bloom and Glow/BloomAndFlares (3.5, Deprecated)")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	public class BloomAndFlares : PostEffectsBase
	{
		// Token: 0x060001AC RID: 428 RVA: 0x00002688 File Offset: 0x00000888
		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x51D3E70", Offset = "0x51D2A70", VA = "0x1851D3E70", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x51D3FF0", Offset = "0x51D2BF0", VA = "0x1851D3FF0")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001AE")]
		[Address(RVA = "0x51D3AE0", Offset = "0x51D26E0", VA = "0x1851D3AE0")]
		private void AddTo(float intensity_, RenderTexture from, RenderTexture to)
		{
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001AF")]
		[Address(RVA = "0x51D3B90", Offset = "0x51D2790", VA = "0x1851D3B90")]
		private void BlendFlares(RenderTexture from, RenderTexture to)
		{
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001B0")]
		[Address(RVA = "0x51D3D40", Offset = "0x51D2940", VA = "0x1851D3D40")]
		private void BrightFilter(float thresh, float useAlphaAsMask, RenderTexture from, RenderTexture to)
		{
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001B1")]
		[Address(RVA = "0x51D4CB0", Offset = "0x51D38B0", VA = "0x1851D4CB0")]
		private void Vignette(float amount, RenderTexture from, RenderTexture to)
		{
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001B2")]
		[Address(RVA = "0x51D4E10", Offset = "0x51D3A10", VA = "0x1851D4E10")]
		public BloomAndFlares()
		{
		}

		// Token: 0x04000125 RID: 293
		[Token(Token = "0x4000125")]
		[FieldOffset(Offset = "0x28")]
		public TweakMode34 tweakMode;

		// Token: 0x04000126 RID: 294
		[Token(Token = "0x4000126")]
		[FieldOffset(Offset = "0x2C")]
		public BloomScreenBlendMode screenBlendMode;

		// Token: 0x04000127 RID: 295
		[Token(Token = "0x4000127")]
		[FieldOffset(Offset = "0x30")]
		public HDRBloomMode hdr;

		// Token: 0x04000128 RID: 296
		[Token(Token = "0x4000128")]
		[FieldOffset(Offset = "0x34")]
		private bool doHdr;

		// Token: 0x04000129 RID: 297
		[Token(Token = "0x4000129")]
		[FieldOffset(Offset = "0x38")]
		public float sepBlurSpread;

		// Token: 0x0400012A RID: 298
		[Token(Token = "0x400012A")]
		[FieldOffset(Offset = "0x3C")]
		public float useSrcAlphaAsMask;

		// Token: 0x0400012B RID: 299
		[Token(Token = "0x400012B")]
		[FieldOffset(Offset = "0x40")]
		public float bloomIntensity;

		// Token: 0x0400012C RID: 300
		[Token(Token = "0x400012C")]
		[FieldOffset(Offset = "0x44")]
		public float bloomThreshold;

		// Token: 0x0400012D RID: 301
		[Token(Token = "0x400012D")]
		[FieldOffset(Offset = "0x48")]
		public int bloomBlurIterations;

		// Token: 0x0400012E RID: 302
		[Token(Token = "0x400012E")]
		[FieldOffset(Offset = "0x4C")]
		public bool lensflares;

		// Token: 0x0400012F RID: 303
		[Token(Token = "0x400012F")]
		[FieldOffset(Offset = "0x50")]
		public int hollywoodFlareBlurIterations;

		// Token: 0x04000130 RID: 304
		[Token(Token = "0x4000130")]
		[FieldOffset(Offset = "0x54")]
		public LensflareStyle34 lensflareMode;

		// Token: 0x04000131 RID: 305
		[Token(Token = "0x4000131")]
		[FieldOffset(Offset = "0x58")]
		public float hollyStretchWidth;

		// Token: 0x04000132 RID: 306
		[Token(Token = "0x4000132")]
		[FieldOffset(Offset = "0x5C")]
		public float lensflareIntensity;

		// Token: 0x04000133 RID: 307
		[Token(Token = "0x4000133")]
		[FieldOffset(Offset = "0x60")]
		public float lensflareThreshold;

		// Token: 0x04000134 RID: 308
		[Token(Token = "0x4000134")]
		[FieldOffset(Offset = "0x64")]
		public Color flareColorA;

		// Token: 0x04000135 RID: 309
		[Token(Token = "0x4000135")]
		[FieldOffset(Offset = "0x74")]
		public Color flareColorB;

		// Token: 0x04000136 RID: 310
		[Token(Token = "0x4000136")]
		[FieldOffset(Offset = "0x84")]
		public Color flareColorC;

		// Token: 0x04000137 RID: 311
		[Token(Token = "0x4000137")]
		[FieldOffset(Offset = "0x94")]
		public Color flareColorD;

		// Token: 0x04000138 RID: 312
		[Token(Token = "0x4000138")]
		[FieldOffset(Offset = "0xA8")]
		public Texture2D lensFlareVignetteMask;

		// Token: 0x04000139 RID: 313
		[Token(Token = "0x4000139")]
		[FieldOffset(Offset = "0xB0")]
		public Shader lensFlareShader;

		// Token: 0x0400013A RID: 314
		[Token(Token = "0x400013A")]
		[FieldOffset(Offset = "0xB8")]
		private Material lensFlareMaterial;

		// Token: 0x0400013B RID: 315
		[Token(Token = "0x400013B")]
		[FieldOffset(Offset = "0xC0")]
		public Shader vignetteShader;

		// Token: 0x0400013C RID: 316
		[Token(Token = "0x400013C")]
		[FieldOffset(Offset = "0xC8")]
		private Material vignetteMaterial;

		// Token: 0x0400013D RID: 317
		[Token(Token = "0x400013D")]
		[FieldOffset(Offset = "0xD0")]
		public Shader separableBlurShader;

		// Token: 0x0400013E RID: 318
		[Token(Token = "0x400013E")]
		[FieldOffset(Offset = "0xD8")]
		private Material separableBlurMaterial;

		// Token: 0x0400013F RID: 319
		[Token(Token = "0x400013F")]
		[FieldOffset(Offset = "0xE0")]
		public Shader addBrightStuffOneOneShader;

		// Token: 0x04000140 RID: 320
		[Token(Token = "0x4000140")]
		[FieldOffset(Offset = "0xE8")]
		private Material addBrightStuffBlendOneOneMaterial;

		// Token: 0x04000141 RID: 321
		[Token(Token = "0x4000141")]
		[FieldOffset(Offset = "0xF0")]
		public Shader screenBlendShader;

		// Token: 0x04000142 RID: 322
		[Token(Token = "0x4000142")]
		[FieldOffset(Offset = "0xF8")]
		private Material screenBlend;

		// Token: 0x04000143 RID: 323
		[Token(Token = "0x4000143")]
		[FieldOffset(Offset = "0x100")]
		public Shader hollywoodFlaresShader;

		// Token: 0x04000144 RID: 324
		[Token(Token = "0x4000144")]
		[FieldOffset(Offset = "0x108")]
		private Material hollywoodFlaresMaterial;

		// Token: 0x04000145 RID: 325
		[Token(Token = "0x4000145")]
		[FieldOffset(Offset = "0x110")]
		public Shader brightPassFilterShader;

		// Token: 0x04000146 RID: 326
		[Token(Token = "0x4000146")]
		[FieldOffset(Offset = "0x118")]
		private Material brightPassFilterMaterial;
	}
}
