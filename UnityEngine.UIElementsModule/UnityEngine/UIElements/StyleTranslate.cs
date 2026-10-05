using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000235 RID: 565
	[Token(Token = "0x2000235")]
	public struct StyleTranslate : IStyleValue<Translate>, IEquatable<StyleTranslate>
	{
		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x06000FEB RID: 4075 RVA: 0x00008A90 File Offset: 0x00006C90
		[Token(Token = "0x170003D8")]
		public Translate value
		{
			[Token(Token = "0x6000FEB")]
			[Address(RVA = "0x5B21070", Offset = "0x5B1FC70", VA = "0x185B21070", Slot = "4")]
			get
			{
				return default(Translate);
			}
		}

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x06000FEC RID: 4076 RVA: 0x00008AA8 File Offset: 0x00006CA8
		[Token(Token = "0x170003D9")]
		public StyleKeyword keyword
		{
			[Token(Token = "0x6000FEC")]
			[Address(RVA = "0x428FB90", Offset = "0x428E790", VA = "0x18428FB90", Slot = "5")]
			get
			{
				return StyleKeyword.Undefined;
			}
		}

		// Token: 0x06000FED RID: 4077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FED")]
		[Address(RVA = "0x5B24460", Offset = "0x5B23060", VA = "0x185B24460")]
		public StyleTranslate(Translate v)
		{
		}

		// Token: 0x06000FEE RID: 4078 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FEE")]
		[Address(RVA = "0x5B21A90", Offset = "0x5B20690", VA = "0x185B21A90")]
		public StyleTranslate(StyleKeyword keyword)
		{
		}

		// Token: 0x06000FEF RID: 4079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FEF")]
		[Address(RVA = "0x5B21AC0", Offset = "0x5B206C0", VA = "0x185B21AC0")]
		internal StyleTranslate(Translate v, StyleKeyword keyword)
		{
		}

		// Token: 0x06000FF0 RID: 4080 RVA: 0x00008AC0 File Offset: 0x00006CC0
		[Token(Token = "0x6000FF0")]
		[Address(RVA = "0x5B24480", Offset = "0x5B23080", VA = "0x185B24480")]
		public static bool operator ==(StyleTranslate lhs, StyleTranslate rhs)
		{
			return default(bool);
		}

		// Token: 0x06000FF1 RID: 4081 RVA: 0x00008AD8 File Offset: 0x00006CD8
		[Token(Token = "0x6000FF1")]
		[Address(RVA = "0x5B21B70", Offset = "0x5B20770", VA = "0x185B21B70")]
		public static implicit operator StyleTranslate(StyleKeyword keyword)
		{
			return default(StyleTranslate);
		}

		// Token: 0x06000FF2 RID: 4082 RVA: 0x00008AF0 File Offset: 0x00006CF0
		[Token(Token = "0x6000FF2")]
		[Address(RVA = "0x5B24510", Offset = "0x5B23110", VA = "0x185B24510")]
		public static implicit operator StyleTranslate(Translate v)
		{
			return default(StyleTranslate);
		}

		// Token: 0x06000FF3 RID: 4083 RVA: 0x00008B08 File Offset: 0x00006D08
		[Token(Token = "0x6000FF3")]
		[Address(RVA = "0x5B24230", Offset = "0x5B22E30", VA = "0x185B24230", Slot = "6")]
		public bool Equals(StyleTranslate other)
		{
			return default(bool);
		}

		// Token: 0x06000FF4 RID: 4084 RVA: 0x00008B20 File Offset: 0x00006D20
		[Token(Token = "0x6000FF4")]
		[Address(RVA = "0x5B242C0", Offset = "0x5B22EC0", VA = "0x185B242C0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000FF5 RID: 4085 RVA: 0x00008B38 File Offset: 0x00006D38
		[Token(Token = "0x6000FF5")]
		[Address(RVA = "0x5B243C0", Offset = "0x5B22FC0", VA = "0x185B243C0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000FF6 RID: 4086 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000FF6")]
		[Address(RVA = "0x5B243E0", Offset = "0x5B22FE0", VA = "0x185B243E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04000822 RID: 2082
		[Token(Token = "0x4000822")]
		[FieldOffset(Offset = "0x0")]
		private Translate m_Value;

		// Token: 0x04000823 RID: 2083
		[Token(Token = "0x4000823")]
		[FieldOffset(Offset = "0x18")]
		private StyleKeyword m_Keyword;
	}
}
