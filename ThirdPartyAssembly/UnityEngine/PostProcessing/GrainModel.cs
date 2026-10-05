using System;
using Il2CppDummyDll;

namespace UnityEngine.PostProcessing
{
	// Token: 0x020000D4 RID: 212
	[Token(Token = "0x20000D4")]
	[Serializable]
	public class GrainModel : PostProcessingModel
	{
		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000399 RID: 921 RVA: 0x00003528 File Offset: 0x00001728
		// (set) Token: 0x0600039A RID: 922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700006D")]
		public GrainModel.Settings settings
		{
			[Token(Token = "0x6000399")]
			[Address(RVA = "0x906940", Offset = "0x905540", VA = "0x180906940")]
			get
			{
				return default(GrainModel.Settings);
			}
			[Token(Token = "0x600039A")]
			[Address(RVA = "0x36B1B50", Offset = "0x36B0750", VA = "0x1836B1B50")]
			set
			{
			}
		}

		// Token: 0x0600039B RID: 923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600039B")]
		[Address(RVA = "0x5426B10", Offset = "0x5425710", VA = "0x185426B10", Slot = "4")]
		public override void Reset()
		{
		}

		// Token: 0x0600039C RID: 924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600039C")]
		[Address(RVA = "0x5426B70", Offset = "0x5425770", VA = "0x185426B70")]
		public GrainModel()
		{
		}

		// Token: 0x040004DC RID: 1244
		[Token(Token = "0x40004DC")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GrainModel.Settings m_Settings;

		// Token: 0x020000D5 RID: 213
		[Token(Token = "0x20000D5")]
		[Serializable]
		public struct Settings
		{
			// Token: 0x1700006E RID: 110
			// (get) Token: 0x0600039D RID: 925 RVA: 0x00003540 File Offset: 0x00001740
			[Token(Token = "0x1700006E")]
			public static GrainModel.Settings defaultSettings
			{
				[Token(Token = "0x600039D")]
				[Address(RVA = "0x54322F0", Offset = "0x5430EF0", VA = "0x1854322F0")]
				get
				{
					return default(GrainModel.Settings);
				}
			}

			// Token: 0x040004DD RID: 1245
			[Token(Token = "0x40004DD")]
			[FieldOffset(Offset = "0x0")]
			[Tooltip("Enable the use of colored grain.")]
			public bool colored;

			// Token: 0x040004DE RID: 1246
			[Token(Token = "0x40004DE")]
			[FieldOffset(Offset = "0x4")]
			[Tooltip("Grain strength. Higher means more visible grain.")]
			[Range(0f, 1f)]
			public float intensity;

			// Token: 0x040004DF RID: 1247
			[Token(Token = "0x40004DF")]
			[FieldOffset(Offset = "0x8")]
			[Range(0.3f, 3f)]
			[Tooltip("Grain particle size in \"Filmic\" mode.")]
			public float size;

			// Token: 0x040004E0 RID: 1248
			[Token(Token = "0x40004E0")]
			[FieldOffset(Offset = "0xC")]
			[Range(0f, 1f)]
			[Tooltip("Controls the noisiness response curve based on scene luminance. Lower values mean less noise in dark areas.")]
			public float luminanceContribution;
		}
	}
}
