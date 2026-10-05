using System;
using Il2CppDummyDll;

namespace System.Linq.Expressions
{
	// Token: 0x0200005D RID: 93
	[Token(Token = "0x200005D")]
	internal sealed class Expression3<TDelegate> : Expression<TDelegate>
	{
		// Token: 0x060002E5 RID: 741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002E5")]
		public Expression3(Expression body, ParameterExpression par0, ParameterExpression par1, ParameterExpression par2)
		{
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060002E6 RID: 742 RVA: 0x000029E8 File Offset: 0x00000BE8
		[Token(Token = "0x17000070")]
		internal override int ParameterCount
		{
			[Token(Token = "0x60002E6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002E7")]
		internal override ParameterExpression GetParameter(int index)
		{
			return null;
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002E8")]
		internal override Expression<TDelegate> Rewrite(Expression body, ParameterExpression[] parameters)
		{
			return null;
		}

		// Token: 0x0400014C RID: 332
		[Token(Token = "0x400014C")]
		[FieldOffset(Offset = "0x0")]
		private object _par0;

		// Token: 0x0400014D RID: 333
		[Token(Token = "0x400014D")]
		[FieldOffset(Offset = "0x0")]
		private readonly ParameterExpression _par1;

		// Token: 0x0400014E RID: 334
		[Token(Token = "0x400014E")]
		[FieldOffset(Offset = "0x0")]
		private readonly ParameterExpression _par2;
	}
}
