using System;
using Il2CppDummyDll;

namespace UnityEngine.PostProcessing
{
	// Token: 0x020000DF RID: 223
	[Token(Token = "0x20000DF")]
	[Serializable]
	public class UserLutModel : PostProcessingModel
	{
		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060003A8 RID: 936 RVA: 0x000035B8 File Offset: 0x000017B8
		// (set) Token: 0x060003A9 RID: 937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000073")]
		public UserLutModel.Settings settings
		{
			[Token(Token = "0x60003A8")]
			[Address(RVA = "0x906940", Offset = "0x905540", VA = "0x180906940")]
			get
			{
				return default(UserLutModel.Settings);
			}
			[Token(Token = "0x60003A9")]
			[Address(RVA = "0x906A40", Offset = "0x905640", VA = "0x180906A40")]
			set
			{
			}
		}

		// Token: 0x060003AA RID: 938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003AA")]
		[Address(RVA = "0x5435720", Offset = "0x5434320", VA = "0x185435720", Slot = "4")]
		public override void Reset()
		{
		}

		// Token: 0x060003AB RID: 939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003AB")]
		[Address(RVA = "0x5435790", Offset = "0x5434390", VA = "0x185435790")]
		public UserLutModel()
		{
		}

		// Token: 0x040004FC RID: 1276
		[Token(Token = "0x40004FC")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UserLutModel.Settings m_Settings;

		// Token: 0x020000E0 RID: 224
		[Token(Token = "0x20000E0")]
		[Serializable]
		public struct Settings
		{
			// Token: 0x17000074 RID: 116
			// (get) Token: 0x060003AC RID: 940 RVA: 0x000035D0 File Offset: 0x000017D0
			[Token(Token = "0x17000074")]
			public static UserLutModel.Settings defaultSettings
			{
				[Token(Token = "0x60003AC")]
				[Address(RVA = "0x5432320", Offset = "0x5430F20", VA = "0x185432320")]
				get
				{
					return default(UserLutModel.Settings);
				}
			}

			// Token: 0x040004FD RID: 1277
			[Token(Token = "0x40004FD")]
			[FieldOffset(Offset = "0x0")]
			[Tooltip("Custom lookup texture (strip format, e.g. 256x16).")]
			public Texture2D lut;

			// Token: 0x040004FE RID: 1278
			[Token(Token = "0x40004FE")]
			[FieldOffset(Offset = "0x8")]
			[Range(0f, 1f)]
			[Tooltip("Blending factor.")]
			public float contribution;
		}
	}
}
