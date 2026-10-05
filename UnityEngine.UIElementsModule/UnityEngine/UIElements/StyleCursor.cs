using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x0200022C RID: 556
	[Token(Token = "0x200022C")]
	public struct StyleCursor : IStyleValue<Cursor>, IEquatable<StyleCursor>
	{
		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x06000F8E RID: 3982 RVA: 0x00008508 File Offset: 0x00006708
		[Token(Token = "0x170003C9")]
		public Cursor value
		{
			[Token(Token = "0x6000F8E")]
			[Address(RVA = "0x5B21070", Offset = "0x5B1FC70", VA = "0x185B21070", Slot = "4")]
			get
			{
				return default(Cursor);
			}
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06000F8F RID: 3983 RVA: 0x00008520 File Offset: 0x00006720
		[Token(Token = "0x170003CA")]
		public StyleKeyword keyword
		{
			[Token(Token = "0x6000F8F")]
			[Address(RVA = "0x428FB90", Offset = "0x428E790", VA = "0x18428FB90", Slot = "5")]
			get
			{
				return StyleKeyword.Undefined;
			}
		}

		// Token: 0x06000F90 RID: 3984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F90")]
		[Address(RVA = "0x5B21020", Offset = "0x5B1FC20", VA = "0x185B21020")]
		public StyleCursor(StyleKeyword keyword)
		{
		}

		// Token: 0x06000F91 RID: 3985 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F91")]
		[Address(RVA = "0x5B21050", Offset = "0x5B1FC50", VA = "0x185B21050")]
		internal StyleCursor(Cursor v, StyleKeyword keyword)
		{
		}

		// Token: 0x06000F92 RID: 3986 RVA: 0x00008538 File Offset: 0x00006738
		[Token(Token = "0x6000F92")]
		[Address(RVA = "0x5B210C0", Offset = "0x5B1FCC0", VA = "0x185B210C0")]
		public static bool operator ==(StyleCursor lhs, StyleCursor rhs)
		{
			return default(bool);
		}

		// Token: 0x06000F93 RID: 3987 RVA: 0x00008550 File Offset: 0x00006750
		[Token(Token = "0x6000F93")]
		[Address(RVA = "0x5B21140", Offset = "0x5B1FD40", VA = "0x185B21140")]
		public static implicit operator StyleCursor(StyleKeyword keyword)
		{
			return default(StyleCursor);
		}

		// Token: 0x06000F94 RID: 3988 RVA: 0x00008568 File Offset: 0x00006768
		[Token(Token = "0x6000F94")]
		[Address(RVA = "0x5B20E20", Offset = "0x5B1FA20", VA = "0x185B20E20", Slot = "6")]
		public bool Equals(StyleCursor other)
		{
			return default(bool);
		}

		// Token: 0x06000F95 RID: 3989 RVA: 0x00008580 File Offset: 0x00006780
		[Token(Token = "0x6000F95")]
		[Address(RVA = "0x5B20EA0", Offset = "0x5B1FAA0", VA = "0x185B20EA0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000F96 RID: 3990 RVA: 0x00008598 File Offset: 0x00006798
		[Token(Token = "0x6000F96")]
		[Address(RVA = "0x5B20F90", Offset = "0x5B1FB90", VA = "0x185B20F90", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000F97 RID: 3991 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000F97")]
		[Address(RVA = "0x5B20FB0", Offset = "0x5B1FBB0", VA = "0x185B20FB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0400080F RID: 2063
		[Token(Token = "0x400080F")]
		[FieldOffset(Offset = "0x0")]
		private Cursor m_Value;

		// Token: 0x04000810 RID: 2064
		[Token(Token = "0x4000810")]
		[FieldOffset(Offset = "0x18")]
		private StyleKeyword m_Keyword;
	}
}
