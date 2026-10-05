using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x0200002E RID: 46
	[Token(Token = "0x200002E")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Bloom and Glow/Bloom")]
	public class Bloom : PostEffectsBase
	{
		// Token: 0x060001A4 RID: 420 RVA: 0x00002670 File Offset: 0x00000870
		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x51D5850", Offset = "0x51D4450", VA = "0x1851D5850", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x51D5950", Offset = "0x51D4550", VA = "0x1851D5950")]
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001A6")]
		[Address(RVA = "0x51D53E0", Offset = "0x51D3FE0", VA = "0x1851D53E0")]
		private void AddTo(float intensity_, RenderTexture from, RenderTexture to)
		{
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001A7")]
		[Address(RVA = "0x51D54B0", Offset = "0x51D40B0", VA = "0x1851D54B0")]
		private void BlendFlares(RenderTexture from, RenderTexture to)
		{
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001A8")]
		[Address(RVA = "0x51D5680", Offset = "0x51D4280", VA = "0x1851D5680")]
		private void BrightFilter(float thresh, RenderTexture from, RenderTexture to)
		{
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001A9")]
		[Address(RVA = "0x51D5750", Offset = "0x51D4350", VA = "0x1851D5750")]
		private void BrightFilter(Color threshColor, RenderTexture from, RenderTexture to)
		{
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001AA")]
		[Address(RVA = "0x51D6A50", Offset = "0x51D5650", VA = "0x1851D6A50")]
		private void Vignette(float amount, RenderTexture from, RenderTexture to)
		{
		}

		// Token: 0x060001AB RID: 427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001AB")]
		[Address(RVA = "0x51D6C40", Offset = "0x51D5840", VA = "0x1851D6C40")]
		public Bloom()
		{
		}

		// Token: 0x040000E8 RID: 232
		[Token(Token = "0x40000E8")]
		[FieldOffset(Offset = "0x28")]
		public Bloom.TweakMode tweakMode;

		// Token: 0x040000E9 RID: 233
		[Token(Token = "0x40000E9")]
		[FieldOffset(Offset = "0x2C")]
		public Bloom.BloomScreenBlendMode screenBlendMode;

		// Token: 0x040000EA RID: 234
		[Token(Token = "0x40000EA")]
		[FieldOffset(Offset = "0x30")]
		public Bloom.HDRBloomMode hdr;

		// Token: 0x040000EB RID: 235
		[Token(Token = "0x40000EB")]
		[FieldOffset(Offset = "0x34")]
		private bool doHdr;

		// Token: 0x040000EC RID: 236
		[Token(Token = "0x40000EC")]
		[FieldOffset(Offset = "0x38")]
		public float sepBlurSpread;

		// Token: 0x040000ED RID: 237
		[Token(Token = "0x40000ED")]
		[FieldOffset(Offset = "0x3C")]
		public Bloom.BloomQuality quality;

		// Token: 0x040000EE RID: 238
		[Token(Token = "0x40000EE")]
		[FieldOffset(Offset = "0x40")]
		public float bloomIntensity;

		// Token: 0x040000EF RID: 239
		[Token(Token = "0x40000EF")]
		[FieldOffset(Offset = "0x44")]
		public float bloomThreshold;

		// Token: 0x040000F0 RID: 240
		[Token(Token = "0x40000F0")]
		[FieldOffset(Offset = "0x48")]
		public Color bloomThresholdColor;

		// Token: 0x040000F1 RID: 241
		[Token(Token = "0x40000F1")]
		[FieldOffset(Offset = "0x58")]
		public int bloomBlurIterations;

		// Token: 0x040000F2 RID: 242
		[Token(Token = "0x40000F2")]
		[FieldOffset(Offset = "0x5C")]
		public int hollywoodFlareBlurIterations;

		// Token: 0x040000F3 RID: 243
		[Token(Token = "0x40000F3")]
		[FieldOffset(Offset = "0x60")]
		public float flareRotation;

		// Token: 0x040000F4 RID: 244
		[Token(Token = "0x40000F4")]
		[FieldOffset(Offset = "0x64")]
		public Bloom.LensFlareStyle lensflareMode;

		// Token: 0x040000F5 RID: 245
		[Token(Token = "0x40000F5")]
		[FieldOffset(Offset = "0x68")]
		public float hollyStretchWidth;

		// Token: 0x040000F6 RID: 246
		[Token(Token = "0x40000F6")]
		[FieldOffset(Offset = "0x6C")]
		public float lensflareIntensity;

		// Token: 0x040000F7 RID: 247
		[Token(Token = "0x40000F7")]
		[FieldOffset(Offset = "0x70")]
		public float lensflareThreshold;

		// Token: 0x040000F8 RID: 248
		[Token(Token = "0x40000F8")]
		[FieldOffset(Offset = "0x74")]
		public float lensFlareSaturation;

		// Token: 0x040000F9 RID: 249
		[Token(Token = "0x40000F9")]
		[FieldOffset(Offset = "0x78")]
		public Color flareColorA;

		// Token: 0x040000FA RID: 250
		[Token(Token = "0x40000FA")]
		[FieldOffset(Offset = "0x88")]
		public Color flareColorB;

		// Token: 0x040000FB RID: 251
		[Token(Token = "0x40000FB")]
		[FieldOffset(Offset = "0x98")]
		public Color flareColorC;

		// Token: 0x040000FC RID: 252
		[Token(Token = "0x40000FC")]
		[FieldOffset(Offset = "0xA8")]
		public Color flareColorD;

		// Token: 0x040000FD RID: 253
		[Token(Token = "0x40000FD")]
		[FieldOffset(Offset = "0xB8")]
		public Texture2D lensFlareVignetteMask;

		// Token: 0x040000FE RID: 254
		[Token(Token = "0x40000FE")]
		[FieldOffset(Offset = "0xC0")]
		public Shader lensFlareShader;

		// Token: 0x040000FF RID: 255
		[Token(Token = "0x40000FF")]
		[FieldOffset(Offset = "0xC8")]
		private Material lensFlareMaterial;

		// Token: 0x04000100 RID: 256
		[Token(Token = "0x4000100")]
		[FieldOffset(Offset = "0xD0")]
		public Shader screenBlendShader;

		// Token: 0x04000101 RID: 257
		[Token(Token = "0x4000101")]
		[FieldOffset(Offset = "0xD8")]
		private Material screenBlend;

		// Token: 0x04000102 RID: 258
		[Token(Token = "0x4000102")]
		[FieldOffset(Offset = "0xE0")]
		public Shader blurAndFlaresShader;

		// Token: 0x04000103 RID: 259
		[Token(Token = "0x4000103")]
		[FieldOffset(Offset = "0xE8")]
		private Material blurAndFlaresMaterial;

		// Token: 0x04000104 RID: 260
		[Token(Token = "0x4000104")]
		[FieldOffset(Offset = "0xF0")]
		public Shader brightPassFilterShader;

		// Token: 0x04000105 RID: 261
		[Token(Token = "0x4000105")]
		[FieldOffset(Offset = "0xF8")]
		private Material brightPassFilterMaterial;

		// Token: 0x0200002F RID: 47
		[Token(Token = "0x200002F")]
		public enum LensFlareStyle
		{
			// Token: 0x04000107 RID: 263
			[Token(Token = "0x4000107")]
			Ghosting,
			// Token: 0x04000108 RID: 264
			[Token(Token = "0x4000108")]
			Anamorphic,
			// Token: 0x04000109 RID: 265
			[Token(Token = "0x4000109")]
			Combined
		}

		// Token: 0x02000030 RID: 48
		[Token(Token = "0x2000030")]
		public enum TweakMode
		{
			// Token: 0x0400010B RID: 267
			[Token(Token = "0x400010B")]
			Basic,
			// Token: 0x0400010C RID: 268
			[Token(Token = "0x400010C")]
			Complex
		}

		// Token: 0x02000031 RID: 49
		[Token(Token = "0x2000031")]
		public enum HDRBloomMode
		{
			// Token: 0x0400010E RID: 270
			[Token(Token = "0x400010E")]
			Auto,
			// Token: 0x0400010F RID: 271
			[Token(Token = "0x400010F")]
			On,
			// Token: 0x04000110 RID: 272
			[Token(Token = "0x4000110")]
			Off
		}

		// Token: 0x02000032 RID: 50
		[Token(Token = "0x2000032")]
		public enum BloomScreenBlendMode
		{
			// Token: 0x04000112 RID: 274
			[Token(Token = "0x4000112")]
			Screen,
			// Token: 0x04000113 RID: 275
			[Token(Token = "0x4000113")]
			Add
		}

		// Token: 0x02000033 RID: 51
		[Token(Token = "0x2000033")]
		public enum BloomQuality
		{
			// Token: 0x04000115 RID: 277
			[Token(Token = "0x4000115")]
			Cheap,
			// Token: 0x04000116 RID: 278
			[Token(Token = "0x4000116")]
			High
		}
	}
}
