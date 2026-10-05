using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000232 RID: 562
	[Token(Token = "0x2000232")]
	public struct StyleLength : IStyleValue<Length>, IEquatable<StyleLength>
	{
		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x06000FCB RID: 4043 RVA: 0x00008880 File Offset: 0x00006A80
		[Token(Token = "0x170003D2")]
		public Length value
		{
			[Token(Token = "0x6000FCB")]
			[Address(RVA = "0x5B21770", Offset = "0x5B20370", VA = "0x185B21770", Slot = "4")]
			get
			{
				return default(Length);
			}
		}

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x06000FCC RID: 4044 RVA: 0x00008898 File Offset: 0x00006A98
		[Token(Token = "0x170003D3")]
		public StyleKeyword keyword
		{
			[Token(Token = "0x6000FCC")]
			[Address(RVA = "0x4226DD0", Offset = "0x42259D0", VA = "0x184226DD0", Slot = "5")]
			get
			{
				return StyleKeyword.Undefined;
			}
		}

		// Token: 0x06000FCD RID: 4045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FCD")]
		[Address(RVA = "0x5B216E0", Offset = "0x5B202E0", VA = "0x185B216E0")]
		public StyleLength(float v)
		{
		}

		// Token: 0x06000FCE RID: 4046 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FCE")]
		[Address(RVA = "0x5B21730", Offset = "0x5B20330", VA = "0x185B21730")]
		public StyleLength(StyleKeyword keyword)
		{
		}

		// Token: 0x06000FCF RID: 4047 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FCF")]
		[Address(RVA = "0x5B21740", Offset = "0x5B20340", VA = "0x185B21740")]
		internal StyleLength(Length v, StyleKeyword keyword)
		{
		}

		// Token: 0x06000FD0 RID: 4048 RVA: 0x000088B0 File Offset: 0x00006AB0
		[Token(Token = "0x6000FD0")]
		[Address(RVA = "0x5B21780", Offset = "0x5B20380", VA = "0x185B21780")]
		public static bool operator ==(StyleLength lhs, StyleLength rhs)
		{
			return default(bool);
		}

		// Token: 0x06000FD1 RID: 4049 RVA: 0x000088C8 File Offset: 0x00006AC8
		[Token(Token = "0x6000FD1")]
		[Address(RVA = "0x5B217C0", Offset = "0x5B203C0", VA = "0x185B217C0")]
		public static implicit operator StyleLength(StyleKeyword keyword)
		{
			return default(StyleLength);
		}

		// Token: 0x06000FD2 RID: 4050 RVA: 0x000088E0 File Offset: 0x00006AE0
		[Token(Token = "0x6000FD2")]
		[Address(RVA = "0x5B217E0", Offset = "0x5B203E0", VA = "0x185B217E0")]
		public static implicit operator StyleLength(float v)
		{
			return default(StyleLength);
		}

		// Token: 0x06000FD3 RID: 4051 RVA: 0x000088F8 File Offset: 0x00006AF8
		[Token(Token = "0x6000FD3")]
		[Address(RVA = "0x5B214E0", Offset = "0x5B200E0", VA = "0x185B214E0", Slot = "6")]
		public bool Equals(StyleLength other)
		{
			return default(bool);
		}

		// Token: 0x06000FD4 RID: 4052 RVA: 0x00008910 File Offset: 0x00006B10
		[Token(Token = "0x6000FD4")]
		[Address(RVA = "0x5B21550", Offset = "0x5B20150", VA = "0x185B21550", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000FD5 RID: 4053 RVA: 0x00008928 File Offset: 0x00006B28
		[Token(Token = "0x6000FD5")]
		[Address(RVA = "0x5B21640", Offset = "0x5B20240", VA = "0x185B21640", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000FD6 RID: 4054 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000FD6")]
		[Address(RVA = "0x5B21670", Offset = "0x5B20270", VA = "0x185B21670", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0400081C RID: 2076
		[Token(Token = "0x400081C")]
		[FieldOffset(Offset = "0x0")]
		private Length m_Value;

		// Token: 0x0400081D RID: 2077
		[Token(Token = "0x400081D")]
		[FieldOffset(Offset = "0x8")]
		private StyleKeyword m_Keyword;
	}
}
