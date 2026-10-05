using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements.StyleSheets.Syntax
{
	// Token: 0x020002FE RID: 766
	[Token(Token = "0x20002FE")]
	internal class Expression
	{
		// Token: 0x060014FE RID: 5374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60014FE")]
		[Address(RVA = "0x5A7B820", Offset = "0x5A7A420", VA = "0x185A7B820")]
		public Expression(ExpressionType type)
		{
		}

		// Token: 0x04000C75 RID: 3189
		[Token(Token = "0x4000C75")]
		[FieldOffset(Offset = "0x10")]
		public ExpressionType type;

		// Token: 0x04000C76 RID: 3190
		[Token(Token = "0x4000C76")]
		[FieldOffset(Offset = "0x14")]
		public ExpressionMultiplier multiplier;

		// Token: 0x04000C77 RID: 3191
		[Token(Token = "0x4000C77")]
		[FieldOffset(Offset = "0x20")]
		public DataType dataType;

		// Token: 0x04000C78 RID: 3192
		[Token(Token = "0x4000C78")]
		[FieldOffset(Offset = "0x24")]
		public ExpressionCombinator combinator;

		// Token: 0x04000C79 RID: 3193
		[Token(Token = "0x4000C79")]
		[FieldOffset(Offset = "0x28")]
		public Expression[] subExpressions;

		// Token: 0x04000C7A RID: 3194
		[Token(Token = "0x4000C7A")]
		[FieldOffset(Offset = "0x30")]
		public string keyword;
	}
}
