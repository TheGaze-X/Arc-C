using System;
using Il2CppDummyDll;

namespace UnityEngine.PostProcessing
{
	// Token: 0x020000E1 RID: 225
	[Token(Token = "0x20000E1")]
	[Serializable]
	public class VignetteModel : PostProcessingModel
	{
		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060003AD RID: 941 RVA: 0x000035E8 File Offset: 0x000017E8
		// (set) Token: 0x060003AE RID: 942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000075")]
		public VignetteModel.Settings settings
		{
			[Token(Token = "0x60003AD")]
			[Address(RVA = "0x5435C90", Offset = "0x5434890", VA = "0x185435C90")]
			get
			{
				return default(VignetteModel.Settings);
			}
			[Token(Token = "0x60003AE")]
			[Address(RVA = "0x5435CC0", Offset = "0x54348C0", VA = "0x185435CC0")]
			set
			{
			}
		}

		// Token: 0x060003AF RID: 943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003AF")]
		[Address(RVA = "0x5435B60", Offset = "0x5434760", VA = "0x185435B60", Slot = "4")]
		public override void Reset()
		{
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003B0")]
		[Address(RVA = "0x5435BF0", Offset = "0x54347F0", VA = "0x185435BF0")]
		public VignetteModel()
		{
		}

		// Token: 0x040004FF RID: 1279
		[Token(Token = "0x40004FF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private VignetteModel.Settings m_Settings;

		// Token: 0x020000E2 RID: 226
		[Token(Token = "0x20000E2")]
		public enum Mode
		{
			// Token: 0x04000501 RID: 1281
			[Token(Token = "0x4000501")]
			Classic,
			// Token: 0x04000502 RID: 1282
			[Token(Token = "0x4000502")]
			Masked
		}

		// Token: 0x020000E3 RID: 227
		[Token(Token = "0x20000E3")]
		[Serializable]
		public struct Settings
		{
			// Token: 0x17000076 RID: 118
			// (get) Token: 0x060003B1 RID: 945 RVA: 0x00003600 File Offset: 0x00001800
			[Token(Token = "0x17000076")]
			public static VignetteModel.Settings defaultSettings
			{
				[Token(Token = "0x60003B1")]
				[Address(RVA = "0x5432150", Offset = "0x5430D50", VA = "0x185432150")]
				get
				{
					return default(VignetteModel.Settings);
				}
			}

			// Token: 0x04000503 RID: 1283
			[Token(Token = "0x4000503")]
			[FieldOffset(Offset = "0x0")]
			[Tooltip("Use the \"Classic\" mode for parametric controls. Use \"Round\" to get a perfectly round vignette no matter what the aspect ratio is. Use the \"Masked\" mode to use your own texture mask.")]
			public VignetteModel.Mode mode;

			// Token: 0x04000504 RID: 1284
			[Token(Token = "0x4000504")]
			[FieldOffset(Offset = "0x4")]
			[Tooltip("Vignette color. Use the alpha channel for transparency.")]
			[ColorUsage(false)]
			public Color color;

			// Token: 0x04000505 RID: 1285
			[Token(Token = "0x4000505")]
			[FieldOffset(Offset = "0x14")]
			[Tooltip("Sets the vignette center point (screen center is [0.5,0.5]).")]
			public Vector2 center;

			// Token: 0x04000506 RID: 1286
			[Token(Token = "0x4000506")]
			[FieldOffset(Offset = "0x1C")]
			[Range(0f, 1f)]
			[Tooltip("Amount of vignetting on screen.")]
			public float intensity;

			// Token: 0x04000507 RID: 1287
			[Token(Token = "0x4000507")]
			[FieldOffset(Offset = "0x20")]
			[Tooltip("Smoothness of the vignette borders.")]
			[Range(0.01f, 1f)]
			public float smoothness;

			// Token: 0x04000508 RID: 1288
			[Token(Token = "0x4000508")]
			[FieldOffset(Offset = "0x24")]
			[Range(0f, 1f)]
			[Tooltip("Lower values will make a square-ish vignette.")]
			public float roundness;

			// Token: 0x04000509 RID: 1289
			[Token(Token = "0x4000509")]
			[FieldOffset(Offset = "0x28")]
			[Tooltip("A black and white mask to use as a vignette.")]
			public Texture mask;

			// Token: 0x0400050A RID: 1290
			[Token(Token = "0x400050A")]
			[FieldOffset(Offset = "0x30")]
			[Tooltip("Mask opacity.")]
			[Range(0f, 1f)]
			public float opacity;

			// Token: 0x0400050B RID: 1291
			[Token(Token = "0x400050B")]
			[FieldOffset(Offset = "0x34")]
			[Tooltip("Should the vignette be perfectly round or be dependent on the current aspect ratio?")]
			public bool rounded;
		}
	}
}
