using System;
using Il2CppDummyDll;

namespace System.Linq.Expressions
{
	// Token: 0x0200005B RID: 91
	[Token(Token = "0x200005B")]
	internal sealed class Expression1<TDelegate> : Expression<TDelegate>
	{
		// Token: 0x060002DD RID: 733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002DD")]
		public Expression1(Expression body, ParameterExpression par0)
		{
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060002DE RID: 734 RVA: 0x000029B8 File Offset: 0x00000BB8
		[Token(Token = "0x1700006E")]
		internal override int ParameterCount
		{
			[Token(Token = "0x60002DE")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060002DF RID: 735 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002DF")]
		internal override ParameterExpression GetParameter(int index)
		{
			return null;
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002E0")]
		internal override Expression<TDelegate> Rewrite(Expression body, ParameterExpression[] parameters)
		{
			return null;
		}

		// Token: 0x04000149 RID: 329
		[Token(Token = "0x4000149")]
		[FieldOffset(Offset = "0x0")]
		private object _par0;
	}
}
