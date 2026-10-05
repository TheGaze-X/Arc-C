using System;
using Il2CppDummyDll;

namespace UnityEngine.PostProcessing
{
	// Token: 0x020000D2 RID: 210
	[Token(Token = "0x20000D2")]
	[Serializable]
	public class FogModel : PostProcessingModel
	{
		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000394 RID: 916 RVA: 0x000034F8 File Offset: 0x000016F8
		// (set) Token: 0x06000395 RID: 917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700006B")]
		public FogModel.Settings settings
		{
			[Token(Token = "0x6000394")]
			[Address(RVA = "0x4F4E70", Offset = "0x4F3A70", VA = "0x1804F4E70")]
			get
			{
				return default(FogModel.Settings);
			}
			[Token(Token = "0x6000395")]
			[Address(RVA = "0x4F4E80", Offset = "0x4F3A80", VA = "0x1804F4E80")]
			set
			{
			}
		}

		// Token: 0x06000396 RID: 918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000396")]
		[Address(RVA = "0x54236C0", Offset = "0x54222C0", VA = "0x1854236C0", Slot = "4")]
		public override void Reset()
		{
		}

		// Token: 0x06000397 RID: 919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000397")]
		[Address(RVA = "0x3224DB0", Offset = "0x32239B0", VA = "0x183224DB0")]
		public FogModel()
		{
		}

		// Token: 0x040004DA RID: 1242
		[Token(Token = "0x40004DA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private FogModel.Settings m_Settings;

		// Token: 0x020000D3 RID: 211
		[Token(Token = "0x20000D3")]
		[Serializable]
		public struct Settings
		{
			// Token: 0x1700006C RID: 108
			// (get) Token: 0x06000398 RID: 920 RVA: 0x00003510 File Offset: 0x00001710
			[Token(Token = "0x1700006C")]
			public static FogModel.Settings defaultSettings
			{
				[Token(Token = "0x6000398")]
				[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70")]
				get
				{
					return default(FogModel.Settings);
				}
			}

			// Token: 0x040004DB RID: 1243
			[Token(Token = "0x40004DB")]
			[FieldOffset(Offset = "0x0")]
			[Tooltip("Should the fog affect the skybox?")]
			public bool excludeSkybox;
		}
	}
}
