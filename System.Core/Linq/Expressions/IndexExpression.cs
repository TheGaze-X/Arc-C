using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.Linq.Expressions
{
	// Token: 0x02000054 RID: 84
	[Token(Token = "0x2000054")]
	[DebuggerTypeProxy(typeof(Expression.IndexExpressionProxy))]
	public sealed class IndexExpression : Expression, IArgumentProvider
	{
		// Token: 0x060002B0 RID: 688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002B0")]
		[Address(RVA = "0x4F41AB0", Offset = "0x4F406B0", VA = "0x184F41AB0")]
		internal IndexExpression(Expression instance, PropertyInfo indexer, IReadOnlyList<Expression> arguments)
		{
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060002B1 RID: 689 RVA: 0x000028B0 File Offset: 0x00000AB0
		[Token(Token = "0x17000056")]
		public sealed override ExpressionType NodeType
		{
			[Token(Token = "0x60002B1")]
			[Address(RVA = "0x4F41BB0", Offset = "0x4F407B0", VA = "0x184F41BB0", Slot = "4")]
			get
			{
				return ExpressionType.Add;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060002B2 RID: 690 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000057")]
		public sealed override Type Type
		{
			[Token(Token = "0x60002B2")]
			[Address(RVA = "0x4F41BC0", Offset = "0x4F407C0", VA = "0x184F41BC0", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060002B3 RID: 691 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000058")]
		public Expression Object
		{
			[Token(Token = "0x60002B3")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060002B4 RID: 692 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000059")]
		public PropertyInfo Indexer
		{
			[Token(Token = "0x60002B4")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002B5")]
		[Address(RVA = "0x4F419D0", Offset = "0x4F405D0", VA = "0x184F419D0", Slot = "10")]
		public Expression GetArgument(int index)
		{
			return null;
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060002B6 RID: 694 RVA: 0x000028C8 File Offset: 0x00000AC8
		[Token(Token = "0x1700005A")]
		public int ArgumentCount
		{
			[Token(Token = "0x60002B6")]
			[Address(RVA = "0x4F41B60", Offset = "0x4F40760", VA = "0x184F41B60", Slot = "11")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002B7")]
		[Address(RVA = "0x4F41980", Offset = "0x4F40580", VA = "0x184F41980", Slot = "9")]
		protected internal override Expression Accept(ExpressionVisitor visitor)
		{
			return null;
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002B8")]
		[Address(RVA = "0x4F41A30", Offset = "0x4F40630", VA = "0x184F41A30")]
		internal Expression Rewrite(Expression instance, Expression[] arguments)
		{
			return null;
		}

		// Token: 0x04000142 RID: 322
		[Token(Token = "0x4000142")]
		[FieldOffset(Offset = "0x10")]
		private IReadOnlyList<Expression> _arguments;
	}
}
