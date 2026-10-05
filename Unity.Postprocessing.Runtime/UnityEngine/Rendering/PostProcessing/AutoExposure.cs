using System;
using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000016 RID: 22
	[Token(Token = "0x2000016")]
	[PostProcess(typeof(AutoExposureRenderer), "Unity/Auto Exposure", true)]
	[Serializable]
	public sealed class AutoExposure : PostProcessEffectSettings
	{
		// Token: 0x06000021 RID: 33 RVA: 0x000020CC File Offset: 0x000002CC
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x5819F80", Offset = "0x5818B80", VA = "0x185819F80", Slot = "4")]
		public override bool IsEnabledAndSupported(PostProcessRenderContext context)
		{
			return default(bool);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x581A0E0", Offset = "0x5818CE0", VA = "0x18581A0E0")]
		public AutoExposure()
		{
		}

		// Token: 0x04000035 RID: 53
		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0x30")]
		[MinMax(1f, 99f)]
		[DisplayName("Filtering (%)")]
		[Tooltip("Filters the bright and dark parts of the histogram when computing the average luminance. This is to avoid very dark pixels and very bright pixels from contributing to the auto exposure. Unit is in percent.")]
		public Vector2Parameter filtering;

		// Token: 0x04000036 RID: 54
		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0x38")]
		[Range(-9f, 9f)]
		[DisplayName("Minimum (EV)")]
		[Tooltip("Minimum average luminance to consider for auto exposure. Unit is EV.")]
		public FloatParameter minLuminance;

		// Token: 0x04000037 RID: 55
		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0x40")]
		[DisplayName("Maximum (EV)")]
		[Tooltip("Maximum average luminance to consider for auto exposure. Unit is EV.")]
		[Range(-9f, 9f)]
		public FloatParameter maxLuminance;

		// Token: 0x04000038 RID: 56
		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0x48")]
		[PPMin(0f)]
		[DisplayName("Exposure Compensation")]
		[Tooltip("Use this to scale the global exposure of the scene.")]
		public FloatParameter keyValue;

		// Token: 0x04000039 RID: 57
		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0x50")]
		[DisplayName("Type")]
		[Tooltip("Use \"Progressive\" if you want auto exposure to be animated. Use \"Fixed\" otherwise.")]
		public EyeAdaptationParameter eyeAdaptation;

		// Token: 0x0400003A RID: 58
		[Token(Token = "0x400003A")]
		[FieldOffset(Offset = "0x58")]
		[PPMin(0f)]
		[Tooltip("Adaptation speed from a dark to a light environment.")]
		public FloatParameter speedUp;

		// Token: 0x0400003B RID: 59
		[Token(Token = "0x400003B")]
		[FieldOffset(Offset = "0x60")]
		[PPMin(0f)]
		[Tooltip("Adaptation speed from a light to a dark environment.")]
		public FloatParameter speedDown;
	}
}
