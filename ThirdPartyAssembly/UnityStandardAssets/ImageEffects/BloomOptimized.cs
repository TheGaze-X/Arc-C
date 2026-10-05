using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x02000039 RID: 57
	[Token(Token = "0x2000039")]
	[AddComponentMenu("Image Effects/Bloom and Glow/Bloom (Optimized)")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	public class BloomOptimized : PostEffectsBase
	{
		// Token: 0x060001B3 RID: 435 RVA: 0x000026A0 File Offset: 0x000008A0
		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x51D4EA0", Offset = "0x51D3AA0", VA = "0x1851D4EA0", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001B4")]
		[Address(RVA = "0x51D4F00", Offset = "0x51D3B00", VA = "0x1851D4F00")]
		private void OnDisable()
		{
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001B5")]
		[Address(RVA = "0x51D4F80", Offset = "0x51D3B80", VA = "0x1851D4F80")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001B6")]
		[Address(RVA = "0x51D53B0", Offset = "0x51D3FB0", VA = "0x1851D53B0")]
		public BloomOptimized()
		{
		}

		// Token: 0x04000147 RID: 327
		[Token(Token = "0x4000147")]
		[FieldOffset(Offset = "0x28")]
		[Range(0f, 1.5f)]
		public float threshold;

		// Token: 0x04000148 RID: 328
		[Token(Token = "0x4000148")]
		[FieldOffset(Offset = "0x2C")]
		[Range(0f, 2.5f)]
		public float intensity;

		// Token: 0x04000149 RID: 329
		[Token(Token = "0x4000149")]
		[FieldOffset(Offset = "0x30")]
		[Range(0.25f, 5.5f)]
		public float blurSize;

		// Token: 0x0400014A RID: 330
		[Token(Token = "0x400014A")]
		[FieldOffset(Offset = "0x34")]
		private BloomOptimized.Resolution resolution;

		// Token: 0x0400014B RID: 331
		[Token(Token = "0x400014B")]
		[FieldOffset(Offset = "0x38")]
		[Range(1f, 4f)]
		public int blurIterations;

		// Token: 0x0400014C RID: 332
		[Token(Token = "0x400014C")]
		[FieldOffset(Offset = "0x3C")]
		public BloomOptimized.BlurType blurType;

		// Token: 0x0400014D RID: 333
		[Token(Token = "0x400014D")]
		[FieldOffset(Offset = "0x40")]
		public Shader fastBloomShader;

		// Token: 0x0400014E RID: 334
		[Token(Token = "0x400014E")]
		[FieldOffset(Offset = "0x48")]
		private Material fastBloomMaterial;

		// Token: 0x0200003A RID: 58
		[Token(Token = "0x200003A")]
		public enum Resolution
		{
			// Token: 0x04000150 RID: 336
			[Token(Token = "0x4000150")]
			Low,
			// Token: 0x04000151 RID: 337
			[Token(Token = "0x4000151")]
			High
		}

		// Token: 0x0200003B RID: 59
		[Token(Token = "0x200003B")]
		public enum BlurType
		{
			// Token: 0x04000153 RID: 339
			[Token(Token = "0x4000153")]
			Standard,
			// Token: 0x04000154 RID: 340
			[Token(Token = "0x4000154")]
			Sgx
		}
	}
}
