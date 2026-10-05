using System;
using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000081 RID: 129
	[Token(Token = "0x2000081")]
	public sealed class PostProcessResources : ScriptableObject
	{
		// Token: 0x060001CD RID: 461 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60001CD")]
		[Address(RVA = "0x4F4B00", Offset = "0x4F3700", VA = "0x1804F4B00")]
		public PostProcessResources()
		{
		}

		// Token: 0x04000268 RID: 616
		[Token(Token = "0x4000268")]
		[FieldOffset(Offset = "0x18")]
		public Texture2D[] blueNoise64;

		// Token: 0x04000269 RID: 617
		[Token(Token = "0x4000269")]
		[FieldOffset(Offset = "0x20")]
		public Texture2D[] blueNoise256;

		// Token: 0x0400026A RID: 618
		[Token(Token = "0x400026A")]
		[FieldOffset(Offset = "0x28")]
		public PostProcessResources.SMAALuts smaaLuts;

		// Token: 0x0400026B RID: 619
		[Token(Token = "0x400026B")]
		[FieldOffset(Offset = "0x30")]
		public PostProcessResources.Shaders shaders;

		// Token: 0x0400026C RID: 620
		[Token(Token = "0x400026C")]
		[FieldOffset(Offset = "0x38")]
		public PostProcessResources.ComputeShaders computeShaders;

		// Token: 0x02000082 RID: 130
		[Token(Token = "0x2000082")]
		[Serializable]
		public sealed class Shaders
		{
			// Token: 0x060001CE RID: 462 RVA: 0x000020AE File Offset: 0x000002AE
			[Token(Token = "0x60001CE")]
			[Address(RVA = "0x5849F40", Offset = "0x5848B40", VA = "0x185849F40")]
			public PostProcessResources.Shaders Clone()
			{
				return null;
			}

			// Token: 0x060001CF RID: 463 RVA: 0x0000207E File Offset: 0x0000027E
			[Token(Token = "0x60001CF")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Shaders()
			{
			}

			// Token: 0x0400026D RID: 621
			[Token(Token = "0x400026D")]
			[FieldOffset(Offset = "0x10")]
			public Shader bloom;

			// Token: 0x0400026E RID: 622
			[Token(Token = "0x400026E")]
			[FieldOffset(Offset = "0x18")]
			public Shader copy;

			// Token: 0x0400026F RID: 623
			[Token(Token = "0x400026F")]
			[FieldOffset(Offset = "0x20")]
			public Shader copyStd;

			// Token: 0x04000270 RID: 624
			[Token(Token = "0x4000270")]
			[FieldOffset(Offset = "0x28")]
			public Shader copyStdFromTexArray;

			// Token: 0x04000271 RID: 625
			[Token(Token = "0x4000271")]
			[FieldOffset(Offset = "0x30")]
			public Shader copyStdFromDoubleWide;

			// Token: 0x04000272 RID: 626
			[Token(Token = "0x4000272")]
			[FieldOffset(Offset = "0x38")]
			public Shader discardAlpha;

			// Token: 0x04000273 RID: 627
			[Token(Token = "0x4000273")]
			[FieldOffset(Offset = "0x40")]
			public Shader depthOfField;

			// Token: 0x04000274 RID: 628
			[Token(Token = "0x4000274")]
			[FieldOffset(Offset = "0x48")]
			public Shader finalPass;

			// Token: 0x04000275 RID: 629
			[Token(Token = "0x4000275")]
			[FieldOffset(Offset = "0x50")]
			public Shader grainBaker;

			// Token: 0x04000276 RID: 630
			[Token(Token = "0x4000276")]
			[FieldOffset(Offset = "0x58")]
			public Shader motionBlur;

			// Token: 0x04000277 RID: 631
			[Token(Token = "0x4000277")]
			[FieldOffset(Offset = "0x60")]
			public Shader temporalAntialiasing;

			// Token: 0x04000278 RID: 632
			[Token(Token = "0x4000278")]
			[FieldOffset(Offset = "0x68")]
			public Shader subpixelMorphologicalAntialiasing;

			// Token: 0x04000279 RID: 633
			[Token(Token = "0x4000279")]
			[FieldOffset(Offset = "0x70")]
			public Shader texture2dLerp;

			// Token: 0x0400027A RID: 634
			[Token(Token = "0x400027A")]
			[FieldOffset(Offset = "0x78")]
			public Shader uber;

			// Token: 0x0400027B RID: 635
			[Token(Token = "0x400027B")]
			[FieldOffset(Offset = "0x80")]
			public Shader lut2DBaker;

			// Token: 0x0400027C RID: 636
			[Token(Token = "0x400027C")]
			[FieldOffset(Offset = "0x88")]
			public Shader lightMeter;

			// Token: 0x0400027D RID: 637
			[Token(Token = "0x400027D")]
			[FieldOffset(Offset = "0x90")]
			public Shader gammaHistogram;

			// Token: 0x0400027E RID: 638
			[Token(Token = "0x400027E")]
			[FieldOffset(Offset = "0x98")]
			public Shader waveform;

			// Token: 0x0400027F RID: 639
			[Token(Token = "0x400027F")]
			[FieldOffset(Offset = "0xA0")]
			public Shader vectorscope;

			// Token: 0x04000280 RID: 640
			[Token(Token = "0x4000280")]
			[FieldOffset(Offset = "0xA8")]
			public Shader debugOverlays;

			// Token: 0x04000281 RID: 641
			[Token(Token = "0x4000281")]
			[FieldOffset(Offset = "0xB0")]
			public Shader deferredFog;

			// Token: 0x04000282 RID: 642
			[Token(Token = "0x4000282")]
			[FieldOffset(Offset = "0xB8")]
			public Shader scalableAO;

			// Token: 0x04000283 RID: 643
			[Token(Token = "0x4000283")]
			[FieldOffset(Offset = "0xC0")]
			public Shader multiScaleAO;

			// Token: 0x04000284 RID: 644
			[Token(Token = "0x4000284")]
			[FieldOffset(Offset = "0xC8")]
			public Shader screenSpaceReflections;

			// Token: 0x04000285 RID: 645
			[Token(Token = "0x4000285")]
			[FieldOffset(Offset = "0xD0")]
			public Shader mobileBlur;
		}

		// Token: 0x02000083 RID: 131
		[Token(Token = "0x2000083")]
		[Serializable]
		public sealed class ComputeShaders
		{
			// Token: 0x060001D0 RID: 464 RVA: 0x000020AE File Offset: 0x000002AE
			[Token(Token = "0x60001D0")]
			[Address(RVA = "0x582EC50", Offset = "0x582D850", VA = "0x18582EC50")]
			public PostProcessResources.ComputeShaders Clone()
			{
				return null;
			}

			// Token: 0x060001D1 RID: 465 RVA: 0x0000207E File Offset: 0x0000027E
			[Token(Token = "0x60001D1")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ComputeShaders()
			{
			}

			// Token: 0x04000286 RID: 646
			[Token(Token = "0x4000286")]
			[FieldOffset(Offset = "0x10")]
			public ComputeShader autoExposure;

			// Token: 0x04000287 RID: 647
			[Token(Token = "0x4000287")]
			[FieldOffset(Offset = "0x18")]
			public ComputeShader exposureHistogram;

			// Token: 0x04000288 RID: 648
			[Token(Token = "0x4000288")]
			[FieldOffset(Offset = "0x20")]
			public ComputeShader lut3DBaker;

			// Token: 0x04000289 RID: 649
			[Token(Token = "0x4000289")]
			[FieldOffset(Offset = "0x28")]
			public ComputeShader texture3dLerp;

			// Token: 0x0400028A RID: 650
			[Token(Token = "0x400028A")]
			[FieldOffset(Offset = "0x30")]
			public ComputeShader gammaHistogram;

			// Token: 0x0400028B RID: 651
			[Token(Token = "0x400028B")]
			[FieldOffset(Offset = "0x38")]
			public ComputeShader waveform;

			// Token: 0x0400028C RID: 652
			[Token(Token = "0x400028C")]
			[FieldOffset(Offset = "0x40")]
			public ComputeShader vectorscope;

			// Token: 0x0400028D RID: 653
			[Token(Token = "0x400028D")]
			[FieldOffset(Offset = "0x48")]
			public ComputeShader multiScaleAODownsample1;

			// Token: 0x0400028E RID: 654
			[Token(Token = "0x400028E")]
			[FieldOffset(Offset = "0x50")]
			public ComputeShader multiScaleAODownsample2;

			// Token: 0x0400028F RID: 655
			[Token(Token = "0x400028F")]
			[FieldOffset(Offset = "0x58")]
			public ComputeShader multiScaleAORender;

			// Token: 0x04000290 RID: 656
			[Token(Token = "0x4000290")]
			[FieldOffset(Offset = "0x60")]
			public ComputeShader multiScaleAOUpsample;

			// Token: 0x04000291 RID: 657
			[Token(Token = "0x4000291")]
			[FieldOffset(Offset = "0x68")]
			public ComputeShader gaussianDownsample;
		}

		// Token: 0x02000084 RID: 132
		[Token(Token = "0x2000084")]
		[Serializable]
		public sealed class SMAALuts
		{
			// Token: 0x060001D2 RID: 466 RVA: 0x0000207E File Offset: 0x0000027E
			[Token(Token = "0x60001D2")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public SMAALuts()
			{
			}

			// Token: 0x04000292 RID: 658
			[Token(Token = "0x4000292")]
			[FieldOffset(Offset = "0x10")]
			public Texture2D area;

			// Token: 0x04000293 RID: 659
			[Token(Token = "0x4000293")]
			[FieldOffset(Offset = "0x18")]
			public Texture2D search;
		}
	}
}
