using System;
using Il2CppDummyDll;

namespace UnityEngine.PostProcessing
{
	// Token: 0x020000B8 RID: 184
	[Token(Token = "0x20000B8")]
	[Serializable]
	public class BuiltinDebugViewsModel : PostProcessingModel
	{
		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000366 RID: 870 RVA: 0x000032B8 File Offset: 0x000014B8
		// (set) Token: 0x06000367 RID: 871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000053")]
		public BuiltinDebugViewsModel.Settings settings
		{
			[Token(Token = "0x6000366")]
			[Address(RVA = "0x120F310", Offset = "0x120DF10", VA = "0x18120F310")]
			get
			{
				return default(BuiltinDebugViewsModel.Settings);
			}
			[Token(Token = "0x6000367")]
			[Address(RVA = "0x5421EF0", Offset = "0x5420AF0", VA = "0x185421EF0")]
			set
			{
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000368 RID: 872 RVA: 0x000032D0 File Offset: 0x000014D0
		[Token(Token = "0x17000054")]
		public bool willInterrupt
		{
			[Token(Token = "0x6000368")]
			[Address(RVA = "0x5421ED0", Offset = "0x5420AD0", VA = "0x185421ED0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000369 RID: 873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000369")]
		[Address(RVA = "0x5421E00", Offset = "0x5420A00", VA = "0x185421E00", Slot = "4")]
		public override void Reset()
		{
		}

		// Token: 0x0600036A RID: 874 RVA: 0x000032E8 File Offset: 0x000014E8
		[Token(Token = "0x600036A")]
		[Address(RVA = "0x5421DF0", Offset = "0x54209F0", VA = "0x185421DF0")]
		public bool IsModeActive(BuiltinDebugViewsModel.Mode mode)
		{
			return default(bool);
		}

		// Token: 0x0600036B RID: 875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600036B")]
		[Address(RVA = "0x5421E60", Offset = "0x5420A60", VA = "0x185421E60")]
		public BuiltinDebugViewsModel()
		{
		}

		// Token: 0x04000470 RID: 1136
		[Token(Token = "0x4000470")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private BuiltinDebugViewsModel.Settings m_Settings;

		// Token: 0x020000B9 RID: 185
		[Token(Token = "0x20000B9")]
		[Serializable]
		public struct DepthSettings
		{
			// Token: 0x17000055 RID: 85
			// (get) Token: 0x0600036C RID: 876 RVA: 0x00003300 File Offset: 0x00001500
			[Token(Token = "0x17000055")]
			public static BuiltinDebugViewsModel.DepthSettings defaultSettings
			{
				[Token(Token = "0x600036C")]
				[Address(RVA = "0x5422FD0", Offset = "0x5421BD0", VA = "0x185422FD0")]
				get
				{
					return default(BuiltinDebugViewsModel.DepthSettings);
				}
			}

			// Token: 0x04000471 RID: 1137
			[Token(Token = "0x4000471")]
			[FieldOffset(Offset = "0x0")]
			[Range(0f, 1f)]
			[Tooltip("Scales the camera far plane before displaying the depth map.")]
			public float scale;
		}

		// Token: 0x020000BA RID: 186
		[Token(Token = "0x20000BA")]
		[Serializable]
		public struct MotionVectorsSettings
		{
			// Token: 0x17000056 RID: 86
			// (get) Token: 0x0600036D RID: 877 RVA: 0x00003318 File Offset: 0x00001518
			[Token(Token = "0x17000056")]
			public static BuiltinDebugViewsModel.MotionVectorsSettings defaultSettings
			{
				[Token(Token = "0x600036D")]
				[Address(RVA = "0x5428ED0", Offset = "0x5427AD0", VA = "0x185428ED0")]
				get
				{
					return default(BuiltinDebugViewsModel.MotionVectorsSettings);
				}
			}

			// Token: 0x04000472 RID: 1138
			[Token(Token = "0x4000472")]
			[FieldOffset(Offset = "0x0")]
			[Range(0f, 1f)]
			[Tooltip("Opacity of the source render.")]
			public float sourceOpacity;

			// Token: 0x04000473 RID: 1139
			[Token(Token = "0x4000473")]
			[FieldOffset(Offset = "0x4")]
			[Range(0f, 1f)]
			[Tooltip("Opacity of the per-pixel motion vector colors.")]
			public float motionImageOpacity;

			// Token: 0x04000474 RID: 1140
			[Token(Token = "0x4000474")]
			[FieldOffset(Offset = "0x8")]
			[PPMin(0f)]
			[Tooltip("Because motion vectors are mainly very small vectors, you can use this setting to make them more visible.")]
			public float motionImageAmplitude;

			// Token: 0x04000475 RID: 1141
			[Token(Token = "0x4000475")]
			[FieldOffset(Offset = "0xC")]
			[Tooltip("Opacity for the motion vector arrows.")]
			[Range(0f, 1f)]
			public float motionVectorsOpacity;

			// Token: 0x04000476 RID: 1142
			[Token(Token = "0x4000476")]
			[FieldOffset(Offset = "0x10")]
			[Range(8f, 64f)]
			[Tooltip("The arrow density on screen.")]
			public int motionVectorsResolution;

			// Token: 0x04000477 RID: 1143
			[Token(Token = "0x4000477")]
			[FieldOffset(Offset = "0x14")]
			[PPMin(0f)]
			[Tooltip("Tweaks the arrows length.")]
			public float motionVectorsAmplitude;
		}

		// Token: 0x020000BB RID: 187
		[Token(Token = "0x20000BB")]
		public enum Mode
		{
			// Token: 0x04000479 RID: 1145
			[Token(Token = "0x4000479")]
			None,
			// Token: 0x0400047A RID: 1146
			[Token(Token = "0x400047A")]
			Depth,
			// Token: 0x0400047B RID: 1147
			[Token(Token = "0x400047B")]
			Normals,
			// Token: 0x0400047C RID: 1148
			[Token(Token = "0x400047C")]
			MotionVectors,
			// Token: 0x0400047D RID: 1149
			[Token(Token = "0x400047D")]
			AmbientOcclusion,
			// Token: 0x0400047E RID: 1150
			[Token(Token = "0x400047E")]
			EyeAdaptation,
			// Token: 0x0400047F RID: 1151
			[Token(Token = "0x400047F")]
			FocusPlane,
			// Token: 0x04000480 RID: 1152
			[Token(Token = "0x4000480")]
			PreGradingLog,
			// Token: 0x04000481 RID: 1153
			[Token(Token = "0x4000481")]
			LogLut,
			// Token: 0x04000482 RID: 1154
			[Token(Token = "0x4000482")]
			UserLut
		}

		// Token: 0x020000BC RID: 188
		[Token(Token = "0x20000BC")]
		[Serializable]
		public struct Settings
		{
			// Token: 0x17000057 RID: 87
			// (get) Token: 0x0600036E RID: 878 RVA: 0x00003330 File Offset: 0x00001530
			[Token(Token = "0x17000057")]
			public static BuiltinDebugViewsModel.Settings defaultSettings
			{
				[Token(Token = "0x600036E")]
				[Address(RVA = "0x5432530", Offset = "0x5431130", VA = "0x185432530")]
				get
				{
					return default(BuiltinDebugViewsModel.Settings);
				}
			}

			// Token: 0x04000483 RID: 1155
			[Token(Token = "0x4000483")]
			[FieldOffset(Offset = "0x0")]
			public BuiltinDebugViewsModel.Mode mode;

			// Token: 0x04000484 RID: 1156
			[Token(Token = "0x4000484")]
			[FieldOffset(Offset = "0x4")]
			public BuiltinDebugViewsModel.DepthSettings depth;

			// Token: 0x04000485 RID: 1157
			[Token(Token = "0x4000485")]
			[FieldOffset(Offset = "0x8")]
			public BuiltinDebugViewsModel.MotionVectorsSettings motionVectors;
		}
	}
}
