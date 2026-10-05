using System;
using System.Reflection;
using Il2CppDummyDll;

namespace System.Linq.Expressions
{
	// Token: 0x02000062 RID: 98
	[Token(Token = "0x2000062")]
	internal sealed class PropertyExpression : MemberExpression
	{
		// Token: 0x060002FC RID: 764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002FC")]
		[Address(RVA = "0x4F418B0", Offset = "0x4F404B0", VA = "0x184F418B0")]
		public PropertyExpression(Expression expression, PropertyInfo member)
		{
		}

		// Token: 0x060002FD RID: 765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002FD")]
		[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "10")]
		internal override MemberInfo GetMember()
		{
			return null;
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060002FE RID: 766 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000078")]
		public sealed override Type Type
		{
			[Token(Token = "0x60002FE")]
			[Address(RVA = "0x4F42DA0", Offset = "0x4F419A0", VA = "0x184F42DA0", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000154 RID: 340
		[Token(Token = "0x4000154")]
		[FieldOffset(Offset = "0x18")]
		private readonly PropertyInfo _property;
	}
}
