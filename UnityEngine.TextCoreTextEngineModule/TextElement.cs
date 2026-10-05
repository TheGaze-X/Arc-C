using System;
using Il2CppDummyDll;

namespace UnityEngine.TextCore.Text
{
	// Token: 0x0200001D RID: 29
	[Token(Token = "0x200001D")]
	[Serializable]
	public abstract class TextElement
	{
		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x000025C8 File Offset: 0x000007C8
		[Token(Token = "0x1700002C")]
		public TextElementType elementType
		{
			[Token(Token = "0x60000D7")]
			[Address(RVA = "0x5995790", Offset = "0x5994390", VA = "0x185995790")]
			get
			{
				return (TextElementType)0;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x000025E0 File Offset: 0x000007E0
		// (set) Token: 0x060000D9 RID: 217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002D")]
		public uint unicode
		{
			[Token(Token = "0x60000D8")]
			[Address(RVA = "0x4889940", Offset = "0x4888540", VA = "0x184889940")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60000D9")]
			[Address(RVA = "0x4EEB40", Offset = "0x4ED740", VA = "0x1804EEB40")]
			set
			{
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000DA RID: 218 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x060000DB RID: 219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002E")]
		public TextAsset textAsset
		{
			[Token(Token = "0x60000DA")]
			[Address(RVA = "0x4893C50", Offset = "0x4892850", VA = "0x184893C50")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000DB")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			set
			{
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000DC RID: 220 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x060000DD RID: 221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700002F")]
		public Glyph glyph
		{
			[Token(Token = "0x60000DC")]
			[Address(RVA = "0x5911BE0", Offset = "0x59107E0", VA = "0x185911BE0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000DD")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			set
			{
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000DE RID: 222 RVA: 0x000025F8 File Offset: 0x000007F8
		// (set) Token: 0x060000DF RID: 223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000030")]
		public uint glyphIndex
		{
			[Token(Token = "0x60000DE")]
			[Address(RVA = "0x59649A0", Offset = "0x59635A0", VA = "0x1859649A0")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60000DF")]
			[Address(RVA = "0x4EF630", Offset = "0x4EE230", VA = "0x1804EF630")]
			set
			{
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x00002610 File Offset: 0x00000810
		// (set) Token: 0x060000E1 RID: 225 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000031")]
		public float scale
		{
			[Token(Token = "0x60000E0")]
			[Address(RVA = "0x59BA3C0", Offset = "0x59B8FC0", VA = "0x1859BA3C0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60000E1")]
			[Address(RVA = "0x4E4C110", Offset = "0x4E4AD10", VA = "0x184E4C110")]
			set
			{
			}
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected TextElement()
		{
		}

		// Token: 0x040000BF RID: 191
		[Token(Token = "0x40000BF")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		protected TextElementType m_ElementType;

		// Token: 0x040000C0 RID: 192
		[Token(Token = "0x40000C0")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		internal uint m_Unicode;

		// Token: 0x040000C1 RID: 193
		[Token(Token = "0x40000C1")]
		[FieldOffset(Offset = "0x18")]
		internal TextAsset m_TextAsset;

		// Token: 0x040000C2 RID: 194
		[Token(Token = "0x40000C2")]
		[FieldOffset(Offset = "0x20")]
		internal Glyph m_Glyph;

		// Token: 0x040000C3 RID: 195
		[Token(Token = "0x40000C3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		internal uint m_GlyphIndex;

		// Token: 0x040000C4 RID: 196
		[Token(Token = "0x40000C4")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		internal float m_Scale;
	}
}
