using System;
using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x0200003B RID: 59
	[Token(Token = "0x200003B")]
	[PostProcess(typeof(MotionBlurRenderer), "Unity/Motion Blur", false)]
	[Serializable]
	public sealed class MotionBlur : PostProcessEffectSettings
	{
		// Token: 0x0600006D RID: 109 RVA: 0x00002294 File Offset: 0x00000494
		[Token(Token = "0x600006D")]
		[Address(RVA = "0x5825110", Offset = "0x5823D10", VA = "0x185825110", Slot = "4")]
		public override bool IsEnabledAndSupported(PostProcessRenderContext context)
		{
			return default(bool);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600006E")]
		[Address(RVA = "0x58251D0", Offset = "0x5823DD0", VA = "0x1858251D0")]
		public MotionBlur()
		{
		}

		// Token: 0x040000CD RID: 205
		[Token(Token = "0x40000CD")]
		[FieldOffset(Offset = "0x30")]
		[Range(0f, 360f)]
		[Tooltip("The angle of rotary shutter. Larger values give longer exposure.")]
		public FloatParameter shutterAngle;

		// Token: 0x040000CE RID: 206
		[Token(Token = "0x40000CE")]
		[FieldOffset(Offset = "0x38")]
		[Range(4f, 32f)]
		[Tooltip("The amount of sample points. This affects quality and performance.")]
		public IntParameter sampleCount;
	}
}
