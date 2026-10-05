using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.Linq.Expressions
{
	// Token: 0x02000031 RID: 49
	[Token(Token = "0x2000031")]
	internal sealed class LogicalBinaryExpression : BinaryExpression
	{
		// Token: 0x0600016A RID: 362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600016A")]
		[Address(RVA = "0x4F3CBE0", Offset = "0x4F3B7E0", VA = "0x184F3CBE0")]
		internal LogicalBinaryExpression(ExpressionType nodeType, Expression left, Expression right)
		{
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600016B RID: 363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700003A")]
		public sealed override Type Type
		{
			[Token(Token = "0x600016B")]
			[Address(RVA = "0x4F3CC20", Offset = "0x4F3B820", VA = "0x184F3CC20", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x0600016C RID: 364 RVA: 0x00002658 File Offset: 0x00000858
		[Token(Token = "0x1700003B")]
		public sealed override ExpressionType NodeType
		{
			[Token(Token = "0x600016C")]
			[Address(RVA = "0x4EA890", Offset = "0x4E9490", VA = "0x1804EA890", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return ExpressionType.Add;
			}
		}
	}
}
