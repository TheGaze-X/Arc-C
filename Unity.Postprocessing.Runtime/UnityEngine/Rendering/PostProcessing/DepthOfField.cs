using System;
using Il2CppDummyDll;

namespace UnityEngine.Rendering.PostProcessing
{
	// Token: 0x02000023 RID: 35
	[Token(Token = "0x2000023")]
	[PostProcess(typeof(DepthOfFieldRenderer), "Unity/Depth of Field", false)]
	[Serializable]
	public sealed class DepthOfField : PostProcessEffectSettings
	{
		// Token: 0x0600003E RID: 62 RVA: 0x0000215C File Offset: 0x0000035C
		[Token(Token = "0x600003E")]
		[Address(RVA = "0x5820990", Offset = "0x581F590", VA = "0x185820990", Slot = "4")]
		public override bool IsEnabledAndSupported(PostProcessRenderContext context)
		{
			return default(bool);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x58209D0", Offset = "0x581F5D0", VA = "0x1858209D0")]
		public DepthOfField()
		{
		}

		// Token: 0x04000085 RID: 133
		[Token(Token = "0x4000085")]
		[FieldOffset(Offset = "0x30")]
		[PPMin(0.1f)]
		[Tooltip("Distance to the point of focus.")]
		public FloatParameter focusDistance;

		// Token: 0x04000086 RID: 134
		[Token(Token = "0x4000086")]
		[FieldOffset(Offset = "0x38")]
		[Range(0.05f, 32f)]
		[Tooltip("Ratio of aperture (known as f-stop or f-number). The smaller the value is, the shallower the depth of field is.")]
		public FloatParameter aperture;

		// Token: 0x04000087 RID: 135
		[Token(Token = "0x4000087")]
		[FieldOffset(Offset = "0x40")]
		[Range(1f, 300f)]
		[Tooltip("Distance between the lens and the film. The larger the value is, the shallower the depth of field is.")]
		public FloatParameter focalLength;

		// Token: 0x04000088 RID: 136
		[Token(Token = "0x4000088")]
		[FieldOffset(Offset = "0x48")]
		[DisplayName("Max Blur Size")]
		[Tooltip("Convolution kernel size of the bokeh filter, which determines the maximum radius of bokeh. It also affects performances (the larger the kernel is, the longer the GPU time is required).")]
		public KernelSizeParameter kernelSize;
	}
}
