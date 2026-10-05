using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Il2CppDummyDll;

namespace System.Linq.Expressions
{
	// Token: 0x0200004A RID: 74
	[Token(Token = "0x200004A")]
	internal class ScopeN : ScopeExpression
	{
		// Token: 0x06000227 RID: 551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000227")]
		[Address(RVA = "0x4F23980", Offset = "0x4F22580", VA = "0x184F23980")]
		internal ScopeN(IReadOnlyList<ParameterExpression> variables, IReadOnlyList<Expression> body)
		{
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000228 RID: 552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000050")]
		protected IReadOnlyList<Expression> Body
		{
			[Token(Token = "0x6000228")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000229 RID: 553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000229")]
		[Address(RVA = "0x4F3D290", Offset = "0x4F3BE90", VA = "0x184F3D290", Slot = "10")]
		internal override Expression GetExpression(int index)
		{
			return null;
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x0600022A RID: 554 RVA: 0x00002850 File Offset: 0x00000A50
		[Token(Token = "0x17000051")]
		internal override int ExpressionCount
		{
			[Token(Token = "0x600022A")]
			[Address(RVA = "0x4F3D410", Offset = "0x4F3C010", VA = "0x184F3D410", Slot = "11")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022B")]
		[Address(RVA = "0x4F3D2F0", Offset = "0x4F3BEF0", VA = "0x184F3D2F0", Slot = "13")]
		internal override BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args)
		{
			return null;
		}

		// Token: 0x040000E7 RID: 231
		[Token(Token = "0x40000E7")]
		[FieldOffset(Offset = "0x18")]
		private IReadOnlyList<Expression> _body;
	}
}
