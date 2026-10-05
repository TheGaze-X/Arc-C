using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x02000041 RID: 65
	[Token(Token = "0x2000041")]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Color Adjustments/Color Correction (Curves, Saturation)")]
	public class ColorCorrectionCurves : PostEffectsBase
	{
		// Token: 0x060001CE RID: 462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001CE")]
		[Address(RVA = "0x51DAC90", Offset = "0x51D9890", VA = "0x1851DAC90")]
		private new void Start()
		{
		}

		// Token: 0x060001CF RID: 463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		private void Awake()
		{
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x00002700 File Offset: 0x00000900
		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x51DA5D0", Offset = "0x51D91D0", VA = "0x1851DA5D0", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x51DACB0", Offset = "0x51D98B0", VA = "0x1851DACB0")]
		public void UpdateParameters()
		{
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x51DB190", Offset = "0x51D9D90", VA = "0x1851DB190")]
		private void UpdateTextures()
		{
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x51DA900", Offset = "0x51D9500", VA = "0x1851DA900")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x51DB1A0", Offset = "0x51D9DA0", VA = "0x1851DB1A0")]
		public ColorCorrectionCurves()
		{
		}

		// Token: 0x04000188 RID: 392
		[Token(Token = "0x4000188")]
		[FieldOffset(Offset = "0x28")]
		public AnimationCurve redChannel;

		// Token: 0x04000189 RID: 393
		[Token(Token = "0x4000189")]
		[FieldOffset(Offset = "0x30")]
		public AnimationCurve greenChannel;

		// Token: 0x0400018A RID: 394
		[Token(Token = "0x400018A")]
		[FieldOffset(Offset = "0x38")]
		public AnimationCurve blueChannel;

		// Token: 0x0400018B RID: 395
		[Token(Token = "0x400018B")]
		[FieldOffset(Offset = "0x40")]
		public bool useDepthCorrection;

		// Token: 0x0400018C RID: 396
		[Token(Token = "0x400018C")]
		[FieldOffset(Offset = "0x48")]
		public AnimationCurve zCurve;

		// Token: 0x0400018D RID: 397
		[Token(Token = "0x400018D")]
		[FieldOffset(Offset = "0x50")]
		public AnimationCurve depthRedChannel;

		// Token: 0x0400018E RID: 398
		[Token(Token = "0x400018E")]
		[FieldOffset(Offset = "0x58")]
		public AnimationCurve depthGreenChannel;

		// Token: 0x0400018F RID: 399
		[Token(Token = "0x400018F")]
		[FieldOffset(Offset = "0x60")]
		public AnimationCurve depthBlueChannel;

		// Token: 0x04000190 RID: 400
		[Token(Token = "0x4000190")]
		[FieldOffset(Offset = "0x68")]
		private Material ccMaterial;

		// Token: 0x04000191 RID: 401
		[Token(Token = "0x4000191")]
		[FieldOffset(Offset = "0x70")]
		private Material ccDepthMaterial;

		// Token: 0x04000192 RID: 402
		[Token(Token = "0x4000192")]
		[FieldOffset(Offset = "0x78")]
		private Material selectiveCcMaterial;

		// Token: 0x04000193 RID: 403
		[Token(Token = "0x4000193")]
		[FieldOffset(Offset = "0x80")]
		private Texture2D rgbChannelTex;

		// Token: 0x04000194 RID: 404
		[Token(Token = "0x4000194")]
		[FieldOffset(Offset = "0x88")]
		private Texture2D rgbDepthChannelTex;

		// Token: 0x04000195 RID: 405
		[Token(Token = "0x4000195")]
		[FieldOffset(Offset = "0x90")]
		private Texture2D zCurveTex;

		// Token: 0x04000196 RID: 406
		[Token(Token = "0x4000196")]
		[FieldOffset(Offset = "0x98")]
		public float saturation;

		// Token: 0x04000197 RID: 407
		[Token(Token = "0x4000197")]
		[FieldOffset(Offset = "0x9C")]
		public bool selectiveCc;

		// Token: 0x04000198 RID: 408
		[Token(Token = "0x4000198")]
		[FieldOffset(Offset = "0xA0")]
		public Color selectiveFromColor;

		// Token: 0x04000199 RID: 409
		[Token(Token = "0x4000199")]
		[FieldOffset(Offset = "0xB0")]
		public Color selectiveToColor;

		// Token: 0x0400019A RID: 410
		[Token(Token = "0x400019A")]
		[FieldOffset(Offset = "0xC0")]
		public ColorCorrectionCurves.ColorCorrectionMode mode;

		// Token: 0x0400019B RID: 411
		[Token(Token = "0x400019B")]
		[FieldOffset(Offset = "0xC4")]
		public bool updateTextures;

		// Token: 0x0400019C RID: 412
		[Token(Token = "0x400019C")]
		[FieldOffset(Offset = "0xC8")]
		public Shader colorCorrectionCurvesShader;

		// Token: 0x0400019D RID: 413
		[Token(Token = "0x400019D")]
		[FieldOffset(Offset = "0xD0")]
		public Shader simpleColorCorrectionCurvesShader;

		// Token: 0x0400019E RID: 414
		[Token(Token = "0x400019E")]
		[FieldOffset(Offset = "0xD8")]
		public Shader colorCorrectionSelectiveShader;

		// Token: 0x0400019F RID: 415
		[Token(Token = "0x400019F")]
		[FieldOffset(Offset = "0xE0")]
		private bool updateTexturesOnStartup;

		// Token: 0x02000042 RID: 66
		[Token(Token = "0x2000042")]
		public enum ColorCorrectionMode
		{
			// Token: 0x040001A1 RID: 417
			[Token(Token = "0x40001A1")]
			Simple,
			// Token: 0x040001A2 RID: 418
			[Token(Token = "0x40001A2")]
			Advanced
		}
	}
}
