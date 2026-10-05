using System;
using System.Diagnostics.CodeAnalysis;
using Il2CppDummyDll;

namespace System.Linq.Expressions
{
	// Token: 0x02000058 RID: 88
	[Token(Token = "0x2000058")]
	public class Expression<TDelegate> : LambdaExpression
	{
		// Token: 0x060002D3 RID: 723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002D3")]
		internal Expression(Expression body)
		{
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060002D4 RID: 724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700006B")]
		internal sealed override Type TypeCore
		{
			[Token(Token = "0x60002D4")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060002D5 RID: 725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700006C")]
		internal override Type PublicType
		{
			[Token(Token = "0x60002D5")]
			get
			{
				return null;
			}
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D6")]
		[ExcludeFromCodeCoverage]
		internal virtual Expression<TDelegate> Rewrite(Expression body, ParameterExpression[] parameters)
		{
			return null;
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D7")]
		protected internal override Expression Accept(ExpressionVisitor visitor)
		{
			return null;
		}
	}
}
