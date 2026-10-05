using System;
using Il2CppDummyDll;

namespace System.Linq.Expressions
{
	// Token: 0x02000032 RID: 50
	[Token(Token = "0x2000032")]
	internal class AssignBinaryExpression : BinaryExpression
	{
		// Token: 0x0600016D RID: 365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600016D")]
		[Address(RVA = "0x4F21C30", Offset = "0x4F20830", VA = "0x184F21C30")]
		internal AssignBinaryExpression(Expression left, Expression right)
		{
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x0600016E RID: 366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700003C")]
		public sealed override Type Type
		{
			[Token(Token = "0x600016E")]
			[Address(RVA = "0x4F21C50", Offset = "0x4F20850", VA = "0x184F21C50", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x0600016F RID: 367 RVA: 0x00002670 File Offset: 0x00000870
		[Token(Token = "0x1700003D")]
		public sealed override ExpressionType NodeType
		{
			[Token(Token = "0x600016F")]
			[Address(RVA = "0x4F21C40", Offset = "0x4F20840", VA = "0x184F21C40", Slot = "4")]
			get
			{
				return ExpressionType.Add;
			}
		}
	}
}
