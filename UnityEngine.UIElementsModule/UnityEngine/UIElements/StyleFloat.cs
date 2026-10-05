using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000230 RID: 560
	[Token(Token = "0x2000230")]
	public struct StyleFloat : IStyleValue<float>, IEquatable<StyleFloat>
	{
		// Token: 0x170003CE RID: 974
		// (get) Token: 0x06000FB5 RID: 4021 RVA: 0x00008718 File Offset: 0x00006918
		[Token(Token = "0x170003CE")]
		public float value
		{
			[Token(Token = "0x6000FB5")]
			[Address(RVA = "0x5B21300", Offset = "0x5B1FF00", VA = "0x185B21300", Slot = "4")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x06000FB6 RID: 4022 RVA: 0x00008730 File Offset: 0x00006930
		[Token(Token = "0x170003CF")]
		public StyleKeyword keyword
		{
			[Token(Token = "0x6000FB6")]
			[Address(RVA = "0x566210", Offset = "0x564E10", VA = "0x180566210", Slot = "5")]
			get
			{
				return StyleKeyword.Undefined;
			}
		}

		// Token: 0x06000FB7 RID: 4023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FB7")]
		[Address(RVA = "0x5B212E0", Offset = "0x5B1FEE0", VA = "0x185B212E0")]
		public StyleFloat(float v)
		{
		}

		// Token: 0x06000FB8 RID: 4024 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FB8")]
		[Address(RVA = "0x5B212F0", Offset = "0x5B1FEF0", VA = "0x185B212F0")]
		public StyleFloat(StyleKeyword keyword)
		{
		}

		// Token: 0x06000FB9 RID: 4025 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FB9")]
		[Address(RVA = "0x46B3760", Offset = "0x46B2360", VA = "0x1846B3760")]
		internal StyleFloat(float v, StyleKeyword keyword)
		{
		}

		// Token: 0x06000FBA RID: 4026 RVA: 0x00008748 File Offset: 0x00006948
		[Token(Token = "0x6000FBA")]
		[Address(RVA = "0x5B21310", Offset = "0x5B1FF10", VA = "0x185B21310")]
		public static bool operator ==(StyleFloat lhs, StyleFloat rhs)
		{
			return default(bool);
		}

		// Token: 0x06000FBB RID: 4027 RVA: 0x00008760 File Offset: 0x00006960
		[Token(Token = "0x6000FBB")]
		[Address(RVA = "0x5B21340", Offset = "0x5B1FF40", VA = "0x185B21340")]
		public static implicit operator StyleFloat(StyleKeyword keyword)
		{
			return default(StyleFloat);
		}

		// Token: 0x06000FBC RID: 4028 RVA: 0x00008778 File Offset: 0x00006978
		[Token(Token = "0x6000FBC")]
		[Address(RVA = "0x5B02370", Offset = "0x5B00F70", VA = "0x185B02370")]
		public static implicit operator StyleFloat(float v)
		{
			return default(StyleFloat);
		}

		// Token: 0x06000FBD RID: 4029 RVA: 0x00008790 File Offset: 0x00006990
		[Token(Token = "0x6000FBD")]
		[Address(RVA = "0x5B21250", Offset = "0x5B1FE50", VA = "0x185B21250", Slot = "6")]
		public bool Equals(StyleFloat other)
		{
			return default(bool);
		}

		// Token: 0x06000FBE RID: 4030 RVA: 0x000087A8 File Offset: 0x000069A8
		[Token(Token = "0x6000FBE")]
		[Address(RVA = "0x5B211A0", Offset = "0x5B1FDA0", VA = "0x185B211A0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000FBF RID: 4031 RVA: 0x000087C0 File Offset: 0x000069C0
		[Token(Token = "0x6000FBF")]
		[Address(RVA = "0x5B02130", Offset = "0x5B00D30", VA = "0x185B02130", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000FC0 RID: 4032 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000FC0")]
		[Address(RVA = "0x5B21280", Offset = "0x5B1FE80", VA = "0x185B21280", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04000818 RID: 2072
		[Token(Token = "0x4000818")]
		[FieldOffset(Offset = "0x0")]
		private float m_Value;

		// Token: 0x04000819 RID: 2073
		[Token(Token = "0x4000819")]
		[FieldOffset(Offset = "0x4")]
		private StyleKeyword m_Keyword;
	}
}
