using System;
using Il2CppDummyDll;

namespace UnityEngine.PostProcessing
{
	// Token: 0x020000EB RID: 235
	[Token(Token = "0x20000EB")]
	public class PostProcessingProfile : ScriptableObject
	{
		// Token: 0x060003E3 RID: 995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003E3")]
		[Address(RVA = "0x542D9E0", Offset = "0x542C5E0", VA = "0x18542D9E0")]
		public PostProcessingProfile()
		{
		}

		// Token: 0x04000531 RID: 1329
		[Token(Token = "0x4000531")]
		[FieldOffset(Offset = "0x18")]
		public BuiltinDebugViewsModel debugViews;

		// Token: 0x04000532 RID: 1330
		[Token(Token = "0x4000532")]
		[FieldOffset(Offset = "0x20")]
		public FogModel fog;

		// Token: 0x04000533 RID: 1331
		[Token(Token = "0x4000533")]
		[FieldOffset(Offset = "0x28")]
		public AntialiasingModel antialiasing;

		// Token: 0x04000534 RID: 1332
		[Token(Token = "0x4000534")]
		[FieldOffset(Offset = "0x30")]
		public AmbientOcclusionModel ambientOcclusion;

		// Token: 0x04000535 RID: 1333
		[Token(Token = "0x4000535")]
		[FieldOffset(Offset = "0x38")]
		public ScreenSpaceReflectionModel screenSpaceReflection;

		// Token: 0x04000536 RID: 1334
		[Token(Token = "0x4000536")]
		[FieldOffset(Offset = "0x40")]
		public DepthOfFieldModel depthOfField;

		// Token: 0x04000537 RID: 1335
		[Token(Token = "0x4000537")]
		[FieldOffset(Offset = "0x48")]
		public MotionBlurModel motionBlur;

		// Token: 0x04000538 RID: 1336
		[Token(Token = "0x4000538")]
		[FieldOffset(Offset = "0x50")]
		public EyeAdaptationModel eyeAdaptation;

		// Token: 0x04000539 RID: 1337
		[Token(Token = "0x4000539")]
		[FieldOffset(Offset = "0x58")]
		public BloomModel bloom;

		// Token: 0x0400053A RID: 1338
		[Token(Token = "0x400053A")]
		[FieldOffset(Offset = "0x60")]
		public ColorGradingModel colorGrading;

		// Token: 0x0400053B RID: 1339
		[Token(Token = "0x400053B")]
		[FieldOffset(Offset = "0x68")]
		public UserLutModel userLut;

		// Token: 0x0400053C RID: 1340
		[Token(Token = "0x400053C")]
		[FieldOffset(Offset = "0x70")]
		public ChromaticAberrationModel chromaticAberration;

		// Token: 0x0400053D RID: 1341
		[Token(Token = "0x400053D")]
		[FieldOffset(Offset = "0x78")]
		public GrainModel grain;

		// Token: 0x0400053E RID: 1342
		[Token(Token = "0x400053E")]
		[FieldOffset(Offset = "0x80")]
		public VignetteModel vignette;

		// Token: 0x0400053F RID: 1343
		[Token(Token = "0x400053F")]
		[FieldOffset(Offset = "0x88")]
		public DitheringModel dithering;
	}
}
