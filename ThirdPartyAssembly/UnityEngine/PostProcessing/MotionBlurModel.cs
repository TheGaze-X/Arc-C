using System;
using Il2CppDummyDll;

namespace UnityEngine.PostProcessing
{
	// Token: 0x020000D6 RID: 214
	[Token(Token = "0x20000D6")]
	[Serializable]
	public class MotionBlurModel : PostProcessingModel
	{
		// Token: 0x1700006F RID: 111
		// (get) Token: 0x0600039E RID: 926 RVA: 0x00003558 File Offset: 0x00001758
		// (set) Token: 0x0600039F RID: 927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700006F")]
		public MotionBlurModel.Settings settings
		{
			[Token(Token = "0x600039E")]
			[Address(RVA = "0x5428EA0", Offset = "0x5427AA0", VA = "0x185428EA0")]
			get
			{
				return default(MotionBlurModel.Settings);
			}
			[Token(Token = "0x600039F")]
			[Address(RVA = "0x5428EC0", Offset = "0x5427AC0", VA = "0x185428EC0")]
			set
			{
			}
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003A0")]
		[Address(RVA = "0x5428E20", Offset = "0x5427A20", VA = "0x185428E20", Slot = "4")]
		public override void Reset()
		{
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003A1")]
		[Address(RVA = "0x5428E60", Offset = "0x5427A60", VA = "0x185428E60")]
		public MotionBlurModel()
		{
		}

		// Token: 0x040004E1 RID: 1249
		[Token(Token = "0x40004E1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MotionBlurModel.Settings m_Settings;

		// Token: 0x020000D7 RID: 215
		[Token(Token = "0x20000D7")]
		[Serializable]
		public struct Settings
		{
			// Token: 0x17000070 RID: 112
			// (get) Token: 0x060003A2 RID: 930 RVA: 0x00003570 File Offset: 0x00001770
			[Token(Token = "0x17000070")]
			public static MotionBlurModel.Settings defaultSettings
			{
				[Token(Token = "0x60003A2")]
				[Address(RVA = "0x5432130", Offset = "0x5430D30", VA = "0x185432130")]
				get
				{
					return default(MotionBlurModel.Settings);
				}
			}

			// Token: 0x040004E2 RID: 1250
			[Token(Token = "0x40004E2")]
			[FieldOffset(Offset = "0x0")]
			[Tooltip("The angle of rotary shutter. Larger values give longer exposure.")]
			[Range(0f, 360f)]
			public float shutterAngle;

			// Token: 0x040004E3 RID: 1251
			[Token(Token = "0x40004E3")]
			[FieldOffset(Offset = "0x4")]
			[Range(4f, 32f)]
			[Tooltip("The amount of sample points, which affects quality and performances.")]
			public int sampleCount;

			// Token: 0x040004E4 RID: 1252
			[Token(Token = "0x40004E4")]
			[FieldOffset(Offset = "0x8")]
			[Tooltip("The strength of multiple frame blending. The opacity of preceding frames are determined from this coefficient and time differences.")]
			[Range(0f, 1f)]
			public float frameBlending;
		}
	}
}
