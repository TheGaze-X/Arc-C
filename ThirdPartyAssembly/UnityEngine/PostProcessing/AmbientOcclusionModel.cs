using System;
using Il2CppDummyDll;

namespace UnityEngine.PostProcessing
{
	// Token: 0x020000A9 RID: 169
	[Token(Token = "0x20000A9")]
	[Serializable]
	public class AmbientOcclusionModel : PostProcessingModel
	{
		// Token: 0x17000048 RID: 72
		// (get) Token: 0x0600034F RID: 847 RVA: 0x000031B0 File Offset: 0x000013B0
		// (set) Token: 0x06000350 RID: 848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000048")]
		public AmbientOcclusionModel.Settings settings
		{
			[Token(Token = "0x600034F")]
			[Address(RVA = "0x906940", Offset = "0x905540", VA = "0x180906940")]
			get
			{
				return default(AmbientOcclusionModel.Settings);
			}
			[Token(Token = "0x6000350")]
			[Address(RVA = "0x36B1B50", Offset = "0x36B0750", VA = "0x1836B1B50")]
			set
			{
			}
		}

		// Token: 0x06000351 RID: 849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000351")]
		[Address(RVA = "0x541D880", Offset = "0x541C480", VA = "0x18541D880", Slot = "4")]
		public override void Reset()
		{
		}

		// Token: 0x06000352 RID: 850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000352")]
		[Address(RVA = "0x541D8E0", Offset = "0x541C4E0", VA = "0x18541D8E0")]
		public AmbientOcclusionModel()
		{
		}

		// Token: 0x0400043E RID: 1086
		[Token(Token = "0x400043E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private AmbientOcclusionModel.Settings m_Settings;

		// Token: 0x020000AA RID: 170
		[Token(Token = "0x20000AA")]
		public enum SampleCount
		{
			// Token: 0x04000440 RID: 1088
			[Token(Token = "0x4000440")]
			Lowest = 3,
			// Token: 0x04000441 RID: 1089
			[Token(Token = "0x4000441")]
			Low = 6,
			// Token: 0x04000442 RID: 1090
			[Token(Token = "0x4000442")]
			Medium = 10,
			// Token: 0x04000443 RID: 1091
			[Token(Token = "0x4000443")]
			High = 16
		}

		// Token: 0x020000AB RID: 171
		[Token(Token = "0x20000AB")]
		[Serializable]
		public struct Settings
		{
			// Token: 0x17000049 RID: 73
			// (get) Token: 0x06000353 RID: 851 RVA: 0x000031C8 File Offset: 0x000013C8
			[Token(Token = "0x17000049")]
			public static AmbientOcclusionModel.Settings defaultSettings
			{
				[Token(Token = "0x6000353")]
				[Address(RVA = "0x5432110", Offset = "0x5430D10", VA = "0x185432110")]
				get
				{
					return default(AmbientOcclusionModel.Settings);
				}
			}

			// Token: 0x04000444 RID: 1092
			[Token(Token = "0x4000444")]
			[FieldOffset(Offset = "0x0")]
			[Tooltip("Degree of darkness produced by the effect.")]
			[Range(0f, 4f)]
			public float intensity;

			// Token: 0x04000445 RID: 1093
			[Token(Token = "0x4000445")]
			[FieldOffset(Offset = "0x4")]
			[Tooltip("Radius of sample points, which affects extent of darkened areas.")]
			[PPMin(0.0001f)]
			public float radius;

			// Token: 0x04000446 RID: 1094
			[Token(Token = "0x4000446")]
			[FieldOffset(Offset = "0x8")]
			[Tooltip("Number of sample points, which affects quality and performance.")]
			public AmbientOcclusionModel.SampleCount sampleCount;

			// Token: 0x04000447 RID: 1095
			[Token(Token = "0x4000447")]
			[FieldOffset(Offset = "0xC")]
			[Tooltip("Halves the resolution of the effect to increase performance.")]
			public bool downsampling;

			// Token: 0x04000448 RID: 1096
			[Token(Token = "0x4000448")]
			[FieldOffset(Offset = "0xD")]
			[Tooltip("Forces compatibility with Forward rendered objects when working with the Deferred rendering path.")]
			public bool forceForwardCompatibility;

			// Token: 0x04000449 RID: 1097
			[Token(Token = "0x4000449")]
			[FieldOffset(Offset = "0xE")]
			[Tooltip("Enables the ambient-only mode in that the effect only affects ambient lighting. This mode is only available with the Deferred rendering path and HDR rendering.")]
			public bool ambientOnly;

			// Token: 0x0400044A RID: 1098
			[Token(Token = "0x400044A")]
			[FieldOffset(Offset = "0xF")]
			[Tooltip("Toggles the use of a higher precision depth texture with the forward rendering path (may impact performances). Has no effect with the deferred rendering path.")]
			public bool highPrecision;
		}
	}
}
