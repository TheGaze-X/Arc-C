using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000237 RID: 567
	[Token(Token = "0x2000237")]
	public struct StyleTransformOrigin : IStyleValue<TransformOrigin>, IEquatable<StyleTransformOrigin>
	{
		// Token: 0x170003DC RID: 988
		// (get) Token: 0x06001001 RID: 4097 RVA: 0x00008BF8 File Offset: 0x00006DF8
		[Token(Token = "0x170003DC")]
		public TransformOrigin value
		{
			[Token(Token = "0x6001001")]
			[Address(RVA = "0x5B240E0", Offset = "0x5B22CE0", VA = "0x185B240E0", Slot = "4")]
			get
			{
				return default(TransformOrigin);
			}
		}

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x06001002 RID: 4098 RVA: 0x00008C10 File Offset: 0x00006E10
		[Token(Token = "0x170003DD")]
		public StyleKeyword keyword
		{
			[Token(Token = "0x6001002")]
			[Address(RVA = "0x4889940", Offset = "0x4888540", VA = "0x184889940", Slot = "5")]
			get
			{
				return StyleKeyword.Undefined;
			}
		}

		// Token: 0x06001003 RID: 4099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001003")]
		[Address(RVA = "0x5B240B0", Offset = "0x5B22CB0", VA = "0x185B240B0")]
		public StyleTransformOrigin(StyleKeyword keyword)
		{
		}

		// Token: 0x06001004 RID: 4100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001004")]
		[Address(RVA = "0x5B240C0", Offset = "0x5B22CC0", VA = "0x185B240C0")]
		internal StyleTransformOrigin(TransformOrigin v, StyleKeyword keyword)
		{
		}

		// Token: 0x06001005 RID: 4101 RVA: 0x00008C28 File Offset: 0x00006E28
		[Token(Token = "0x6001005")]
		[Address(RVA = "0x5B24110", Offset = "0x5B22D10", VA = "0x185B24110")]
		public static bool operator ==(StyleTransformOrigin lhs, StyleTransformOrigin rhs)
		{
			return default(bool);
		}

		// Token: 0x06001006 RID: 4102 RVA: 0x00008C40 File Offset: 0x00006E40
		[Token(Token = "0x6001006")]
		[Address(RVA = "0x5B24200", Offset = "0x5B22E00", VA = "0x185B24200")]
		public static implicit operator StyleTransformOrigin(StyleKeyword keyword)
		{
			return default(StyleTransformOrigin);
		}

		// Token: 0x06001007 RID: 4103 RVA: 0x00008C58 File Offset: 0x00006E58
		[Token(Token = "0x6001007")]
		[Address(RVA = "0x5B23E90", Offset = "0x5B22A90", VA = "0x185B23E90", Slot = "6")]
		public bool Equals(StyleTransformOrigin other)
		{
			return default(bool);
		}

		// Token: 0x06001008 RID: 4104 RVA: 0x00008C70 File Offset: 0x00006E70
		[Token(Token = "0x6001008")]
		[Address(RVA = "0x5B23F80", Offset = "0x5B22B80", VA = "0x185B23F80", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06001009 RID: 4105 RVA: 0x00008C88 File Offset: 0x00006E88
		[Token(Token = "0x6001009")]
		[Address(RVA = "0x5B24020", Offset = "0x5B22C20", VA = "0x185B24020", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600100A RID: 4106 RVA: 0x0000212A File Offset: 0x0000032A
		[Token(Token = "0x600100A")]
		[Address(RVA = "0x5B24040", Offset = "0x5B22C40", VA = "0x185B24040", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04000826 RID: 2086
		[Token(Token = "0x4000826")]
		[FieldOffset(Offset = "0x0")]
		private TransformOrigin m_Value;

		// Token: 0x04000827 RID: 2087
		[Token(Token = "0x4000827")]
		[FieldOffset(Offset = "0x14")]
		private StyleKeyword m_Keyword;
	}
}
