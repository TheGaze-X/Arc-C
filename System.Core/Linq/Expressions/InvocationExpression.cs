using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.Linq.Expressions
{
	// Token: 0x02000055 RID: 85
	[Token(Token = "0x2000055")]
	[DebuggerTypeProxy(typeof(Expression.InvocationExpressionProxy))]
	public class InvocationExpression : Expression, IArgumentProvider
	{
		// Token: 0x060002B9 RID: 697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002B9")]
		[Address(RVA = "0x4F41EC0", Offset = "0x4F40AC0", VA = "0x184F41EC0")]
		internal InvocationExpression(Expression expression, Type returnType)
		{
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060002BA RID: 698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700005B")]
		public sealed override Type Type
		{
			[Token(Token = "0x60002BA")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060002BB RID: 699 RVA: 0x000028E0 File Offset: 0x00000AE0
		[Token(Token = "0x1700005C")]
		public sealed override ExpressionType NodeType
		{
			[Token(Token = "0x60002BB")]
			[Address(RVA = "0x4DF2DE0", Offset = "0x4DF19E0", VA = "0x184DF2DE0", Slot = "4")]
			get
			{
				return ExpressionType.Add;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060002BC RID: 700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700005D")]
		public Expression Expression
		{
			[Token(Token = "0x60002BC")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x060002BD RID: 701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002BD")]
		[Address(RVA = "0x4F41E60", Offset = "0x4F40A60", VA = "0x184F41E60", Slot = "12")]
		[ExcludeFromCodeCoverage]
		public virtual Expression GetArgument(int index)
		{
			return null;
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060002BE RID: 702 RVA: 0x000028F8 File Offset: 0x00000AF8
		[Token(Token = "0x1700005E")]
		[ExcludeFromCodeCoverage]
		public virtual int ArgumentCount
		{
			[Token(Token = "0x60002BE")]
			[Address(RVA = "0x4F41F40", Offset = "0x4F40B40", VA = "0x184F41F40", Slot = "13")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060002BF RID: 703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x4F41350", Offset = "0x4F3FF50", VA = "0x184F41350", Slot = "9")]
		protected internal override Expression Accept(ExpressionVisitor visitor)
		{
			return null;
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x4F41E90", Offset = "0x4F40A90", VA = "0x184F41E90", Slot = "14")]
		[ExcludeFromCodeCoverage]
		internal virtual InvocationExpression Rewrite(Expression lambda, Expression[] arguments)
		{
			return null;
		}
	}
}
