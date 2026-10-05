using System;
using Il2CppDummyDll;

namespace UnityEngine.PostProcessing
{
	// Token: 0x020000AC RID: 172
	[Token(Token = "0x20000AC")]
	[Serializable]
	public class AntialiasingModel : PostProcessingModel
	{
		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000354 RID: 852 RVA: 0x000031E0 File Offset: 0x000013E0
		// (set) Token: 0x06000355 RID: 853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700004A")]
		public AntialiasingModel.Settings settings
		{
			[Token(Token = "0x6000354")]
			[Address(RVA = "0x15F2880", Offset = "0x15F1480", VA = "0x1815F2880")]
			get
			{
				return default(AntialiasingModel.Settings);
			}
			[Token(Token = "0x6000355")]
			[Address(RVA = "0x541D9C0", Offset = "0x541C5C0", VA = "0x18541D9C0")]
			set
			{
			}
		}

		// Token: 0x06000356 RID: 854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000356")]
		[Address(RVA = "0x541D940", Offset = "0x541C540", VA = "0x18541D940", Slot = "4")]
		public override void Reset()
		{
		}

		// Token: 0x06000357 RID: 855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000357")]
		[Address(RVA = "0x541D980", Offset = "0x541C580", VA = "0x18541D980")]
		public AntialiasingModel()
		{
		}

