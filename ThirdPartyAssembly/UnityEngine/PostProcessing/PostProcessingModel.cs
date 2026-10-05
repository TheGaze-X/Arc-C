using System;
using Il2CppDummyDll;

namespace UnityEngine.PostProcessing
{
	// Token: 0x020000EA RID: 234
	[Token(Token = "0x20000EA")]
	[Serializable]
	public abstract class PostProcessingModel
	{
		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060003DE RID: 990 RVA: 0x000036D8 File Offset: 0x000018D8
		// (set) Token: 0x060003DF RID: 991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700007F")]
		public bool enabled
		{
			[Token(Token = "0x60003DE")]
			[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60003DF")]
			[Address(RVA = "0x542D9A0", Offset = "0x542C5A0", VA = "0x18542D9A0")]
			set
			{
			}
		}

		// Token: 0x060003E0 RID: 992
		[Token(Token = "0x60003E0")]
		public abstract void Reset();

		// Token: 0x060003E1 RID: 993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003E1")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "5")]
		public virtual void OnValidate()
		{
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60003E2")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected PostProcessingModel()
		{
		}

		// Token: 0x04000530 RID: 1328
		[Token(Token = "0x4000530")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		[GetSet("enabled")]
		private bool m_Enabled;
	}
}
