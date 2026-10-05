using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000234 RID: 564
	[Token(Token = "0x2000234")]
	public struct StyleScale : IStyleValue<Scale>, IEquatable<StyleScale>
	{
		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x06000FE1 RID: 4065 RVA: 0x000089E8 File Offset: 0x00006BE8
		[Token(Token = "0x170003D6")]
		public Scale value
		{
			[Token(Token = "0x6000FE1")]
			[Address(RVA = "0x5B205E0", Offset = "0x5B1F1E0", VA = "0x185B205E0", Slot = "4")]
			get
			{
				return default(Scale);
			}
		}

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x06000FE2 RID: 4066 RVA: 0x00008A00 File Offset: 0x00006C00
		[Token(Token = "0x170003D7")]
		public StyleKeyword keyword
		{
			[Token(Token = "0x6000FE2")]
			[Address(RVA = "0x592C450", Offset = "0x592B050", VA = "0x18592C450", Slot = "5")]
			get
			{
				return StyleKeyword.Undefined;
			}
		}

		// Token: 0x06000FE3 RID: 4067 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FE3")]
		[Address(RVA = "0x5B21DC0", Offset = "0x5B209C0", VA = "0x185B21DC0")]
		public StyleScale(StyleKeyword keyword)
		{
		}

		// Token: 0x06000FE4 RID: 4068 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FE4")]
		[Address(RVA = "0x4C43770", Offset = "0x4C42370", VA = "0x184C43770")]
		internal StyleScale(Scale v, StyleKeyword keyword)
		{
		}

		// Token: 0x06000FE5 RID: 4069 RVA: 0x00008A18 File Offset: 0x00006C18
		[Token(Token = "0x6000FE5")]
		[Address(RVA = "0x5B21DD0", Offset = "0x5B209D0", VA = "0x185B21DD0")]
		public static bool operator ==(StyleScale lhs, StyleScale rhs)
		{
			return default(bool);
		}

		// Token: 0x06000FE6 RID: 4070 RVA: 0x00008A30 File Offset: 0x00006C30
		[Token(Token = "0x6000FE6")]
		[Address(RVA = "0x5B21E40", Offset = "0x5B20A40", VA = "0x185B21E40")]
		public static implicit operator StyleScale(StyleKeyword keyword)
		{
			return default(StyleScale);
		}

		// Token: 0x06000FE7 RID: 4071 RVA: 0x00008A48 File Offset: 0x00006C48
		[Token(Token = "0x6000FE7")]
		[Address(RVA = "0x5B21BA0", Offset = "0x5B207A0", VA = "0x185B21BA0", Slot = "6")]
		public bool Equals(StyleScale other)
		{
			return default(bool);
		}

		// Token: 0x06000FE8 RID: 4072 RVA: 0x00008A60 File Offset: 0x00006C60
		[Token(Token = "0x6000FE8")]
		[Address(RVA = "0x5B21C10", Offset = "0x5B20810", VA = "0x185B21C10", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000FE9 RID: 4073 RVA: 0x00008A78 File Offset: 0x00006C78
		[Token(Token = "0x6000FE9")]
		[Address(RVA = "0x5B21CF0", Offset = "0x5B208F0", VA = "0x185B21CF0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000FEA RID: 4074 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000FEA")]
		[Address(RVA = "0x5B21D50", Offset = "0x5B20950", VA = "0x185B21D50", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04000820 RID: 2080
		[Token(Token = "0x4000820")]
		[FieldOffset(Offset = "0x0")]
		private Scale m_Value;

		// Token: 0x04000821 RID: 2081
		[Token(Token = "0x4000821")]
		[FieldOffset(Offset = "0x10")]
		private StyleKeyword m_Keyword;
	}
}
