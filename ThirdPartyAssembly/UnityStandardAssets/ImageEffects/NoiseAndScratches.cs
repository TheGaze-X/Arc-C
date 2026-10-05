using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x02000059 RID: 89
	[Token(Token = "0x2000059")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Noise/Noise and Scratches")]
	public class NoiseAndScratches : MonoBehaviour
	{
		// Token: 0x06000228 RID: 552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000228")]
		[Address(RVA = "0x51E5600", Offset = "0x51E4200", VA = "0x1851E5600")]
		protected void Start()
		{
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000229 RID: 553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000030")]
		protected Material material
		{
			[Token(Token = "0x6000229")]
			[Address(RVA = "0x51E5760", Offset = "0x51E4360", VA = "0x1851E5760")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600022A RID: 554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600022A")]
		[Address(RVA = "0x51E4E00", Offset = "0x51E3A00", VA = "0x1851E4E00")]
		protected void OnDisable()
		{
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600022B")]
		[Address(RVA = "0x51E5510", Offset = "0x51E4110", VA = "0x1851E5510")]
		private void SanitizeParameters()
		{
		}

		// Token: 0x0600022C RID: 556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600022C")]
		[Address(RVA = "0x51E4ED0", Offset = "0x51E3AD0", VA = "0x1851E4ED0")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x0600022D RID: 557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600022D")]
		[Address(RVA = "0x51E5720", Offset = "0x51E4320", VA = "0x1851E5720")]
		public NoiseAndScratches()
		{
		}

		// Token: 0x04000256 RID: 598
		[Token(Token = "0x4000256")]
		[FieldOffset(Offset = "0x18")]
		public bool monochrome;

		// Token: 0x04000257 RID: 599
		[Token(Token = "0x4000257")]
		[FieldOffset(Offset = "0x19")]
		private bool rgbFallback;

		// Token: 0x04000258 RID: 600
		[Token(Token = "0x4000258")]
		[FieldOffset(Offset = "0x1C")]
		[Range(0f, 5f)]
		public float grainIntensityMin;

		// Token: 0x04000259 RID: 601
		[Token(Token = "0x4000259")]
		[FieldOffset(Offset = "0x20")]
		[Range(0f, 5f)]
		public float grainIntensityMax;

		// Token: 0x0400025A RID: 602
		[Token(Token = "0x400025A")]
		[FieldOffset(Offset = "0x24")]
		[Range(0.1f, 50f)]
		public float grainSize;

		// Token: 0x0400025B RID: 603
		[Token(Token = "0x400025B")]
		[FieldOffset(Offset = "0x28")]
		[Range(0f, 5f)]
		public float scratchIntensityMin;

		// Token: 0x0400025C RID: 604
		[Token(Token = "0x400025C")]
		[FieldOffset(Offset = "0x2C")]
		[Range(0f, 5f)]
		public float scratchIntensityMax;

		// Token: 0x0400025D RID: 605
		[Token(Token = "0x400025D")]
		[FieldOffset(Offset = "0x30")]
		[Range(1f, 30f)]
		public float scratchFPS;

		// Token: 0x0400025E RID: 606
		[Token(Token = "0x400025E")]
		[FieldOffset(Offset = "0x34")]
		[Range(0f, 1f)]
		public float scratchJitter;

		// Token: 0x0400025F RID: 607
		[Token(Token = "0x400025F")]
		[FieldOffset(Offset = "0x38")]
		public Texture grainTexture;

		// Token: 0x04000260 RID: 608
		[Token(Token = "0x4000260")]
		[FieldOffset(Offset = "0x40")]
		public Texture scratchTexture;

		// Token: 0x04000261 RID: 609
		[Token(Token = "0x4000261")]
		[FieldOffset(Offset = "0x48")]
		public Shader shaderRGB;

		// Token: 0x04000262 RID: 610
		[Token(Token = "0x4000262")]
		[FieldOffset(Offset = "0x50")]
		public Shader shaderYUV;

		// Token: 0x04000263 RID: 611
		[Token(Token = "0x4000263")]
		[FieldOffset(Offset = "0x58")]
		private Material m_MaterialRGB;

		// Token: 0x04000264 RID: 612
		[Token(Token = "0x4000264")]
		[FieldOffset(Offset = "0x60")]
		private Material m_MaterialYUV;

		// Token: 0x04000265 RID: 613
		[Token(Token = "0x4000265")]
		[FieldOffset(Offset = "0x68")]
		private float scratchTimeLeft;

		// Token: 0x04000266 RID: 614
		[Token(Token = "0x4000266")]
		[FieldOffset(Offset = "0x6C")]
		private float scratchX;

		// Token: 0x04000267 RID: 615
		[Token(Token = "0x4000267")]
		[FieldOffset(Offset = "0x70")]
		private float scratchY;
	}
}
