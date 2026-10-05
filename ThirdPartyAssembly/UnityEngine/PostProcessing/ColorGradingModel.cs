using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.PostProcessing
{
	// Token: 0x020000BF RID: 191
	[Token(Token = "0x20000BF")]
	[Serializable]
	public class ColorGradingModel : PostProcessingModel
	{
		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000374 RID: 884 RVA: 0x00003378 File Offset: 0x00001578
		// (set) Token: 0x06000375 RID: 885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700005A")]
		public ColorGradingModel.Settings settings
		{
			[Token(Token = "0x6000374")]
			[Address(RVA = "0x5422610", Offset = "0x5421210", VA = "0x185422610")]
			get
			{
				return default(ColorGradingModel.Settings);
			}
			[Token(Token = "0x6000375")]
			[Address(RVA = "0x5422690", Offset = "0x5421290", VA = "0x185422690")]
			set
			{
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000376 RID: 886 RVA: 0x00003390 File Offset: 0x00001590
		// (set) Token: 0x06000377 RID: 887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700005B")]
		public bool isDirty
		{
			[Token(Token = "0x6000376")]
			[Address(RVA = "0x4DA7640", Offset = "0x4DA6240", VA = "0x184DA7640")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000377")]
			[Address(RVA = "0x4DA7720", Offset = "0x4DA6320", VA = "0x184DA7720")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000378 RID: 888 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000379 RID: 889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700005C")]
		public RenderTexture bakedLut
		{
			[Token(Token = "0x6000378")]
			[Address(RVA = "0x538F820", Offset = "0x538E420", VA = "0x18538F820")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000379")]
			[Address(RVA = "0x4E7E510", Offset = "0x4E7D110", VA = "0x184E7E510")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		// Token: 0x0600037A RID: 890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600037A")]
		[Address(RVA = "0x54223D0", Offset = "0x5420FD0", VA = "0x1854223D0", Slot = "4")]
		public override void Reset()
		{
		}

		// Token: 0x0600037B RID: 891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600037B")]
		[Address(RVA = "0x54223C0", Offset = "0x5420FC0", VA = "0x1854223C0", Slot = "5")]
		public override void OnValidate()
		{
		}

		// Token: 0x0600037C RID: 892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600037C")]
		[Address(RVA = "0x5422500", Offset = "0x5421100", VA = "0x185422500")]
		public ColorGradingModel()
		{
		}

		// Token: 0x04000489 RID: 1161
		[Token(Token = "0x4000489")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ColorGradingModel.Settings m_Settings;

		// Token: 0x020000C0 RID: 192
		[Token(Token = "0x20000C0")]
		public enum Tonemapper
		{
			// Token: 0x0400048D RID: 1165
			[Token(Token = "0x400048D")]
			None,
			// Token: 0x0400048E RID: 1166
			[Token(Token = "0x400048E")]
			ACES,
			// Token: 0x0400048F RID: 1167
			[Token(Token = "0x400048F")]
			Neutral
		}

		// Token: 0x020000C1 RID: 193
		[Token(Token = "0x20000C1")]
		[Serializable]
		public struct TonemappingSettings
		{
			// Token: 0x1700005D RID: 93
			// (get) Token: 0x0600037D RID: 893 RVA: 0x000033A8 File Offset: 0x000015A8
			[Token(Token = "0x1700005D")]
			public static ColorGradingModel.TonemappingSettings defaultSettings
			{
				[Token(Token = "0x600037D")]
				[Address(RVA = "0x5433BC0", Offset = "0x54327C0", VA = "0x185433BC0")]
				get
				{
					return default(ColorGradingModel.TonemappingSettings);
				}
			}

			// Token: 0x04000490 RID: 1168
			[Token(Token = "0x4000490")]
			[FieldOffset(Offset = "0x0")]
			[Tooltip("Tonemapping algorithm to use at the end of the color grading process. Use \"Neutral\" if you need a customizable tonemapper or \"Filmic\" to give a standard filmic look to your scenes.")]
			public ColorGradingModel.Tonemapper tonemapper;

			// Token: 0x04000491 RID: 1169
			[Token(Token = "0x4000491")]
			[FieldOffset(Offset = "0x4")]
			[Range(-0.1f, 0.1f)]
			public float neutralBlackIn;

			// Token: 0x04000492 RID: 1170
			[Token(Token = "0x4000492")]
			[FieldOffset(Offset = "0x8")]
			[Range(1f, 20f)]
			public float neutralWhiteIn;

			// Token: 0x04000493 RID: 1171
			[Token(Token = "0x4000493")]
			[FieldOffset(Offset = "0xC")]
			[Range(-0.09f, 0.1f)]
			public float neutralBlackOut;

			// Token: 0x04000494 RID: 1172
			[Token(Token = "0x4000494")]
			[FieldOffset(Offset = "0x10")]
			[Range(1f, 19f)]
			public float neutralWhiteOut;

			// Token: 0x04000495 RID: 1173
			[Token(Token = "0x4000495")]
			[FieldOffset(Offset = "0x14")]
			[Range(0.1f, 20f)]
			public float neutralWhiteLevel;

			// Token: 0x04000496 RID: 1174
			[Token(Token = "0x4000496")]
			[FieldOffset(Offset = "0x18")]
			[Range(1f, 10f)]
			public float neutralWhiteClip;
		}

		// Token: 0x020000C2 RID: 194
		[Token(Token = "0x20000C2")]
		[Serializable]
		public struct BasicSettings
		{
			// Token: 0x1700005E RID: 94
			// (get) Token: 0x0600037E RID: 894 RVA: 0x000033C0 File Offset: 0x000015C0
			[Token(Token = "0x1700005E")]
			public static ColorGradingModel.BasicSettings defaultSettings
			{
				[Token(Token = "0x600037E")]
				[Address(RVA = "0x5421BE0", Offset = "0x54207E0", VA = "0x185421BE0")]
				get
				{
					return default(ColorGradingModel.BasicSettings);
				}
			}

			// Token: 0x04000497 RID: 1175
			[Token(Token = "0x4000497")]
			[FieldOffset(Offset = "0x0")]
			[Tooltip("Adjusts the overall exposure of the scene in EV units. This is applied after HDR effect and right before tonemapping so it won't affect previous effects in the chain.")]
			public float postExposure;

			// Token: 0x04000498 RID: 1176
			[Token(Token = "0x4000498")]
			[FieldOffset(Offset = "0x4")]
			[Range(-100f, 100f)]
			[Tooltip("Sets the white balance to a custom color temperature.")]
			public float temperature;

			// Token: 0x04000499 RID: 1177
			[Token(Token = "0x4000499")]
			[FieldOffset(Offset = "0x8")]
			[Range(-100f, 100f)]
			[Tooltip("Sets the white balance to compensate for a green or magenta tint.")]
			public float tint;

			// Token: 0x0400049A RID: 1178
			[Token(Token = "0x400049A")]
			[FieldOffset(Offset = "0xC")]
			[Tooltip("Shift the hue of all colors.")]
			[Range(-180f, 180f)]
			public float hueShift;

			// Token: 0x0400049B RID: 1179
			[Token(Token = "0x400049B")]
			[FieldOffset(Offset = "0x10")]
			[Range(0f, 2f)]
			[Tooltip("Pushes the intensity of all colors.")]
			public float saturation;

			// Token: 0x0400049C RID: 1180
			[Token(Token = "0x400049C")]
			[FieldOffset(Offset = "0x14")]
			[Tooltip("Expands or shrinks the overall range of tonal values.")]
			[Range(0f, 2f)]
			public float contrast;
		}

		// Token: 0x020000C3 RID: 195
		[Token(Token = "0x20000C3")]
		[Serializable]
		public struct ChannelMixerSettings
		{
			// Token: 0x1700005F RID: 95
			// (get) Token: 0x0600037F RID: 895 RVA: 0x000033D8 File Offset: 0x000015D8
			[Token(Token = "0x1700005F")]
			public static ColorGradingModel.ChannelMixerSettings defaultSettings
			{
				[Token(Token = "0x600037F")]
				[Address(RVA = "0x5421F00", Offset = "0x5420B00", VA = "0x185421F00")]
				get
				{
					return default(ColorGradingModel.ChannelMixerSettings);
				}
			}

			// Token: 0x0400049D RID: 1181
			[Token(Token = "0x400049D")]
			[FieldOffset(Offset = "0x0")]
			public Vector3 red;

			// Token: 0x0400049E RID: 1182
			[Token(Token = "0x400049E")]
			[FieldOffset(Offset = "0xC")]
			public Vector3 green;

			// Token: 0x0400049F RID: 1183
			[Token(Token = "0x400049F")]
			[FieldOffset(Offset = "0x18")]
			public Vector3 blue;

			// Token: 0x040004A0 RID: 1184
			[Token(Token = "0x40004A0")]
			[FieldOffset(Offset = "0x24")]
			[HideInInspector]
			public int currentEditingChannel;
		}

		// Token: 0x020000C4 RID: 196
		[Token(Token = "0x20000C4")]
		[Serializable]
		public struct LogWheelsSettings
		{
			// Token: 0x17000060 RID: 96
			// (get) Token: 0x06000380 RID: 896 RVA: 0x000033F0 File Offset: 0x000015F0
			[Token(Token = "0x17000060")]
			public static ColorGradingModel.LogWheelsSettings defaultSettings
			{
				[Token(Token = "0x6000380")]
				[Address(RVA = "0x5427400", Offset = "0x5426000", VA = "0x185427400")]
				get
				{
					return default(ColorGradingModel.LogWheelsSettings);
				}
			}

			// Token: 0x040004A1 RID: 1185
			[Token(Token = "0x40004A1")]
			[FieldOffset(Offset = "0x0")]
			[Trackball("GetSlopeValue")]
			public Color slope;

			// Token: 0x040004A2 RID: 1186
			[Token(Token = "0x40004A2")]
			[FieldOffset(Offset = "0x10")]
			[Trackball("GetPowerValue")]
			public Color power;

			// Token: 0x040004A3 RID: 1187
			[Token(Token = "0x40004A3")]
			[FieldOffset(Offset = "0x20")]
			[Trackball("GetOffsetValue")]
			public Color offset;
		}

		// Token: 0x020000C5 RID: 197
		[Token(Token = "0x20000C5")]
		[Serializable]
		public struct LinearWheelsSettings
		{
			// Token: 0x17000061 RID: 97
			// (get) Token: 0x06000381 RID: 897 RVA: 0x00003408 File Offset: 0x00001608
			[Token(Token = "0x17000061")]
			public static ColorGradingModel.LinearWheelsSettings defaultSettings
			{
				[Token(Token = "0x6000381")]
				[Address(RVA = "0x5427400", Offset = "0x5426000", VA = "0x185427400")]
				get
				{
					return default(ColorGradingModel.LinearWheelsSettings);
				}
			}

			// Token: 0x040004A4 RID: 1188
			[Token(Token = "0x40004A4")]
			[FieldOffset(Offset = "0x0")]
			[Trackball("GetLiftValue")]
			public Color lift;

			// Token: 0x040004A5 RID: 1189
			[Token(Token = "0x40004A5")]
			[FieldOffset(Offset = "0x10")]
			[Trackball("GetGammaValue")]
			public Color gamma;

			// Token: 0x040004A6 RID: 1190
			[Token(Token = "0x40004A6")]
			[FieldOffset(Offset = "0x20")]
			[Trackball("GetGainValue")]
			public Color gain;
		}

		// Token: 0x020000C6 RID: 198
		[Token(Token = "0x20000C6")]
		public enum ColorWheelMode
		{
			// Token: 0x040004A8 RID: 1192
			[Token(Token = "0x40004A8")]
			Linear,
			// Token: 0x040004A9 RID: 1193
			[Token(Token = "0x40004A9")]
			Log
		}

		// Token: 0x020000C7 RID: 199
		[Token(Token = "0x20000C7")]
		[Serializable]
		public struct ColorWheelsSettings
		{
			// Token: 0x17000062 RID: 98
			// (get) Token: 0x06000382 RID: 898 RVA: 0x00003420 File Offset: 0x00001620
			[Token(Token = "0x17000062")]
			public static ColorGradingModel.ColorWheelsSettings defaultSettings
			{
				[Token(Token = "0x6000382")]
				[Address(RVA = "0x5422740", Offset = "0x5421340", VA = "0x185422740")]
				get
				{
					return default(ColorGradingModel.ColorWheelsSettings);
				}
			}

			// Token: 0x040004AA RID: 1194
			[Token(Token = "0x40004AA")]
			[FieldOffset(Offset = "0x0")]
			public ColorGradingModel.ColorWheelMode mode;

			// Token: 0x040004AB RID: 1195
			[Token(Token = "0x40004AB")]
			[FieldOffset(Offset = "0x4")]
			[TrackballGroup]
			public ColorGradingModel.LogWheelsSettings log;

			// Token: 0x040004AC RID: 1196
			[Token(Token = "0x40004AC")]
			[FieldOffset(Offset = "0x34")]
			[TrackballGroup]
			public ColorGradingModel.LinearWheelsSettings linear;
		}

		// Token: 0x020000C8 RID: 200
		[Token(Token = "0x20000C8")]
		[Serializable]
		public struct CurvesSettings
		{
			// Token: 0x17000063 RID: 99
			// (get) Token: 0x06000383 RID: 899 RVA: 0x00003438 File Offset: 0x00001638
			[Token(Token = "0x17000063")]
			public static ColorGradingModel.CurvesSettings defaultSettings
			{
				[Token(Token = "0x6000383")]
				[Address(RVA = "0x5422770", Offset = "0x5421370", VA = "0x185422770")]
				get
				{
					return default(ColorGradingModel.CurvesSettings);
				}
			}

			// Token: 0x040004AD RID: 1197
			[Token(Token = "0x40004AD")]
			[FieldOffset(Offset = "0x0")]
			public ColorGradingCurve master;

			// Token: 0x040004AE RID: 1198
			[Token(Token = "0x40004AE")]
			[FieldOffset(Offset = "0x8")]
			public ColorGradingCurve red;

			// Token: 0x040004AF RID: 1199
			[Token(Token = "0x40004AF")]
			[FieldOffset(Offset = "0x10")]
			public ColorGradingCurve green;

			// Token: 0x040004B0 RID: 1200
			[Token(Token = "0x40004B0")]
			[FieldOffset(Offset = "0x18")]
			public ColorGradingCurve blue;

			// Token: 0x040004B1 RID: 1201
			[Token(Token = "0x40004B1")]
			[FieldOffset(Offset = "0x20")]
			public ColorGradingCurve hueVShue;

			// Token: 0x040004B2 RID: 1202
			[Token(Token = "0x40004B2")]
			[FieldOffset(Offset = "0x28")]
			public ColorGradingCurve hueVSsat;

			// Token: 0x040004B3 RID: 1203
			[Token(Token = "0x40004B3")]
			[FieldOffset(Offset = "0x30")]
			public ColorGradingCurve satVSsat;

			// Token: 0x040004B4 RID: 1204
			[Token(Token = "0x40004B4")]
			[FieldOffset(Offset = "0x38")]
			public ColorGradingCurve lumVSsat;

			// Token: 0x040004B5 RID: 1205
			[Token(Token = "0x40004B5")]
			[FieldOffset(Offset = "0x40")]
			[HideInInspector]
			public int e_CurrentEditingCurve;

			// Token: 0x040004B6 RID: 1206
			[Token(Token = "0x40004B6")]
			[FieldOffset(Offset = "0x44")]
			[HideInInspector]
			public bool e_CurveY;

			// Token: 0x040004B7 RID: 1207
			[Token(Token = "0x40004B7")]
			[FieldOffset(Offset = "0x45")]
			[HideInInspector]
			public bool e_CurveR;

			// Token: 0x040004B8 RID: 1208
			[Token(Token = "0x40004B8")]
			[FieldOffset(Offset = "0x46")]
			[HideInInspector]
			public bool e_CurveG;

			// Token: 0x040004B9 RID: 1209
			[Token(Token = "0x40004B9")]
			[FieldOffset(Offset = "0x47")]
			[HideInInspector]
			public bool e_CurveB;
		}

		// Token: 0x020000C9 RID: 201
		[Token(Token = "0x20000C9")]
		[Serializable]
		public struct Settings
		{
			// Token: 0x17000064 RID: 100
			// (get) Token: 0x06000384 RID: 900 RVA: 0x00003450 File Offset: 0x00001650
			[Token(Token = "0x17000064")]
			public static ColorGradingModel.Settings defaultSettings
			{
				[Token(Token = "0x6000384")]
				[Address(RVA = "0x5432370", Offset = "0x5430F70", VA = "0x185432370")]
				get
				{
					return default(ColorGradingModel.Settings);
				}
			}

			// Token: 0x040004BA RID: 1210
			[Token(Token = "0x40004BA")]
			[FieldOffset(Offset = "0x0")]
			public ColorGradingModel.TonemappingSettings tonemapping;

			// Token: 0x040004BB RID: 1211
			[Token(Token = "0x40004BB")]
			[FieldOffset(Offset = "0x1C")]
			public ColorGradingModel.BasicSettings basic;

			// Token: 0x040004BC RID: 1212
			[Token(Token = "0x40004BC")]
			[FieldOffset(Offset = "0x34")]
			public ColorGradingModel.ChannelMixerSettings channelMixer;

			// Token: 0x040004BD RID: 1213
			[Token(Token = "0x40004BD")]
			[FieldOffset(Offset = "0x5C")]
			public ColorGradingModel.ColorWheelsSettings colorWheels;

			// Token: 0x040004BE RID: 1214
			[Token(Token = "0x40004BE")]
			[FieldOffset(Offset = "0xC0")]
			public ColorGradingModel.CurvesSettings curves;
		}
	}
}
