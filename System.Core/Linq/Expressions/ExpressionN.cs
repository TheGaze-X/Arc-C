using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace System.Linq.Expressions
{
	// Token: 0x0200005E RID: 94
	[Token(Token = "0x200005E")]
	internal class ExpressionN<TDelegate> : Expression<TDelegate>
	{
		// Token: 0x060002E9 RID: 745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002E9")]
		public ExpressionN(Expression body, IReadOnlyList<ParameterExpression> parameters)
		{
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060002EA RID: 746 RVA: 0x00002A00 File Offset: 0x00000C00
		[Token(Token = "0x17000071")]
		internal override int ParameterCount
		{
			[Token(Token = "0x60002EA")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060002EB RID: 747 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002EB")]
		internal override ParameterExpression GetParameter(int index)
		{
			return null;
		}

		// Token: 0x060002EC RID: 748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002EC")]
		internal override Expression<TDelegate> Rewrite(Expression body, ParameterExpression[] parameters)
		{
			return null;
		}

		// Token: 0x0400014F RID: 335
		[Token(Token = "0x400014F")]
		[FieldOffset(Offset = "0x0")]
		private IReadOnlyList<ParameterExpression> _parameters;
	}
}
