using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.TextCore;

namespace TMPro
{
	// Token: 0x02000099 RID: 153
	[Token(Token = "0x2000099")]
	[Serializable]
	public class TMP_TextElement
	{
		// Token: 0x17000167 RID: 359
		// (get) Token: 0x060005DB RID: 1499 RVA: 0x00004488 File Offset: 0x00002688
		[Token(Token = "0x17000167")]
		public TextElementType elementType
		{
			[Token(Token = "0x60005DB")]
			[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300")]
			get
			{
				return (TextElementType)0;
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x060005DC RID: 1500 RVA: 0x000044A0 File Offset: 0x000026A0
		// (set) Token: 0x060005DD RID: 1501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000168")]
		public uint unicode
		{
			[Token(Token = "0x60005DC")]
			[Address(RVA = "0x4EEB30", Offset = "0x4ED730", VA = "0x1804EEB30")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60005DD")]
			[Address(RVA = "0x4EEB40", Offset = "0x4ED740", VA = "0x1804EEB40")]
			set
			{
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x060005DE RID: 1502 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060005DF RID: 1503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000169")]
		public TMP_Asset textAsset
		{
			[Token(Token = "0x60005DE")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005DF")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			set
			{
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x060005E0 RID: 1504 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060005E1 RID: 1505 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700016A")]
		public Glyph glyph
		{
			[Token(Token = "0x60005E0")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
			[Token(Token = "0x60005E1")]
			[Address(RVA = "0x4E6EC0", Offset = "0x4E5AC0", VA = "0x1804E6EC0")]
			set
			{
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x060005E2 RID: 1506 RVA: 0x000044B8 File Offset: 0x000026B8
		// (set) Token: 0x060005E3 RID: 1507 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700016B")]
		public uint glyphIndex
		{
			[Token(Token = "0x60005E2")]
			[Address(RVA = "0x4EF610", Offset = "0x4EE210", VA = "0x1804EF610")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x60005E3")]
			[Address(RVA = "0x4EF630", Offset = "0x4EE230", VA = "0x1804EF630")]
			set
			{
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x060005E4 RID: 1508 RVA: 0x000044D0 File Offset: 0x000026D0
		// (set) Token: 0x060005E5 RID: 1509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700016C")]
		public float scale
		{
			[Token(Token = "0x60005E4")]
			[Address(RVA = "0x194DD70", Offset = "0x194C970", VA = "0x18194DD70")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60005E5")]
			[Address(RVA = "0x4E4C110", Offset = "0x4E4AD10", VA = "0x184E4C110")]
			set
			{
			}
		}

		// Token: 0x060005E6 RID: 1510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60005E6")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public TMP_TextElement()
		{
		}

		// Token: 0x040005B5 RID: 1461
		[Token(Token = "0x40005B5")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		protected TextElementType m_ElementType;

		// Token: 0x040005B6 RID: 1462
		[Token(Token = "0x40005B6")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		internal uint m_Unicode;

		// Token: 0x040005B7 RID: 1463
		[Token(Token = "0x40005B7")]
		[FieldOffset(Offset = "0x18")]
		internal TMP_Asset m_TextAsset;

		// Token: 0x040005B8 RID: 1464
		[Token(Token = "0x40005B8")]
		[FieldOffset(Offset = "0x20")]
		internal Glyph m_Glyph;

		// Token: 0x040005B9 RID: 1465
		[Token(Token = "0x40005B9")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		internal uint m_GlyphIndex;

		// Token: 0x040005BA RID: 1466
		[Token(Token = "0x40005BA")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		internal float m_Scale;
	}
}
