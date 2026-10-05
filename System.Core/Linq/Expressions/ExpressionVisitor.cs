using System;
using System.Collections.ObjectModel;
using Il2CppDummyDll;

namespace System.Linq.Expressions
{
	// Token: 0x02000051 RID: 81
	[Token(Token = "0x2000051")]
	public abstract class ExpressionVisitor
	{
		// Token: 0x0600029A RID: 666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600029A")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected ExpressionVisitor()
		{
		}

		// Token: 0x0600029B RID: 667 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600029B")]
		[Address(RVA = "0x4F41850", Offset = "0x4F40450", VA = "0x184F41850", Slot = "4")]
		public virtual Expression Visit(Expression node)
		{
			return null;
		}

		// Token: 0x0600029C RID: 668 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600029C")]
		[Address(RVA = "0x4F41000", Offset = "0x4F3FC00", VA = "0x184F41000")]
		private Expression[] VisitArguments(IArgumentProvider nodes)
		{
			return null;
		}

		// Token: 0x0600029D RID: 669 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600029D")]
		[Address(RVA = "0x4F41630", Offset = "0x4F40230", VA = "0x184F41630")]
		private ParameterExpression[] VisitParameters(IParameterProvider nodes, string callerName)
		{
			return null;
		}

		// Token: 0x0600029E RID: 670 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600029E")]
		public T VisitAndConvert<T>(T node, string callerName) where T : Expression
		{
			return null;
		}

		// Token: 0x0600029F RID: 671 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600029F")]
		public ReadOnlyCollection<T> VisitAndConvert<T>(ReadOnlyCollection<T> nodes, string callerName) where T : Expression
		{
			return null;
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A0")]
		[Address(RVA = "0x4F41010", Offset = "0x4F3FC10", VA = "0x184F41010", Slot = "5")]
		protected internal virtual Expression VisitBinary(BinaryExpression node)
		{
			return null;
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x4F41260", Offset = "0x4F3FE60", VA = "0x184F41260", Slot = "6")]
		protected internal virtual Expression VisitBlock(BlockExpression node)
		{
			return null;
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x4F41350", Offset = "0x4F3FF50", VA = "0x184F41350", Slot = "7")]
		protected internal virtual Expression VisitExtension(Expression node)
		{
			return null;
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A3")]
		[Address(RVA = "0x4F41480", Offset = "0x4F40080", VA = "0x184F41480", Slot = "8")]
		protected internal virtual Expression VisitInvocation(InvocationExpression node)
		{
			return null;
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A4")]
		protected internal virtual Expression VisitLambda<T>(Expression<T> node)
		{
			return null;
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A5")]
		[Address(RVA = "0x4F41550", Offset = "0x4F40150", VA = "0x184F41550", Slot = "10")]
		protected internal virtual Expression VisitMember(MemberExpression node)
		{
			return null;
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A6")]
		[Address(RVA = "0x4F413A0", Offset = "0x4F3FFA0", VA = "0x184F413A0", Slot = "11")]
		protected internal virtual Expression VisitIndex(IndexExpression node)
		{
			return null;
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A7")]
		[Address(RVA = "0x5B5210", Offset = "0x5B3E10", VA = "0x1805B5210", Slot = "12")]
		protected internal virtual Expression VisitParameter(ParameterExpression node)
		{
			return null;
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A8")]
		[Address(RVA = "0x4F41640", Offset = "0x4F40240", VA = "0x184F41640", Slot = "13")]
		protected internal virtual Expression VisitUnary(UnaryExpression node)
		{
			return null;
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002A9")]
		[Address(RVA = "0x4F40EF0", Offset = "0x4F3FAF0", VA = "0x184F40EF0")]
		private static UnaryExpression ValidateUnary(UnaryExpression before, UnaryExpression after)
		{
			return null;
		}

		// Token: 0x060002AA RID: 682 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002AA")]
		[Address(RVA = "0x4F40C40", Offset = "0x4F3F840", VA = "0x184F40C40")]
		private static BinaryExpression ValidateBinary(BinaryExpression before, BinaryExpression after)
		{
			return null;
		}

		// Token: 0x060002AB RID: 683 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002AB")]
		[Address(RVA = "0x4F40DB0", Offset = "0x4F3F9B0", VA = "0x184F40DB0")]
		private static void ValidateChildType(Type before, Type after, string methodName)
		{
		}
	}
}
