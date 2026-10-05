using System;
using System.Reflection;
using Il2CppDummyDll;

namespace System.Linq.Expressions
{
	// Token: 0x02000036 RID: 54
	[Token(Token = "0x2000036")]
	internal class MethodBinaryExpression : SimpleBinaryExpression
	{
		// Token: 0x06000179 RID: 377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000179")]
		[Address(RVA = "0x4F3CC80", Offset = "0x4F3B880", VA = "0x184F3CC80")]
		internal MethodBinaryExpression(ExpressionType nodeType, Expression left, Expression right, Type type, MethodInfo method)
		{
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600017A")]
		[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0", Slot = "10")]
		internal override MethodInfo GetMethod()
		{
			return null;
		}

		// Token: 0x040000D0 RID: 208
		[Token(Token = "0x40000D0")]
		[FieldOffset(Offset = "0x30")]
		private readonly MethodInfo _method;
	}
}
