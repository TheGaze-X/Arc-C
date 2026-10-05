using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.Linq.Expressions
{
	// Token: 0x02000068 RID: 104
	[Token(Token = "0x2000068")]
	[DebuggerTypeProxy(typeof(Expression.UnaryExpressionProxy))]
	public sealed class UnaryExpression : Expression
	{
		// Token: 0x06000359 RID: 857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000359")]
		[Address(RVA = "0x4F4C9E0", Offset = "0x4F4B5E0", VA = "0x184F4C9E0")]
		internal UnaryExpression(ExpressionType nodeType, Expression expression, Type type, MethodInfo method)
		{
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x0600035A RID: 858 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000A4")]
		public sealed override Type Type
		{
			[Token(Token = "0x600035A")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x0600035B RID: 859 RVA: 0x00002AA8 File Offset: 0x00000CA8
		[Token(Token = "0x170000A5")]
		public sealed override ExpressionType NodeType
		{
			[Token(Token = "0x600035B")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return ExpressionType.Add;
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x0600035C RID: 860 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000A6")]
		public Expression Operand
		{
			[Token(Token = "0x600035C")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x0600035D RID: 861 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000A7")]
		public MethodInfo Method
		{
			[Token(Token = "0x600035D")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x0600035E RID: 862 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600035E")]
		[Address(RVA = "0x4F4B530", Offset = "0x4F4A130", VA = "0x184F4B530", Slot = "9")]
		protected internal override Expression Accept(ExpressionVisitor visitor)
		{
			return null;
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x0600035F RID: 863 RVA: 0x00002AC0 File Offset: 0x00000CC0
		[Token(Token = "0x170000A8")]
		public override bool CanReduce
		{
			[Token(Token = "0x600035F")]
			[Address(RVA = "0x4F4CA80", Offset = "0x4F4B680", VA = "0x184F4CA80", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000360 RID: 864 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000360")]
		[Address(RVA = "0x4F4C830", Offset = "0x4F4B430", VA = "0x184F4C830", Slot = "7")]
		public override Expression Reduce()
		{
			return null;
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000361 RID: 865 RVA: 0x00002AD8 File Offset: 0x00000CD8
		[Token(Token = "0x170000A9")]
		private bool IsPrefix
		{
			[Token(Token = "0x6000361")]
			[Address(RVA = "0x4F4CAC0", Offset = "0x4F4B6C0", VA = "0x184F4CAC0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000362 RID: 866 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000362")]
		[Address(RVA = "0x4F4B580", Offset = "0x4F4A180", VA = "0x184F4B580")]
		private UnaryExpression FunctionalOp(Expression operand)
		{
			return null;
		}

		// Token: 0x06000363 RID: 867 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000363")]
		[Address(RVA = "0x4F4C4F0", Offset = "0x4F4B0F0", VA = "0x184F4C4F0")]
		private Expression ReduceVariable()
		{
			return null;
		}

		// Token: 0x06000364 RID: 868 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000364")]
		[Address(RVA = "0x4F4BE90", Offset = "0x4F4AA90", VA = "0x184F4BE90")]
		private Expression ReduceMember()
		{
			return null;
		}

		// Token: 0x06000365 RID: 869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000365")]
		[Address(RVA = "0x4F4B700", Offset = "0x4F4A300", VA = "0x184F4B700")]
		private Expression ReduceIndex()
		{
			return null;
		}

		// Token: 0x06000366 RID: 870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000366")]
		[Address(RVA = "0x4F4C8F0", Offset = "0x4F4B4F0", VA = "0x184F4C8F0")]
		public UnaryExpression Update(Expression operand)
		{
			return null;
		}
	}
}
