using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000231 RID: 561
	[Token(Token = "0x2000231")]
	public struct StyleInt : IStyleValue<int>, IEquatable<StyleInt>
	{
		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x06000FC1 RID: 4033 RVA: 0x000087D8 File Offset: 0x000069D8
		[Token(Token = "0x170003D0")]
		public int value
		{
			[Token(Token = "0x6000FC1")]
			[Address(RVA = "0x44124B0", Offset = "0x44110B0", VA = "0x1844124B0", Slot = "4")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x06000FC2 RID: 4034 RVA: 0x000087F0 File Offset: 0x000069F0
		[Token(Token = "0x170003D1")]
		public StyleKeyword keyword
		{
			[Token(Token = "0x6000FC2")]
			[Address(RVA = "0x566210", Offset = "0x564E10", VA = "0x180566210", Slot = "5")]
			get
			{
				return StyleKeyword.Undefined;
			}
		}

		// Token: 0x06000FC3 RID: 4035 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FC3")]
		[Address(RVA = "0x5B212F0", Offset = "0x5B1FEF0", VA = "0x185B212F0")]
		public StyleInt(StyleKeyword keyword)
		{
		}

		// Token: 0x06000FC4 RID: 4036 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FC4")]
		[Address(RVA = "0x44124A0", Offset = "0x44110A0", VA = "0x1844124A0")]
		internal StyleInt(int v, StyleKeyword keyword)
		{
		}

		// Token: 0x06000FC5 RID: 4037 RVA: 0x00008808 File Offset: 0x00006A08
		[Token(Token = "0x6000FC5")]
		[Address(RVA = "0x5B214A0", Offset = "0x5B200A0", VA = "0x185B214A0")]
		public static bool operator ==(StyleInt lhs, StyleInt rhs)
		{
			return default(bool);
		}

		// Token: 0x06000FC6 RID: 4038 RVA: 0x00008820 File Offset: 0x00006A20
		[Token(Token = "0x6000FC6")]
		[Address(RVA = "0x5B214C0", Offset = "0x5B200C0", VA = "0x185B214C0")]
		public static implicit operator StyleInt(StyleKeyword keyword)
		{
			return default(StyleInt);
		}

		// Token: 0x06000FC7 RID: 4039 RVA: 0x00008838 File Offset: 0x00006A38
		[Token(Token = "0x6000FC7")]
		[Address(RVA = "0x5B21400", Offset = "0x5B20000", VA = "0x185B21400", Slot = "6")]
		public bool Equals(StyleInt other)
		{
			return default(bool);
		}

		// Token: 0x06000FC8 RID: 4040 RVA: 0x00008850 File Offset: 0x00006A50
		[Token(Token = "0x6000FC8")]
		[Address(RVA = "0x5B21360", Offset = "0x5B1FF60", VA = "0x185B21360", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000FC9 RID: 4041 RVA: 0x00008868 File Offset: 0x00006A68
		[Token(Token = "0x6000FC9")]
		[Address(RVA = "0x5B21430", Offset = "0x5B20030", VA = "0x185B21430", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000FCA RID: 4042 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000FCA")]
		[Address(RVA = "0x5B21440", Offset = "0x5B20040", VA = "0x185B21440", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0400081A RID: 2074
		[Token(Token = "0x400081A")]
		[FieldOffset(Offset = "0x0")]
		private int m_Value;

		// Token: 0x0400081B RID: 2075
		[Token(Token = "0x400081B")]
		[FieldOffset(Offset = "0x4")]
		private StyleKeyword m_Keyword;
	}
}
