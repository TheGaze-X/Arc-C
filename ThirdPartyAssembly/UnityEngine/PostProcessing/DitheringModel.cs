using System;
using Il2CppDummyDll;

namespace UnityEngine.PostProcessing
{
	// Token: 0x020000CD RID: 205
	[Token(Token = "0x20000CD")]
	[Serializable]
	public class DitheringModel : PostProcessingModel
	{
		// Token: 0x17000067 RID: 103
		// (get) Token: 0x0600038A RID: 906 RVA: 0x00003498 File Offset: 0x00001698
		// (set) Token: 0x0600038B RID: 907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000067")]
		public DitheringModel.Settings settings
		{
			[Token(Token = "0x600038A")]
			[Address(RVA = "0x4F4E70", Offset = "0x4F3A70", VA = "0x1804F4E70")]
			get
			{
				return default(DitheringModel.Settings);
			}
			[Token(Token = "0x600038B")]
			[Address(RVA = "0x4F4E80", Offset = "0x4F3A80", VA = "0x1804F4E80")]
			set
			{
			}
		}

		// Token: 0x0600038C RID: 908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600038C")]
		[Address(RVA = "0x5422FE0", Offset = "0x5421BE0", VA = "0x185422FE0", Slot = "4")]
		public override void Reset()
		{
		}

		// Token: 0x0600038D RID: 909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600038D")]
		[Address(RVA = "0x4E0E1A0", Offset = "0x4E0CDA0", VA = "0x184E0E1A0")]
		public DitheringModel()
		{
		}

		// Token: 0x040004CA RID: 1226
		[Token(Token = "0x40004CA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private DitheringModel.Settings m_Settings;

		// Token: 0x020000CE RID: 206
		[Token(Token = "0x20000CE")]
		[Serializable]
		public struct Settings
		{
			// Token: 0x17000068 RID: 104
			// (get) Token: 0x0600038E RID: 910 RVA: 0x000034B0 File Offset: 0x000016B0
			[Token(Token = "0x17000068")]
			public static DitheringModel.Settings defaultSettings
			{
				[Token(Token = "0x600038E")]
				[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40")]
				get
				{
					return default(DitheringModel.Settings);
				}
			}
		}
	}
}
