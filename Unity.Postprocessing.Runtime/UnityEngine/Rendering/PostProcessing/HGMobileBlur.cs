using System;
using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000032 RID: 50
	[Token(Token = "0x2000032")]
	[PostProcess(typeof(HGMobileBlurRenderer), "HG/Mobile Blur", false)]
	[Serializable]
	public sealed class HGMobileBlur : PostProcessEffectSettings
	{
		// Token: 0x06000062 RID: 98 RVA: 0x00002264 File Offset: 0x00000464
		[Token(Token = "0x6000062")]
		[Address(RVA = "0x5823B30", Offset = "0x5822730", VA = "0x185823B30", Slot = "4")]
		public override bool IsEnabledAndSupported(PostProcessRenderContext context)
		{
			return default(bool);
		}

		// Token: 0x06000063 RID: 99 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000063")]
		[Address(RVA = "0x5823B90", Offset = "0x5822790", VA = "0x185823B90")]
		public HGMobileBlur()
		{
		}

		// Token: 0x040000B6 RID: 182
		[Token(Token = "0x40000B6")]
		[FieldOffset(Offset = "0x30")]
		[Range(0f, 1f)]
		[Tooltip("Blur Degree")]
		public FloatParameter blurDegree;

		// Token: 0x040000B7 RID: 183
		[Token(Token = "0x40000B7")]
		[FieldOffset(Offset = "0x38")]
		[DisplayName("Resolution Mode")]
		[Tooltip("Blur Quality, Related to resolution")]
		public HGMobileBlur.BlurModeParameter resMode;

		// Token: 0x040000B8 RID: 184
		[Token(Token = "0x40000B8")]
		[FieldOffset(Offset = "0x40")]
		[Range(0.2f, 1.3f)]
		[DisplayName("Blur Spread")]
		[Tooltip("Blur distance, too large may cause artifact!")]
		public FloatParameter blurSpread;

		// Token: 0x040000B9 RID: 185
		[Token(Token = "0x40000B9")]
		[FieldOffset(Offset = "0x48")]
		[DisplayName("Quality")]
		[Tooltip("Rendertexture size")]
		public HGMobileBlur.Blurquality quality;

		// Token: 0x02000033 RID: 51
		[Token(Token = "0x2000033")]
		public enum BlurMode
		{
			// Token: 0x040000BB RID: 187
			[Token(Token = "0x40000BB")]
			LowRes,
			// Token: 0x040000BC RID: 188
			[Token(Token = "0x40000BC")]
			HighRes
		}

		// Token: 0x02000034 RID: 52
		[Token(Token = "0x2000034")]
		public enum Quality
		{
			// Token: 0x040000BE RID: 190
			[Token(Token = "0x40000BE")]
			High,
			// Token: 0x040000BF RID: 191
			[Token(Token = "0x40000BF")]
			Low
		}

		// Token: 0x02000035 RID: 53
		[Token(Token = "0x2000035")]
		[Serializable]
		public sealed class BlurModeParameter : ParameterOverride<HGMobileBlur.BlurMode>
		{
			// Token: 0x06000064 RID: 100 RVA: 0x0000207E File Offset: 0x0000027E
			[Token(Token = "0x6000064")]
			[Address(RVA = "0x581A2F0", Offset = "0x5818EF0", VA = "0x18581A2F0")]
			public BlurModeParameter()
			{
			}
		}

		// Token: 0x02000036 RID: 54
		[Token(Token = "0x2000036")]
		[Serializable]
		public sealed class Blurquality : ParameterOverride<HGMobileBlur.Quality>
		{
			// Token: 0x06000065 RID: 101 RVA: 0x0000207E File Offset: 0x0000027E
			[Token(Token = "0x6000065")]
			[Address(RVA = "0x581A330", Offset = "0x5818F30", VA = "0x18581A330")]
			public Blurquality()
			{
			}
		}
	}
}
