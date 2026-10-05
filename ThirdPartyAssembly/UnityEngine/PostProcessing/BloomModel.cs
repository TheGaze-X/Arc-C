using System;
using Il2CppDummyDll;

namespace UnityEngine.PostProcessing
{
	// Token: 0x020000B4 RID: 180
	[Token(Token = "0x20000B4")]
	[Serializable]
	public class BloomModel : PostProcessingModel
	{
		// Token: 0x1700004E RID: 78
		// (get) Token: 0x0600035D RID: 861 RVA: 0x00003240 File Offset: 0x00001440
		// (set) Token: 0x0600035E RID: 862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700004E")]
		public BloomModel.Settings settings
		{
			[Token(Token = "0x600035D")]
			[Address(RVA = "0x133EFA0", Offset = "0x133DBA0", VA = "0x18133EFA0")]
			get
			{
				return default(BloomModel.Settings);
			}
			[Token(Token = "0x600035E")]
			[Address(RVA = "0x5421D60", Offset = "0x5420960", VA = "0x185421D60")]
			set
			{
			}
		}

		// Token: 0x0600035F RID: 863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600035F")]
		[Address(RVA = "0x5421C00", Offset = "0x5420800", VA = "0x185421C00", Slot = "4")]
		public override void Reset()
		{
		}

		// Token: 0x06000360 RID: 864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000360")]
		[Address(RVA = "0x5421CB0", Offset = "0x54208B0", VA = "0x185421CB0")]
		public BloomModel()
		{
		}

		// Token: 0x04000466 RID: 1126
		[Token(Token = "0x4000466")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private BloomModel.Settings m_Settings;

		// Token: 0x020000B5 RID: 181
		[Token(Token = "0x20000B5")]
		[Serializable]
		public struct BloomSettings
		{
			// Token: 0x1700004F RID: 79
			// (get) Token: 0x06000362 RID: 866 RVA: 0x00003258 File Offset: 0x00001458
			// (set) Token: 0x06000361 RID: 865 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700004F")]
			public float thresholdLinear
			{
				[Token(Token = "0x6000362")]
				[Address(RVA = "0x5421DC0", Offset = "0x54209C0", VA = "0x185421DC0")]
				get
				{
					return 0f;
				}
				[Token(Token = "0x6000361")]
				[Address(RVA = "0x5421DD0", Offset = "0x54209D0", VA = "0x185421DD0")]
				set
				{
				}
			}

			// Token: 0x17000050 RID: 80
			// (get) Token: 0x06000363 RID: 867 RVA: 0x00003270 File Offset: 0x00001470
			[Token(Token = "0x17000050")]
			public static BloomModel.BloomSettings defaultSettings
			{
				[Token(Token = "0x6000363")]
				[Address(RVA = "0x5421D90", Offset = "0x5420990", VA = "0x185421D90")]
				get
				{
					return default(BloomModel.BloomSettings);
				}
			}

			// Token: 0x04000467 RID: 1127
			[Token(Token = "0x4000467")]
			[FieldOffset(Offset = "0x0")]
			[PPMin(0f)]
			[Tooltip("Blend factor of the result image.")]
			public float intensity;

			// Token: 0x04000468 RID: 1128
			[Token(Token = "0x4000468")]
			[FieldOffset(Offset = "0x4")]
			[PPMin(0f)]
			[Tooltip("Filters out pixels under this level of brightness.")]
			public float threshold;

			// Token: 0x04000469 RID: 1129
			[Token(Token = "0x4000469")]
			[FieldOffset(Offset = "0x8")]
			[Range(0f, 1f)]
			[Tooltip("Makes transition between under/over-threshold gradual (0 = hard threshold, 1 = soft threshold).")]
			public float softKnee;

			// Token: 0x0400046A RID: 1130
			[Token(Token = "0x400046A")]
			[FieldOffset(Offset = "0xC")]
			[Range(1f, 7f)]
			[Tooltip("Changes extent of veiling effects in a screen resolution-independent fashion.")]
			public float radius;

			// Token: 0x0400046B RID: 1131
			[Token(Token = "0x400046B")]
			[FieldOffset(Offset = "0x10")]
			[Tooltip("Reduces flashing noise with an additional filter.")]
			public bool antiFlicker;
		}

		// Token: 0x020000B6 RID: 182
		[Token(Token = "0x20000B6")]
		[Serializable]
		public struct LensDirtSettings
		{
			// Token: 0x17000051 RID: 81
			// (get) Token: 0x06000364 RID: 868 RVA: 0x00003288 File Offset: 0x00001488
			[Token(Token = "0x17000051")]
			public static BloomModel.LensDirtSettings defaultSettings
			{
				[Token(Token = "0x6000364")]
				[Address(RVA = "0x54273D0", Offset = "0x5425FD0", VA = "0x1854273D0")]
				get
				{
					return default(BloomModel.LensDirtSettings);
				}
			}

			// Token: 0x0400046C RID: 1132
			[Token(Token = "0x400046C")]
			[FieldOffset(Offset = "0x0")]
			[Tooltip("Dirtiness texture to add smudges or dust to the lens.")]
			public Texture texture;

			// Token: 0x0400046D RID: 1133
			[Token(Token = "0x400046D")]
			[FieldOffset(Offset = "0x8")]
			[Tooltip("Amount of lens dirtiness.")]
			[PPMin(0f)]
			public float intensity;
		}

		// Token: 0x020000B7 RID: 183
		[Token(Token = "0x20000B7")]
		[Serializable]
		public struct Settings
		{
			// Token: 0x17000052 RID: 82
			// (get) Token: 0x06000365 RID: 869 RVA: 0x000032A0 File Offset: 0x000014A0
			[Token(Token = "0x17000052")]
			public static BloomModel.Settings defaultSettings
			{
				[Token(Token = "0x6000365")]
				[Address(RVA = "0x5432590", Offset = "0x5431190", VA = "0x185432590")]
				get
				{
					return default(BloomModel.Settings);
				}
			}

			// Token: 0x0400046E RID: 1134
			[Token(Token = "0x400046E")]
			[FieldOffset(Offset = "0x0")]
			public BloomModel.BloomSettings bloom;

			// Token: 0x0400046F RID: 1135
			[Token(Token = "0x400046F")]
			[FieldOffset(Offset = "0x18")]
			public BloomModel.LensDirtSettings lensDirt;
		}
	}
}
