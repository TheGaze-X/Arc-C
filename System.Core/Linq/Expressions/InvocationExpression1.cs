using System;
using Il2CppDummyDll;

namespace System.Linq.Expressions
{
	// Token: 0x02000056 RID: 86
	[Token(Token = "0x2000056")]
	internal sealed class InvocationExpression1 : InvocationExpression
	{
		// Token: 0x060002C1 RID: 705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002C1")]
		[Address(RVA = "0x4F41DC0", Offset = "0x4F409C0", VA = "0x184F41DC0")]
		public InvocationExpression1(Expression lambda, Type returnType, Expression arg0)
		{
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C2")]
		[Address(RVA = "0x4F41C80", Offset = "0x4F40880", VA = "0x184F41C80", Slot = "12")]
		public override Expression GetArgument(int index)
		{
			return null;
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060002C3 RID: 707 RVA: 0x00002910 File Offset: 0x00000B10
		[Token(Token = "0x1700005F")]
		public override int ArgumentCount
		{
			[Token(Token = "0x60002C3")]
			[Address(RVA = "0x557C40", Offset = "0x556840", VA = "0x180557C40", Slot = "13")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C4")]
		[Address(RVA = "0x4F41D20", Offset = "0x4F40920", VA = "0x184F41D20", Slot = "14")]
		internal override InvocationExpression Rewrite(Expression lambda, Expression[] arguments)
		{
			return null;
		}

		// Token: 0x04000147 RID: 327
		[Token(Token = "0x4000147")]
		[FieldOffset(Offset = "0x20")]
		private object _arg0;
	}
}
