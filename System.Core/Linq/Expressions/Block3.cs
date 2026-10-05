using System;
using System.Collections.ObjectModel;
using Il2CppDummyDll;

namespace System.Linq.Expressions
{
	// Token: 0x02000044 RID: 68
	[Token(Token = "0x2000044")]
	internal sealed class Block3 : BlockExpression
	{
		// Token: 0x0600020E RID: 526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600020E")]
		[Address(RVA = "0x4F23B60", Offset = "0x4F22760", VA = "0x184F23B60")]
		internal Block3(Expression arg0, Expression arg1, Expression arg2)
		{
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600020F")]
		[Address(RVA = "0x4F23A00", Offset = "0x4F22600", VA = "0x184F23A00", Slot = "10")]
		internal override Expression GetExpression(int index)
		{
			return null;
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000210 RID: 528 RVA: 0x000027D8 File Offset: 0x000009D8
		[Token(Token = "0x1700004A")]
		internal override int ExpressionCount
		{
			[Token(Token = "0x6000210")]
			[Address(RVA = "0x54B800", Offset = "0x54A400", VA = "0x18054B800", Slot = "11")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000211")]
		[Address(RVA = "0x4F23AB0", Offset = "0x4F226B0", VA = "0x184F23AB0", Slot = "13")]
		internal override BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args)
		{
			return null;
		}

		// Token: 0x040000D8 RID: 216
		[Token(Token = "0x40000D8")]
		[FieldOffset(Offset = "0x10")]
		private object _arg0;

		// Token: 0x040000D9 RID: 217
		[Token(Token = "0x40000D9")]
		[FieldOffset(Offset = "0x18")]
		private readonly Expression _arg1;

		// Token: 0x040000DA RID: 218
		[Token(Token = "0x40000DA")]
		[FieldOffset(Offset = "0x20")]
		private readonly Expression _arg2;
	}
}
