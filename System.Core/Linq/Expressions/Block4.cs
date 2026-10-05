using System;
using System.Collections.ObjectModel;
using Il2CppDummyDll;

namespace System.Linq.Expressions
{
	// Token: 0x02000045 RID: 69
	[Token(Token = "0x2000045")]
	internal sealed class Block4 : BlockExpression
	{
		// Token: 0x06000212 RID: 530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000212")]
		[Address(RVA = "0x4F23D80", Offset = "0x4F22980", VA = "0x184F23D80")]
		internal Block4(Expression arg0, Expression arg1, Expression arg2, Expression arg3)
		{
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000213")]
		[Address(RVA = "0x4F23C00", Offset = "0x4F22800", VA = "0x184F23C00", Slot = "10")]
		internal override Expression GetExpression(int index)
		{
			return null;
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000214 RID: 532 RVA: 0x000027F0 File Offset: 0x000009F0
		[Token(Token = "0x1700004B")]
		internal override int ExpressionCount
		{
			[Token(Token = "0x6000214")]
			[Address(RVA = "0x54B470", Offset = "0x54A070", VA = "0x18054B470", Slot = "11")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000215")]
		[Address(RVA = "0x4F23CC0", Offset = "0x4F228C0", VA = "0x184F23CC0", Slot = "13")]
		internal override BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args)
		{
			return null;
		}

		// Token: 0x040000DB RID: 219
		[Token(Token = "0x40000DB")]
		[FieldOffset(Offset = "0x10")]
		private object _arg0;

		// Token: 0x040000DC RID: 220
		[Token(Token = "0x40000DC")]
		[FieldOffset(Offset = "0x18")]
		private readonly Expression _arg1;

		// Token: 0x040000DD RID: 221
		[Token(Token = "0x40000DD")]
		[FieldOffset(Offset = "0x20")]
		private readonly Expression _arg2;

		// Token: 0x040000DE RID: 222
		[Token(Token = "0x40000DE")]
		[FieldOffset(Offset = "0x28")]
		private readonly Expression _arg3;
	}
}
