using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x0200022B RID: 555
	[Token(Token = "0x200022B")]
	public struct StyleColor : IStyleValue<Color>, IEquatable<StyleColor>
	{
		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x06000F84 RID: 3972 RVA: 0x00008460 File Offset: 0x00006660
		[Token(Token = "0x170003C7")]
		public Color value
		{
			[Token(Token = "0x6000F84")]
			[Address(RVA = "0x5B205E0", Offset = "0x5B1F1E0", VA = "0x185B205E0", Slot = "4")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x06000F85 RID: 3973 RVA: 0x00008478 File Offset: 0x00006678
		[Token(Token = "0x170003C8")]
		public StyleKeyword keyword
		{
			[Token(Token = "0x6000F85")]
			[Address(RVA = "0x592C450", Offset = "0x592B050", VA = "0x18592C450", Slot = "5")]
			get
			{
				return StyleKeyword.Undefined;
			}
		}

		// Token: 0x06000F86 RID: 3974 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F86")]
		[Address(RVA = "0x4C43780", Offset = "0x4C42380", VA = "0x184C43780")]
		public StyleColor(Color v)
		{
		}

		// Token: 0x06000F87 RID: 3975 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F87")]
		[Address(RVA = "0x4C43770", Offset = "0x4C42370", VA = "0x184C43770")]
		internal StyleColor(Color v, StyleKeyword keyword)
		{
		}

		// Token: 0x06000F88 RID: 3976 RVA: 0x00008490 File Offset: 0x00006690
		[Token(Token = "0x6000F88")]
		[Address(RVA = "0x5B20600", Offset = "0x5B1F200", VA = "0x185B20600")]
		public static bool operator ==(StyleColor lhs, StyleColor rhs)
		{
			return default(bool);
		}

		// Token: 0x06000F89 RID: 3977 RVA: 0x000084A8 File Offset: 0x000066A8
		[Token(Token = "0x6000F89")]
		[Address(RVA = "0x5B20680", Offset = "0x5B1F280", VA = "0x185B20680")]
		public static implicit operator StyleColor(Color v)
		{
			return default(StyleColor);
		}

		// Token: 0x06000F8A RID: 3978 RVA: 0x000084C0 File Offset: 0x000066C0
		[Token(Token = "0x6000F8A")]
		[Address(RVA = "0x5B203D0", Offset = "0x5B1EFD0", VA = "0x185B203D0", Slot = "6")]
		public bool Equals(StyleColor other)
		{
			return default(bool);
		}

		// Token: 0x06000F8B RID: 3979 RVA: 0x000084D8 File Offset: 0x000066D8
		[Token(Token = "0x6000F8B")]
		[Address(RVA = "0x5B20450", Offset = "0x5B1F050", VA = "0x185B20450", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000F8C RID: 3980 RVA: 0x000084F0 File Offset: 0x000066F0
		[Token(Token = "0x6000F8C")]
		[Address(RVA = "0x5B20550", Offset = "0x5B1F150", VA = "0x185B20550", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06000F8D RID: 3981 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6000F8D")]
		[Address(RVA = "0x5B20570", Offset = "0x5B1F170", VA = "0x185B20570", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0400080D RID: 2061
		[Token(Token = "0x400080D")]
		[FieldOffset(Offset = "0x0")]
		private Color m_Value;

		// Token: 0x0400080E RID: 2062
		[Token(Token = "0x400080E")]
		[FieldOffset(Offset = "0x10")]
		private StyleKeyword m_Keyword;
	}
}
