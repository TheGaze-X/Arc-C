using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x0200003D RID: 61
	[Token(Token = "0x200003D")]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Blur/Blur (Optimized)")]
	[ExecuteInEditMode]
	public class BlurOptimized : PostEffectsBase
	{
		// Token: 0x060001BE RID: 446 RVA: 0x000026B8 File Offset: 0x000008B8
		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x51D6CE0", Offset = "0x51D58E0", VA = "0x1851D6CE0", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x51D6D40", Offset = "0x51D5940", VA = "0x1851D6D40")]
		public void OnDisable()
		{
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x51D6DC0", Offset = "0x51D59C0", VA = "0x1851D6DC0")]
		public void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001C1")]
		[Address(RVA = "0x51D71E0", Offset = "0x51D5DE0", VA = "0x1851D71E0")]
		public BlurOptimized()
		{
		}

		// Token: 0x04000159 RID: 345
		[Token(Token = "0x4000159")]
		[FieldOffset(Offset = "0x28")]
		[Range(0f, 2f)]
		public int downsample;

		// Token: 0x0400015A RID: 346
		[Token(Token = "0x400015A")]
		[FieldOffset(Offset = "0x2C")]
		[Range(0f, 10f)]
		public float blurSize;

		// Token: 0x0400015B RID: 347
		[Token(Token = "0x400015B")]
		[FieldOffset(Offset = "0x30")]
		[Range(1f, 4f)]
		public int blurIterations;

		// Token: 0x0400015C RID: 348
		[Token(Token = "0x400015C")]
		[FieldOffset(Offset = "0x34")]
		public BlurOptimized.BlurType blurType;

		// Token: 0x0400015D RID: 349
		[Token(Token = "0x400015D")]
		[FieldOffset(Offset = "0x38")]
		public Shader blurShader;

		// Token: 0x0400015E RID: 350
		[Token(Token = "0x400015E")]
		[FieldOffset(Offset = "0x40")]
		private Material blurMaterial;

		// Token: 0x0200003E RID: 62
		[Token(Token = "0x200003E")]
		public enum BlurType
		{
			// Token: 0x04000160 RID: 352
			[Token(Token = "0x4000160")]
			StandardGauss,
			// Token: 0x04000161 RID: 353
			[Token(Token = "0x4000161")]
			SgxGauss
		}
	}
}