		// Token: 0x0400044B RID: 1099
		[Token(Token = "0x400044B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AntialiasingModel.Settings m_Settings;

		// Token: 0x020000AD RID: 173
		[Token(Token = "0x20000AD")]
		public enum Method
		{
			// Token: 0x0400044D RID: 1101
			[Token(Token = "0x400044D")]
			Fxaa,
			// Token: 0x0400044E RID: 1102
			[Token(Token = "0x400044E")]
			Taa
		}

		// Token: 0x020000AE RID: 174
		[Token(Token = "0x20000AE")]
		public enum FxaaPreset
		{
			// Token: 0x04000450 RID: 1104
			[Token(Token = "0x4000450")]
			ExtremePerformance,
			// Token: 0x04000451 RID: 1105
			[Token(Token = "0x4000451")]
			Performance,
			// Token: 0x04000452 RID: 1106
			[Token(Token = "0x4000452")]
			Default,
			// Token: 0x04000453 RID: 1107
			[Token(Token = "0x4000453")]
			Quality,
			// Token: 0x04000454 RID: 1108
			[Token(Token = "0x4000454")]
			ExtremeQuality
		}

		// Token: 0x020000AF RID: 175
		[Token(Token = "0x20000AF")]
		[Serializable]
		public struct FxaaQualitySettings
		{
			// Token: 0x04000455 RID: 1109
			[Token(Token = "0x4000455")]
			[FieldOffset(Offset = "0x0")]
			[Tooltip("The amount of desired sub-pixel aliasing removal. Effects the sharpeness of the output.")]
			[Range(0f, 1f)]
			public float subpixelAliasingRemovalAmount;

			// Token: 0x04000456 RID: 1110
			[Token(Token = "0x4000456")]
			[FieldOffset(Offset = "0x4")]
			[Range(0.063f, 0.333f)]
			[Tooltip("The minimum amount of local contrast required to qualify a region as containing an edge.")]
			public float edgeDetectionThreshold;

			// Token: 0x04000457 RID: 1111
			[Token(Token = "0x4000457")]
			[FieldOffset(Offset = "0x8")]
			[Tooltip("Local contrast adaptation value to disallow the algorithm from executing on the darker regions.")]
			[Range(0f, 0.0833f)]
			public float minimumRequiredLuminance;

			// Token: 0x04000458 RID: 1112
			[Token(Token = "0x4000458")]
			[FieldOffset(Offset = "0x0")]
			public static AntialiasingModel.FxaaQualitySettings[] presets;
		}

		// Token: 0x020000B0 RID: 176
		[Token(Token = "0x20000B0")]
		[Serializable]
		public struct FxaaConsoleSettings
		{
			// Token: 0x04000459 RID: 1113
			[Token(Token = "0x4000459")]
			[FieldOffset(Offset = "0x0")]
			[Tooltip("The amount of spread applied to the sampling coordinates while sampling for subpixel information.")]
			[Range(0.33f, 0.5f)]
			public float subpixelSpreadAmount;

			// Token: 0x0400045A RID: 1114
			[Token(Token = "0x400045A")]
			[FieldOffset(Offset = "0x4")]
			[Tooltip("This value dictates how sharp the edges in the image are kept; a higher value implies sharper edges.")]
			[Range(2f, 8f)]
			public float edgeSharpnessAmount;

			// Token: 0x0400045B RID: 1115
			[Token(Token = "0x400045B")]
			[FieldOffset(Offset = "0x8")]
			[Range(0.125f, 0.25f)]
			[Tooltip("The minimum amount of local contrast required to qualify a region as containing an edge.")]
			public float edgeDetectionThreshold;

			// Token: 0x0400045C RID: 1116
			[Token(Token = "0x400045C")]
			[FieldOffset(Offset = "0xC")]
			[Range(0.04f, 0.06f)]
			[Tooltip("Local contrast adaptation value to disallow the algorithm from executing on the darker regions.")]
			public float minimumRequiredLuminance;

			// Token: 0x0400045D RID: 1117
			[Token(Token = "0x400045D")]
			[FieldOffset(Offset = "0x0")]
			public static AntialiasingModel.FxaaConsoleSettings[] presets;
		}

		// Token: 0x020000B1 RID: 177
		[Token(Token = "0x20000B1")]
		[Serializable]
		public struct FxaaSettings
		{
			// Token: 0x1700004B RID: 75
			// (get) Token: 0x0600035A RID: 858 RVA: 0x000031F8 File Offset: 0x000013F8
			[Token(Token = "0x1700004B")]
			public static AntialiasingModel.FxaaSettings defaultSettings
			{
				[Token(Token = "0x600035A")]
				[Address(RVA = "0x54B0E0", Offset = "0x549CE0", VA = "0x18054B0E0")]
				get
				{
					return default(AntialiasingModel.FxaaSettings);
				}
			}

			// Token: 0x0400045E RID: 1118
			[Token(Token = "0x400045E")]
			[FieldOffset(Offset = "0x0")]
			public AntialiasingModel.FxaaPreset preset;
		}

		// Token: 0x020000B2 RID: 178
		[Token(Token = "0x20000B2")]
		[Serializable]
		public struct TaaSettings
		{
			// Token: 0x1700004C RID: 76
			// (get) Token: 0x0600035B RID: 859 RVA: 0x00003210 File Offset: 0x00001410
			[Token(Token = "0x1700004C")]
			public static AntialiasingModel.TaaSettings defaultSettings
			{
				[Token(Token = "0x600035B")]
				[Address(RVA = "0x5433BA0", Offset = "0x54327A0", VA = "0x185433BA0")]
				get
				{
					return default(AntialiasingModel.TaaSettings);
				}
			}

			// Token: 0x0400045F RID: 1119
			[Token(Token = "0x400045F")]
			[FieldOffset(Offset = "0x0")]
			[Range(0.1f, 1f)]
			[Tooltip("The diameter (in texels) inside which jitter samples are spread. Smaller values result in crisper but more aliased output, while larger values result in more stable but blurrier output.")]
			public float jitterSpread;

			// Token: 0x04000460 RID: 1120
			[Token(Token = "0x4000460")]
			[FieldOffset(Offset = "0x4")]
			[Tooltip("Controls the amount of sharpening applied to the color buffer.")]
			[Range(0f, 3f)]
			public float sharpen;

			// Token: 0x04000461 RID: 1121
			[Token(Token = "0x4000461")]
			[FieldOffset(Offset = "0x8")]
			[Tooltip("The blend coefficient for a stationary fragment. Controls the percentage of history sample blended into the final color.")]
			[Range(0f, 0.99f)]
			public float stationaryBlending;

			// Token: 0x04000462 RID: 1122
			[Token(Token = "0x4000462")]
			[FieldOffset(Offset = "0xC")]
			[Tooltip("The blend coefficient for a fragment with significant motion. Controls the percentage of history sample blended into the final color.")]
			[Range(0f, 0.99f)]
			public float motionBlending;
		}

		// Token: 0x020000B3 RID: 179
		[Token(Token = "0x20000B3")]
		[Serializable]
		public struct Settings
		{
			// Token: 0x1700004D RID: 77
			// (get) Token: 0x0600035C RID: 860 RVA: 0x00003228 File Offset: 0x00001428
			[Token(Token = "0x1700004D")]
			public static AntialiasingModel.Settings defaultSettings
			{
				[Token(Token = "0x600035C")]
				[Address(RVA = "0x5432350", Offset = "0x5430F50", VA = "0x185432350")]
				get
				{
					return default(AntialiasingModel.Settings);
				}
			}

			// Token: 0x04000463 RID: 1123
			[Token(Token = "0x4000463")]
			[FieldOffset(Offset = "0x0")]
			public AntialiasingModel.Method method;

			// Token: 0x04000464 RID: 1124
			[Token(Token = "0x4000464")]
			[FieldOffset(Offset = "0x4")]
			public AntialiasingModel.FxaaSettings fxaaSettings;

			// Token: 0x04000465 RID: 1125
			[Token(Token = "0x4000465")]
			[FieldOffset(Offset = "0x8")]
			public AntialiasingModel.TaaSettings taaSettings;
		}
	}
}
