using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000233 RID: 563
	[Token(Token = "0x2000233")]
	public struct StyleRotate : IStyleValue<Rotate>, IEquatable<StyleRotate>
	{
		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x06000FD7 RID: 4055 RVA: 0x00008940 File Offset: 0x00006B40
		[Token(Token = "0x170003D4")]
		public Rotate value
		{
			[Token(Token = "0x6000FD7")]
			[Address(RVA = "0x5B21070", Offset = "0x5B1FC70", VA = "0x185B21070", Slot = "4")]
			get
			{
				return default(Rotate);
			}
		}

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x06000FD8 RID: 4056 RVA: 0x00008958 File Offset: 0x00006B58
		[Token(Token = "0x170003D5")]
		public StyleKeyword keyword
		{
			[Token(Token = "0x6000FD8")]
			[Address(RVA = "0x428FB90", Offset = "0x428E790", VA = "0x18428FB90", Slot = "5")]
			get
			{
				return StyleKeyword.Undefined;
			}
		}

		// Token: 0x06000FD9 RID: 4057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FD9")]
		[Address(RVA = "0x5B21A90", Offset = "0x5B20690", VA = "0x185B21A90")]
		public StyleRotate(StyleKeyword keyword)
		{
		}

		// Token: 0x06000FDA RID: 4058 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FDA")]
		[Address(RVA = "0x5B21AC0", Offset = "0x5B206C0", VA = "0x185B21AC0")]
		internal StyleRotate(Rotate v, StyleKeyword keyword)
		{
		}

		// Token: 0x06000FDB RID: 4059 RVA: 0x00008970 File Offset: 0x00006B70
		[Token(Token = "0x6000FDB")]
		[Address(RVA = "0x5B21AE0", Offset = "0x5B206E0", VA = "0x185B21AE0")]
		public static bool operator ==(StyleRotate lhs, StyleRotate rhs)
		{
			return default(bool);
		}

		// Token: 0x06000FDC RID: 4060 RVA: 0x00008988 File Offset: 0x00006B88
		[Token(Token = "0x6000FDC")]
		[Address(RVA = "0x5B21B70", Offset = "0x5B20770", VA = "0x185B21B70")]
		public static implicit operator StyleRotate(StyleKeyword keyword)
		{
			return default(StyleRotate);
		}

		// Token: 0x06000FDD RID: 4061 RVA: 0x000089A0 File Offset: 0x00006BA0
		[Token(Token = "0x6000FDD")]
		[Address(RVA = "0x5B21960", Offset = "0x5B20560", VA = "0x185B21960", Slot = "6")]
		public bool Equals(StyleRotate other)
		{
			return default(bool);
		}

		// Token: 0x06000FDE RID: 4062 RVA: 0x000089B8 File Offset: 0x00006BB8
		[Token(Token = "0x6000FDE")]
		[Address(RVA = "0x5B21860", Offset = "0x5B20460", VA = "0x185B21860", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000FDF RID: 4063 RVA: 0x000089D0 File Offset: 0x00006BD0
		[Token(Token = "0x6000FDF")]
		[Address(RVA = "0x5B219F0", Offset = "0x5B205F0", VA = "0x185B219F0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000FE0 RID: 4064 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000FE0")]
		[Address(RVA = "0x5B21A10", Offset = "0x5B20610", VA = "0x185B21A10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0400081E RID: 2078
		[Token(Token = "0x400081E")]
		[FieldOffset(Offset = "0x0")]
		private Rotate m_Value;

		// Token: 0x0400081F RID: 2079
		[Token(Token = "0x400081F")]
		[FieldOffset(Offset = "0x18")]
		private StyleKeyword m_Keyword;
	}
}
