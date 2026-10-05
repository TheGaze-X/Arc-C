using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace TMPro
{
	// Token: 0x02000044 RID: 68
	[Token(Token = "0x2000044")]
	[Serializable]
	public class KerningPair
	{
		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600023D RID: 573 RVA: 0x00002B98 File Offset: 0x00000D98
		// (set) Token: 0x0600023E RID: 574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000065")]
		public uint firstGlyph
		{
			[Token(Token = "0x600023D")]
			[Address(RVA = "0x4EA8B0", Offset = "0x4E94B0", VA = "0x1804EA8B0")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x600023E")]
			[Address(RVA = "0x4EAC40", Offset = "0x4E9840", VA = "0x1804EAC40")]
			set
			{
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x0600023F RID: 575 RVA: 0x00002BB0 File Offset: 0x00000DB0
		[Token(Token = "0x17000066")]
		public GlyphValueRecord_Legacy firstGlyphAdjustments
		{
			[Token(Token = "0x600023F")]
			[Address(RVA = "0x2694830", Offset = "0x2693430", VA = "0x182694830")]
			get
			{
				return default(GlyphValueRecord_Legacy);
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000240 RID: 576 RVA: 0x00002BC8 File Offset: 0x00000DC8
		// (set) Token: 0x06000241 RID: 577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000067")]
		public uint secondGlyph
		{
			[Token(Token = "0x6000240")]
			[Address(RVA = "0x4F6200", Offset = "0x4F4E00", VA = "0x1804F6200")]
			get
			{
				return 0U;
			}
			[Token(Token = "0x6000241")]
			[Address(RVA = "0x4F6220", Offset = "0x4F4E20", VA = "0x1804F6220")]
			set
			{
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000242 RID: 578 RVA: 0x00002BE0 File Offset: 0x00000DE0
		[Token(Token = "0x17000068")]
		public GlyphValueRecord_Legacy secondGlyphAdjustments
		{
			[Token(Token = "0x6000242")]
			[Address(RVA = "0x4013E20", Offset = "0x4012A20", VA = "0x184013E20")]
			get
			{
				return default(GlyphValueRecord_Legacy);
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000243 RID: 579 RVA: 0x00002BF8 File Offset: 0x00000DF8
		[Token(Token = "0x17000069")]
		public bool ignoreSpacingAdjustments
		{
			[Token(Token = "0x6000243")]
			[Address(RVA = "0x1DBF210", Offset = "0x1DBDE10", VA = "0x181DBF210")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000244")]
		[Address(RVA = "0x5881060", Offset = "0x587FC60", VA = "0x185881060")]
		public KerningPair()
		{
		}

		// Token: 0x06000245 RID: 581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000245")]
		[Address(RVA = "0x5880FB0", Offset = "0x587FBB0", VA = "0x185880FB0")]
		public KerningPair(uint left, uint right, float offset)
		{
		}

		// Token: 0x06000246 RID: 582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000246")]
		[Address(RVA = "0x5881000", Offset = "0x587FC00", VA = "0x185881000")]
		public KerningPair(uint firstGlyph, GlyphValueRecord_Legacy firstGlyphAdjustments, uint secondGlyph, GlyphValueRecord_Legacy secondGlyphAdjustments)
		{
		}

		// Token: 0x06000247 RID: 583 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000247")]
		[Address(RVA = "0x5880F10", Offset = "0x587FB10", VA = "0x185880F10")]
		internal void ConvertLegacyKerningData()
		{
		}

		// Token: 0x04000213 RID: 531
		[Token(Token = "0x4000213")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		[FormerlySerializedAs("AscII_Left")]
		private uint m_FirstGlyph;

		// Token: 0x04000214 RID: 532
		[Token(Token = "0x4000214")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private GlyphValueRecord_Legacy m_FirstGlyphAdjustments;

		// Token: 0x04000215 RID: 533
		[Token(Token = "0x4000215")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		[FormerlySerializedAs("AscII_Right")]
		private uint m_SecondGlyph;

		// Token: 0x04000216 RID: 534
		[Token(Token = "0x4000216")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GlyphValueRecord_Legacy m_SecondGlyphAdjustments;

		// Token: 0x04000217 RID: 535
		[Token(Token = "0x4000217")]
		[FieldOffset(Offset = "0x38")]
		[FormerlySerializedAs("XadvanceOffset")]
		public float xOffset;

		// Token: 0x04000218 RID: 536
		[Token(Token = "0x4000218")]
		[FieldOffset(Offset = "0x0")]
		internal static KerningPair empty;

		// Token: 0x04000219 RID: 537
		[Token(Token = "0x4000219")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private bool m_IgnoreSpacingAdjustments;
	}
}
