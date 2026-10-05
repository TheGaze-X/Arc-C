using System;
using System.Reflection;
using Il2CppDummyDll;

namespace System.Linq.Expressions
{
	// Token: 0x02000034 RID: 52
	[Token(Token = "0x2000034")]
	internal sealed class OpAssignMethodConversionBinaryExpression : MethodBinaryExpression
	{
		// Token: 0x06000174 RID: 372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000174")]
		[Address(RVA = "0x4F3CCE0", Offset = "0x4F3B8E0", VA = "0x184F3CCE0")]
		internal OpAssignMethodConversionBinaryExpression(ExpressionType nodeType, Expression left, Expression right, Type type, MethodInfo method, LambdaExpression conversion)
		{
		}

		// Token: 0x06000175 RID: 373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000175")]
		[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850", Slot = "11")]
		internal override LambdaExpression GetConversion()
		{
			return null;
		}

		// Token: 0x040000CD RID: 205
		[Token(Token = "0x40000CD")]
		[FieldOffset(Offset = "0x38")]
		private readonly LambdaExpression _conversion;
	}
}
