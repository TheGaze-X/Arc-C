using System;
using Il2CppDummyDll;

namespace System.Linq.Expressions
{
	// Token: 0x0200005C RID: 92
	[Token(Token = "0x200005C")]
	internal sealed class Expression2<TDelegate> : Expression<TDelegate>
	{
		// Token: 0x060002E1 RID: 737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002E1")]
		public Expression2(Expression body, ParameterExpression par0, ParameterExpression par1)
		{
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060002E2 RID: 738 RVA: 0x000029D0 File Offset: 0x00000BD0
		[Token(Token = "0x1700006F")]
		internal override int ParameterCount
		{
			[Token(Token = "0x60002E2")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002E3")]
		internal override ParameterExpression GetParameter(int index)
		{
			return null;
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002E4")]
		internal override Expression<TDelegate> Rewrite(Expression body, ParameterExpression[] parameters)
		{
			return null;
		}

		// Token: 0x0400014A RID: 330
		[Token(Token = "0x400014A")]
		[FieldOffset(Offset = "0x0")]
		private object _par0;

		// Token: 0x0400014B RID: 331
		[Token(Token = "0x400014B")]
		[FieldOffset(Offset = "0x0")]
		private readonly ParameterExpression _par1;
	}
}
