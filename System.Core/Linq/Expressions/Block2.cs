using System;
using System.Collections.ObjectModel;
using Il2CppDummyDll;

namespace System.Linq.Expressions
{
	// Token: 0x02000043 RID: 67
	[Token(Token = "0x2000043")]
	internal sealed class Block2 : BlockExpression
	{
		// Token: 0x0600020A RID: 522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600020A")]
		[Address(RVA = "0x4F23980", Offset = "0x4F22580", VA = "0x184F23980")]
		internal Block2(Expression arg0, Expression arg1)
		{
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600020B")]
		[Address(RVA = "0x4F23860", Offset = "0x4F22460", VA = "0x184F23860", Slot = "10")]
		internal override Expression GetExpression(int index)
		{
			return null;
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x0600020C RID: 524 RVA: 0x000027C0 File Offset: 0x000009C0
		[Token(Token = "0x17000049")]
		internal override int ExpressionCount
		{
			[Token(Token = "0x600020C")]
			[Address(RVA = "0x54B0E0", Offset = "0x549CE0", VA = "0x18054B0E0", Slot = "11")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600020D")]
		[Address(RVA = "0x4F238F0", Offset = "0x4F224F0", VA = "0x184F238F0", Slot = "13")]
		internal override BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args)
		{
			return null;
		}

		// Token: 0x040000D6 RID: 214
		[Token(Token = "0x40000D6")]
		[FieldOffset(Offset = "0x10")]
		private object _arg0;

		// Token: 0x040000D7 RID: 215
		[Token(Token = "0x40000D7")]
		[FieldOffset(Offset = "0x18")]
		private readonly Expression _arg1;
	}
}
