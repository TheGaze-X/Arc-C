using System;
using Il2CppDummyDll;

namespace System.Linq.Expressions
{
	// Token: 0x0200005A RID: 90
	[Token(Token = "0x200005A")]
	internal sealed class Expression0<TDelegate> : Expression<TDelegate>
	{
		// Token: 0x060002D9 RID: 729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002D9")]
		public Expression0(Expression body)
		{
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060002DA RID: 730 RVA: 0x000029A0 File Offset: 0x00000BA0
		[Token(Token = "0x1700006D")]
		internal override int ParameterCount
		{
			[Token(Token = "0x60002DA")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060002DB RID: 731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002DB")]
		internal override ParameterExpression GetParameter(int index)
		{
			return null;
		}

		// Token: 0x060002DC RID: 732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002DC")]
		internal override Expression<TDelegate> Rewrite(Expression body, ParameterExpression[] parameters)
		{
			return null;
		}
	}
}
