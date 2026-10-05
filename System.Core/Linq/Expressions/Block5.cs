using System;
using System.Collections.ObjectModel;
using Il2CppDummyDll;

namespace System.Linq.Expressions
{
	// Token: 0x02000046 RID: 70
	[Token(Token = "0x2000046")]
	internal sealed class Block5 : BlockExpression
	{
		// Token: 0x06000216 RID: 534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000216")]
		[Address(RVA = "0x4F23FE0", Offset = "0x4F22BE0", VA = "0x184F23FE0")]
		internal Block5(Expression arg0, Expression arg1, Expression arg2, Expression arg3, Expression arg4)
		{
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000217")]
		[Address(RVA = "0x4F23E30", Offset = "0x4F22A30", VA = "0x184F23E30", Slot = "10")]
		internal override Expression GetExpression(int index)
		{
			return null;
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000218 RID: 536 RVA: 0x00002808 File Offset: 0x00000A08
		[Token(Token = "0x1700004C")]
		internal override int ExpressionCount
		{
			[Token(Token = "0x6000218")]
			[Address(RVA = "0x54AE00", Offset = "0x549A00", VA = "0x18054AE00", Slot = "11")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000219")]
		[Address(RVA = "0x4F23F00", Offset = "0x4F22B00", VA = "0x184F23F00", Slot = "13")]
		internal override BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args)
		{
			return null;
		}

		// Token: 0x040000DF RID: 223
		[Token(Token = "0x40000DF")]
		[FieldOffset(Offset = "0x10")]
		private object _arg0;

		// Token: 0x040000E0 RID: 224
		[Token(Token = "0x40000E0")]
		[FieldOffset(Offset = "0x18")]
		private readonly Expression _arg1;

		// Token: 0x040000E1 RID: 225
		[Token(Token = "0x40000E1")]
		[FieldOffset(Offset = "0x20")]
		private readonly Expression _arg2;

		// Token: 0x040000E2 RID: 226
		[Token(Token = "0x40000E2")]
		[FieldOffset(Offset = "0x28")]
		private readonly Expression _arg3;

		// Token: 0x040000E3 RID: 227
		[Token(Token = "0x40000E3")]
		[FieldOffset(Offset = "0x30")]
		private readonly Expression _arg4;
	}
}
