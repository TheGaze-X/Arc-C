using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Il2CppDummyDll;

namespace System.Linq.Expressions
{
	// Token: 0x0200004F RID: 79
	[Token(Token = "0x200004F")]
	internal sealed class ExpressionStringBuilder : ExpressionVisitor
	{
		// Token: 0x06000288 RID: 648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000288")]
		[Address(RVA = "0x4F3FBE0", Offset = "0x4F3E7E0", VA = "0x184F3FBE0")]
		private ExpressionStringBuilder()
		{
		}

		// Token: 0x06000289 RID: 649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000289")]
		[Address(RVA = "0x4F3E300", Offset = "0x4F3CF00", VA = "0x184F3E300", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600028A RID: 650 RVA: 0x00002868 File Offset: 0x00000A68
		[Token(Token = "0x600028A")]
		[Address(RVA = "0x4F3DF30", Offset = "0x4F3CB30", VA = "0x184F3DF30")]
		private int GetParamId(ParameterExpression p)
		{
			return 0;
		}

		// Token: 0x0600028B RID: 651 RVA: 0x00002880 File Offset: 0x00000A80
		[Token(Token = "0x600028B")]
		[Address(RVA = "0x4F3DF30", Offset = "0x4F3CB30", VA = "0x184F3DF30")]
		private int GetId(object o)
		{
			return 0;
		}

		// Token: 0x0600028C RID: 652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600028C")]
		[Address(RVA = "0x4F3E2C0", Offset = "0x4F3CEC0", VA = "0x184F3E2C0")]
		private void Out(string s)
		{
		}

		// Token: 0x0600028D RID: 653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600028D")]
		[Address(RVA = "0x4F3E2E0", Offset = "0x4F3CEE0", VA = "0x184F3E2E0")]
		private void Out(char c)
		{
		}

		// Token: 0x0600028E RID: 654 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600028E")]
		[Address(RVA = "0x4F3DE30", Offset = "0x4F3CA30", VA = "0x184F3DE30")]
		internal static string ExpressionToString(Expression node)
		{
			return null;
		}

		// Token: 0x0600028F RID: 655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600028F")]
		[Address(RVA = "0x4F3E350", Offset = "0x4F3CF50", VA = "0x184F3E350", Slot = "5")]
		protected internal override Expression VisitBinary(BinaryExpression node)
		{
			return null;
		}

		// Token: 0x06000290 RID: 656 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000290")]
		[Address(RVA = "0x4F3F430", Offset = "0x4F3E030", VA = "0x184F3F430", Slot = "12")]
		protected internal override Expression VisitParameter(ParameterExpression node)
		{
			return null;
		}

		// Token: 0x06000291 RID: 657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000291")]
		protected internal override Expression VisitLambda<T>(Expression<T> node)
		{
			return null;
		}

		// Token: 0x06000292 RID: 658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000292")]
		[Address(RVA = "0x4F3E190", Offset = "0x4F3CD90", VA = "0x184F3E190")]
		private void OutMember(Expression instance, MemberInfo member)
		{
		}

		// Token: 0x06000293 RID: 659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000293")]
		[Address(RVA = "0x4F3F2B0", Offset = "0x4F3DEB0", VA = "0x184F3F2B0", Slot = "10")]
		protected internal override Expression VisitMember(MemberExpression node)
		{
			return null;
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000294")]
		[Address(RVA = "0x4F3F130", Offset = "0x4F3DD30", VA = "0x184F3F130", Slot = "8")]
		protected internal override Expression VisitInvocation(InvocationExpression node)
		{
			return null;
		}

		// Token: 0x06000295 RID: 661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000295")]
		[Address(RVA = "0x4F3F620", Offset = "0x4F3E220", VA = "0x184F3F620", Slot = "13")]
		protected internal override Expression VisitUnary(UnaryExpression node)
		{
			return null;
		}

		// Token: 0x06000296 RID: 662 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000296")]
		[Address(RVA = "0x4F3E9C0", Offset = "0x4F3D5C0", VA = "0x184F3E9C0", Slot = "6")]
		protected internal override Expression VisitBlock(BlockExpression node)
		{
			return null;
		}

		// Token: 0x06000297 RID: 663 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000297")]
		[Address(RVA = "0x4F3EEF0", Offset = "0x4F3DAF0", VA = "0x184F3EEF0", Slot = "11")]
		protected internal override Expression VisitIndex(IndexExpression node)
		{
			return null;
		}

		// Token: 0x06000298 RID: 664 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000298")]
		[Address(RVA = "0x4F3EC70", Offset = "0x4F3D870", VA = "0x184F3EC70", Slot = "7")]
		protected internal override Expression VisitExtension(Expression node)
		{
			return null;
		}

		// Token: 0x06000299 RID: 665 RVA: 0x00002898 File Offset: 0x00000A98
		[Token(Token = "0x6000299")]
		[Address(RVA = "0x4F3E050", Offset = "0x4F3CC50", VA = "0x184F3E050")]
		private static bool IsBool(Expression node)
		{
			return default(bool);
		}

		// Token: 0x040000EA RID: 234
		[Token(Token = "0x40000EA")]
		[FieldOffset(Offset = "0x10")]
		private readonly StringBuilder _out;

		// Token: 0x040000EB RID: 235
		[Token(Token = "0x40000EB")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<object, int> _ids;
	}
}
