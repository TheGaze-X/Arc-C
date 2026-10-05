using System;
using Il2CppDummyDll;
using UnityEngine.Serialization;

namespace UnityEngine.UI
{
	// Token: 0x0200006F RID: 111
	[Token(Token = "0x200006F")]
	[Serializable]
	public struct SpriteState : IEquatable<SpriteState>
	{
		// Token: 0x17000146 RID: 326
		// (get) Token: 0x060004C7 RID: 1223 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060004C8 RID: 1224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000146")]
		public Sprite highlightedSprite
		{
			[Token(Token = "0x60004C7")]
			[Address(RVA = "0x925550", Offset = "0x924150", VA = "0x180925550")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004C8")]
			[Address(RVA = "0xE7C280", Offset = "0xE7AE80", VA = "0x180E7C280")]
			set
			{
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x060004C9 RID: 1225 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060004CA RID: 1226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000147")]
		public Sprite pressedSprite
		{
			[Token(Token = "0x60004C9")]
			[Address(RVA = "0xE93E60", Offset = "0xE92A60", VA = "0x180E93E60")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004CA")]
			[Address(RVA = "0xFE9360", Offset = "0xFE7F60", VA = "0x180FE9360")]
			set
			{
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x060004CB RID: 1227 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060004CC RID: 1228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000148")]
		public Sprite selectedSprite
		{
			[Token(Token = "0x60004CB")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004CC")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			set
			{
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x060004CD RID: 1229 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060004CE RID: 1230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000149")]
		public Sprite disabledSprite
		{
			[Token(Token = "0x60004CD")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
			[Token(Token = "0x60004CE")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			set
			{
			}
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x00003EA0 File Offset: 0x000020A0
		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x5B7BE40", Offset = "0x5B7AA40", VA = "0x185B7BE40", Slot = "4")]
		public bool Equals(SpriteState other)
		{
			return default(bool);
		}

		// Token: 0x0400024D RID: 589
		[Token(Token = "0x400024D")]
		[FieldOffset(Offset = "0x0")]
		[SerializeField]
		private Sprite m_HighlightedSprite;

		// Token: 0x0400024E RID: 590
		[Token(Token = "0x400024E")]
		[FieldOffset(Offset = "0x8")]
		[SerializeField]
		private Sprite m_PressedSprite;

		// Token: 0x0400024F RID: 591
		[Token(Token = "0x400024F")]
		[FieldOffset(Offset = "0x10")]
		[FormerlySerializedAs("m_HighlightedSprite")]
		[SerializeField]
		private Sprite m_SelectedSprite;

		// Token: 0x04000250 RID: 592
		[Token(Token = "0x4000250")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Sprite m_DisabledSprite;
	}
}
