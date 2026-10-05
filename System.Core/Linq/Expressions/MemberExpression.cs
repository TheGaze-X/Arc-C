using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.Linq.Expressions
{
	// Token: 0x02000060 RID: 96
	[Token(Token = "0x2000060")]
	[DebuggerTypeProxy(typeof(Expression.MemberExpressionProxy))]
	public class MemberExpression : Expression
	{
		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060002F0 RID: 752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000074")]
		public MemberInfo Member
		{
			[Token(Token = "0x60002F0")]
			[Address(RVA = "0x4F23820", Offset = "0x4F22420", VA = "0x184F23820")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060002F1 RID: 753 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000075")]
		public Expression Expression
		{
			[Token(Token = "0x60002F1")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60002F2")]
		[Address(RVA = "0x4F423B0", Offset = "0x4F40FB0", VA = "0x184F423B0")]
		internal MemberExpression(Expression expression)
		{
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x4F42250", Offset = "0x4F40E50", VA = "0x184F42250")]
		internal static PropertyExpression Make(Expression expression, PropertyInfo property)
		{
			return null;
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F4")]
		[Address(RVA = "0x4F42190", Offset = "0x4F40D90", VA = "0x184F42190")]
		internal static FieldExpression Make(Expression expression, FieldInfo field)
		{
			return null;
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060002F5 RID: 757 RVA: 0x00002A30 File Offset: 0x00000C30
		[Token(Token = "0x17000076")]
		public sealed override ExpressionType NodeType
		{
			[Token(Token = "0x60002F5")]
			[Address(RVA = "0x4C45240", Offset = "0x4C43E40", VA = "0x184C45240", Slot = "4")]
			get
			{
				return ExpressionType.Add;
			}
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F6")]
		[Address(RVA = "0x4F42160", Offset = "0x4F40D60", VA = "0x184F42160", Slot = "10")]
		[ExcludeFromCodeCoverage]
		internal virtual MemberInfo GetMember()
		{
			return null;
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F7")]
		[Address(RVA = "0x4F42110", Offset = "0x4F40D10", VA = "0x184F42110", Slot = "9")]
		protected internal override Expression Accept(ExpressionVisitor visitor)
		{
			return null;
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002F8")]
		[Address(RVA = "0x4F42310", Offset = "0x4F40F10", VA = "0x184F42310")]
		public MemberExpression Update(Expression expression)
		{
			return null;
		}
	}
}
