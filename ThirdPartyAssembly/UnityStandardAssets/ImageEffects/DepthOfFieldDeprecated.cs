using System;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x0200004B RID: 75
	[Token(Token = "0x200004B")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Camera/Depth of Field (deprecated)")]
	public class DepthOfFieldDeprecated : PostEffectsBase
	{
		// Token: 0x060001F8 RID: 504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001F8")]
		[Address(RVA = "0x51DEE00", Offset = "0x51DDA00", VA = "0x1851DEE00")]
		private void CreateMaterials()
		{
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x000027A8 File Offset: 0x000009A8
		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x51DECD0", Offset = "0x51DD8D0", VA = "0x1851DECD0", Slot = "4")]
		public override bool CheckResources()
		{
			return default(bool);
		}

		// Token: 0x060001FA RID: 506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x51DF2A0", Offset = "0x51DDEA0", VA = "0x1851DF2A0")]
		private void OnDisable()
		{
		}

		// Token: 0x060001FB RID: 507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x51DF2B0", Offset = "0x51DDEB0", VA = "0x1851DF2B0")]
		private void OnEnable()
		{
		}

		// Token: 0x060001FC RID: 508 RVA: 0x000027C0 File Offset: 0x000009C0
		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x51DF0C0", Offset = "0x51DDCC0", VA = "0x1851DF0C0")]
		private float FocalDistance01(float worldDist)
		{
			return 0f;
		}

		// Token: 0x060001FD RID: 509 RVA: 0x000027D8 File Offset: 0x000009D8
		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x51DF260", Offset = "0x51DDE60", VA = "0x1851DF260")]
		private int GetDividerBasedOnQuality()
		{
			return 0;
		}

		// Token: 0x060001FE RID: 510 RVA: 0x000027F0 File Offset: 0x000009F0
		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x51DF280", Offset = "0x51DDE80", VA = "0x1851DF280")]
		private int GetLowResolutionDividerBasedOnQuality(int baseDivider)
		{
			return 0;
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x51DF330", Offset = "0x51DDF30", VA = "0x1851DF330")]
		private void OnRenderImage(RenderTexture source, RenderTexture destination)
		{
		}

		// Token: 0x06000200 RID: 512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000200")]
		[Address(RVA = "0x51DEA50", Offset = "0x51DD650", VA = "0x1851DEA50")]
		private void Blur(RenderTexture from, RenderTexture to, DepthOfFieldDeprecated.DofBlurriness iterations, int blurPass, float spread)
		{
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000201")]
		[Address(RVA = "0x51DE570", Offset = "0x51DD170", VA = "0x1851DE570")]
		private void BlurFg(RenderTexture from, RenderTexture to, DepthOfFieldDeprecated.DofBlurriness iterations, int blurPass, float spread)
		{
		}

		// Token: 0x06000202 RID: 514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000202")]
		[Address(RVA = "0x51DE820", Offset = "0x51DD420", VA = "0x1851DE820")]
		private void BlurHex(RenderTexture from, RenderTexture to, int blurPass, float spread, RenderTexture tmp)
		{
		}

		// Token: 0x06000203 RID: 515 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000203")]
		[Address(RVA = "0x51DEF10", Offset = "0x51DDB10", VA = "0x1851DEF10")]
		private void Downsample(RenderTexture from, RenderTexture to)
		{
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000204")]
		[Address(RVA = "0x51DDB90", Offset = "0x51DC790", VA = "0x1851DDB90")]
		private void AddBokeh(RenderTexture bokehInfo, RenderTexture tempTex, RenderTexture finalTarget)
		{
		}

		// Token: 0x06000205 RID: 517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000205")]
		[Address(RVA = "0x51E0000", Offset = "0x51DEC00", VA = "0x1851E0000")]
		private void ReleaseTextures()
		{
		}

		// Token: 0x06000206 RID: 518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000206")]
		[Address(RVA = "0x51DE060", Offset = "0x51DCC60", VA = "0x1851DE060")]
		private void AllocateTextures(bool blurForeground, RenderTexture source, int divider, int lowTexDivider)
		{
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000207")]
		[Address(RVA = "0x51E01E0", Offset = "0x51DEDE0", VA = "0x1851E01E0")]
		public DepthOfFieldDeprecated()
		{
		}

		// Token: 0x040001E5 RID: 485
		[Token(Token = "0x40001E5")]
		[FieldOffset(Offset = "0x0")]
		private static int SMOOTH_DOWNSAMPLE_PASS;

		// Token: 0x040001E6 RID: 486
		[Token(Token = "0x40001E6")]
		[FieldOffset(Offset = "0x4")]
		private static float BOKEH_EXTRA_BLUR;

		// Token: 0x040001E7 RID: 487
		[Token(Token = "0x40001E7")]
		[FieldOffset(Offset = "0x28")]
		public DepthOfFieldDeprecated.Dof34QualitySetting quality;

		// Token: 0x040001E8 RID: 488
		[Token(Token = "0x40001E8")]
		[FieldOffset(Offset = "0x2C")]
		public DepthOfFieldDeprecated.DofResolution resolution;

		// Token: 0x040001E9 RID: 489
		[Token(Token = "0x40001E9")]
		[FieldOffset(Offset = "0x30")]
		public bool simpleTweakMode;

		// Token: 0x040001EA RID: 490
		[Token(Token = "0x40001EA")]
		[FieldOffset(Offset = "0x34")]
		public float focalPoint;

		// Token: 0x040001EB RID: 491
		[Token(Token = "0x40001EB")]
		[FieldOffset(Offset = "0x38")]
		public float smoothness;

		// Token: 0x040001EC RID: 492
		[Token(Token = "0x40001EC")]
		[FieldOffset(Offset = "0x3C")]
		public float focalZDistance;

		// Token: 0x040001ED RID: 493
		[Token(Token = "0x40001ED")]
		[FieldOffset(Offset = "0x40")]
		public float focalZStartCurve;

		// Token: 0x040001EE RID: 494
		[Token(Token = "0x40001EE")]
		[FieldOffset(Offset = "0x44")]
		public float focalZEndCurve;

		// Token: 0x040001EF RID: 495
		[Token(Token = "0x40001EF")]
		[FieldOffset(Offset = "0x48")]
		private float focalStartCurve;

		// Token: 0x040001F0 RID: 496
		[Token(Token = "0x40001F0")]
		[FieldOffset(Offset = "0x4C")]
		private float focalEndCurve;

		// Token: 0x040001F1 RID: 497
		[Token(Token = "0x40001F1")]
		[FieldOffset(Offset = "0x50")]
		private float focalDistance01;

		// Token: 0x040001F2 RID: 498
		[Token(Token = "0x40001F2")]
		[FieldOffset(Offset = "0x58")]
		public Transform objectFocus;

		// Token: 0x040001F3 RID: 499
		[Token(Token = "0x40001F3")]
		[FieldOffset(Offset = "0x60")]
		public float focalSize;

		// Token: 0x040001F4 RID: 500
		[Token(Token = "0x40001F4")]
		[FieldOffset(Offset = "0x64")]
		public DepthOfFieldDeprecated.DofBlurriness bluriness;

		// Token: 0x040001F5 RID: 501
		[Token(Token = "0x40001F5")]
		[FieldOffset(Offset = "0x68")]
		public float maxBlurSpread;

		// Token: 0x040001F6 RID: 502
		[Token(Token = "0x40001F6")]
		[FieldOffset(Offset = "0x6C")]
		public float foregroundBlurExtrude;

		// Token: 0x040001F7 RID: 503
		[Token(Token = "0x40001F7")]
		[FieldOffset(Offset = "0x70")]
		public Shader dofBlurShader;

		// Token: 0x040001F8 RID: 504
		[Token(Token = "0x40001F8")]
		[FieldOffset(Offset = "0x78")]
		private Material dofBlurMaterial;

		// Token: 0x040001F9 RID: 505
		[Token(Token = "0x40001F9")]
		[FieldOffset(Offset = "0x80")]
		public Shader dofShader;

		// Token: 0x040001FA RID: 506
		[Token(Token = "0x40001FA")]
		[FieldOffset(Offset = "0x88")]
		private Material dofMaterial;

		// Token: 0x040001FB RID: 507
		[Token(Token = "0x40001FB")]
		[FieldOffset(Offset = "0x90")]
		public bool visualize;

		// Token: 0x040001FC RID: 508
		[Token(Token = "0x40001FC")]
		[FieldOffset(Offset = "0x94")]
		public DepthOfFieldDeprecated.BokehDestination bokehDestination;

		// Token: 0x040001FD RID: 509
		[Token(Token = "0x40001FD")]
		[FieldOffset(Offset = "0x98")]
		private float widthOverHeight;

		// Token: 0x040001FE RID: 510
		[Token(Token = "0x40001FE")]
		[FieldOffset(Offset = "0x9C")]
		private float oneOverBaseSize;

		// Token: 0x040001FF RID: 511
		[Token(Token = "0x40001FF")]
		[FieldOffset(Offset = "0xA0")]
		public bool bokeh;

		// Token: 0x04000200 RID: 512
		[Token(Token = "0x4000200")]
		[FieldOffset(Offset = "0xA1")]
		public bool bokehSupport;

		// Token: 0x04000201 RID: 513
		[Token(Token = "0x4000201")]
		[FieldOffset(Offset = "0xA8")]
		public Shader bokehShader;

		// Token: 0x04000202 RID: 514
		[Token(Token = "0x4000202")]
		[FieldOffset(Offset = "0xB0")]
		public Texture2D bokehTexture;

		// Token: 0x04000203 RID: 515
		[Token(Token = "0x4000203")]
		[FieldOffset(Offset = "0xB8")]
		public float bokehScale;

		// Token: 0x04000204 RID: 516
		[Token(Token = "0x4000204")]
		[FieldOffset(Offset = "0xBC")]
		public float bokehIntensity;

		// Token: 0x04000205 RID: 517
		[Token(Token = "0x4000205")]
		[FieldOffset(Offset = "0xC0")]
		public float bokehThresholdContrast;

		// Token: 0x04000206 RID: 518
		[Token(Token = "0x4000206")]
		[FieldOffset(Offset = "0xC4")]
		public float bokehThresholdLuminance;

		// Token: 0x04000207 RID: 519
		[Token(Token = "0x4000207")]
		[FieldOffset(Offset = "0xC8")]
		public int bokehDownsample;

		// Token: 0x04000208 RID: 520
		[Token(Token = "0x4000208")]
		[FieldOffset(Offset = "0xD0")]
		private Material bokehMaterial;

		// Token: 0x04000209 RID: 521
		[Token(Token = "0x4000209")]
		[FieldOffset(Offset = "0xD8")]
		private Camera _camera;

		// Token: 0x0400020A RID: 522
		[Token(Token = "0x400020A")]
		[FieldOffset(Offset = "0xE0")]
		private RenderTexture foregroundTexture;

		// Token: 0x0400020B RID: 523
		[Token(Token = "0x400020B")]
		[FieldOffset(Offset = "0xE8")]
		private RenderTexture mediumRezWorkTexture;

		// Token: 0x0400020C RID: 524
		[Token(Token = "0x400020C")]
		[FieldOffset(Offset = "0xF0")]
		private RenderTexture finalDefocus;

		// Token: 0x0400020D RID: 525
		[Token(Token = "0x400020D")]
		[FieldOffset(Offset = "0xF8")]
		private RenderTexture lowRezWorkTexture;

		// Token: 0x0400020E RID: 526
		[Token(Token = "0x400020E")]
		[FieldOffset(Offset = "0x100")]
		private RenderTexture bokehSource;

		// Token: 0x0400020F RID: 527
		[Token(Token = "0x400020F")]
		[FieldOffset(Offset = "0x108")]
		private RenderTexture bokehSource2;

		// Token: 0x0200004C RID: 76
		[Token(Token = "0x200004C")]
		public enum Dof34QualitySetting
		{
			// Token: 0x04000211 RID: 529
			[Token(Token = "0x4000211")]
			OnlyBackground = 1,
			// Token: 0x04000212 RID: 530
			[Token(Token = "0x4000212")]
			BackgroundAndForeground
		}

		// Token: 0x0200004D RID: 77
		[Token(Token = "0x200004D")]
		public enum DofResolution
		{
			// Token: 0x04000214 RID: 532
			[Token(Token = "0x4000214")]
			High = 2,
			// Token: 0x04000215 RID: 533
			[Token(Token = "0x4000215")]
			Medium,
			// Token: 0x04000216 RID: 534
			[Token(Token = "0x4000216")]
			Low
		}

		// Token: 0x0200004E RID: 78
		[Token(Token = "0x200004E")]
		public enum DofBlurriness
		{
			// Token: 0x04000218 RID: 536
			[Token(Token = "0x4000218")]
			Low = 1,
			// Token: 0x04000219 RID: 537
			[Token(Token = "0x4000219")]
			High,
			// Token: 0x0400021A RID: 538
			[Token(Token = "0x400021A")]
			VeryHigh = 4
		}

		// Token: 0x0200004F RID: 79
		[Token(Token = "0x200004F")]
		public enum BokehDestination
		{
			// Token: 0x0400021C RID: 540
			[Token(Token = "0x400021C")]
			Background = 1,
			// Token: 0x0400021D RID: 541
			[Token(Token = "0x400021D")]
			Foreground,
			// Token: 0x0400021E RID: 542
			[Token(Token = "0x400021E")]
			BackgroundAndForeground
		}
	}
}
