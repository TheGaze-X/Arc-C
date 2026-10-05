using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000236 RID: 566
	[Token(Token = "0x2000236")]
	public struct StyleTextShadow : IStyleValue<TextShadow>, IEquatable<StyleTextShadow>
	{
		// Token: 0x170003DA RID: 986
		// (get) Token: 0x06000FF7 RID: 4087 RVA: 0x00008B50 File Offset: 0x00006D50
		[Token(Token = "0x170003DA")]
		public TextShadow value
		{
			[Token(Token = "0x6000FF7")]
			[Address(RVA = "0x5B23D50", Offset = "0x5B22950", VA = "0x185B23D50", Slot = "4")]
			get
			{
				return default(TextShadow);
			}
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x06000FF8 RID: 4088 RVA: 0x00008B68 File Offset: 0x00006D68
		[Token(Token = "0x170003DB")]
		public StyleKeyword keyword
		{
			[Token(Token = "0x6000FF8")]
			[Address(RVA = "0x566200", Offset = "0x564E00", VA = "0x180566200", Slot = "5")]
			get
			{
				return StyleKeyword.Undefined;
			}
		}

		// Token: 0x06000FF9 RID: 4089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FF9")]
		[Address(RVA = "0x5B23D00", Offset = "0x5B22900", VA = "0x185B23D00")]
		public StyleTextShadow(StyleKeyword keyword)
		{
		}

		// Token: 0x06000FFA RID: 4090 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000FFA")]
		[Address(RVA = "0x5B23D30", Offset = "0x5B22930", VA = "0x185B23D30")]
		internal StyleTextShadow(TextShadow v, StyleKeyword keyword)
		{
		}

		// Token: 0x06000FFB RID: 4091 RVA: 0x00008B80 File Offset: 0x00006D80
		[Token(Token = "0x6000FFB")]
		[Address(RVA = "0x5B23DA0", Offset = "0x5B229A0", VA = "0x185B23DA0")]
		public static bool operator ==(StyleTextShadow lhs, StyleTextShadow rhs)
		{
			return default(bool);
		}

		// Token: 0x06000FFC RID: 4092 RVA: 0x00008B98 File Offset: 0x00006D98
		[Token(Token = "0x6000FFC")]
		[Address(RVA = "0x5B23E50", Offset = "0x5B22A50", VA = "0x185B23E50")]
		public static implicit operator StyleTextShadow(StyleKeyword keyword)
		{
			return default(StyleTextShadow);
		}

		// Token: 0x06000FFD RID: 4093 RVA: 0x00008BB0 File Offset: 0x00006DB0
		[Token(Token = "0x6000FFD")]
		[Address(RVA = "0x5B23BA0", Offset = "0x5B227A0", VA = "0x185B23BA0", Slot = "6")]
		public bool Equals(StyleTextShadow other)
		{
			return default(bool);
		}

		// Token: 0x06000FFE RID: 4094 RVA: 0x00008BC8 File Offset: 0x00006DC8
		[Token(Token = "0x6000FFE")]
		[Address(RVA = "0x5B23A70", Offset = "0x5B22670", VA = "0x185B23A70", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06000FFF RID: 4095 RVA: 0x00008BE0 File Offset: 0x00006DE0
		[Token(Token = "0x6000FFF")]
		[Address(RVA = "0x5B23C50", Offset = "0x5B22850", VA = "0x185B23C50", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001000 RID: 4096 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x6001000")]
		[Address(RVA = "0x5B23C90", Offset = "0x5B22890", VA = "0x185B23C90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04000824 RID: 2084
		[Token(Token = "0x4000824")]
		[FieldOffset(Offset = "0x0")]
		private StyleKeyword m_Keyword;

		// Token: 0x04000825 RID: 2085
		[Token(Token = "0x4000825")]
		[FieldOffset(Offset = "0x4")]
		private TextShadow m_Value;
	}
}
