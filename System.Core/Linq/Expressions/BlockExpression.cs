using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using Il2CppDummyDll;

namespace System.Linq.Expressions
{
	// Token: 0x02000042 RID: 66
	[Token(Token = "0x2000042")]
	[DebuggerTypeProxy(typeof(Expression.BlockExpressionProxy))]
	public class BlockExpression : Expression
	{
		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000201 RID: 513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000045")]
		public ReadOnlyCollection<ParameterExpression> Variables
		{
			[Token(Token = "0x6000201")]
			[Address(RVA = "0x4F242E0", Offset = "0x4F22EE0", VA = "0x184F242E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000202 RID: 514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000202")]
		[Address(RVA = "0x4F241A0", Offset = "0x4F22DA0", VA = "0x184F241A0")]
		internal BlockExpression()
		{
		}

		// Token: 0x06000203 RID: 515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000203")]
		[Address(RVA = "0x4F240A0", Offset = "0x4F22CA0", VA = "0x184F240A0", Slot = "9")]
		protected internal override Expression Accept(ExpressionVisitor visitor)
		{
			return null;
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000204 RID: 516 RVA: 0x00002790 File Offset: 0x00000990
		[Token(Token = "0x17000046")]
		public sealed override ExpressionType NodeType
		{
			[Token(Token = "0x6000204")]
			[Address(RVA = "0x4F24220", Offset = "0x4F22E20", VA = "0x184F24220", Slot = "4")]
			get
			{
				return ExpressionType.Add;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000205 RID: 517 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000047")]
		public override Type Type
		{
			[Token(Token = "0x6000205")]
			[Address(RVA = "0x4F24230", Offset = "0x4F22E30", VA = "0x184F24230", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000206 RID: 518 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000206")]
		[Address(RVA = "0x4F240F0", Offset = "0x4F22CF0", VA = "0x184F240F0", Slot = "10")]
		[ExcludeFromCodeCoverage]
		internal virtual Expression GetExpression(int index)
		{
			return null;
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000207 RID: 519 RVA: 0x000027A8 File Offset: 0x000009A8
		[Token(Token = "0x17000048")]
		[ExcludeFromCodeCoverage]
		internal virtual int ExpressionCount
		{
			[Token(Token = "0x6000207")]
			[Address(RVA = "0x4F241F0", Offset = "0x4F22DF0", VA = "0x184F241F0", Slot = "11")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000208 RID: 520 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000208")]
		[Address(RVA = "0x4F24120", Offset = "0x4F22D20", VA = "0x184F24120", Slot = "12")]
		internal virtual ReadOnlyCollection<ParameterExpression> GetOrMakeVariables()
		{
			return null;
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000209")]
		[Address(RVA = "0x4F24170", Offset = "0x4F22D70", VA = "0x184F24170", Slot = "13")]
		[ExcludeFromCodeCoverage]
		internal virtual BlockExpression Rewrite(ReadOnlyCollection<ParameterExpression> variables, Expression[] args)
		{
			return null;
		}
	}
}
