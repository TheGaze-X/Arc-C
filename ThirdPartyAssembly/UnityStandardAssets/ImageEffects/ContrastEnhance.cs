using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x02000045 RID: 69
	[Token(Token = "0x2000045")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Color Adjustments/Contrast Enhance (Unsharp Mask)")]
	public class ContrastEnhance : PostEffectsBase
	{
		// Token: 0x060001DF RID: 479 RVA: 0x00002748 File Offset: 0x00000948
		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x51DC5B0", Offset = "0x51DB1B0", VA = "0x1851DC5B0", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x51DC630", Offset = "0x51DB230", VA = "0x1851DC630")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x51DC9F0", Offset = "0x51DB5F0", VA = "0x1851DC9F0")]
		public ContrastEnhance()
		{
		}

		// Token: 0x040001A8 RID: 424
		[Token(Token = "0x40001A8")]
		[FieldOffset(Offset = "0x28")]
		[Range(0f, 1f)]
		public float intensity;

		// Token: 0x040001A9 RID: 425
		[Token(Token = "0x40001A9")]
		[FieldOffset(Offset = "0x2C")]
		[Range(0f, 0.999f)]
		public float threshold;

		// Token: 0x040001AA RID: 426
		[Token(Token = "0x40001AA")]
		[FieldOffset(Offset = "0x30")]
		private Material separableBlurMaterial;

		// Token: 0x040001AB RID: 427
		[Token(Token = "0x40001AB")]
		[FieldOffset(Offset = "0x38")]
		private Material contrastCompositeMaterial;

		// Token: 0x040001AC RID: 428
		[Token(Token = "0x40001AC")]
		[FieldOffset(Offset = "0x40")]
		[Range(0f, 1f)]
		public float blurSpread;

		// Token: 0x040001AD RID: 429
		[Token(Token = "0x40001AD")]
		[FieldOffset(Offset = "0x48")]
		public Shader separableBlurShader;

		// Token: 0x040001AE RID: 430
		[Token(Token = "0x40001AE")]
		[FieldOffset(Offset = "0x50")]
		public Shader contrastCompositeShader;
	}
}
