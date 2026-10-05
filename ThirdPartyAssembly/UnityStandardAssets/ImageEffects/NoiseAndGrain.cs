using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x02000058 RID: 88
	[Token(Token = "0x2000058")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Noise/Noise And Grain (Filmic)")]
	public class NoiseAndGrain : PostEffectsBase
	{
		// Token: 0x06000223 RID: 547 RVA: 0x00002850 File Offset: 0x00000A50
		[Token(Token = "0x6000223")]
		[Address(RVA = "0x51E3EF0", Offset = "0x51E2AF0", VA = "0x1851E3EF0", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		// Token: 0x06000224 RID: 548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000224")]
		[Address(RVA = "0x51E43E0", Offset = "0x51E2FE0", VA = "0x1851E43E0")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x06000225 RID: 549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000225")]
		[Address(RVA = "0x51E3F90", Offset = "0x51E2B90", VA = "0x1851E3F90")]
		private static void DrawNoiseQuadGrid(RenderTexture source, RenderTexture dest, Material fxMaterial, Texture2D noise, int passNr)
		{
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000226")]
		[Address(RVA = "0x51E4D70", Offset = "0x51E3970", VA = "0x1851E4D70")]
		public NoiseAndGrain()
		{
		}

		// Token: 0x04000244 RID: 580
		[Token(Token = "0x4000244")]
		[FieldOffset(Offset = "0x28")]
		public float intensityMultiplier;

		// Token: 0x04000245 RID: 581
		[Token(Token = "0x4000245")]
		[FieldOffset(Offset = "0x2C")]
		public float generalIntensity;

		// Token: 0x04000246 RID: 582
		[Token(Token = "0x4000246")]
		[FieldOffset(Offset = "0x30")]
		public float blackIntensity;

		// Token: 0x04000247 RID: 583
		[Token(Token = "0x4000247")]
		[FieldOffset(Offset = "0x34")]
		public float whiteIntensity;

		// Token: 0x04000248 RID: 584
		[Token(Token = "0x4000248")]
		[FieldOffset(Offset = "0x38")]
		public float midGrey;

		// Token: 0x04000249 RID: 585
		[Token(Token = "0x4000249")]
		[FieldOffset(Offset = "0x3C")]
		public bool dx11Grain;

		// Token: 0x0400024A RID: 586
		[Token(Token = "0x400024A")]
		[FieldOffset(Offset = "0x40")]
		public float softness;

		// Token: 0x0400024B RID: 587
		[Token(Token = "0x400024B")]
		[FieldOffset(Offset = "0x44")]
		public bool monochrome;

		// Token: 0x0400024C RID: 588
		[Token(Token = "0x400024C")]
		[FieldOffset(Offset = "0x48")]
		public Vector3 intensities;

		// Token: 0x0400024D RID: 589
		[Token(Token = "0x400024D")]
		[FieldOffset(Offset = "0x54")]
		public Vector3 tiling;

		// Token: 0x0400024E RID: 590
		[Token(Token = "0x400024E")]
		[FieldOffset(Offset = "0x60")]
		public float monochromeTiling;

		// Token: 0x0400024F RID: 591
		[Token(Token = "0x400024F")]
		[FieldOffset(Offset = "0x64")]
		public FilterMode filterMode;

		// Token: 0x04000250 RID: 592
		[Token(Token = "0x4000250")]
		[FieldOffset(Offset = "0x68")]
		public Texture2D noiseTexture;

		// Token: 0x04000251 RID: 593
		[Token(Token = "0x4000251")]
		[FieldOffset(Offset = "0x70")]
		public Shader noiseShader;

		// Token: 0x04000252 RID: 594
		[Token(Token = "0x4000252")]
		[FieldOffset(Offset = "0x78")]
		private Material noiseMaterial;

		// Token: 0x04000253 RID: 595
		[Token(Token = "0x4000253")]
		[FieldOffset(Offset = "0x80")]
		public Shader dx11NoiseShader;

		// Token: 0x04000254 RID: 596
		[Token(Token = "0x4000254")]
		[FieldOffset(Offset = "0x88")]
		private Material dx11NoiseMaterial;

		// Token: 0x04000255 RID: 597
		[Token(Token = "0x4000255")]
		[FieldOffset(Offset = "0x0")]
		private static float TILE_AMOUNT;
	}
}
