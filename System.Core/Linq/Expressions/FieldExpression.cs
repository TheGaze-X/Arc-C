using System;
using System.Reflection;
using Il2CppDummyDll;

namespace System.Linq.Expressions
{
	// Token: 0x02000061 RID: 97
	[Token(Token = "0x2000061")]
	internal sealed class FieldExpression : MemberExpression
	{
		// Token: 0x060002F9 RID: 761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002F9")]
		[Address(RVA = "0x4F418B0", Offset = "0x4F404B0", VA = "0x184F418B0")]
		public FieldExpression(Expression expression, FieldInfo member)
		{
		}

		// Token: 0x060002FA RID: 762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002FA")]
		[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "10")]
		internal override MemberInfo GetMember()
		{
			return null;
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060002FB RID: 763 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000077")]
		public sealed override Type Type
		{
			[Token(Token = "0x60002FB")]
			[Address(RVA = "0x4F41930", Offset = "0x4F40530", VA = "0x184F41930", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000153 RID: 339
		[Token(Token = "0x4000153")]
		[FieldOffset(Offset = "0x18")]
		private readonly FieldInfo _field;
	}
}
