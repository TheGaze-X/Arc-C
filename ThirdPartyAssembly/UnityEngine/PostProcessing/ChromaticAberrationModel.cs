using System;
using Il2CppDummyDll;

namespace UnityEngine.PostProcessing
{
	// Token: 0x020000BD RID: 189
	[Token(Token = "0x20000BD")]
	[Serializable]
	public class ChromaticAberrationModel : PostProcessingModel
	{
		// Token: 0x17000058 RID: 88
		// (get) Token: 0x0600036F RID: 879 RVA: 0x00003348 File Offset: 0x00001548
		// (set) Token: 0x06000370 RID: 880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000058")]
		public ChromaticAberrationModel.Settings settings
		{
			[Token(Token = "0x600036F")]
			[Address(RVA = "0x906940", Offset = "0x905540", VA = "0x180906940")]
			get
			{
				return default(ChromaticAberrationModel.Settings);
			}
			[Token(Token = "0x6000370")]
			[Address(RVA = "0x906A40", Offset = "0x905640", VA = "0x180906A40")]
			set
			{
			}
		}

		// Token: 0x06000371 RID: 881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000371")]
		[Address(RVA = "0x5421F70", Offset = "0x5420B70", VA = "0x185421F70", Slot = "4")]
		public override void Reset()
		{
		}

		// Token: 0x06000372 RID: 882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000372")]
		[Address(RVA = "0x5421FE0", Offset = "0x5420BE0", VA = "0x185421FE0")]
		public ChromaticAberrationModel()
		{
		}

		// Token: 0x04000486 RID: 1158
		[Token(Token = "0x4000486")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ChromaticAberrationModel.Settings m_Settings;

		// Token: 0x020000BE RID: 190
		[Token(Token = "0x20000BE")]
		[Serializable]
		public struct Settings
		{
			// Token: 0x17000059 RID: 89
			// (get) Token: 0x06000373 RID: 883 RVA: 0x00003360 File Offset: 0x00001560
			[Token(Token = "0x17000059")]
			public static ChromaticAberrationModel.Settings defaultSettings
			{
				[Token(Token = "0x6000373")]
				[Address(RVA = "0x5432220", Offset = "0x5430E20", VA = "0x185432220")]
				get
				{
					return default(ChromaticAberrationModel.Settings);
				}
			}

			// Token: 0x04000487 RID: 1159
			[Token(Token = "0x4000487")]
			[FieldOffset(Offset = "0x0")]
			[Tooltip("Shift the hue of chromatic aberrations.")]
			public Texture2D spectralTexture;

			// Token: 0x04000488 RID: 1160
			[Token(Token = "0x4000488")]
			[FieldOffset(Offset = "0x8")]
			[Tooltip("Amount of tangential distortion.")]
			[Range(0f, 1f)]
			public float intensity;
		}
	}
}
