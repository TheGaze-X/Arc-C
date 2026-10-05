using System;
using Il2CppDummyDll;

namespace UnityEngine.PostProcessing
{
	// Token: 0x020000CA RID: 202
	[Token(Token = "0x20000CA")]
	[Serializable]
	public class DepthOfFieldModel : PostProcessingModel
	{
		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000385 RID: 901 RVA: 0x00003468 File Offset: 0x00001668
		// (set) Token: 0x06000386 RID: 902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000065")]
		public DepthOfFieldModel.Settings settings
		{
			[Token(Token = "0x6000385")]
			[Address(RVA = "0x5422FA0", Offset = "0x5421BA0", VA = "0x185422FA0")]
			get
			{
				return default(DepthOfFieldModel.Settings);
			}
			[Token(Token = "0x6000386")]
			[Address(RVA = "0x5422FC0", Offset = "0x5421BC0", VA = "0x185422FC0")]
			set
			{
			}
		}

		// Token: 0x06000387 RID: 903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000387")]
		[Address(RVA = "0x5422EE0", Offset = "0x5421AE0", VA = "0x185422EE0", Slot = "4")]
		public override void Reset()
		{
		}

		// Token: 0x06000388 RID: 904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000388")]
		[Address(RVA = "0x5422F40", Offset = "0x5421B40", VA = "0x185422F40")]
		public DepthOfFieldModel()
		{
		}

		// Token: 0x040004BF RID: 1215
		[Token(Token = "0x40004BF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private DepthOfFieldModel.Settings m_Settings;

		// Token: 0x020000CB RID: 203
		[Token(Token = "0x20000CB")]
		public enum KernelSize
		{
			// Token: 0x040004C1 RID: 1217
			[Token(Token = "0x40004C1")]
			Small,
			// Token: 0x040004C2 RID: 1218
			[Token(Token = "0x40004C2")]
			Medium,
			// Token: 0x040004C3 RID: 1219
			[Token(Token = "0x40004C3")]
			Large,
			// Token: 0x040004C4 RID: 1220
			[Token(Token = "0x40004C4")]
			VeryLarge
		}

		// Token: 0x020000CC RID: 204
		[Token(Token = "0x20000CC")]
		[Serializable]
		public struct Settings
		{
			// Token: 0x17000066 RID: 102
			// (get) Token: 0x06000389 RID: 905 RVA: 0x00003480 File Offset: 0x00001680
			[Token(Token = "0x17000066")]
			public static DepthOfFieldModel.Settings defaultSettings
			{
				[Token(Token = "0x6000389")]
				[Address(RVA = "0x5432500", Offset = "0x5431100", VA = "0x185432500")]
				get
				{
					return default(DepthOfFieldModel.Settings);
				}
			}

			// Token: 0x040004C5 RID: 1221
			[Token(Token = "0x40004C5")]
			[FieldOffset(Offset = "0x0")]
			[PPMin(0.1f)]
			[Tooltip("Distance to the point of focus.")]
			public float focusDistance;

			// Token: 0x040004C6 RID: 1222
			[Token(Token = "0x40004C6")]
			[FieldOffset(Offset = "0x4")]
			[Tooltip("Ratio of aperture (known as f-stop or f-number). The smaller the value is, the shallower the depth of field is.")]
			[Range(0.05f, 32f)]
			public float aperture;

			// Token: 0x040004C7 RID: 1223
			[Token(Token = "0x40004C7")]
			[FieldOffset(Offset = "0x8")]
			[Range(1f, 300f)]
			[Tooltip("Distance between the lens and the film. The larger the value is, the shallower the depth of field is.")]
			public float focalLength;

			// Token: 0x040004C8 RID: 1224
			[Token(Token = "0x40004C8")]
			[FieldOffset(Offset = "0xC")]
			[Tooltip("Calculate the focal length automatically from the field-of-view value set on the camera.")]
			public bool useCameraFov;

			// Token: 0x040004C9 RID: 1225
			[Token(Token = "0x40004C9")]
			[FieldOffset(Offset = "0x10")]
			[Tooltip("Convolution kernel size of the bokeh filter, which determines the maximum radius of bokeh. It also affects the performance (the larger the kernel is, the longer the GPU time is required).")]
			public DepthOfFieldModel.KernelSize kernelSize;
		}
	}
}
