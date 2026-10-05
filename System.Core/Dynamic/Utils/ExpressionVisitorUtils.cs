using System;
using System.Linq.Expressions;
using Il2CppDummyDll;

namespace System.Dynamic.Utils
{
	// Token: 0x02000072 RID: 114
	[Token(Token = "0x2000072")]
	internal static class ExpressionVisitorUtils
	{
		// Token: 0x060003A5 RID: 933 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A5")]
		[Address(RVA = "0x4F407F0", Offset = "0x4F3F3F0", VA = "0x184F407F0")]
		public static Expression[] VisitBlockExpressions(ExpressionVisitor visitor, BlockExpression block)
		{
			return null;
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A6")]
		[Address(RVA = "0x4F40A20", Offset = "0x4F3F620", VA = "0x184F40A20")]
		public static ParameterExpression[] VisitParameters(ExpressionVisitor visitor, IParameterProvider nodes, string callerName)
		{
			return null;
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003A7")]
		[Address(RVA = "0x4F405D0", Offset = "0x4F3F1D0", VA = "0x184F405D0")]
		public static Expression[] VisitArguments(ExpressionVisitor visitor, IArgumentProvider nodes)
		{
			return null;
		}
	}
}
