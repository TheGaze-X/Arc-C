using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Il2CppDummyDll;

namespace System.Linq.Expressions
{
	// Token: 0x02000049 RID: 73
	[Token(Token = "0x2000049")]
	internal sealed class Scope1 : ScopeExpression
	{
		// Token: 0x06000222 RID: 546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000222")]
		[Address(RVA = "0x4F3D1B0", Offset = "0x4F3BDB0", VA = "0x184F3D1B0")]
		internal Scope1(IReadOnlyList<ParameterExpression> variables, Expression body)
		{
		}

		// Token: 0x06000223 RID: 547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000223")]
		[Address(RVA = "0x4F23980", Offset = "0x4F22580", VA = "0x184F23980")]
		private Scope1(IReadOnlyList<ParameterExpression> variables, object body)
		{
		}

		// Token: 0x06000224 RID: 548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000224")]
		[Address(RVA = "0x4F3D000", Offset = "0x4F3BC00", VA = "0x184F3D000", Slot = "10")]
		internal override Expression GetExpression(int index)
		{
			return null;
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000225 RID: 549 RVA: 0x00002838 File Offset: 0x00000A38
		[Token(Token = "0x1700004F")]
		internal override int ExpressionCount
		{
			[Token(Token = "0x6000225")]
			[Address(RVA = "0x557C40", Offset = "0x556840", VA = "0x180557C40", Slot = "11")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000226")]
		[Address(RVA = "0x4F3D080", Offset = "0x4F3BC80", VA = "0x184F3D080", Slot = "13")]
		internal override BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args)
		{
			return null;
		}

		// Token: 0x040000E6 RID: 230
		[Token(Token = "0x40000E6")]
		[FieldOffset(Offset = "0x18")]
		private object _body;
	}
}
