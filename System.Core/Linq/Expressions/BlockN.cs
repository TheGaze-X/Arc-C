using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Il2CppDummyDll;

namespace System.Linq.Expressions
{
	// Token: 0x02000047 RID: 71
	[Token(Token = "0x2000047")]
	internal class BlockN : BlockExpression
	{
		// Token: 0x0600021A RID: 538 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600021A")]
		[Address(RVA = "0x4F24420", Offset = "0x4F23020", VA = "0x184F24420")]
		internal BlockN(IReadOnlyList<Expression> expressions)
		{
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600021B")]
		[Address(RVA = "0x4F24320", Offset = "0x4F22F20", VA = "0x184F24320", Slot = "10")]
		internal override Expression GetExpression(int index)
		{
			return null;
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x0600021C RID: 540 RVA: 0x00002820 File Offset: 0x00000A20
		[Token(Token = "0x1700004D")]
		internal override int ExpressionCount
		{
			[Token(Token = "0x600021C")]
			[Address(RVA = "0x4F24490", Offset = "0x4F23090", VA = "0x184F24490", Slot = "11")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600021D RID: 541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600021D")]
		[Address(RVA = "0x4F24380", Offset = "0x4F22F80", VA = "0x184F24380", Slot = "13")]
		internal override BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args)
		{
			return null;
		}

		// Token: 0x040000E4 RID: 228
		[Token(Token = "0x40000E4")]
		[FieldOffset(Offset = "0x10")]
		private IReadOnlyList<Expression> _expressions;
	}
}
